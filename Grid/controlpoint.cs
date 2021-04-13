using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using GeoAPI.CoordinateSystems;
using GeoAPI.CoordinateSystems.Transformations;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using log4net;
using MissionPlanner.Grid;
using MissionPlanner.Plugin;
using MissionPlanner.Utilities;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using CoordConvert;
using MissionPlanner.GCSViews;
using System.Diagnostics;

namespace MissionPlanner.controlpoint
{
    public partial class GridUI : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        const double rad2deg = (180 / Math.PI);
        const double deg2rad = (1.0 / rad2deg);

        GMapOverlay layerpolygons;
        GMapPolygon wppoly;
        GMapOverlay kmlpolygonsoverlay;
        private GridPlugin plugin;
        List<PointLatLngAlt> grid;
        public string DistUnits = "";
        public string inchpixel = "";
        public string feet_fovH = "";
        public string feet_fovV = "";
        public double homelat = 0;
        public double homelong = 0;
        Dictionary<string, camerainfo> cameras = new Dictionary<string, camerainfo>();
        //  List<PointLatLng> listpoly = new List<PointLatLng>();

        public GridUI(GridPlugin plugin)
        {
            this.plugin = plugin;

            InitializeComponent();

            map.MapProvider = plugin.Host.FDMapType;

            layerpolygons = new GMapOverlay("polygons");
            map.Overlays.Add(layerpolygons);

            kmlpolygonsoverlay = new GMapOverlay("kmlpolygons");
            map.Overlays.Add(kmlpolygonsoverlay);

            CMB_startfrom.DataSource = Enum.GetNames(typeof(Utilities.Grid.StartPosition));

            CMB_startfrom.SelectedIndex = 0;

            // set and angle that is good
            list = new List<PointLatLngAlt>();
            plugin.Host.FPDrawnPolygon.Points.ForEach(x =>
            {
                list.Add(x);
                //listpoly.Add(x);
            });
            NUM_angle.Value = (decimal)((getAngleOfLongestSide(list) + 360) % 360);

            map.ZoomAndCenterMarkers("polygons");//缩放到多边形
            // Map Events
            map.OnMarkerEnter += new MarkerEnter(map_OnMarkerEnter);
            map.OnMarkerLeave += new MarkerLeave(map_OnMarkerLeave);
            map.MouseUp += new MouseEventHandler(map_MouseUp);
            map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map_MouseDown);
            map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_MouseMove);

            foreach (var temp in FlightData.kmlpolygons.Polygons)
            {
                kmlpolygonsoverlay.Polygons.Add(new GMapPolygon(temp.Points, "") { Fill = Brushes.Transparent });
            }
            foreach (var temp in FlightData.kmlpolygons.Routes)
            {
                kmlpolygonsoverlay.Routes.Add(new GMapRoute(temp.Points, ""));
            }

        }

        void loadsettings()
        {
            if (plugin.Host.config.ContainsKey("simplegrid_camera"))
            {

                loadsetting("simplegrid_alt", NUM_altitude);
                loadsetting("simplegrid_alt", num_alt);
                loadsetting("simplegrid_dist", NUM_Distance);
                loadsetting("simplegrid_overshoot1", NUM_overshoot);
                loadsetting("simplegrid_overshoot2", NUM_overshoot2);
                //loadsetting("simplegrid_camera", CMB_camera);
                loadsetting("simplegrid_cam_dist", cam_dist);
                loadsetting("simplegrid_startfrom", CMB_startfrom);
                loadsetting("simplegrid_cam_angle", num_cam_angle);

            }
        }

        void loadsetting(string key, Control item)
        {
            if (plugin.Host.config.ContainsKey(key))
            {
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = decimal.Parse(plugin.Host.config[key].ToString());
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).Text = plugin.Host.config[key].ToString();
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = bool.Parse(plugin.Host.config[key].ToString());
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = bool.Parse(plugin.Host.config[key].ToString());
                }
            }
        }

        void savesettings()
        {
            plugin.Host.config["simplegrid_alt"] = NUM_altitude.Value.ToString();
            plugin.Host.config["simplegrid_angle"] = NUM_angle.Value.ToString();
            // plugin.Host.config["simplegrid_camera"] = CMB_camera.Text;
            plugin.Host.config["simplegrid_dist"] = NUM_Distance.Value.ToString();
            plugin.Host.config["simplegrid_overshoot1"] = NUM_overshoot.Value.ToString();
            plugin.Host.config["simplegrid_overshoot2"] = NUM_overshoot2.Value.ToString();

            plugin.Host.config["simplegrid_cam_dist"] = cam_dist.Value.ToString();
            plugin.Host.config["simplegrid_startfrom"] = CMB_startfrom.Text;
            plugin.Host.config["simplegrid_cam_angle"] = num_cam_angle.Value.ToString();

        }

        List<PointLatLngAlt> list = new List<PointLatLngAlt>();
        internal PointLatLng MouseDownStart = new PointLatLng();
        internal PointLatLng MouseDownEnd;
        internal PointLatLngAlt CurrentGMapMarkerStartPos;
        PointLatLng currentMousePosition;
        GMapMarker marker;
        GMapMarker CurrentGMapMarker = null;
        int CurrentGMapMarkerIndex = 0;
        bool isMouseDown = false;
        bool isMouseDraging = false;
        static public Object thisLock = new Object();

        public PluginHost Host2 { get; private set; }

        private void map_OnMarkerLeave(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarker)
                {
                    // when you click the context menu this triggers and causes problems
                    CurrentGMapMarker = null;
                }

            }
        }

        private void map_OnMarkerEnter(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarker)
                {
                    CurrentGMapMarker = item as GMapMarker;
                    CurrentGMapMarkerStartPos = CurrentGMapMarker.Position;
                }
            }
        }

        private void map_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownEnd = map.FromLocalToLatLng(e.X, e.Y);

            // Console.WriteLine("MainMap MU");

            if (e.Button == MouseButtons.Right) // ignore right clicks
            {
                return;
            }

            if (isMouseDown) // mouse down on some other object and dragged to here.
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = false;
                }
                if (!isMouseDraging)
                {
                    if (CurrentGMapMarker != null)
                    {
                        // Redraw polygon
                        //AddDrawPolygon();
                    }
                }
            }
            isMouseDraging = false;
            CurrentGMapMarker = null;
            CurrentGMapMarkerIndex = 0;
            CurrentGMapMarkerStartPos = null;
        }

        private void map_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownStart = map.FromLocalToLatLng(e.X, e.Y);

            if (e.Button == MouseButtons.Left && Control.ModifierKeys != Keys.Alt)
            {
                isMouseDown = true;
                isMouseDraging = false;

                if (CurrentGMapMarkerStartPos != null)
                    CurrentGMapMarkerIndex = list.FindIndex(c => c.ToString() == CurrentGMapMarkerStartPos.ToString());
            }
        }

        private void map_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = map.FromLocalToLatLng(e.X, e.Y);
            currentMousePosition = point;

            if (MouseDownStart == point)
                return;

            if (!isMouseDown)
            {
                // update mouse pos display
                //SetMouseDisplay(point.Lat, point.Lng, 0);
            }

            //draging
            if (e.Button == MouseButtons.Left && isMouseDown)
            {
                isMouseDraging = true;

                if (CurrentGMapMarker != null)
                {
                    if (CurrentGMapMarkerIndex == -1)
                    {
                        isMouseDraging = false;
                        return;
                    }

                    PointLatLng pnew = map.FromLocalToLatLng(e.X, e.Y);

                    CurrentGMapMarker.Position = pnew;

                    list[CurrentGMapMarkerIndex] = new PointLatLngAlt(pnew);
                    domainUpDown1_ValueChanged(sender, e);
                }
                else // left click pan
                {
                    double latdif = MouseDownStart.Lat - point.Lat;
                    double lngdif = MouseDownStart.Lng - point.Lng;

                    try
                    {
                        lock (thisLock)
                        {
                            map.Position = new PointLatLng(map.Position.Lat + latdif, map.Position.Lng + lngdif);
                        }
                    }
                    catch { }
                }
            }
        }

        void AddDrawPolygon()
        {
            List<PointLatLng> list2 = new List<PointLatLng>();

            list.ForEach(x => { list2.Add(x); });

            var poly = new GMapPolygon(list2, "poly");
            poly.Stroke = new Pen(Color.Red, 2);
            poly.Fill = Brushes.Transparent;

            layerpolygons.Polygons.Add(poly);

            foreach (var item in list)
            {
                layerpolygons.Markers.Add(new GMarkerGoogle(item, GMarkerGoogleType.red));
            }
        }

        double getAngleOfLongestSide(List<PointLatLngAlt> list)
        {
            double angle = 0;
            double maxdist = 0;
            PointLatLngAlt last = list[list.Count - 1];
            foreach (var item in list)
            {
                if (item.GetDistance(last) > maxdist)
                {
                    angle = item.GetBearing(last);
                    maxdist = item.GetDistance(last);
                }
                last = item;
            }

            return (angle + 360) % 360;
        }

        private void domainUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //if (CMB_camera.Text != "")
            //{
            //    doCalc();
            //}

            Host2 = plugin.Host;

            //grid = Utilities.Grid.CreateGrid(list, (double) NUM_altitude.Value, (double) NUM_Distance.Value,
            //    (double) NUM_spacing.Value, (double) NUM_angle.Value, (double) NUM_overshoot.Value,
            //    (double) NUM_overshoot2.Value,
            //    (Utilities.Grid.StartPosition) Enum.Parse(typeof(Utilities.Grid.StartPosition), CMB_startfrom.Text),
            //    false, 0, 0, plugin.Host.cs.HomeLocation);
            grid = Utilities.Grid.CreateGrid1(list, (double)NUM_altitude.Value, (double)NUM_Distance.Value,
                (double)NUM_spacing.Value, (double)num_offset.Value, (double)NUM_angle.Value, (double)NUM_overshoot.Value,
                (double)NUM_overshoot2.Value,
                (Utilities.Grid.StartPosition)Enum.Parse(typeof(Utilities.Grid.StartPosition), CMB_startfrom.Text),
                false, 0, 0, plugin.Host.cs.HomeLocation);

            List<PointLatLng> list2 = new List<PointLatLng>();

            grid.ForEach(x => { list2.Add(x); });

            map.HoldInvalidation = true;

            layerpolygons.Polygons.Clear();
            layerpolygons.Markers.Clear();


            if (chk_boundary.Checked)
                AddDrawPolygon();


            if (grid.Count == 0)
            {
                map.ZoomAndCenterMarkers("polygons");
                return;
            }

            int strips = 0;
            int a = 1;
            int m_n = 0;//tag = M  航点数量
            PointLatLngAlt prevpoint = grid[0];
            foreach (var item in grid)
            {
                if (item.Tag == "M")
                {
                    if (CHK_internals.Checked)
                    {
                        layerpolygons.Markers.Add(new GMarkerGoogle(item, GMarkerGoogleType.green) { ToolTipText = a.ToString(), ToolTipMode = MarkerTooltipMode.OnMouseOver });
                        a++;
                        m_n++;
                    }
                }
                else
                {
                    if (item.Tag == "S" || item.Tag == "E")
                    {
                        strips++;
                        if (chk_markers.Checked)
                            layerpolygons.Markers.Add(new GMarkerGoogle(item, GMarkerGoogleType.green)
                            {
                                ToolTipText = a.ToString(),
                                ToolTipMode = MarkerTooltipMode.OnMouseOver
                            });

                        a++;
                    }
                }
                prevpoint = item;
            }

            // add wp polygon
            wppoly = new GMapPolygon(list2, "Grid");
            wppoly.Stroke.Color = Color.Yellow;
            wppoly.Fill = Brushes.Transparent;
            wppoly.Stroke.Width = 4;
            if (chk_grid.Checked)
                layerpolygons.Polygons.Add(wppoly);

            Console.WriteLine("Poly Dist " + wppoly.Distance);

            lbl_area.Text = (calcpolygonarea(list) / 1000000).ToString("f6") + " km^2";

            if (chk_markers.Checked == true)
                lbl_distance.Text = (wppoly.Distance + ((double)loiter_r.Value * Math.PI * 2 * a) / 1000).ToString("0.##") + " km";
            else
                lbl_distance.Text = (wppoly.Distance + ((double)loiter_r.Value * Math.PI * 2 * m_n) / 1000).ToString("0.##") + " km";


            lbl_strips.Text = ((int)(strips / 2)).ToString();
            lbl_distbetweenlines.Text = NUM_Distance.Value.ToString("0.##") + " m";


            map.HoldInvalidation = false;

            //map.ZoomAndCenterMarkers("polygons");

        }

        double calcpolygonarea(List<PointLatLngAlt> polygon)
        {
            // should be a closed polygon
            // coords are in lat long
            // need utm to calc area

            if (polygon.Count == 0)
            {
                CustomMessageBox.Show("请绘制一个多边形!");
                return 0;
            }

            // close the polygon
            if (polygon[0] != polygon[polygon.Count - 1])
                polygon.Add(polygon[0]); // make a full loop

            CoordinateTransformationFactory ctfac = new CoordinateTransformationFactory();

            IGeographicCoordinateSystem wgs84 = GeographicCoordinateSystem.WGS84;

            int utmzone = (int)((polygon[0].Lng - -186.0) / 6.0);

            IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone, polygon[0].Lat < 0 ? false : true);

            ICoordinateTransformation trans = ctfac.CreateFromCoordinateSystems(wgs84, utm);

            double prod1 = 0;
            double prod2 = 0;

            for (int a = 0; a < (polygon.Count - 1); a++)
            {
                double[] pll1 = { polygon[a].Lng, polygon[a].Lat };
                double[] pll2 = { polygon[a + 1].Lng, polygon[a + 1].Lat };

                double[] p1 = trans.MathTransform.Transform(pll1);
                double[] p2 = trans.MathTransform.Transform(pll2);

                prod1 += p1[0] * p2[1];
                prod2 += p1[1] * p2[0];
            }

            double answer = (prod1 - prod2) / 2;

            if (polygon[0] == polygon[polygon.Count - 1])
                polygon.RemoveAt(polygon.Count - 1); // unmake a full loop

            return Math.Abs(answer);
        }

        private void BUT_Accept_Click(object sender, EventArgs e)
        {

            if (grid != null && grid.Count > 0)
            {
                MainV2.instance.FlightPlanner.quickadd = true;

                PointLatLngAlt lastpnt = PointLatLngAlt.Zero;

                if (MainV2.comPort.BaseStream.IsOpen)
                {
                    homelat = MainV2.comPort.MAV.cs.lat;
                    homelong = MainV2.comPort.MAV.cs.lng;
                }
                else
                {
                    homelat = double.Parse(MainV2.instance.FlightPlanner.TXT_homelat.Text);
                    homelong = double.Parse(MainV2.instance.FlightPlanner.TXT_homelng.Text);
                }
                //plugin.Host.AddWPtoList(MAVLink.MAV_CMD.DO_CHANGE_SPEED, 1,
                //    (int)((float)NUM_UpDownFlySpeed.Value / CurrentState.multiplierspeed), 0, 0, 0, 0, 0,
                //    null);
                //double X, Y;
                int n = 2;//计算第一个wp
                if (chk_markers.Checked)
                    n = 1;
                //var firstwp = grid[n];
                //var firstwpxyz = GaussProjection.GaussProjCal(new BLHCoordinate(firstwp.Lat,firstwp.Lng,firstwp.Alt),CoordConsts.cgcs2000atum,0);
                //var homexyz = GaussProjection.GaussProjCal(new BLHCoordinate(homelat,homelong,0), CoordConsts.cgcs2000atum, 0);
                //double dist_hometofirstwp = squar(firstwpxyz.X - homexyz.X, firstwpxyz.Y - homexyz.Y);
                //double dist_rat = (double)loiter_r.Value / dist_hometofirstwp;

                ////目标XY
                //        X = firstwpxyz.X - dist_rat * (firstwpxyz.X - homexyz.X);
                //        Y = firstwpxyz.Y - dist_rat * (firstwpxyz.Y - homexyz.Y);

                //var targetwp = GaussProjection.GaussProjInvCal(new XYZCoordinate(X, Y, 0), CoordConsts.cgcs2000atum, (int)((firstwp.Lng - 1.5) / 3 + 1)*3);//根据第一个航点计算带号
                //plugin.Host.AddWPtoList(MAVLink.MAV_CMD.WAYPOINT, 0, 0, 0, 0, targetwp.L,targetwp.B, grid[n].Alt);

                //plugin.Host.AddWPtoList(MAVLink.MAV_CMD.DO_SET_CAM_TRIGG_DIST, (double)cam_dist.Value, 0, 0, 0, 0, 0, 0);

                grid.ForEach(plla =>
                {
                    if (plla.Tag == "M")
                    {
                        if (CHK_internals.Checked)
                            plugin.Host.AddWPtoList(MAVLink.MAV_CMD.WAYPOINT, 0, 0, 0, 0, plla.Lng, plla.Lat, 0);
                    }
                    else
                    {
                        if (!(plla.Lat == lastpnt.Lat && plla.Lng == lastpnt.Lng && plla.Alt == lastpnt.Alt) && chk_markers.Checked == true)
                            plugin.Host.AddWPtoList(MAVLink.MAV_CMD.WAYPOINT, 0, 0, 0, 0, plla.Lng, plla.Lat, 0);

                        lastpnt = plla;
                    }
                });
                //plugin.Host.AddWPtoList(MAVLink.MAV_CMD.DO_SET_CAM_TRIGG_DIST, 0, 0, 0, 0, 0, 0, 0);

                MainV2.instance.FlightPlanner.quickadd = false;

                MainV2.instance.FlightPlanner.writeKML();

                savesettings();

                this.Close();

                Process.Start ("http://127.0.0.1:56781/controlpoint.kml");
            }
            else
            {
                CustomMessageBox.Show("Bad Grid", "Error");
            }
        }
        private double squar(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        private void GridUI_Resize(object sender, EventArgs e)
        {
            map.ZoomAndCenterMarkers("polygons");
        }

        private void GridUI_Load(object sender, EventArgs e)
        {
            loadsettings();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void chk_set_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_set.Checked == true)
            {
                gb_set.Visible = true;
            }
            else
            {
                gb_set.Visible = false;
            }
        }
        //private double cam35mmxy_circlecenterdist_120m = 1.231896;//以35mm a7r 镜头在120m高度 照片区域直径与圆心距离比值做参考
        private void num_alt_ValueChanged(object sender, EventArgs e)
        {
            //((NumericUpDown)sender).Enabled = false;
            NUM_altitude.Value = num_alt.Value;
            //NUM_Distance.Value = num_alt.Value;
            //NUM_spacing.Value = num_alt.Value;
            loiter_r.Value = num_alt.Value;

            NUM_Distance.Value = (decimal)((double)num_alt.Value * Math.Sqrt(3) / 2);
            NUM_spacing.Value = num_alt.Value;
            num_offset.Value = (decimal)((double)num_alt.Value/2);
            domainUpDown1_ValueChanged(null, null);
            map.ZoomAndCenterMarkers("polygons");
            // ((NumericUpDown)sender).Enabled = true;
        }
     
        private void maprefresh(object sender, EventArgs e)
        {
            domainUpDown1_ValueChanged(null, null);
            map.ZoomAndCenterMarkers("polygons");
        }

        private void chk_markers_CheckedChanged(object sender, EventArgs e)
        {
            domainUpDown1_ValueChanged(null, null);
            map.ZoomAndCenterMarkers("polygons");
        }
    }
}

