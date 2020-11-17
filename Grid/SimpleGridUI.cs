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

namespace MissionPlanner.SimpleGrid
{
    public partial class GridUI : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        const double rad2deg = (180 / Math.PI);
        const double deg2rad = (1.0 / rad2deg);

        GMapOverlay layerpolygons;
        GMapPolygon wppoly;
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

            layerpolygons = new GMapOverlay( "polygons");
            map.Overlays.Add(layerpolygons);

            CMB_startfrom.DataSource = Enum.GetNames(typeof(Utilities.Grid.StartPosition));
            
            CMB_startfrom.SelectedIndex = 0;

            // set and angle that is good
            list = new List<PointLatLngAlt>();
            plugin.Host.FPDrawnPolygon.Points.ForEach(x => { list.Add(x);
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

            xmlcamera(false, Settings.GetRunningDirectory() + "camerasBuiltin.xml");

            xmlcamera(false, Settings.GetUserDataDirectory() + "cameras.xml");
        }

        void loadsettings()
        {
            if (plugin.Host.config.ContainsKey("simplegrid_camera"))
            {
                
                loadsetting("simplegrid_alt", NUM_altitude);

                loadsetting("simplegrid_dist", NUM_Distance);
                loadsetting("simplegrid_overshoot1", NUM_overshoot);
                loadsetting("simplegrid_overshoot2", NUM_overshoot2);

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

            plugin.Host.config["simplegrid_dist"] = NUM_Distance.Value.ToString();
            plugin.Host.config["simplegrid_overshoot1"] = NUM_overshoot.Value.ToString();
            plugin.Host.config["simplegrid_overshoot2"] = NUM_overshoot2.Value.ToString();
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
            if (CMB_camera.Text != "")
            {
                doCalc();
            }

            Host2 = plugin.Host;

            grid = Utilities.Grid.CreateGrid(list, (double) NUM_altitude.Value, (double) NUM_Distance.Value,
                (double) NUM_spacing.Value, (double) NUM_angle.Value, (double) NUM_overshoot.Value,
                (double) NUM_overshoot2.Value,
                (Utilities.Grid.StartPosition) Enum.Parse(typeof(Utilities.Grid.StartPosition), CMB_startfrom.Text),
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

            lbl_area.Text = (calcpolygonarea(list) /1000000).ToString("f6") + " km^2";

            if(chk_markers.Checked==true)
                lbl_distance.Text = (wppoly.Distance + ((double)loiter_r.Value * Math.PI * 2 * a) / 1000).ToString("0.##") + " km";
            else
                lbl_distance.Text = (wppoly.Distance+((double)loiter_r.Value*Math.PI*2*m_n)/1000).ToString("0.##") + " km";


            lbl_strips.Text = ((int)(strips / 2)).ToString();
            lbl_distbetweenlines.Text = NUM_Distance.Value.ToString("0.##") + " m";
            lbl_homeres.Text = TXT_cmpixel.Text + " cm/pixel";

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
                
                if(MainV2.comPort.BaseStream.IsOpen)
                {
                    homelat = MainV2.comPort.MAV.cs.HomeLocation.Lat;
                    homelong = MainV2.comPort.MAV.cs.HomeLocation.Lng;
                }
                //plugin.Host.AddWPtoList(MAVLink.MAV_CMD.DO_CHANGE_SPEED, 1,
                //    (int)((float)NUM_UpDownFlySpeed.Value / CurrentState.multiplierspeed), 0, 0, 0, 0, 0,
                //    null);
                double lat, lng;
                int n=2;//计算第一个wp
                if (chk_markers.Checked)
                    n = 1;
                if(Math.Abs( grid[n].Lat-homelat)>Math.Abs( grid[n].Lng-homelong))
                {
                    if (grid[n].Lat>= homelat)
                    {
                        lat = grid[n].Lat - (double)loiter_r.Value * 0.0009 / 100;
                        lng = grid[n].Lng;
                    }else
                    {
                        lat = grid[n].Lat + (double)loiter_r.Value * 0.0009 / 100;
                        lng = grid[n].Lng;
                    }
                }
                else
                {
                    if (grid[n].Lng >= homelong)
                    {
                        lat = grid[n].Lat;
                        lng = grid[n].Lng - (double)loiter_r.Value * 0.001035 / 100;
                    }
                    else
                    {
                        lat = grid[n].Lat;
                        lng = grid[n].Lng + (double)loiter_r.Value * 0.001035 / 100;
                    }
                }
                plugin.Host.AddWPtoList(MAVLink.MAV_CMD.WAYPOINT, 0, 0, 0, 0, lng,lat, grid[0].Alt);

                plugin.Host.AddWPtoList(MAVLink.MAV_CMD.DO_SET_CAM_TRIGG_DIST, (double)cam_dist.Value, 0, 1, 0, 0, 0, 0);

                grid.ForEach(plla =>
                {
                    if (plla.Tag == "M")
                    {
                        if (CHK_internals.Checked)
                            plugin.Host.AddWPtoList(MAVLink.MAV_CMD.LOITER_TURNS, (double)loiter_turn.Value,0 ,(double)loiter_r.Value, 0, plla.Lng, plla.Lat, plla.Alt);
                    }
                    else
                    {
                        if (!(plla.Lat == lastpnt.Lat && plla.Lng == lastpnt.Lng && plla.Alt == lastpnt.Alt)&&chk_markers.Checked==true)
                            plugin.Host.AddWPtoList(MAVLink.MAV_CMD.LOITER_TURNS, (double)loiter_turn.Value, 0, (double)loiter_r.Value, 0, plla.Lng, plla.Lat, plla.Alt);

                        lastpnt = plla;
                    }
                });
                plugin.Host.AddWPtoList(MAVLink.MAV_CMD.DO_SET_CAM_TRIGG_DIST, 0, 0, 1, 0, 0, 0, 0);

                MainV2.instance.FlightPlanner.quickadd = false;

                MainV2.instance.FlightPlanner.writeKML();

                savesettings();

                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Bad Grid", "Error");
            }
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
            if(chk_set.Checked==true)
            {
                gb_set.Visible = true;
            }
            else
            {
                gb_set.Visible = false;
            }
        }
        private double cam35mmxy_circlecenterdist_120m = 1.231896;//以35mm a7r 镜头在120m高度 照片区域直径与圆心距离比值做参考
        private void num_alt_ValueChanged(object sender, EventArgs e)
        {
            NUM_altitude.Value = num_alt.Value;
            //NUM_Distance.Value = num_alt.Value;
            //NUM_spacing.Value = num_alt.Value;
            loiter_r.Value = num_alt.Value;
            if(CMB_camera.Text=="")
            {
                NUM_Distance.Value = num_alt.Value;
                NUM_spacing.Value = num_alt.Value;
            }
            else
            {
                NUM_Distance.Value = (decimal)circledist(double.Parse(TXT_fovH.Text)/2,double.Parse (TXT_fovV.Text)/2);
                NUM_spacing.Value = (decimal)circledist(double.Parse(TXT_fovH.Text)/2, double.Parse(TXT_fovV.Text) / 2);
            }
            domainUpDown1_ValueChanged(sender, e);
        }
        double circledist (double x,double y)
        {
            x = x * x;
            y = y * y;
            double d=Math.Sqrt(x + y);
            d = d * 2 / cam35mmxy_circlecenterdist_120m;
            return Math.Round(d);
        }
        private void CMB_camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cameras.ContainsKey(CMB_camera.Text))
            {
                camerainfo camera = cameras[CMB_camera.Text];

                NUM_focallength.Value = (decimal)camera.focallen;
                TXT_imgheight.Text = camera.imageheight.ToString();
                TXT_imgwidth.Text = camera.imagewidth.ToString();
                TXT_sensheight.Text = camera.sensorheight.ToString();
                TXT_senswidth.Text = camera.sensorwidth.ToString();

                //NUM_Distance.Enabled = false;
            }
            // GMapMarkerOverlap.Clear();
            //num_alt_ValueChanged(null, null);
            domainUpDown1_ValueChanged(null, null);
            if (CMB_camera.Text == "")
            {
                NUM_Distance.Value = num_alt.Value;
                NUM_spacing.Value = num_alt.Value;
            }
            else
            {
                NUM_Distance.Value = (decimal)circledist(double.Parse(TXT_fovH.Text) / 2, double.Parse(TXT_fovV.Text) / 2);
                NUM_spacing.Value = (decimal)circledist(double.Parse(TXT_fovH.Text) / 2, double.Parse(TXT_fovV.Text) / 2);
            }
        }
        private void xmlcamera(bool write, string filename)
        {
            bool exists = File.Exists(filename);

            if (write || !exists)
            {
                try
                {
                    XmlTextWriter xmlwriter = new XmlTextWriter(filename, Encoding.ASCII);
                    xmlwriter.Formatting = Formatting.Indented;

                    xmlwriter.WriteStartDocument();

                    xmlwriter.WriteStartElement("Cameras");

                    foreach (string key in cameras.Keys)
                    {
                        try
                        {
                            if (key == "")
                                continue;
                            xmlwriter.WriteStartElement("Camera");
                            xmlwriter.WriteElementString("name", cameras[key].name);
                            xmlwriter.WriteElementString("flen", cameras[key].focallen.ToString(new System.Globalization.CultureInfo("en-US")));
                            xmlwriter.WriteElementString("imgh", cameras[key].imageheight.ToString(new System.Globalization.CultureInfo("en-US")));
                            xmlwriter.WriteElementString("imgw", cameras[key].imagewidth.ToString(new System.Globalization.CultureInfo("en-US")));
                            xmlwriter.WriteElementString("senh", cameras[key].sensorheight.ToString(new System.Globalization.CultureInfo("en-US")));
                            xmlwriter.WriteElementString("senw", cameras[key].sensorwidth.ToString(new System.Globalization.CultureInfo("en-US")));
                            xmlwriter.WriteEndElement();
                        }
                        catch { }
                    }

                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteEndDocument();
                    xmlwriter.Close();

                }
                catch (Exception ex) { CustomMessageBox.Show(ex.ToString()); }
            }
            else
            {
                try
                {
                    using (XmlTextReader xmlreader = new XmlTextReader(filename))
                    {
                        while (xmlreader.Read())
                        {
                            xmlreader.MoveToElement();
                            try
                            {
                                switch (xmlreader.Name)
                                {
                                    case "Camera":
                                        {
                                            camerainfo camera = new camerainfo();

                                            while (xmlreader.Read())
                                            {
                                                bool dobreak = false;
                                                xmlreader.MoveToElement();
                                                switch (xmlreader.Name)
                                                {
                                                    case "name":
                                                        camera.name = xmlreader.ReadString();
                                                        break;
                                                    case "imgw":
                                                        camera.imagewidth = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                        break;
                                                    case "imgh":
                                                        camera.imageheight = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                        break;
                                                    case "senw":
                                                        camera.sensorwidth = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                        break;
                                                    case "senh":
                                                        camera.sensorheight = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                        break;
                                                    case "flen":
                                                        camera.focallen = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                        break;
                                                    case "Camera":
                                                        cameras[camera.name] = camera;
                                                        dobreak = true;
                                                        break;
                                                }
                                                if (dobreak)
                                                    break;
                                            }
                                            string temp = xmlreader.ReadString();
                                        }
                                        break;
                                    case "Config":
                                        break;
                                    case "xml":
                                        break;
                                    default:
                                        if (xmlreader.Name == "") // line feeds
                                            break;
                                        //config[xmlreader.Name] = xmlreader.ReadString();
                                        break;
                                }
                            }
                            catch (Exception ee) { Console.WriteLine(ee.Message); } // silent fail on bad entry
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("Bad Camera File: " + ex.ToString()); } // bad config file

                // populate list
                foreach (var camera in cameras.Values)
                {
                    if (!CMB_camera.Items.Contains(camera.name))
                        CMB_camera.Items.Add(camera.name);
                }
            }
        }

        private void BUT_save_Click(object sender, EventArgs e)
        {
            camerainfo camera = new camerainfo();

            string camname = "Default";

            if (MissionPlanner.Controls.InputBox.Show("Camera Name", "Please and a camera name", ref camname) != System.Windows.Forms.DialogResult.OK)
                return;

            CMB_camera.Text = camname;

            // check if camera exists alreay
            if (cameras.ContainsKey(CMB_camera.Text))
            {
                camera = cameras[CMB_camera.Text];
            }
            else
            {
                cameras.Add(CMB_camera.Text, camera);
            }

            try
            {
                camera.name = CMB_camera.Text;
                camera.focallen = (float)NUM_focallength.Value;
                camera.imageheight = float.Parse(TXT_imgheight.Text);
                camera.imagewidth = float.Parse(TXT_imgwidth.Text);
                camera.sensorheight = float.Parse(TXT_sensheight.Text);
                camera.sensorwidth = float.Parse(TXT_senswidth.Text);
            }
            catch { CustomMessageBox.Show("One of your entries is not a valid number"); return; }

            cameras[CMB_camera.Text] = camera;

            xmlcamera(true, Settings.GetUserDataDirectory() + "cameras.xml");
        }
        void doCalc()
        {
            try
            {
                // entered values
                float flyalt = (float)CurrentState.fromDistDisplayUnit((float)NUM_altitude.Value);
                int imagewidth = int.Parse(TXT_imgwidth.Text);
                int imageheight = int.Parse(TXT_imgheight.Text);
              

                double viewwidth = 0;
                double viewheight = 0;

                getFOV(flyalt, ref viewwidth, ref viewheight);


                TXT_fovH.Text = viewwidth.ToString("#.#");
                TXT_fovV.Text = viewheight.ToString("#.#");
                // Imperial
                feet_fovH = (viewwidth * 3.2808399f).ToString("#.#");
                feet_fovV = (viewheight * 3.2808399f).ToString("#.#");

                //    mm  / pixels * 100
                TXT_cmpixel.Text = ((viewheight / imageheight) * 100*Math.Sqrt(2)).ToString("0.00");
                // Imperial
                inchpixel = (((viewheight / imageheight) * 100) * 0.393701).ToString("0.00 inches");

                
            }
            catch { return; }
        }
        void getFOV(double flyalt, ref double fovh, ref double fovv)
        {
            double focallen = (double)NUM_focallength.Value;
            double sensorwidth = double.Parse(TXT_senswidth.Text);
            double sensorheight = double.Parse(TXT_sensheight.Text);

            // scale      mm / mm
            double flscale = (1000 * flyalt) / focallen;

            //   mm * mm / 1000
            double viewwidth = (sensorwidth * flscale / 1000);
            double viewheight = (sensorheight * flscale / 1000);

            float fovh1 = (float)(Math.Atan(sensorwidth / (2 * focallen)) * rad2deg * 2);
            float fovv1 = (float)(Math.Atan(sensorheight / (2 * focallen)) * rad2deg * 2);

            fovh = viewwidth;
            fovv = viewheight;
        }
        void getFOVangle(ref double fovh, ref double fovv)
        {
            double focallen = (double)NUM_focallength.Value;
            double sensorwidth = double.Parse(TXT_senswidth.Text);
            double sensorheight = double.Parse(TXT_sensheight.Text);

            fovh = (float)(Math.Atan(sensorwidth / (2 * focallen)) * rad2deg * 2);
            fovv = (float)(Math.Atan(sensorheight / (2 * focallen)) * rad2deg * 2);
        }
    }
}

