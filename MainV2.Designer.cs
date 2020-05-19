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
            this.MenuFlightData = new System.Windows.Forms.ToolStripButton();
            this.MenuFlightPlanner = new System.Windows.Forms.ToolStripButton();
            this.MenuConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripConnectionControl = new MissionPlanner.Controls.ToolStripConnectionControl();
            this.preflight_check = new System.Windows.Forms.ToolStripButton();
            this.lock_unlock = new System.Windows.Forms.ToolStripButton();
            this.auto_flight = new System.Windows.Forms.ToolStripButton();
            this.return_flight = new System.Windows.Forms.ToolStripButton();
            this.jump_to = new System.Windows.Forms.ToolStripButton();
            this.wp_no = new System.Windows.Forms.ToolStripComboBox();
            this.menu = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status1 = new MissionPlanner.Controls.Status();
            this.resume_flight = new System.Windows.Forms.ToolStripButton();
            this.MainMenu.SuspendLayout();
            this.CTX_mainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.ContextMenuStrip = this.CTX_mainmenu;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(45, 39);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFlightData,
            this.MenuFlightPlanner,
            this.MenuConnect,
            this.toolStripConnectionControl,
            this.preflight_check,
            this.lock_unlock,
            this.auto_flight,
            this.return_flight,
            this.jump_to,
            this.wp_no,
            this.resume_flight});
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
            this.firmware_install});
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
            // MenuFlightData
            // 
            this.MenuFlightData.BackColor = System.Drawing.Color.Transparent;
            this.MenuFlightData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuFlightData.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightData, "MenuFlightData");
            this.MenuFlightData.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightData.Name = "MenuFlightData";
            this.MenuFlightData.Click += new System.EventHandler(this.MenuFlightData_Click);
            // 
            // MenuFlightPlanner
            // 
            this.MenuFlightPlanner.BackColor = System.Drawing.Color.Transparent;
            this.MenuFlightPlanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuFlightPlanner.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightPlanner, "MenuFlightPlanner");
            this.MenuFlightPlanner.Margin = new System.Windows.Forms.Padding(0);
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
            this.toolStripConnectionControl.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.toolStripConnectionControl, "toolStripConnectionControl");
            this.toolStripConnectionControl.ForeColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripConnectionControl.Name = "toolStripConnectionControl";
            this.toolStripConnectionControl.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // preflight_check
            // 
            this.preflight_check.BackColor = System.Drawing.Color.Transparent;
            this.preflight_check.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.preflight_check.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.preflight_check, "preflight_check");
            this.preflight_check.Margin = new System.Windows.Forms.Padding(0);
            this.preflight_check.Name = "preflight_check";
            // 
            // lock_unlock
            // 
            this.lock_unlock.BackColor = System.Drawing.Color.Transparent;
            this.lock_unlock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lock_unlock.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.lock_unlock, "lock_unlock");
            this.lock_unlock.Margin = new System.Windows.Forms.Padding(0);
            this.lock_unlock.Name = "lock_unlock";
            this.lock_unlock.Click += new System.EventHandler(this.lock_unlock_Click);
            // 
            // auto_flight
            // 
            this.auto_flight.BackColor = System.Drawing.Color.Transparent;
            this.auto_flight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.auto_flight.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.auto_flight, "auto_flight");
            this.auto_flight.Margin = new System.Windows.Forms.Padding(0);
            this.auto_flight.Name = "auto_flight";
            this.auto_flight.Click += new System.EventHandler(this.auto_flight_Click);
            // 
            // return_flight
            // 
            this.return_flight.BackColor = System.Drawing.Color.Transparent;
            this.return_flight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.return_flight.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.return_flight, "return_flight");
            this.return_flight.Margin = new System.Windows.Forms.Padding(0);
            this.return_flight.Name = "return_flight";
            this.return_flight.Click += new System.EventHandler(this.return_flight_Click);
            // 
            // jump_to
            // 
            this.jump_to.BackColor = System.Drawing.Color.Transparent;
            this.jump_to.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jump_to.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.jump_to, "jump_to");
            this.jump_to.Margin = new System.Windows.Forms.Padding(0);
            this.jump_to.Name = "jump_to";
            this.jump_to.Click += new System.EventHandler(this.jump_to_Click);
            // 
            // wp_no
            // 
            this.wp_no.BackColor = System.Drawing.SystemColors.MenuBar;
            this.wp_no.Name = "wp_no";
            resources.ApplyResources(this.wp_no, "wp_no");
            this.wp_no.Click += new System.EventHandler(this.wp_no_Click);
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
            // resume_flight
            // 
            this.resume_flight.BackColor = System.Drawing.Color.Transparent;
            this.resume_flight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resume_flight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resume_flight.Image = global::MissionPlanner.Properties.Resources.dark_resume;
            resources.ApplyResources(this.resume_flight, "resume_flight");
            this.resume_flight.Margin = new System.Windows.Forms.Padding(0);
            this.resume_flight.Name = "resume_flight";
            this.resume_flight.Click += new System.EventHandler(this.resume_flight_Click);
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
            this.panel1.PerformLayout();
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
        public System.Windows.Forms.ToolStripButton preflight_check;
        public System.Windows.Forms.ToolStripButton lock_unlock;
        public System.Windows.Forms.ToolStripButton auto_flight;
        public System.Windows.Forms.ToolStripButton return_flight;
        public System.Windows.Forms.ToolStripButton jump_to;
        private System.Windows.Forms.ToolStripComboBox wp_no;
        private System.Windows.Forms.ToolStripMenuItem simulition;
        private System.Windows.Forms.ToolStripMenuItem config_tune;
        private System.Windows.Forms.ToolStripMenuItem firmware_install;
        public System.Windows.Forms.ToolStripButton resume_flight;
    }
}