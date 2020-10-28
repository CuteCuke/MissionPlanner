namespace MissionPlanner.Log
{
    partial class Coordinateconvert
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
            this.dataGridView1 = new MissionPlanner.Controls.MyDataGridView();
            this.bt_loadlog = new MissionPlanner.Controls.MyButton();
            this.bt_downpos = new MissionPlanner.Controls.MyButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_cgcs2000 = new System.Windows.Forms.CheckBox();
            this.chk_cg80 = new System.Windows.Forms.CheckBox();
            this.chk_wgs84 = new System.Windows.Forms.CheckBox();
            this.chk_bj54 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chk_userdefined = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(300, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // bt_loadlog
            // 
            this.bt_loadlog.Location = new System.Drawing.Point(12, 12);
            this.bt_loadlog.Name = "bt_loadlog";
            this.bt_loadlog.Size = new System.Drawing.Size(75, 23);
            this.bt_loadlog.TabIndex = 2;
            this.bt_loadlog.Text = "加载日志";
            this.bt_loadlog.UseVisualStyleBackColor = true;
            this.bt_loadlog.Click += new System.EventHandler(this.bt_loadlog_Click);
            // 
            // bt_downpos
            // 
            this.bt_downpos.Location = new System.Drawing.Point(12, 41);
            this.bt_downpos.Name = "bt_downpos";
            this.bt_downpos.Size = new System.Drawing.Size(75, 23);
            this.bt_downpos.TabIndex = 3;
            this.bt_downpos.Text = "导出POS";
            this.bt_downpos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_userdefined);
            this.groupBox1.Controls.Add(this.chk_bj54);
            this.groupBox1.Controls.Add(this.chk_wgs84);
            this.groupBox1.Controls.Add(this.chk_cg80);
            this.groupBox1.Controls.Add(this.chk_cgcs2000);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "坐标系";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 262);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // chk_cgcs2000
            // 
            this.chk_cgcs2000.AutoSize = true;
            this.chk_cgcs2000.Checked = true;
            this.chk_cgcs2000.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cgcs2000.Location = new System.Drawing.Point(16, 30);
            this.chk_cgcs2000.Name = "chk_cgcs2000";
            this.chk_cgcs2000.Size = new System.Drawing.Size(72, 16);
            this.chk_cgcs2000.TabIndex = 0;
            this.chk_cgcs2000.Text = "CGCS2000";
            this.chk_cgcs2000.UseVisualStyleBackColor = true;
            // 
            // chk_cg80
            // 
            this.chk_cg80.AutoSize = true;
            this.chk_cg80.Location = new System.Drawing.Point(104, 30);
            this.chk_cg80.Name = "chk_cg80";
            this.chk_cg80.Size = new System.Drawing.Size(60, 16);
            this.chk_cg80.TabIndex = 1;
            this.chk_cg80.Text = "全国80";
            this.chk_cg80.UseVisualStyleBackColor = true;
            // 
            // chk_wgs84
            // 
            this.chk_wgs84.AutoSize = true;
            this.chk_wgs84.Location = new System.Drawing.Point(16, 62);
            this.chk_wgs84.Name = "chk_wgs84";
            this.chk_wgs84.Size = new System.Drawing.Size(54, 16);
            this.chk_wgs84.TabIndex = 2;
            this.chk_wgs84.Text = "WGS84";
            this.chk_wgs84.UseVisualStyleBackColor = true;
            // 
            // chk_bj54
            // 
            this.chk_bj54.AutoSize = true;
            this.chk_bj54.Location = new System.Drawing.Point(104, 62);
            this.chk_bj54.Name = "chk_bj54";
            this.chk_bj54.Size = new System.Drawing.Size(60, 16);
            this.chk_bj54.TabIndex = 3;
            this.chk_bj54.Text = "北京54";
            this.chk_bj54.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 21);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(62, 21);
            this.textBox4.TabIndex = 3;
            // 
            // chk_userdefined
            // 
            this.chk_userdefined.AutoSize = true;
            this.chk_userdefined.Location = new System.Drawing.Point(182, 47);
            this.chk_userdefined.Name = "chk_userdefined";
            this.chk_userdefined.Size = new System.Drawing.Size(60, 16);
            this.chk_userdefined.TabIndex = 4;
            this.chk_userdefined.Text = "自定义";
            this.chk_userdefined.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(182, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(62, 21);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(182, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(62, 21);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(182, 74);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(62, 21);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(182, 101);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(62, 21);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(62, 128);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(62, 21);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(182, 128);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(62, 21);
            this.textBox10.TabIndex = 9;
            // 
            // Coordinateconvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_downpos);
            this.Controls.Add(this.bt_loadlog);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Coordinateconvert";
            this.Text = "Coordinateconvert";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyDataGridView dataGridView1;
        private Controls.MyButton bt_loadlog;
        private Controls.MyButton bt_downpos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_userdefined;
        private System.Windows.Forms.CheckBox chk_bj54;
        private System.Windows.Forms.CheckBox chk_wgs84;
        private System.Windows.Forms.CheckBox chk_cg80;
        private System.Windows.Forms.CheckBox chk_cgcs2000;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
    }
}