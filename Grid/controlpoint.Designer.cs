namespace MissionPlanner.controlpoint
{
    partial class GridUI
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUI));
            this.map = new MissionPlanner.Controls.myGMAP();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_strips = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.lbl_distbetweenlines = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.CHK_internals = new System.Windows.Forms.CheckBox();
            this.chk_set = new System.Windows.Forms.CheckBox();
            this.chk_boundary = new System.Windows.Forms.CheckBox();
            this.chk_markers = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NUM_overshoot2 = new System.Windows.Forms.NumericUpDown();
            this.NUM_altitude = new System.Windows.Forms.NumericUpDown();
            this.NUM_UpDownFlySpeed = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUM_overshoot = new System.Windows.Forms.NumericUpDown();
            this.tabSimple = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.num_alt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUM_angle = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BUT_Accept = new MissionPlanner.Controls.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_startfrom = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_homeres = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gb_set = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.num_cam_angle = new System.Windows.Forms.NumericUpDown();
            this.num_offset = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUM_Distance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.loiter_r = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NUM_spacing = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.loiter_turn = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cam_dist = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_overshoot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_altitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_UpDownFlySpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_overshoot)).BeginInit();
            this.tabSimple.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_angle)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.gb_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cam_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_spacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam_dist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            resources.ApplyResources(this.map, "map");
            this.map.EmptyTileColor = System.Drawing.Color.Gray;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.HoldInvalidation = false;
            this.map.LevelsKeepInMemmory = 5;
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 19;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Zoom = 3D;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_strips);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.chk_grid);
            this.groupBox5.Controls.Add(this.lbl_distbetweenlines);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.CHK_internals);
            this.groupBox5.Controls.Add(this.chk_set);
            this.groupBox5.Controls.Add(this.chk_boundary);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // lbl_strips
            // 
            resources.ApplyResources(this.lbl_strips, "lbl_strips");
            this.lbl_strips.Name = "lbl_strips";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            this.chk_grid.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // lbl_distbetweenlines
            // 
            resources.ApplyResources(this.lbl_distbetweenlines, "lbl_distbetweenlines");
            this.lbl_distbetweenlines.Name = "lbl_distbetweenlines";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // CHK_internals
            // 
            resources.ApplyResources(this.CHK_internals, "CHK_internals");
            this.CHK_internals.Checked = true;
            this.CHK_internals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_internals.Name = "CHK_internals";
            this.CHK_internals.UseVisualStyleBackColor = true;
            this.CHK_internals.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // chk_set
            // 
            resources.ApplyResources(this.chk_set, "chk_set");
            this.chk_set.Name = "chk_set";
            this.chk_set.UseVisualStyleBackColor = true;
            this.chk_set.CheckedChanged += new System.EventHandler(this.chk_set_CheckedChanged);
            // 
            // chk_boundary
            // 
            resources.ApplyResources(this.chk_boundary, "chk_boundary");
            this.chk_boundary.Checked = true;
            this.chk_boundary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_boundary.Name = "chk_boundary";
            this.chk_boundary.UseVisualStyleBackColor = true;
            this.chk_boundary.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // chk_markers
            // 
            resources.ApplyResources(this.chk_markers, "chk_markers");
            this.chk_markers.Name = "chk_markers";
            this.chk_markers.UseVisualStyleBackColor = true;
            this.chk_markers.CheckedChanged += new System.EventHandler(this.chk_markers_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // NUM_overshoot2
            // 
            resources.ApplyResources(this.NUM_overshoot2, "NUM_overshoot2");
            this.NUM_overshoot2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUM_overshoot2.Name = "NUM_overshoot2";
            this.NUM_overshoot2.ValueChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // NUM_altitude
            // 
            this.NUM_altitude.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.NUM_altitude, "NUM_altitude");
            this.NUM_altitude.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUM_altitude.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUM_altitude.Name = "NUM_altitude";
            this.NUM_altitude.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NUM_altitude.ValueChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // NUM_UpDownFlySpeed
            // 
            resources.ApplyResources(this.NUM_UpDownFlySpeed, "NUM_UpDownFlySpeed");
            this.NUM_UpDownFlySpeed.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NUM_UpDownFlySpeed.Name = "NUM_UpDownFlySpeed";
            this.NUM_UpDownFlySpeed.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUM_UpDownFlySpeed.ValueChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            // 
            // lbl_area
            // 
            resources.ApplyResources(this.lbl_area, "lbl_area");
            this.lbl_area.Name = "lbl_area";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // NUM_overshoot
            // 
            resources.ApplyResources(this.NUM_overshoot, "NUM_overshoot");
            this.NUM_overshoot.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUM_overshoot.Name = "NUM_overshoot";
            this.NUM_overshoot.ValueChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // tabSimple
            // 
            this.tabSimple.Controls.Add(this.groupBox6);
            this.tabSimple.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.tabSimple, "tabSimple");
            this.tabSimple.Name = "tabSimple";
            this.tabSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.num_alt);
            this.groupBox6.Controls.Add(this.chk_markers);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.NUM_angle);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.BUT_Accept);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.CMB_startfrom);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // num_alt
            // 
            this.num_alt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.num_alt, "num_alt");
            this.num_alt.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_alt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_alt.Name = "num_alt";
            this.num_alt.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_alt.ValueChanged += new System.EventHandler(this.num_alt_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // NUM_angle
            // 
            resources.ApplyResources(this.NUM_angle, "NUM_angle");
            this.NUM_angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NUM_angle.Name = "NUM_angle";
            this.NUM_angle.ValueChanged += new System.EventHandler(this.maprefresh);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // BUT_Accept
            // 
            resources.ApplyResources(this.BUT_Accept, "BUT_Accept");
            this.BUT_Accept.Name = "BUT_Accept";
            this.BUT_Accept.UseVisualStyleBackColor = true;
            this.BUT_Accept.Click += new System.EventHandler(this.BUT_Accept_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // CMB_startfrom
            // 
            this.CMB_startfrom.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_startfrom, "CMB_startfrom");
            this.CMB_startfrom.Name = "CMB_startfrom";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_homeres);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.lbl_distance);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.lbl_area);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lbl_homeres
            // 
            resources.ApplyResources(this.lbl_homeres, "lbl_homeres");
            this.lbl_homeres.Name = "lbl_homeres";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // gb_set
            // 
            this.gb_set.Controls.Add(this.label27);
            this.gb_set.Controls.Add(this.label26);
            this.gb_set.Controls.Add(this.num_cam_angle);
            this.gb_set.Controls.Add(this.num_offset);
            this.gb_set.Controls.Add(this.label2);
            this.gb_set.Controls.Add(this.NUM_Distance);
            this.gb_set.Controls.Add(this.label3);
            this.gb_set.Controls.Add(this.loiter_r);
            this.gb_set.Controls.Add(this.label9);
            this.gb_set.Controls.Add(this.NUM_spacing);
            this.gb_set.Controls.Add(this.label8);
            this.gb_set.Controls.Add(this.loiter_turn);
            resources.ApplyResources(this.gb_set, "gb_set");
            this.gb_set.Name = "gb_set";
            this.gb_set.TabStop = false;
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // num_cam_angle
            // 
            resources.ApplyResources(this.num_cam_angle, "num_cam_angle");
            this.num_cam_angle.Maximum = new decimal(new int[] {
            58,
            0,
            0,
            0});
            this.num_cam_angle.Minimum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.num_cam_angle.Name = "num_cam_angle";
            this.num_cam_angle.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // num_offset
            // 
            this.num_offset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.num_offset, "num_offset");
            this.num_offset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_offset.Name = "num_offset";
            this.num_offset.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // NUM_Distance
            // 
            resources.ApplyResources(this.NUM_Distance, "NUM_Distance");
            this.NUM_Distance.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUM_Distance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUM_Distance.Name = "NUM_Distance";
            this.NUM_Distance.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // loiter_r
            // 
            this.loiter_r.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.loiter_r, "loiter_r");
            this.loiter_r.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.loiter_r.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.loiter_r.Name = "loiter_r";
            this.loiter_r.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // NUM_spacing
            // 
            resources.ApplyResources(this.NUM_spacing, "NUM_spacing");
            this.NUM_spacing.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUM_spacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUM_spacing.Name = "NUM_spacing";
            this.NUM_spacing.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // loiter_turn
            // 
            resources.ApplyResources(this.loiter_turn, "loiter_turn");
            this.loiter_turn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loiter_turn.Name = "loiter_turn";
            this.loiter_turn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cam_dist
            // 
            resources.ApplyResources(this.cam_dist, "cam_dist");
            this.cam_dist.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.cam_dist.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.cam_dist.Name = "cam_dist";
            this.cam_dist.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimple);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // GridUI
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.map);
            this.Controls.Add(this.gb_set);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.NUM_UpDownFlySpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NUM_overshoot);
            this.Controls.Add(this.cam_dist);
            this.Controls.Add(this.NUM_altitude);
            this.Controls.Add(this.NUM_overshoot2);
            this.Name = "GridUI";
            this.Load += new System.EventHandler(this.GridUI_Load);
            this.Resize += new System.EventHandler(this.GridUI_Resize);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_overshoot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_altitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_UpDownFlySpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_overshoot)).EndInit();
            this.tabSimple.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_angle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gb_set.ResumeLayout(false);
            this.gb_set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cam_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_spacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loiter_turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam_dist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.myGMAP map;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_distbetweenlines;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_strips;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage tabSimple;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUM_overshoot2;
        private System.Windows.Forms.NumericUpDown NUM_angle;
        private System.Windows.Forms.NumericUpDown NUM_altitude;
        private System.Windows.Forms.Label label6;
        private Controls.MyButton BUT_Accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMB_startfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUM_Distance;
        private System.Windows.Forms.NumericUpDown NUM_overshoot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_grid;
        private System.Windows.Forms.CheckBox chk_markers;
        private System.Windows.Forms.CheckBox chk_boundary;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox CHK_internals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUM_spacing;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown NUM_UpDownFlySpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown loiter_r;
        private System.Windows.Forms.NumericUpDown loiter_turn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown cam_dist;
        private System.Windows.Forms.GroupBox gb_set;
        private System.Windows.Forms.CheckBox chk_set;
        private System.Windows.Forms.NumericUpDown num_alt;
        private System.Windows.Forms.Label lbl_homeres;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown num_offset;
        private System.Windows.Forms.NumericUpDown num_cam_angle;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
    }
}