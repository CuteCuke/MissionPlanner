using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    partial class FlightPlanner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (currentMarker != null) currentMarker.Dispose();
            if (drawnpolygon != null) drawnpolygon.Dispose();
            if (kmlpolygonsoverlay != null) kmlpolygonsoverlay.Dispose();
            if (wppolygon != null) wppolygon.Dispose();
            if (top != null) top.Dispose();
            if (geofencepolygon != null) geofencepolygon.Dispose();
            if (geofenceoverlay != null) geofenceoverlay.Dispose();
            if (drawnpolygonsoverlay != null) drawnpolygonsoverlay.Dispose();
            if (center != null) center.Dispose(); 

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.panelWaypoints = new System.Windows.Forms.Panel();
            this.btn_per = new MissionPlanner.Controls.MyButton();
            this.num_per = new System.Windows.Forms.NumericUpDown();
            this.num_per_dist = new System.Windows.Forms.NumericUpDown();
            this.chk_ispart = new System.Windows.Forms.CheckBox();
            this.Commands = new MissionPlanner.Controls.MyDataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.coordZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordEasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordNorthing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_mincommands = new MissionPlanner.Controls.MyButton();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.BUT_Add = new MissionPlanner.Controls.MyButton();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelAction = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_imitation = new System.Windows.Forms.CheckBox();
            this.load_kml = new MissionPlanner.Controls.MyButton();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.alt_curve = new MissionPlanner.Controls.MyButton();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.del_area = new MissionPlanner.Controls.MyButton();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.but_writewpfast = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.del_flight = new MissionPlanner.Controls.MyButton();
            this.creat_flight = new MissionPlanner.Controls.MyButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_flytimenum = new System.Windows.Forms.Label();
            this.lbl_flytime = new System.Windows.Forms.Label();
            this.add_updownwp = new MissionPlanner.Controls.MyButton();
            this.refresh_updown = new MissionPlanner.Controls.MyButton();
            this.del_updownwp = new MissionPlanner.Controls.MyButton();
            this.gpb_takeoffandland = new System.Windows.Forms.GroupBox();
            this.panel_plane = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.loiter_downalt = new System.Windows.Forms.NumericUpDown();
            this.loiter_upalt = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.pilotwp_downalt = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.pilotwp_upalt = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.updown_angle = new System.Windows.Forms.NumericUpDown();
            this.vtol_takeoff_alt = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pilotwp_downdist = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.pilotwp_updist = new System.Windows.Forms.NumericUpDown();
            this.loiter_radius = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.panelMap = new System.Windows.Forms.Panel();
            this.trackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_missiontype = new System.Windows.Forms.ComboBox();
            this.MainMap = new MissionPlanner.Controls.myGMAP();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertWpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSplineWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitercirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpwPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.geoFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFenceuploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFencedownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReturnLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRallyPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWpCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSplineCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCircleSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchWPPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevationGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseWPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSHPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiaddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poideleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poieditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUTMCoordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchDockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenceInclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenceExclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBASE = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripPoly = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawAPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripZoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomToVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panelWaypoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_per_dist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.panelAction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpb_takeoffandland.SuspendLayout();
            this.panel_plane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_downalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_upalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_downalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_upalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtol_takeoff_alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_downdist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_updist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_radius)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelBASE.SuspendLayout();
            this.contextMenuStripPoly.SuspendLayout();
            this.contextMenuStripZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.CHK_verifyheight.UseVisualStyleBackColor = true;
            // 
            // TXT_WPRad
            // 
            this.TXT_WPRad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TXT_WPRad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_WPRad_KeyPress);
            this.TXT_WPRad.Leave += new System.EventHandler(this.TXT_WPRad_Leave);
            // 
            // TXT_DefaultAlt
            // 
            this.TXT_DefaultAlt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TXT_DefaultAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.TXT_DefaultAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DefaultAlt_KeyPress);
            this.TXT_DefaultAlt.Leave += new System.EventHandler(this.TXT_DefaultAlt_Leave);
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.Name = "LBL_WPRad";
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            this.toolTip1.SetToolTip(this.LBL_defalutalt, resources.GetString("LBL_defalutalt.ToolTip"));
            // 
            // TXT_loiterrad
            // 
            this.TXT_loiterrad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TXT_loiterrad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.TXT_loiterrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_loiterrad_KeyPress);
            this.TXT_loiterrad.Leave += new System.EventHandler(this.TXT_loiterrad_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.TXT_homealt);
            this.panel1.Controls.Add(this.TXT_homelng);
            this.panel1.Controls.Add(this.TXT_homelat);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.TabStop = true;
            this.label4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label4_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // TXT_homealt
            // 
            this.TXT_homealt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TXT_homealt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // TXT_homelng
            // 
            this.TXT_homelng.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TXT_homelng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homelat
            // 
            this.TXT_homelat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TXT_homelat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_homelat.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle17;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle18;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Name = "coords1";
            this.coords1.Vertical = true;
            this.coords1.SystemChanged += new System.EventHandler(this.coords1_SystemChanged);
            this.coords1.Load += new System.EventHandler(this.coords1_Load);
            // 
            // panelWaypoints
            // 
            this.panelWaypoints.Controls.Add(this.btn_per);
            this.panelWaypoints.Controls.Add(this.num_per);
            this.panelWaypoints.Controls.Add(this.num_per_dist);
            this.panelWaypoints.Controls.Add(this.chk_ispart);
            this.panelWaypoints.Controls.Add(this.Commands);
            this.panelWaypoints.Controls.Add(this.but_mincommands);
            this.panelWaypoints.Controls.Add(this.CHK_splinedefault);
            this.panelWaypoints.Controls.Add(this.label17);
            this.panelWaypoints.Controls.Add(this.TXT_altwarn);
            this.panelWaypoints.Controls.Add(this.BUT_Add);
            this.panelWaypoints.Controls.Add(this.LBL_defalutalt);
            this.panelWaypoints.Controls.Add(this.TXT_DefaultAlt);
            this.panelWaypoints.Controls.Add(this.LBL_WPRad);
            this.panelWaypoints.Controls.Add(this.TXT_WPRad);
            this.panelWaypoints.Controls.Add(this.CMB_altmode);
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Name = "panelWaypoints";
            // 
            // btn_per
            // 
            resources.ApplyResources(this.btn_per, "btn_per");
            this.btn_per.Name = "btn_per";
            this.toolTip1.SetToolTip(this.btn_per, resources.GetString("btn_per.ToolTip"));
            this.btn_per.UseVisualStyleBackColor = true;
            this.btn_per.Click += new System.EventHandler(this.btn_per_Click);
            // 
            // num_per
            // 
            resources.ApplyResources(this.num_per, "num_per");
            this.num_per.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_per.Name = "num_per";
            this.num_per.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_per_dist
            // 
            resources.ApplyResources(this.num_per_dist, "num_per_dist");
            this.num_per_dist.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_per_dist.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_per_dist.Name = "num_per_dist";
            this.toolTip1.SetToolTip(this.num_per_dist, resources.GetString("num_per_dist.ToolTip"));
            this.num_per_dist.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // chk_ispart
            // 
            resources.ApplyResources(this.chk_ispart, "chk_ispart");
            this.chk_ispart.Name = "chk_ispart";
            this.toolTip1.SetToolTip(this.chk_ispart, resources.GetString("chk_ispart.ToolTip"));
            this.chk_ispart.UseVisualStyleBackColor = true;
            this.chk_ispart.CheckedChanged += new System.EventHandler(this.chk_ispart_CheckedChanged);
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            resources.ApplyResources(this.Commands, "Commands");
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Frame,
            this.coordZone,
            this.coordEasting,
            this.coordNorthing,
            this.MGRS,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Angle,
            this.Dist,
            this.AZ,
            this.TagData});
            this.Commands.Name = "Commands";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.Format = "N0";
            dataGridViewCellStyle23.NullValue = "0";
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands_DataError);
            this.Commands.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Commands_DefaultValuesNeeded);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            this.Commands.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Commands_RowsRemoved);
            this.Commands.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Commands_RowValidating);
            // 
            // Command
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle20;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Frame
            // 
            resources.ApplyResources(this.Frame, "Frame");
            this.Frame.Name = "Frame";
            // 
            // coordZone
            // 
            resources.ApplyResources(this.coordZone, "coordZone");
            this.coordZone.Name = "coordZone";
            // 
            // coordEasting
            // 
            resources.ApplyResources(this.coordEasting, "coordEasting");
            this.coordEasting.Name = "coordEasting";
            // 
            // coordNorthing
            // 
            resources.ApplyResources(this.coordNorthing, "coordNorthing");
            this.coordNorthing.Name = "coordNorthing";
            // 
            // MGRS
            // 
            resources.ApplyResources(this.MGRS, "MGRS");
            this.MGRS.Name = "MGRS";
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            // 
            // Up
            // 
            this.Up.DefaultCellStyle = dataGridViewCellStyle21;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = global::MissionPlanner.Properties.Resources.up;
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            // 
            // Down
            // 
            this.Down.DefaultCellStyle = dataGridViewCellStyle22;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = global::MissionPlanner.Properties.Resources.down;
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            // 
            // Grad
            // 
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Angle
            // 
            resources.ApplyResources(this.Angle, "Angle");
            this.Angle.Name = "Angle";
            this.Angle.ReadOnly = true;
            this.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TagData
            // 
            resources.ApplyResources(this.TagData, "TagData");
            this.TagData.Name = "TagData";
            this.TagData.ReadOnly = true;
            // 
            // but_mincommands
            // 
            resources.ApplyResources(this.but_mincommands, "but_mincommands");
            this.but_mincommands.Name = "but_mincommands";
            this.but_mincommands.UseVisualStyleBackColor = true;
            this.but_mincommands.Click += new System.EventHandler(this.but_mincommands_Click);
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // TXT_altwarn
            // 
            this.TXT_altwarn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TXT_altwarn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // BUT_Add
            // 
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.FormattingEnabled = true;
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.panelAction, "panelAction");
            this.panelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAction.Name = "panelAction";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.gpb_takeoffandland);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxMapType);
            this.groupBox2.Controls.Add(this.chk_grid);
            this.groupBox2.Controls.Add(this.lnk_kml);
            this.groupBox2.Controls.Add(this.lbl_status);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            this.chk_grid.CheckedChanged += new System.EventHandler(this.chk_grid_CheckedChanged);
            // 
            // lnk_kml
            // 
            resources.ApplyResources(this.lnk_kml, "lnk_kml");
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.TabStop = true;
            this.lnk_kml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_kml_LinkClicked);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_imitation);
            this.groupBox1.Controls.Add(this.load_kml);
            this.groupBox1.Controls.Add(this.BUT_write);
            this.groupBox1.Controls.Add(this.alt_curve);
            this.groupBox1.Controls.Add(this.BUT_saveWPFile);
            this.groupBox1.Controls.Add(this.del_area);
            this.groupBox1.Controls.Add(this.BUT_loadwpfile);
            this.groupBox1.Controls.Add(this.lbl_wpfile);
            this.groupBox1.Controls.Add(this.but_writewpfast);
            this.groupBox1.Controls.Add(this.BUT_read);
            this.groupBox1.Controls.Add(this.del_flight);
            this.groupBox1.Controls.Add(this.creat_flight);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk_imitation
            // 
            resources.ApplyResources(this.chk_imitation, "chk_imitation");
            this.chk_imitation.Name = "chk_imitation";
            this.toolTip1.SetToolTip(this.chk_imitation, resources.GetString("chk_imitation.ToolTip"));
            this.chk_imitation.UseVisualStyleBackColor = true;
            this.chk_imitation.CheckedChanged += new System.EventHandler(this.chk_imitation_CheckedChanged);
            // 
            // load_kml
            // 
            resources.ApplyResources(this.load_kml, "load_kml");
            this.load_kml.Name = "load_kml";
            this.toolTip1.SetToolTip(this.load_kml, resources.GetString("load_kml.ToolTip"));
            this.load_kml.UseVisualStyleBackColor = true;
            this.load_kml.Click += new System.EventHandler(this.load_kml_Click);
            // 
            // BUT_write
            // 
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.Name = "BUT_write";
            this.toolTip1.SetToolTip(this.BUT_write, resources.GetString("BUT_write.ToolTip"));
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // alt_curve
            // 
            resources.ApplyResources(this.alt_curve, "alt_curve");
            this.alt_curve.Name = "alt_curve";
            this.toolTip1.SetToolTip(this.alt_curve, resources.GetString("alt_curve.ToolTip"));
            this.alt_curve.UseVisualStyleBackColor = true;
            this.alt_curve.Click += new System.EventHandler(this.alt_curve_Click);
            // 
            // BUT_saveWPFile
            // 
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.toolTip1.SetToolTip(this.BUT_saveWPFile, resources.GetString("BUT_saveWPFile.ToolTip"));
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // del_area
            // 
            resources.ApplyResources(this.del_area, "del_area");
            this.del_area.Name = "del_area";
            this.toolTip1.SetToolTip(this.del_area, resources.GetString("del_area.ToolTip"));
            this.del_area.UseVisualStyleBackColor = true;
            this.del_area.Click += new System.EventHandler(this.del_area_Click);
            // 
            // BUT_loadwpfile
            // 
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.toolTip1.SetToolTip(this.BUT_loadwpfile, resources.GetString("BUT_loadwpfile.ToolTip"));
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(this.lbl_wpfile, "lbl_wpfile");
            this.lbl_wpfile.Name = "lbl_wpfile";
            // 
            // but_writewpfast
            // 
            resources.ApplyResources(this.but_writewpfast, "but_writewpfast");
            this.but_writewpfast.Name = "but_writewpfast";
            this.but_writewpfast.UseVisualStyleBackColor = true;
            this.but_writewpfast.Click += new System.EventHandler(this.but_writewpfast_Click);
            // 
            // BUT_read
            // 
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.Name = "BUT_read";
            this.toolTip1.SetToolTip(this.BUT_read, resources.GetString("BUT_read.ToolTip"));
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // del_flight
            // 
            resources.ApplyResources(this.del_flight, "del_flight");
            this.del_flight.Name = "del_flight";
            this.toolTip1.SetToolTip(this.del_flight, resources.GetString("del_flight.ToolTip"));
            this.del_flight.UseVisualStyleBackColor = true;
            this.del_flight.Click += new System.EventHandler(this.del_flight_Click);
            // 
            // creat_flight
            // 
            resources.ApplyResources(this.creat_flight, "creat_flight");
            this.creat_flight.Name = "creat_flight";
            this.toolTip1.SetToolTip(this.creat_flight, resources.GetString("creat_flight.ToolTip"));
            this.creat_flight.UseVisualStyleBackColor = true;
            this.creat_flight.Click += new System.EventHandler(this.creat_flight_click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_flytimenum);
            this.groupBox3.Controls.Add(this.lbl_flytime);
            this.groupBox3.Controls.Add(this.add_updownwp);
            this.groupBox3.Controls.Add(this.refresh_updown);
            this.groupBox3.Controls.Add(this.del_updownwp);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lbl_flytimenum
            // 
            resources.ApplyResources(this.lbl_flytimenum, "lbl_flytimenum");
            this.lbl_flytimenum.Name = "lbl_flytimenum";
            // 
            // lbl_flytime
            // 
            resources.ApplyResources(this.lbl_flytime, "lbl_flytime");
            this.lbl_flytime.Name = "lbl_flytime";
            // 
            // add_updownwp
            // 
            resources.ApplyResources(this.add_updownwp, "add_updownwp");
            this.add_updownwp.Name = "add_updownwp";
            this.toolTip1.SetToolTip(this.add_updownwp, resources.GetString("add_updownwp.ToolTip"));
            this.add_updownwp.UseVisualStyleBackColor = true;
            this.add_updownwp.Click += new System.EventHandler(this.add_updownwp_Click);
            // 
            // refresh_updown
            // 
            resources.ApplyResources(this.refresh_updown, "refresh_updown");
            this.refresh_updown.Name = "refresh_updown";
            this.toolTip1.SetToolTip(this.refresh_updown, resources.GetString("refresh_updown.ToolTip"));
            this.refresh_updown.UseVisualStyleBackColor = true;
            this.refresh_updown.Click += new System.EventHandler(this.refresh_updown_Click);
            // 
            // del_updownwp
            // 
            resources.ApplyResources(this.del_updownwp, "del_updownwp");
            this.del_updownwp.Name = "del_updownwp";
            this.toolTip1.SetToolTip(this.del_updownwp, resources.GetString("del_updownwp.ToolTip"));
            this.del_updownwp.UseVisualStyleBackColor = true;
            this.del_updownwp.Click += new System.EventHandler(this.del_updownwp_Click);
            // 
            // gpb_takeoffandland
            // 
            this.gpb_takeoffandland.Controls.Add(this.panel_plane);
            this.gpb_takeoffandland.Controls.Add(this.label21);
            this.gpb_takeoffandland.Controls.Add(this.updown_angle);
            this.gpb_takeoffandland.Controls.Add(this.vtol_takeoff_alt);
            this.gpb_takeoffandland.Controls.Add(this.label9);
            this.gpb_takeoffandland.Controls.Add(this.label8);
            resources.ApplyResources(this.gpb_takeoffandland, "gpb_takeoffandland");
            this.gpb_takeoffandland.Name = "gpb_takeoffandland";
            this.gpb_takeoffandland.TabStop = false;
            this.gpb_takeoffandland.Enter += new System.EventHandler(this.gpb_takeoffandland_Enter);
            // 
            // panel_plane
            // 
            this.panel_plane.Controls.Add(this.label16);
            this.panel_plane.Controls.Add(this.label19);
            this.panel_plane.Controls.Add(this.label18);
            this.panel_plane.Controls.Add(this.loiter_downalt);
            this.panel_plane.Controls.Add(this.loiter_upalt);
            this.panel_plane.Controls.Add(this.label12);
            this.panel_plane.Controls.Add(this.pilotwp_downalt);
            this.panel_plane.Controls.Add(this.label13);
            this.panel_plane.Controls.Add(this.pilotwp_upalt);
            this.panel_plane.Controls.Add(this.label14);
            resources.ApplyResources(this.panel_plane, "panel_plane");
            this.panel_plane.Name = "panel_plane";
            this.panel_plane.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            this.toolTip1.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.toolTip1.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // loiter_downalt
            // 
            this.loiter_downalt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.loiter_downalt, "loiter_downalt");
            this.loiter_downalt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.loiter_downalt.Name = "loiter_downalt";
            this.loiter_downalt.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // loiter_upalt
            // 
            this.loiter_upalt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.loiter_upalt, "loiter_upalt");
            this.loiter_upalt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.loiter_upalt.Name = "loiter_upalt";
            this.loiter_upalt.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // pilotwp_downalt
            // 
            this.pilotwp_downalt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.pilotwp_downalt, "pilotwp_downalt");
            this.pilotwp_downalt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pilotwp_downalt.Name = "pilotwp_downalt";
            this.pilotwp_downalt.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // pilotwp_upalt
            // 
            this.pilotwp_upalt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.pilotwp_upalt, "pilotwp_upalt");
            this.pilotwp_upalt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pilotwp_upalt.Name = "pilotwp_upalt";
            this.pilotwp_upalt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.toolTip1.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // updown_angle
            // 
            this.updown_angle.Increment = new decimal(new int[] {
            45,
            0,
            0,
            0});
            resources.ApplyResources(this.updown_angle, "updown_angle");
            this.updown_angle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.updown_angle.Name = "updown_angle";
            // 
            // vtol_takeoff_alt
            // 
            this.vtol_takeoff_alt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.vtol_takeoff_alt, "vtol_takeoff_alt");
            this.vtol_takeoff_alt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.vtol_takeoff_alt.Name = "vtol_takeoff_alt";
            this.vtol_takeoff_alt.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // pilotwp_downdist
            // 
            this.pilotwp_downdist.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.pilotwp_downdist, "pilotwp_downdist");
            this.pilotwp_downdist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pilotwp_downdist.Name = "pilotwp_downdist";
            this.pilotwp_downdist.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            this.toolTip1.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
            // 
            // pilotwp_updist
            // 
            this.pilotwp_updist.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.pilotwp_updist, "pilotwp_updist");
            this.pilotwp_updist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pilotwp_updist.Name = "pilotwp_updist";
            this.pilotwp_updist.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // loiter_radius
            // 
            this.loiter_radius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.loiter_radius, "loiter_radius");
            this.loiter_radius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.loiter_radius.Name = "loiter_radius";
            this.loiter_radius.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.Controls.Add(this.coords1);
            this.panel4.Controls.Add(this.lbl_homedist);
            this.panel4.Controls.Add(this.lbl_prevdist);
            this.panel4.Controls.Add(this.lbl_distance);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.Name = "lbl_prevdist";
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.panel1);
            this.panelMap.Controls.Add(this.panel4);
            this.panelMap.Controls.Add(this.trackBar1);
            this.panelMap.Controls.Add(this.label11);
            this.panelMap.Controls.Add(this.cmb_missiontype);
            this.panelMap.Controls.Add(this.MainMap);
            this.panelMap.Controls.Add(this.pilotwp_updist);
            this.panelMap.Controls.Add(this.CHK_verifyheight);
            this.panelMap.Controls.Add(this.TXT_loiterrad);
            this.panelMap.Controls.Add(this.label7);
            this.panelMap.Controls.Add(this.label5);
            this.panelMap.Controls.Add(this.loiter_radius);
            this.panelMap.Controls.Add(this.label10);
            this.panelMap.Controls.Add(this.label15);
            this.panelMap.Controls.Add(this.pilotwp_downdist);
            this.panelMap.Controls.Add(this.label20);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cmb_missiontype
            // 
            resources.ApplyResources(this.cmb_missiontype, "cmb_missiontype");
            this.cmb_missiontype.FormattingEnabled = true;
            this.cmb_missiontype.Items.AddRange(new object[] {
            resources.GetString("cmb_missiontype.Items"),
            resources.GetString("cmb_missiontype.Items1"),
            resources.GetString("cmb_missiontype.Items2")});
            this.cmb_missiontype.Name = "cmb_missiontype";
            this.cmb_missiontype.SelectedIndexChanged += new System.EventHandler(this.Cmb_missiontype_SelectedIndexChanged);
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStrip1;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Gray;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.HoldInvalidation = false;
            this.MainMap.LevelsKeepInMemmory = 5;
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 19;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = false;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 0D;
            this.MainMap.Load += new System.EventHandler(this.MainMap_Load);
            this.MainMap.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWPToolStripMenuItem,
            this.insertWpToolStripMenuItem,
            this.insertSplineWPToolStripMenuItem,
            this.loiterToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.rTLToolStripMenuItem,
            this.landToolStripMenuItem,
            this.takeoffToolStripMenuItem,
            this.setROIToolStripMenuItem,
            this.clearMissionToolStripMenuItem,
            this.toolStripSeparator1,
            this.polygonToolStripMenuItem,
            this.geoFenceToolStripMenuItem,
            this.rallyPointsToolStripMenuItem,
            this.autoWPToolStripMenuItem,
            this.mapToolToolStripMenuItem,
            this.fileLoadSaveToolStripMenuItem,
            this.pOIToolStripMenuItem,
            this.trackerHomeToolStripMenuItem,
            this.modifyAltToolStripMenuItem,
            this.enterUTMCoordToolStripMenuItem,
            this.switchDockingToolStripMenuItem,
            this.setHomeHereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteWPToolStripMenuItem
            // 
            this.deleteWPToolStripMenuItem.Name = "deleteWPToolStripMenuItem";
            resources.ApplyResources(this.deleteWPToolStripMenuItem, "deleteWPToolStripMenuItem");
            this.deleteWPToolStripMenuItem.Click += new System.EventHandler(this.deleteWPToolStripMenuItem_Click);
            // 
            // insertWpToolStripMenuItem
            // 
            this.insertWpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPositionToolStripMenuItem});
            this.insertWpToolStripMenuItem.Name = "insertWpToolStripMenuItem";
            resources.ApplyResources(this.insertWpToolStripMenuItem, "insertWpToolStripMenuItem");
            this.insertWpToolStripMenuItem.Click += new System.EventHandler(this.insertWpToolStripMenuItem_Click);
            // 
            // currentPositionToolStripMenuItem
            // 
            this.currentPositionToolStripMenuItem.Name = "currentPositionToolStripMenuItem";
            resources.ApplyResources(this.currentPositionToolStripMenuItem, "currentPositionToolStripMenuItem");
            this.currentPositionToolStripMenuItem.Click += new System.EventHandler(this.currentPositionToolStripMenuItem_Click);
            // 
            // insertSplineWPToolStripMenuItem
            // 
            this.insertSplineWPToolStripMenuItem.Name = "insertSplineWPToolStripMenuItem";
            resources.ApplyResources(this.insertSplineWPToolStripMenuItem, "insertSplineWPToolStripMenuItem");
            this.insertSplineWPToolStripMenuItem.Click += new System.EventHandler(this.insertSplineWPToolStripMenuItem_Click);
            // 
            // loiterToolStripMenuItem
            // 
            this.loiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loiterForeverToolStripMenuItem,
            this.loitertimeToolStripMenuItem,
            this.loitercirclesToolStripMenuItem});
            this.loiterToolStripMenuItem.Name = "loiterToolStripMenuItem";
            resources.ApplyResources(this.loiterToolStripMenuItem, "loiterToolStripMenuItem");
            // 
            // loiterForeverToolStripMenuItem
            // 
            this.loiterForeverToolStripMenuItem.Name = "loiterForeverToolStripMenuItem";
            resources.ApplyResources(this.loiterForeverToolStripMenuItem, "loiterForeverToolStripMenuItem");
            this.loiterForeverToolStripMenuItem.Click += new System.EventHandler(this.loiterForeverToolStripMenuItem_Click);
            // 
            // loitertimeToolStripMenuItem
            // 
            this.loitertimeToolStripMenuItem.Name = "loitertimeToolStripMenuItem";
            resources.ApplyResources(this.loitertimeToolStripMenuItem, "loitertimeToolStripMenuItem");
            this.loitertimeToolStripMenuItem.Click += new System.EventHandler(this.loitertimeToolStripMenuItem_Click);
            // 
            // loitercirclesToolStripMenuItem
            // 
            this.loitercirclesToolStripMenuItem.Name = "loitercirclesToolStripMenuItem";
            resources.ApplyResources(this.loitercirclesToolStripMenuItem, "loitercirclesToolStripMenuItem");
            this.loitercirclesToolStripMenuItem.Click += new System.EventHandler(this.loitercirclesToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpstartToolStripMenuItem,
            this.jumpwPToolStripMenuItem});
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            resources.ApplyResources(this.jumpToolStripMenuItem, "jumpToolStripMenuItem");
            // 
            // jumpstartToolStripMenuItem
            // 
            this.jumpstartToolStripMenuItem.Name = "jumpstartToolStripMenuItem";
            resources.ApplyResources(this.jumpstartToolStripMenuItem, "jumpstartToolStripMenuItem");
            this.jumpstartToolStripMenuItem.Click += new System.EventHandler(this.jumpstartToolStripMenuItem_Click);
            // 
            // jumpwPToolStripMenuItem
            // 
            this.jumpwPToolStripMenuItem.Name = "jumpwPToolStripMenuItem";
            resources.ApplyResources(this.jumpwPToolStripMenuItem, "jumpwPToolStripMenuItem");
            this.jumpwPToolStripMenuItem.Click += new System.EventHandler(this.jumpwPToolStripMenuItem_Click);
            // 
            // rTLToolStripMenuItem
            // 
            this.rTLToolStripMenuItem.Name = "rTLToolStripMenuItem";
            resources.ApplyResources(this.rTLToolStripMenuItem, "rTLToolStripMenuItem");
            this.rTLToolStripMenuItem.Click += new System.EventHandler(this.rTLToolStripMenuItem_Click);
            // 
            // landToolStripMenuItem
            // 
            this.landToolStripMenuItem.Name = "landToolStripMenuItem";
            resources.ApplyResources(this.landToolStripMenuItem, "landToolStripMenuItem");
            this.landToolStripMenuItem.Click += new System.EventHandler(this.landToolStripMenuItem_Click);
            // 
            // takeoffToolStripMenuItem
            // 
            this.takeoffToolStripMenuItem.Name = "takeoffToolStripMenuItem";
            resources.ApplyResources(this.takeoffToolStripMenuItem, "takeoffToolStripMenuItem");
            this.takeoffToolStripMenuItem.Click += new System.EventHandler(this.takeoffToolStripMenuItem_Click);
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            resources.ApplyResources(this.setROIToolStripMenuItem, "setROIToolStripMenuItem");
            this.setROIToolStripMenuItem.Click += new System.EventHandler(this.setROIToolStripMenuItem_Click);
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem2,
            this.clearPolygonToolStripMenuItem2,
            this.savePolygonToolStripMenuItem2,
            this.loadPolygonToolStripMenuItem2,
            this.fromSHPToolStripMenuItem2,
            this.areaToolStripMenuItem2});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            resources.ApplyResources(this.polygonToolStripMenuItem, "polygonToolStripMenuItem");
            // 
            // addPolygonPointToolStripMenuItem2
            // 
            this.addPolygonPointToolStripMenuItem2.Name = "addPolygonPointToolStripMenuItem2";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem2, "addPolygonPointToolStripMenuItem2");
            this.addPolygonPointToolStripMenuItem2.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem2
            // 
            this.clearPolygonToolStripMenuItem2.Name = "clearPolygonToolStripMenuItem2";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem2, "clearPolygonToolStripMenuItem2");
            this.clearPolygonToolStripMenuItem2.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // savePolygonToolStripMenuItem2
            // 
            this.savePolygonToolStripMenuItem2.Name = "savePolygonToolStripMenuItem2";
            resources.ApplyResources(this.savePolygonToolStripMenuItem2, "savePolygonToolStripMenuItem2");
            this.savePolygonToolStripMenuItem2.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem2
            // 
            this.loadPolygonToolStripMenuItem2.Name = "loadPolygonToolStripMenuItem2";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem2, "loadPolygonToolStripMenuItem2");
            this.loadPolygonToolStripMenuItem2.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem2
            // 
            this.fromSHPToolStripMenuItem2.Name = "fromSHPToolStripMenuItem2";
            resources.ApplyResources(this.fromSHPToolStripMenuItem2, "fromSHPToolStripMenuItem2");
            this.fromSHPToolStripMenuItem2.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem2
            // 
            this.areaToolStripMenuItem2.Name = "areaToolStripMenuItem2";
            resources.ApplyResources(this.areaToolStripMenuItem2, "areaToolStripMenuItem2");
            this.areaToolStripMenuItem2.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // geoFenceToolStripMenuItem
            // 
            this.geoFenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeoFenceuploadToolStripMenuItem,
            this.GeoFencedownloadToolStripMenuItem,
            this.setReturnLocationToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.geoFenceToolStripMenuItem.Name = "geoFenceToolStripMenuItem";
            resources.ApplyResources(this.geoFenceToolStripMenuItem, "geoFenceToolStripMenuItem");
            // 
            // GeoFenceuploadToolStripMenuItem
            // 
            this.GeoFenceuploadToolStripMenuItem.Name = "GeoFenceuploadToolStripMenuItem";
            resources.ApplyResources(this.GeoFenceuploadToolStripMenuItem, "GeoFenceuploadToolStripMenuItem");
            this.GeoFenceuploadToolStripMenuItem.Click += new System.EventHandler(this.GeoFenceuploadToolStripMenuItem_Click);
            // 
            // GeoFencedownloadToolStripMenuItem
            // 
            this.GeoFencedownloadToolStripMenuItem.Name = "GeoFencedownloadToolStripMenuItem";
            resources.ApplyResources(this.GeoFencedownloadToolStripMenuItem, "GeoFencedownloadToolStripMenuItem");
            this.GeoFencedownloadToolStripMenuItem.Click += new System.EventHandler(this.GeoFencedownloadToolStripMenuItem_Click);
            // 
            // setReturnLocationToolStripMenuItem
            // 
            this.setReturnLocationToolStripMenuItem.Name = "setReturnLocationToolStripMenuItem";
            resources.ApplyResources(this.setReturnLocationToolStripMenuItem, "setReturnLocationToolStripMenuItem");
            this.setReturnLocationToolStripMenuItem.Click += new System.EventHandler(this.setReturnLocationToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem, "loadFromFileToolStripMenuItem");
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            resources.ApplyResources(this.saveToFileToolStripMenuItem, "saveToFileToolStripMenuItem");
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // rallyPointsToolStripMenuItem
            // 
            this.rallyPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRallyPointToolStripMenuItem,
            this.getRallyPointsToolStripMenuItem,
            this.saveRallyPointsToolStripMenuItem,
            this.clearRallyPointsToolStripMenuItem,
            this.saveToFileToolStripMenuItem1,
            this.loadFromFileToolStripMenuItem1});
            this.rallyPointsToolStripMenuItem.Name = "rallyPointsToolStripMenuItem";
            resources.ApplyResources(this.rallyPointsToolStripMenuItem, "rallyPointsToolStripMenuItem");
            // 
            // setRallyPointToolStripMenuItem
            // 
            this.setRallyPointToolStripMenuItem.Name = "setRallyPointToolStripMenuItem";
            resources.ApplyResources(this.setRallyPointToolStripMenuItem, "setRallyPointToolStripMenuItem");
            this.setRallyPointToolStripMenuItem.Click += new System.EventHandler(this.setRallyPointToolStripMenuItem_Click);
            // 
            // getRallyPointsToolStripMenuItem
            // 
            this.getRallyPointsToolStripMenuItem.Name = "getRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.getRallyPointsToolStripMenuItem, "getRallyPointsToolStripMenuItem");
            this.getRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.getRallyPointsToolStripMenuItem_Click);
            // 
            // saveRallyPointsToolStripMenuItem
            // 
            this.saveRallyPointsToolStripMenuItem.Name = "saveRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.saveRallyPointsToolStripMenuItem, "saveRallyPointsToolStripMenuItem");
            this.saveRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.saveRallyPointsToolStripMenuItem_Click);
            // 
            // clearRallyPointsToolStripMenuItem
            // 
            this.clearRallyPointsToolStripMenuItem.Name = "clearRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.clearRallyPointsToolStripMenuItem, "clearRallyPointsToolStripMenuItem");
            this.clearRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.clearRallyPointsToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            resources.ApplyResources(this.saveToFileToolStripMenuItem1, "saveToFileToolStripMenuItem1");
            this.saveToFileToolStripMenuItem1.Click += new System.EventHandler(this.saveToFileToolStripMenuItem1_Click);
            // 
            // loadFromFileToolStripMenuItem1
            // 
            this.loadFromFileToolStripMenuItem1.Name = "loadFromFileToolStripMenuItem1";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem1, "loadFromFileToolStripMenuItem1");
            this.loadFromFileToolStripMenuItem1.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem1_Click);
            // 
            // autoWPToolStripMenuItem
            // 
            this.autoWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWpCircleToolStripMenuItem,
            this.createSplineCircleToolStripMenuItem,
            this.areaToolStripMenuItem1,
            this.textToolStripMenuItem,
            this.createCircleSurveyToolStripMenuItem,
            this.surveyGridToolStripMenuItem});
            this.autoWPToolStripMenuItem.Name = "autoWPToolStripMenuItem";
            resources.ApplyResources(this.autoWPToolStripMenuItem, "autoWPToolStripMenuItem");
            // 
            // createWpCircleToolStripMenuItem
            // 
            this.createWpCircleToolStripMenuItem.Name = "createWpCircleToolStripMenuItem";
            resources.ApplyResources(this.createWpCircleToolStripMenuItem, "createWpCircleToolStripMenuItem");
            this.createWpCircleToolStripMenuItem.Click += new System.EventHandler(this.createWpCircleToolStripMenuItem_Click);
            // 
            // createSplineCircleToolStripMenuItem
            // 
            this.createSplineCircleToolStripMenuItem.Name = "createSplineCircleToolStripMenuItem";
            resources.ApplyResources(this.createSplineCircleToolStripMenuItem, "createSplineCircleToolStripMenuItem");
            this.createSplineCircleToolStripMenuItem.Click += new System.EventHandler(this.createSplineCircleToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem1
            // 
            this.areaToolStripMenuItem1.Name = "areaToolStripMenuItem1";
            resources.ApplyResources(this.areaToolStripMenuItem1, "areaToolStripMenuItem1");
            this.areaToolStripMenuItem1.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            resources.ApplyResources(this.textToolStripMenuItem, "textToolStripMenuItem");
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // createCircleSurveyToolStripMenuItem
            // 
            this.createCircleSurveyToolStripMenuItem.Name = "createCircleSurveyToolStripMenuItem";
            resources.ApplyResources(this.createCircleSurveyToolStripMenuItem, "createCircleSurveyToolStripMenuItem");
            this.createCircleSurveyToolStripMenuItem.Click += new System.EventHandler(this.createCircleSurveyToolStripMenuItem_Click);
            // 
            // surveyGridToolStripMenuItem
            // 
            this.surveyGridToolStripMenuItem.Name = "surveyGridToolStripMenuItem";
            resources.ApplyResources(this.surveyGridToolStripMenuItem, "surveyGridToolStripMenuItem");
            this.surveyGridToolStripMenuItem.Click += new System.EventHandler(this.surveyGridToolStripMenuItem_Click);
            // 
            // mapToolToolStripMenuItem
            // 
            this.mapToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMeasure,
            this.rotateMapToolStripMenuItem,
            this.zoomToToolStripMenuItem,
            this.prefetchToolStripMenuItem,
            this.prefetchWPPathToolStripMenuItem,
            this.kMLOverlayToolStripMenuItem,
            this.elevationGraphToolStripMenuItem,
            this.reverseWPsToolStripMenuItem});
            this.mapToolToolStripMenuItem.Name = "mapToolToolStripMenuItem";
            resources.ApplyResources(this.mapToolToolStripMenuItem, "mapToolToolStripMenuItem");
            // 
            // ContextMeasure
            // 
            this.ContextMeasure.Name = "ContextMeasure";
            resources.ApplyResources(this.ContextMeasure, "ContextMeasure");
            this.ContextMeasure.Click += new System.EventHandler(this.ContextMeasure_Click);
            // 
            // rotateMapToolStripMenuItem
            // 
            this.rotateMapToolStripMenuItem.Name = "rotateMapToolStripMenuItem";
            resources.ApplyResources(this.rotateMapToolStripMenuItem, "rotateMapToolStripMenuItem");
            this.rotateMapToolStripMenuItem.Click += new System.EventHandler(this.rotateMapToolStripMenuItem_Click);
            // 
            // zoomToToolStripMenuItem
            // 
            this.zoomToToolStripMenuItem.Name = "zoomToToolStripMenuItem";
            resources.ApplyResources(this.zoomToToolStripMenuItem, "zoomToToolStripMenuItem");
            this.zoomToToolStripMenuItem.Click += new System.EventHandler(this.zoomToToolStripMenuItem_Click);
            // 
            // prefetchToolStripMenuItem
            // 
            this.prefetchToolStripMenuItem.Name = "prefetchToolStripMenuItem";
            resources.ApplyResources(this.prefetchToolStripMenuItem, "prefetchToolStripMenuItem");
            this.prefetchToolStripMenuItem.Click += new System.EventHandler(this.prefetchToolStripMenuItem_Click);
            // 
            // prefetchWPPathToolStripMenuItem
            // 
            this.prefetchWPPathToolStripMenuItem.Name = "prefetchWPPathToolStripMenuItem";
            resources.ApplyResources(this.prefetchWPPathToolStripMenuItem, "prefetchWPPathToolStripMenuItem");
            this.prefetchWPPathToolStripMenuItem.Click += new System.EventHandler(this.prefetchWPPathToolStripMenuItem_Click);
            // 
            // kMLOverlayToolStripMenuItem
            // 
            this.kMLOverlayToolStripMenuItem.Name = "kMLOverlayToolStripMenuItem";
            resources.ApplyResources(this.kMLOverlayToolStripMenuItem, "kMLOverlayToolStripMenuItem");
            this.kMLOverlayToolStripMenuItem.Click += new System.EventHandler(this.kMLOverlayToolStripMenuItem_Click);
            // 
            // elevationGraphToolStripMenuItem
            // 
            this.elevationGraphToolStripMenuItem.Name = "elevationGraphToolStripMenuItem";
            resources.ApplyResources(this.elevationGraphToolStripMenuItem, "elevationGraphToolStripMenuItem");
            this.elevationGraphToolStripMenuItem.Click += new System.EventHandler(this.elevationGraphToolStripMenuItem_Click);
            // 
            // reverseWPsToolStripMenuItem
            // 
            this.reverseWPsToolStripMenuItem.Name = "reverseWPsToolStripMenuItem";
            resources.ApplyResources(this.reverseWPsToolStripMenuItem, "reverseWPsToolStripMenuItem");
            this.reverseWPsToolStripMenuItem.Click += new System.EventHandler(this.reverseWPsToolStripMenuItem_Click);
            // 
            // fileLoadSaveToolStripMenuItem
            // 
            this.fileLoadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWPFileToolStripMenuItem,
            this.loadAndAppendToolStripMenuItem,
            this.saveWPFileToolStripMenuItem,
            this.loadKMLFileToolStripMenuItem,
            this.loadSHPFileToolStripMenuItem});
            this.fileLoadSaveToolStripMenuItem.Name = "fileLoadSaveToolStripMenuItem";
            resources.ApplyResources(this.fileLoadSaveToolStripMenuItem, "fileLoadSaveToolStripMenuItem");
            // 
            // loadWPFileToolStripMenuItem
            // 
            this.loadWPFileToolStripMenuItem.Name = "loadWPFileToolStripMenuItem";
            resources.ApplyResources(this.loadWPFileToolStripMenuItem, "loadWPFileToolStripMenuItem");
            this.loadWPFileToolStripMenuItem.Click += new System.EventHandler(this.loadWPFileToolStripMenuItem_Click);
            // 
            // loadAndAppendToolStripMenuItem
            // 
            this.loadAndAppendToolStripMenuItem.Name = "loadAndAppendToolStripMenuItem";
            resources.ApplyResources(this.loadAndAppendToolStripMenuItem, "loadAndAppendToolStripMenuItem");
            this.loadAndAppendToolStripMenuItem.Click += new System.EventHandler(this.loadAndAppendToolStripMenuItem_Click);
            // 
            // saveWPFileToolStripMenuItem
            // 
            this.saveWPFileToolStripMenuItem.Name = "saveWPFileToolStripMenuItem";
            resources.ApplyResources(this.saveWPFileToolStripMenuItem, "saveWPFileToolStripMenuItem");
            this.saveWPFileToolStripMenuItem.Click += new System.EventHandler(this.saveWPFileToolStripMenuItem_Click);
            // 
            // loadKMLFileToolStripMenuItem
            // 
            this.loadKMLFileToolStripMenuItem.Name = "loadKMLFileToolStripMenuItem";
            resources.ApplyResources(this.loadKMLFileToolStripMenuItem, "loadKMLFileToolStripMenuItem");
            this.loadKMLFileToolStripMenuItem.Click += new System.EventHandler(this.loadKMLFileToolStripMenuItem_Click);
            // 
            // loadSHPFileToolStripMenuItem
            // 
            this.loadSHPFileToolStripMenuItem.Name = "loadSHPFileToolStripMenuItem";
            resources.ApplyResources(this.loadSHPFileToolStripMenuItem, "loadSHPFileToolStripMenuItem");
            this.loadSHPFileToolStripMenuItem.Click += new System.EventHandler(this.loadSHPFileToolStripMenuItem_Click);
            // 
            // pOIToolStripMenuItem
            // 
            this.pOIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiaddToolStripMenuItem,
            this.poideleteToolStripMenuItem,
            this.poieditToolStripMenuItem});
            this.pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            resources.ApplyResources(this.pOIToolStripMenuItem, "pOIToolStripMenuItem");
            // 
            // poiaddToolStripMenuItem
            // 
            this.poiaddToolStripMenuItem.Name = "poiaddToolStripMenuItem";
            resources.ApplyResources(this.poiaddToolStripMenuItem, "poiaddToolStripMenuItem");
            this.poiaddToolStripMenuItem.Click += new System.EventHandler(this.poiaddToolStripMenuItem_Click);
            // 
            // poideleteToolStripMenuItem
            // 
            this.poideleteToolStripMenuItem.Name = "poideleteToolStripMenuItem";
            resources.ApplyResources(this.poideleteToolStripMenuItem, "poideleteToolStripMenuItem");
            this.poideleteToolStripMenuItem.Click += new System.EventHandler(this.poideleteToolStripMenuItem_Click);
            // 
            // poieditToolStripMenuItem
            // 
            this.poieditToolStripMenuItem.Name = "poieditToolStripMenuItem";
            resources.ApplyResources(this.poieditToolStripMenuItem, "poieditToolStripMenuItem");
            this.poieditToolStripMenuItem.Click += new System.EventHandler(this.poieditToolStripMenuItem_Click);
            // 
            // trackerHomeToolStripMenuItem
            // 
            this.trackerHomeToolStripMenuItem.Name = "trackerHomeToolStripMenuItem";
            resources.ApplyResources(this.trackerHomeToolStripMenuItem, "trackerHomeToolStripMenuItem");
            this.trackerHomeToolStripMenuItem.Click += new System.EventHandler(this.trackerHomeToolStripMenuItem_Click);
            // 
            // modifyAltToolStripMenuItem
            // 
            this.modifyAltToolStripMenuItem.Name = "modifyAltToolStripMenuItem";
            resources.ApplyResources(this.modifyAltToolStripMenuItem, "modifyAltToolStripMenuItem");
            this.modifyAltToolStripMenuItem.Click += new System.EventHandler(this.modifyAltToolStripMenuItem_Click);
            // 
            // enterUTMCoordToolStripMenuItem
            // 
            this.enterUTMCoordToolStripMenuItem.Name = "enterUTMCoordToolStripMenuItem";
            resources.ApplyResources(this.enterUTMCoordToolStripMenuItem, "enterUTMCoordToolStripMenuItem");
            this.enterUTMCoordToolStripMenuItem.Click += new System.EventHandler(this.enterUTMCoordToolStripMenuItem_Click);
            // 
            // switchDockingToolStripMenuItem
            // 
            this.switchDockingToolStripMenuItem.Name = "switchDockingToolStripMenuItem";
            resources.ApplyResources(this.switchDockingToolStripMenuItem, "switchDockingToolStripMenuItem");
            this.switchDockingToolStripMenuItem.Click += new System.EventHandler(this.switchDockingToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // addPolygonPointToolStripMenuItem
            // 
            this.addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            this.addPolygonPointToolStripMenuItem.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem
            // 
            this.clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            this.clearPolygonToolStripMenuItem.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // savePolygonToolStripMenuItem
            // 
            this.savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            resources.ApplyResources(this.savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            this.savePolygonToolStripMenuItem.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem
            // 
            this.loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            this.loadPolygonToolStripMenuItem.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem
            // 
            this.fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            resources.ApplyResources(this.fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            this.fromSHPToolStripMenuItem.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            resources.ApplyResources(this.areaToolStripMenuItem, "areaToolStripMenuItem");
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // fenceInclusionToolStripMenuItem
            // 
            this.fenceInclusionToolStripMenuItem.Name = "fenceInclusionToolStripMenuItem";
            resources.ApplyResources(this.fenceInclusionToolStripMenuItem, "fenceInclusionToolStripMenuItem");
            this.fenceInclusionToolStripMenuItem.Click += new System.EventHandler(this.FenceInclusionToolStripMenuItem_Click);
            // 
            // fenceExclusionToolStripMenuItem
            // 
            this.fenceExclusionToolStripMenuItem.Name = "fenceExclusionToolStripMenuItem";
            resources.ApplyResources(this.fenceExclusionToolStripMenuItem, "fenceExclusionToolStripMenuItem");
            this.fenceExclusionToolStripMenuItem.Click += new System.EventHandler(this.FenceExclusionToolStripMenuItem_Click);
            // 
            // panelBASE
            // 
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            this.panelBASE.Controls.Add(this.splitter2);
            this.panelBASE.Controls.Add(this.panelMap);
            this.panelBASE.Controls.Add(this.panelAction);
            this.panelBASE.Controls.Add(this.label6);
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Name = "panelBASE";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStripPoly
            // 
            this.contextMenuStripPoly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem,
            this.clearPolygonToolStripMenuItem,
            this.savePolygonToolStripMenuItem,
            this.loadPolygonToolStripMenuItem,
            this.fromSHPToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.fenceInclusionToolStripMenuItem,
            this.fenceExclusionToolStripMenuItem});
            this.contextMenuStripPoly.Name = "contextMenuStripPoly";
            this.contextMenuStripPoly.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStripPoly, "contextMenuStripPoly");
            this.contextMenuStripPoly.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripPoly_Opening);
            // 
            // drawAPolygonToolStripMenuItem
            // 
            this.drawAPolygonToolStripMenuItem.Name = "drawAPolygonToolStripMenuItem";
            resources.ApplyResources(this.drawAPolygonToolStripMenuItem, "drawAPolygonToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            resources.ApplyResources(this.testToolStripMenuItem, "testToolStripMenuItem");
            // 
            // contextMenuStripZoom
            // 
            this.contextMenuStripZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToVehicleToolStripMenuItem,
            this.zoomToMissionToolStripMenuItem,
            this.zoomToHomeToolStripMenuItem});
            this.contextMenuStripZoom.Name = "contextMenuStripZoom";
            resources.ApplyResources(this.contextMenuStripZoom, "contextMenuStripZoom");
            // 
            // zoomToVehicleToolStripMenuItem
            // 
            this.zoomToVehicleToolStripMenuItem.Name = "zoomToVehicleToolStripMenuItem";
            resources.ApplyResources(this.zoomToVehicleToolStripMenuItem, "zoomToVehicleToolStripMenuItem");
            this.zoomToVehicleToolStripMenuItem.Click += new System.EventHandler(this.zoomToVehicleToolStripMenuItem_Click);
            // 
            // zoomToMissionToolStripMenuItem
            // 
            this.zoomToMissionToolStripMenuItem.Name = "zoomToMissionToolStripMenuItem";
            resources.ApplyResources(this.zoomToMissionToolStripMenuItem, "zoomToMissionToolStripMenuItem");
            this.zoomToMissionToolStripMenuItem.Click += new System.EventHandler(this.zoomToMissionToolStripMenuItem_Click);
            // 
            // zoomToHomeToolStripMenuItem
            // 
            this.zoomToHomeToolStripMenuItem.Name = "zoomToHomeToolStripMenuItem";
            resources.ApplyResources(this.zoomToHomeToolStripMenuItem, "zoomToHomeToolStripMenuItem");
            this.zoomToHomeToolStripMenuItem.Click += new System.EventHandler(this.zoomToHomeToolStripMenuItem_Click);
            // 
            // FlightPlanner
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBASE);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.Load += new System.EventHandler(this.FlightPlanner_Load);
            this.Resize += new System.EventHandler(this.Planner_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWaypoints.ResumeLayout(false);
            this.panelWaypoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_per_dist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpb_takeoffandland.ResumeLayout(false);
            this.gpb_takeoffandland.PerformLayout();
            this.panel_plane.ResumeLayout(false);
            this.panel_plane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_downalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_upalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_downalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_upalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtol_takeoff_alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_downdist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotwp_updist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_radius)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelBASE.ResumeLayout(false);
            this.contextMenuStripPoly.ResumeLayout(false);
            this.contextMenuStripZoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        public Panel panelWaypoints;
        public Panel panelAction;
        public Controls.myGMAP MainMap;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.CheckBox CHK_verifyheight;
        public System.Windows.Forms.TextBox TXT_WPRad;
        public System.Windows.Forms.TextBox TXT_DefaultAlt;
        public System.Windows.Forms.TextBox TXT_loiterrad;
        public System.Windows.Forms.CheckBox CHK_splinedefault;
        public System.Windows.Forms.ComboBox CMB_altmode;
        public Panel panel1;
        public LinkLabel label4;
        public Label label3;
        public Label label2;
        public Label Label1;
        public TextBox TXT_homealt;
        public TextBox TXT_homelng;
        public TextBox TXT_homelat;
        public DataGridViewImageColumn dataGridViewImageColumn1;
        public DataGridViewImageColumn dataGridViewImageColumn2;
        public Label label6;
        public MyDataGridView Commands;
        public MyButton BUT_Add;
        public Label LBL_WPRad;
        public Label LBL_defalutalt;
        public Label label5;
        public Panel panelMap;
        public MyTrackBar trackBar1;
        public Label label11;
        public Label lbl_distance;
        public Label lbl_prevdist;
        public Splitter splitter1;
        public Panel panelBASE;
        public Label lbl_homedist;
        public ToolTip toolTip1;
        public ToolStripMenuItem clearMissionToolStripMenuItem;
        public ToolStripMenuItem addPolygonPointToolStripMenuItem;
        public ToolStripMenuItem clearPolygonToolStripMenuItem;
        public ToolStripMenuItem loiterToolStripMenuItem;
        public ToolStripMenuItem loiterForeverToolStripMenuItem;
        public ToolStripMenuItem loitertimeToolStripMenuItem;
        public ToolStripMenuItem loitercirclesToolStripMenuItem;
        public ToolStripMenuItem jumpToolStripMenuItem;
        public ToolStripMenuItem jumpstartToolStripMenuItem;
        public ToolStripMenuItem jumpwPToolStripMenuItem;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem deleteWPToolStripMenuItem;
        public Timer timer1;
        public ToolStripMenuItem setROIToolStripMenuItem;
        public ToolStripMenuItem mapToolToolStripMenuItem;
        public ToolStripMenuItem ContextMeasure;
        public ToolStripMenuItem rotateMapToolStripMenuItem;
        public ToolStripMenuItem zoomToToolStripMenuItem;
        public ToolStripMenuItem prefetchToolStripMenuItem;
        public ToolStripMenuItem kMLOverlayToolStripMenuItem;
        public ToolStripMenuItem elevationGraphToolStripMenuItem;
        public ToolStripMenuItem rTLToolStripMenuItem;
        public ToolStripMenuItem landToolStripMenuItem;
        public ToolStripMenuItem takeoffToolStripMenuItem;
        public ToolStripMenuItem fileLoadSaveToolStripMenuItem;
        public ToolStripMenuItem loadWPFileToolStripMenuItem;
        public ToolStripMenuItem saveWPFileToolStripMenuItem;
        public ToolStripMenuItem trackerHomeToolStripMenuItem;
        public ToolStripMenuItem reverseWPsToolStripMenuItem;
        public ToolStripMenuItem loadAndAppendToolStripMenuItem;
        public ToolStripMenuItem savePolygonToolStripMenuItem;
        public ToolStripMenuItem loadPolygonToolStripMenuItem;
        public ToolStripMenuItem insertWpToolStripMenuItem;
        public ToolStripMenuItem loadKMLFileToolStripMenuItem;
        public ToolStripMenuItem modifyAltToolStripMenuItem;
        public ToolStripMenuItem prefetchWPPathToolStripMenuItem;
        public Label label17;
        public TextBox TXT_altwarn;
        public ToolStripMenuItem pOIToolStripMenuItem;
        public ToolStripMenuItem poiaddToolStripMenuItem;
        public ToolStripMenuItem poideleteToolStripMenuItem;
        public ToolStripMenuItem poieditToolStripMenuItem;
        public ToolStripMenuItem enterUTMCoordToolStripMenuItem;
        public ToolStripMenuItem loadSHPFileToolStripMenuItem;
        public Coords coords1;
        public Panel panel4;
        public ToolStripMenuItem switchDockingToolStripMenuItem;
        public ToolStripMenuItem insertSplineWPToolStripMenuItem;
        public ToolStripMenuItem fromSHPToolStripMenuItem;
        public ToolStripMenuItem areaToolStripMenuItem;
        public ToolStripMenuItem setHomeHereToolStripMenuItem;
        public ToolStripMenuItem currentPositionToolStripMenuItem;
        public ComboBox cmb_missiontype;
        public ContextMenuStrip contextMenuStripPoly;
        public ToolStripMenuItem drawAPolygonToolStripMenuItem;
        public ToolStripMenuItem fenceInclusionToolStripMenuItem;
        public ToolStripMenuItem fenceExclusionToolStripMenuItem;
        public ToolStripMenuItem autoWPToolStripMenuItem;
        public ToolStripMenuItem createWpCircleToolStripMenuItem;
        public ToolStripMenuItem createSplineCircleToolStripMenuItem;
        public ToolStripMenuItem areaToolStripMenuItem1;
        public ToolStripMenuItem textToolStripMenuItem;
        public ToolStripMenuItem createCircleSurveyToolStripMenuItem;
        public ToolStripMenuItem surveyGridToolStripMenuItem;
        public ToolStripMenuItem geoFenceToolStripMenuItem;
        public ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
        public ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
        public ToolStripMenuItem setReturnLocationToolStripMenuItem;
        public ToolStripMenuItem loadFromFileToolStripMenuItem;
        public ToolStripMenuItem saveToFileToolStripMenuItem;
        public ToolStripMenuItem clearToolStripMenuItem;
        public ToolStripMenuItem rallyPointsToolStripMenuItem;
        public ToolStripMenuItem setRallyPointToolStripMenuItem;
        public ToolStripMenuItem getRallyPointsToolStripMenuItem;
        public ToolStripMenuItem saveRallyPointsToolStripMenuItem;
        public ToolStripMenuItem clearRallyPointsToolStripMenuItem;
        public ToolStripMenuItem saveToFileToolStripMenuItem1;
        public ToolStripMenuItem loadFromFileToolStripMenuItem1;
        public MyButton but_mincommands;
        private ToolStripMenuItem polygonToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem testToolStripMenuItem;
        public ToolStripMenuItem addPolygonPointToolStripMenuItem2;
        public ToolStripMenuItem clearPolygonToolStripMenuItem2;
        public ToolStripMenuItem savePolygonToolStripMenuItem2;
        public ToolStripMenuItem loadPolygonToolStripMenuItem2;
        public ToolStripMenuItem fromSHPToolStripMenuItem2;
        public ToolStripMenuItem areaToolStripMenuItem2;
        private ContextMenuStrip contextMenuStripZoom;
        private ToolStripMenuItem zoomToVehicleToolStripMenuItem;
        private ToolStripMenuItem zoomToMissionToolStripMenuItem;
        private ToolStripMenuItem zoomToHomeToolStripMenuItem;
        public Splitter splitter2;
        private Label label15;
        private Label label7;
        private Label label10;
        private NumericUpDown loiter_radius;
        private NumericUpDown pilotwp_updist;
        private Label label20;
        private NumericUpDown pilotwp_downdist;
        private DataGridViewComboBoxColumn Command;
        private DataGridViewTextBoxColumn Param1;
        private DataGridViewTextBoxColumn Param2;
        private DataGridViewTextBoxColumn Param3;
        private DataGridViewTextBoxColumn Param4;
        private DataGridViewTextBoxColumn Lat;
        private DataGridViewTextBoxColumn Lon;
        private DataGridViewTextBoxColumn Alt;
        private DataGridViewComboBoxColumn Frame;
        private DataGridViewTextBoxColumn coordZone;
        private DataGridViewTextBoxColumn coordEasting;
        private DataGridViewTextBoxColumn coordNorthing;
        private DataGridViewTextBoxColumn MGRS;
        private DataGridViewButtonColumn Delete;
        private DataGridViewImageColumn Up;
        private DataGridViewImageColumn Down;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Angle;
        private DataGridViewTextBoxColumn Dist;
        private DataGridViewTextBoxColumn AZ;
        private DataGridViewTextBoxColumn TagData;
        private MyButton btn_per;
        private NumericUpDown num_per;
        private NumericUpDown num_per_dist;
        private CheckBox chk_ispart;
        public FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        public ComboBox comboBoxMapType;
        public CheckBox chk_grid;
        public LinkLabel lnk_kml;
        public Label lbl_status;
        private GroupBox groupBox1;
        private CheckBox chk_imitation;
        public MyButton load_kml;
        public MyButton BUT_write;
        public MyButton alt_curve;
        public MyButton BUT_saveWPFile;
        public MyButton del_area;
        public MyButton BUT_loadwpfile;
        public Label lbl_wpfile;
        public MyButton but_writewpfast;
        public MyButton BUT_read;
        public MyButton del_flight;
        public MyButton creat_flight;
        private GroupBox groupBox3;
        private Label lbl_flytimenum;
        private Label lbl_flytime;
        private MyButton add_updownwp;
        private MyButton refresh_updown;
        private MyButton del_updownwp;
        private GroupBox gpb_takeoffandland;
        private Panel panel_plane;
        private Label label16;
        private Label label19;
        private Label label18;
        private NumericUpDown loiter_downalt;
        private NumericUpDown loiter_upalt;
        private Label label12;
        private NumericUpDown pilotwp_downalt;
        private Label label13;
        private NumericUpDown pilotwp_upalt;
        private Label label14;
        private Label label21;
        private NumericUpDown updown_angle;
        private NumericUpDown vtol_takeoff_alt;
        private Label label9;
        private Label label8;
    }
}