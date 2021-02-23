using System;
using System.IO;

namespace MissionPlanner
{
    partial class MainV2
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
            Console.WriteLine("mainv2_Dispose");
            if (PluginThreadrunner != null)
                PluginThreadrunner.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV2));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.CTX_mainmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulition = new System.Windows.Forms.ToolStripMenuItem();
            this.config_tune = new System.Windows.Forms.ToolStripMenuItem();
            this.firmware_install = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_pos = new System.Windows.Forms.ToolStripMenuItem();
            this.down_log = new System.Windows.Forms.ToolStripMenuItem();
            this.review_log = new System.Windows.Forms.ToolStripMenuItem();
            this.close_cam = new System.Windows.Forms.ToolStripMenuItem();
            this.open_cam = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFlightData = new System.Windows.Forms.ToolStripButton();
            this.MenuFlightPlanner = new System.Windows.Forms.ToolStripButton();
            this.MenuConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripConnectionControl = new MissionPlanner.Controls.ToolStripConnectionControl();
            this.btn_rtk = new System.Windows.Forms.ToolStripButton();
            this.jump_to = new System.Windows.Forms.ToolStripButton();
            this.wp_no = new System.Windows.Forms.ToolStripComboBox();
            this.resume_flight = new System.Windows.Forms.ToolStripButton();
            this.lj_taobao = new System.Windows.Forms.ToolStripButton();
            this.return_flight = new System.Windows.Forms.ToolStripButton();
            this.auto_flight = new System.Windows.Forms.ToolStripButton();
            this.lock_unlock = new System.Windows.Forms.ToolStripButton();
            this.airspeed_0 = new System.Windows.Forms.ToolStripButton();
            this.shutter = new System.Windows.Forms.ToolStripButton();
            this.switch_yt = new System.Windows.Forms.ToolStripButton();
            this.menu = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status1 = new MissionPlanner.Controls.Status();
            this.MainMenu.SuspendLayout();
            this.CTX_mainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.ContextMenuStrip = this.CTX_mainmenu;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(45, 39);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFlightData,
            this.MenuFlightPlanner,
            this.MenuConnect,
            this.toolStripConnectionControl,
            this.btn_rtk,
            this.jump_to,
            this.wp_no,
            this.resume_flight,
            this.lj_taobao,
            this.return_flight,
            this.auto_flight,
            this.lock_unlock,
            this.airspeed_0,
            this.shutter,
            this.switch_yt});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // CTX_mainmenu
            // 
            this.CTX_mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoHideToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.readonlyToolStripMenuItem,
            this.connectionOptionsToolStripMenuItem,
            this.connectionListToolStripMenuItem,
            this.simulition,
            this.config_tune,
            this.firmware_install,
            this.toolStrip_pos,
            this.close_cam,
            this.open_cam});
            this.CTX_mainmenu.Name = "CTX_mainmenu";
            resources.ApplyResources(this.CTX_mainmenu, "CTX_mainmenu");
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.CheckOnClick = true;
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            resources.ApplyResources(this.autoHideToolStripMenuItem, "autoHideToolStripMenuItem");
            this.autoHideToolStripMenuItem.Click += new System.EventHandler(this.autoHideToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // readonlyToolStripMenuItem
            // 
            this.readonlyToolStripMenuItem.CheckOnClick = true;
            this.readonlyToolStripMenuItem.Name = "readonlyToolStripMenuItem";
            resources.ApplyResources(this.readonlyToolStripMenuItem, "readonlyToolStripMenuItem");
            this.readonlyToolStripMenuItem.Click += new System.EventHandler(this.readonlyToolStripMenuItem_Click);
            // 
            // connectionOptionsToolStripMenuItem
            // 
            this.connectionOptionsToolStripMenuItem.Name = "connectionOptionsToolStripMenuItem";
            resources.ApplyResources(this.connectionOptionsToolStripMenuItem, "connectionOptionsToolStripMenuItem");
            this.connectionOptionsToolStripMenuItem.Click += new System.EventHandler(this.connectionOptionsToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            resources.ApplyResources(this.connectionListToolStripMenuItem, "connectionListToolStripMenuItem");
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // simulition
            // 
            this.simulition.Name = "simulition";
            resources.ApplyResources(this.simulition, "simulition");
            this.simulition.Click += new System.EventHandler(this.simulition_Click);
            // 
            // config_tune
            // 
            this.config_tune.Name = "config_tune";
            resources.ApplyResources(this.config_tune, "config_tune");
            this.config_tune.Click += new System.EventHandler(this.config_tune_Click);
            // 
            // firmware_install
            // 
            this.firmware_install.Name = "firmware_install";
            resources.ApplyResources(this.firmware_install, "firmware_install");
            this.firmware_install.Click += new System.EventHandler(this.firmware_install_Click);
            // 
            // toolStrip_pos
            // 
            this.toolStrip_pos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.down_log,
            this.review_log});
            this.toolStrip_pos.Name = "toolStrip_pos";
            resources.ApplyResources(this.toolStrip_pos, "toolStrip_pos");
            // 
            // down_log
            // 
            this.down_log.Name = "down_log";
            resources.ApplyResources(this.down_log, "down_log");
            this.down_log.Click += new System.EventHandler(this.down_log_Click);
            // 
            // review_log
            // 
            this.review_log.Name = "review_log";
            resources.ApplyResources(this.review_log, "review_log");
            this.review_log.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // close_cam
            // 
            this.close_cam.Name = "close_cam";
            resources.ApplyResources(this.close_cam, "close_cam");
            this.close_cam.Click += new System.EventHandler(this.close_cam_Click);
            // 
            // open_cam
            // 
            this.open_cam.Name = "open_cam";
            resources.ApplyResources(this.open_cam, "open_cam");
            this.open_cam.Click += new System.EventHandler(this.open_cam_Click);
            // 
            // MenuFlightData
            // 
            this.MenuFlightData.BackColor = System.Drawing.Color.Transparent;
            this.MenuFlightData.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightData, "MenuFlightData");
            this.MenuFlightData.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.MenuFlightData.Name = "MenuFlightData";
            this.MenuFlightData.Click += new System.EventHandler(this.MenuFlightData_Click);
            // 
            // MenuFlightPlanner
            // 
            this.MenuFlightPlanner.BackColor = System.Drawing.Color.Transparent;
            this.MenuFlightPlanner.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightPlanner, "MenuFlightPlanner");
            this.MenuFlightPlanner.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.MenuFlightPlanner.Name = "MenuFlightPlanner";
            this.MenuFlightPlanner.Click += new System.EventHandler(this.MenuFlightPlanner_Click);
            // 
            // MenuConnect
            // 
            this.MenuConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuConnect.BackColor = System.Drawing.Color.Transparent;
            this.MenuConnect.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuConnect, "MenuConnect");
            this.MenuConnect.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConnect.Name = "MenuConnect";
            this.MenuConnect.Click += new System.EventHandler(this.MenuConnect_Click);
            // 
            // toolStripConnectionControl
            // 
            this.toolStripConnectionControl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripConnectionControl, "toolStripConnectionControl");
            this.toolStripConnectionControl.BackColor = System.Drawing.Color.Transparent;
            this.toolStripConnectionControl.ForeColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripConnectionControl.Name = "toolStripConnectionControl";
            this.toolStripConnectionControl.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // btn_rtk
            // 
            this.btn_rtk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_rtk.BackColor = System.Drawing.Color.Transparent;
            this.btn_rtk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_rtk.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.btn_rtk, "btn_rtk");
            this.btn_rtk.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_rtk.Name = "btn_rtk";
            this.btn_rtk.Click += new System.EventHandler(this.btn_rtk_Click);
            // 
            // jump_to
            // 
            this.jump_to.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.jump_to.BackColor = System.Drawing.Color.Transparent;
            this.jump_to.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.jump_to, "jump_to");
            this.jump_to.Margin = new System.Windows.Forms.Padding(0);
            this.jump_to.Name = "jump_to";
            this.jump_to.Click += new System.EventHandler(this.jump_to_Click);
            // 
            // wp_no
            // 
            this.wp_no.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wp_no.BackColor = System.Drawing.SystemColors.MenuBar;
            this.wp_no.Name = "wp_no";
            resources.ApplyResources(this.wp_no, "wp_no");
            this.wp_no.Click += new System.EventHandler(this.wp_no_Click);
            // 
            // resume_flight
            // 
            this.resume_flight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.resume_flight.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.resume_flight, "resume_flight");
            this.resume_flight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resume_flight.Image = global::MissionPlanner.Properties.Resources.light_resume;
            this.resume_flight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.resume_flight.Name = "resume_flight";
            this.resume_flight.Click += new System.EventHandler(this.resume_flight_Click);
            // 
            // lj_taobao
            // 
            this.lj_taobao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.lj_taobao, "lj_taobao");
            this.lj_taobao.BackColor = System.Drawing.Color.Transparent;
            this.lj_taobao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lj_taobao.ForeColor = System.Drawing.Color.White;
            this.lj_taobao.Image = global::MissionPlanner.Properties.Resources.light_logo;
            this.lj_taobao.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lj_taobao.Name = "lj_taobao";
            this.lj_taobao.Click += new System.EventHandler(this.lj_taobao_Click);
            // 
            // return_flight
            // 
            this.return_flight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.return_flight.BackColor = System.Drawing.Color.Transparent;
            this.return_flight.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.return_flight, "return_flight");
            this.return_flight.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.return_flight.Name = "return_flight";
            this.return_flight.Click += new System.EventHandler(this.return_flight_Click);
            // 
            // auto_flight
            // 
            this.auto_flight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.auto_flight.BackColor = System.Drawing.Color.Transparent;
            this.auto_flight.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.auto_flight, "auto_flight");
            this.auto_flight.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.auto_flight.Name = "auto_flight";
            this.auto_flight.Click += new System.EventHandler(this.auto_flight_Click);
            // 
            // lock_unlock
            // 
            this.lock_unlock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lock_unlock.BackColor = System.Drawing.Color.Transparent;
            this.lock_unlock.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.lock_unlock, "lock_unlock");
            this.lock_unlock.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lock_unlock.Name = "lock_unlock";
            this.lock_unlock.Click += new System.EventHandler(this.lock_unlock_Click);
            // 
            // airspeed_0
            // 
            this.airspeed_0.BackColor = System.Drawing.Color.Transparent;
            this.airspeed_0.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.airspeed_0, "airspeed_0");
            this.airspeed_0.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.airspeed_0.Name = "airspeed_0";
            this.airspeed_0.Click += new System.EventHandler(this.airspeed_0_Click);
            // 
            // shutter
            // 
            this.shutter.BackColor = System.Drawing.Color.Transparent;
            this.shutter.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.shutter, "shutter");
            this.shutter.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.shutter.Name = "shutter";
            this.shutter.Click += new System.EventHandler(this.shutter_Click);
            // 
            // switch_yt
            // 
            this.switch_yt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.switch_yt.BackColor = System.Drawing.Color.Transparent;
            this.switch_yt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.switch_yt.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.switch_yt, "switch_yt");
            this.switch_yt.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.switch_yt.Name = "switch_yt";
            this.switch_yt.Click += new System.EventHandler(this.switch_yt_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.status1);
            this.panel1.Controls.Add(this.MainMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // status1
            // 
            resources.ApplyResources(this.status1, "status1");
            this.status1.Name = "status1";
            this.status1.Percent = 0D;
            // 
            // MainV2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainV2";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainV2_KeyDown);
            this.Resize += new System.EventHandler(this.MainV2_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.CTX_mainmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStripButton MenuFlightData;
        public System.Windows.Forms.ToolStripButton MenuFlightPlanner;
        //public System.Windows.Forms.ToolStripButton MenuInitConfig;
        //public System.Windows.Forms.ToolStripButton MenuSimulation;
        //public System.Windows.Forms.ToolStripButton MenuConfigTune;
        public System.Windows.Forms.ToolStripButton MenuConnect;
        private Controls.ToolStripConnectionControl toolStripConnectionControl;
        private Controls.MyButton menu;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip CTX_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
        //public System.Windows.Forms.ToolStripButton MenuHelp;
        //public System.Windows.Forms.ToolStripButton MenuArduPilot;
        public Controls.Status status1;
        public System.Windows.Forms.ToolStripButton btn_rtk;
        public System.Windows.Forms.ToolStripButton lock_unlock;
        public System.Windows.Forms.ToolStripButton auto_flight;
        public System.Windows.Forms.ToolStripButton return_flight;
        public System.Windows.Forms.ToolStripButton jump_to;
        private System.Windows.Forms.ToolStripComboBox wp_no;
        private System.Windows.Forms.ToolStripMenuItem simulition;
        private System.Windows.Forms.ToolStripMenuItem config_tune;
        private System.Windows.Forms.ToolStripMenuItem firmware_install;
        public System.Windows.Forms.ToolStripButton resume_flight;
        public System.Windows.Forms.ToolStripButton lj_taobao;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_pos;
        private System.Windows.Forms.ToolStripMenuItem down_log;
        private System.Windows.Forms.ToolStripMenuItem review_log;
        public System.Windows.Forms.ToolStripButton airspeed_0;
        public System.Windows.Forms.ToolStripButton shutter;
        private System.Windows.Forms.ToolStripMenuItem close_cam;
        public System.Windows.Forms.ToolStripButton switch_yt;
        private System.Windows.Forms.ToolStripMenuItem open_cam;
    }
}