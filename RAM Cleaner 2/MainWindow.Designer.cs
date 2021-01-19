
using System.Drawing;
using System.Windows.Forms;

namespace RAM_Cleaner_Pro
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.grp_cleanOptions = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.num_smart = new System.Windows.Forms.NumericUpDown();
            this.rb_smart = new System.Windows.Forms.RadioButton();
            this.lbl_estimatedDeep = new System.Windows.Forms.Label();
            this.lbl_estimatedNormal = new System.Windows.Forms.Label();
            this.lbl_estimatedFast = new System.Windows.Forms.Label();
            this.rb_deep = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_fast = new System.Windows.Forms.RadioButton();
            this.btn_startClean = new System.Windows.Forms.Button();
            this.grp_ramStats = new System.Windows.Forms.GroupBox();
            this.tbl_ramStat = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_12 = new System.Windows.Forms.Label();
            this.tbl_02 = new System.Windows.Forms.Label();
            this.tbl_22 = new System.Windows.Forms.Label();
            this.tbl_11 = new System.Windows.Forms.Label();
            this.tbl_01 = new System.Windows.Forms.Label();
            this.tbl_21 = new System.Windows.Forms.Label();
            this.tbl_00 = new System.Windows.Forms.Label();
            this.tbl_10 = new System.Windows.Forms.Label();
            this.tbl_20 = new System.Windows.Forms.Label();
            this.prg_ramUsage = new System.Windows.Forms.ProgressBar();
            this.prg_progressbar = new System.Windows.Forms.ProgressBar();
            this.grp_cleanStats = new System.Windows.Forms.GroupBox();
            this.lbl_cleanedRam_data = new System.Windows.Forms.Label();
            this.lbl_ramAfter_data = new System.Windows.Forms.Label();
            this.lbl_ramBefore_data = new System.Windows.Forms.Label();
            this.lbl_cleanedRam = new System.Windows.Forms.Label();
            this.lbl_ramAfter = new System.Windows.Forms.Label();
            this.lbl_ramBefore = new System.Windows.Forms.Label();
            this.lbl_startDate_data = new System.Windows.Forms.Label();
            this.lbl_elapsedTime_data = new System.Windows.Forms.Label();
            this.lbl_finishDate_data = new System.Windows.Forms.Label();
            this.lbl_finishDate = new System.Windows.Forms.Label();
            this.lbl_elapsedTime = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.grp_intelligentClean = new System.Windows.Forms.GroupBox();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.lbl_smart = new System.Windows.Forms.Label();
            this.lbl_smartPercent = new System.Windows.Forms.Label();
            this.grp_cleanOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_smart)).BeginInit();
            this.grp_ramStats.SuspendLayout();
            this.tbl_ramStat.SuspendLayout();
            this.grp_cleanStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_cleanOptions
            // 
            this.grp_cleanOptions.Controls.Add(this.lbl_smartPercent);
            this.grp_cleanOptions.Controls.Add(this.linkLabel1);
            this.grp_cleanOptions.Controls.Add(this.num_smart);
            this.grp_cleanOptions.Controls.Add(this.rb_smart);
            this.grp_cleanOptions.Controls.Add(this.lbl_estimatedDeep);
            this.grp_cleanOptions.Controls.Add(this.lbl_estimatedNormal);
            this.grp_cleanOptions.Controls.Add(this.lbl_estimatedFast);
            this.grp_cleanOptions.Controls.Add(this.rb_deep);
            this.grp_cleanOptions.Controls.Add(this.rb_normal);
            this.grp_cleanOptions.Controls.Add(this.rb_fast);
            this.grp_cleanOptions.Controls.Add(this.btn_startClean);
            this.grp_cleanOptions.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grp_cleanOptions.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grp_cleanOptions.Location = new System.Drawing.Point(35, 30);
            this.grp_cleanOptions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_cleanOptions.Name = "grp_cleanOptions";
            this.grp_cleanOptions.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_cleanOptions.Size = new System.Drawing.Size(245, 231);
            this.grp_cleanOptions.TabIndex = 0;
            this.grp_cleanOptions.TabStop = false;
            this.grp_cleanOptions.Text = "Cleaning Options";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(96, 142);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(16, 19);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // num_smart
            // 
            this.num_smart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.num_smart.Font = new System.Drawing.Font("Calibri", 12F);
            this.num_smart.Location = new System.Drawing.Point(138, 140);
            this.num_smart.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_smart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_smart.Name = "num_smart";
            this.num_smart.Size = new System.Drawing.Size(53, 27);
            this.num_smart.TabIndex = 8;
            this.num_smart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rb_smart
            // 
            this.rb_smart.AutoSize = true;
            this.rb_smart.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.rb_smart.Location = new System.Drawing.Point(35, 140);
            this.rb_smart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_smart.Name = "rb_smart";
            this.rb_smart.Size = new System.Drawing.Size(68, 23);
            this.rb_smart.TabIndex = 7;
            this.rb_smart.Text = "Smart";
            this.rb_smart.UseVisualStyleBackColor = true;
            // 
            // lbl_estimatedDeep
            // 
            this.lbl_estimatedDeep.AutoSize = true;
            this.lbl_estimatedDeep.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_estimatedDeep.Location = new System.Drawing.Point(134, 106);
            this.lbl_estimatedDeep.Name = "lbl_estimatedDeep";
            this.lbl_estimatedDeep.Size = new System.Drawing.Size(19, 19);
            this.lbl_estimatedDeep.TabIndex = 6;
            this.lbl_estimatedDeep.Text = "()";
            // 
            // lbl_estimatedNormal
            // 
            this.lbl_estimatedNormal.AutoSize = true;
            this.lbl_estimatedNormal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_estimatedNormal.Location = new System.Drawing.Point(134, 69);
            this.lbl_estimatedNormal.Name = "lbl_estimatedNormal";
            this.lbl_estimatedNormal.Size = new System.Drawing.Size(19, 19);
            this.lbl_estimatedNormal.TabIndex = 5;
            this.lbl_estimatedNormal.Text = "()";
            // 
            // lbl_estimatedFast
            // 
            this.lbl_estimatedFast.AutoSize = true;
            this.lbl_estimatedFast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_estimatedFast.Location = new System.Drawing.Point(134, 36);
            this.lbl_estimatedFast.Name = "lbl_estimatedFast";
            this.lbl_estimatedFast.Size = new System.Drawing.Size(19, 19);
            this.lbl_estimatedFast.TabIndex = 4;
            this.lbl_estimatedFast.Text = "()";
            // 
            // rb_deep
            // 
            this.rb_deep.AutoSize = true;
            this.rb_deep.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.rb_deep.Location = new System.Drawing.Point(35, 105);
            this.rb_deep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_deep.Name = "rb_deep";
            this.rb_deep.Size = new System.Drawing.Size(63, 23);
            this.rb_deep.TabIndex = 3;
            this.rb_deep.Text = "Deep";
            this.rb_deep.UseVisualStyleBackColor = true;
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.rb_normal.Location = new System.Drawing.Point(35, 70);
            this.rb_normal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(77, 23);
            this.rb_normal.TabIndex = 2;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            // 
            // rb_fast
            // 
            this.rb_fast.AutoSize = true;
            this.rb_fast.Checked = true;
            this.rb_fast.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.rb_fast.Location = new System.Drawing.Point(35, 35);
            this.rb_fast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_fast.Name = "rb_fast";
            this.rb_fast.Size = new System.Drawing.Size(55, 23);
            this.rb_fast.TabIndex = 1;
            this.rb_fast.TabStop = true;
            this.rb_fast.Text = "Fast";
            this.rb_fast.UseVisualStyleBackColor = true;
            // 
            // btn_startClean
            // 
            this.btn_startClean.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_startClean.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_startClean.Location = new System.Drawing.Point(35, 174);
            this.btn_startClean.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_startClean.Name = "btn_startClean";
            this.btn_startClean.Size = new System.Drawing.Size(175, 34);
            this.btn_startClean.TabIndex = 0;
            this.btn_startClean.Text = "Start";
            this.btn_startClean.UseVisualStyleBackColor = false;
            this.btn_startClean.Click += new System.EventHandler(this.btn_startClean_Click);
            // 
            // grp_ramStats
            // 
            this.grp_ramStats.Controls.Add(this.tbl_ramStat);
            this.grp_ramStats.Controls.Add(this.prg_ramUsage);
            this.grp_ramStats.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grp_ramStats.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grp_ramStats.Location = new System.Drawing.Point(315, 30);
            this.grp_ramStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_ramStats.Name = "grp_ramStats";
            this.grp_ramStats.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_ramStats.Size = new System.Drawing.Size(350, 231);
            this.grp_ramStats.TabIndex = 1;
            this.grp_ramStats.TabStop = false;
            this.grp_ramStats.Text = "RAM statistics";
            // 
            // tbl_ramStat
            // 
            this.tbl_ramStat.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_ramStat.ColumnCount = 3;
            this.tbl_ramStat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_ramStat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_ramStat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_ramStat.Controls.Add(this.tbl_12, 0, 2);
            this.tbl_ramStat.Controls.Add(this.tbl_02, 0, 2);
            this.tbl_ramStat.Controls.Add(this.tbl_22, 2, 2);
            this.tbl_ramStat.Controls.Add(this.tbl_11, 1, 1);
            this.tbl_ramStat.Controls.Add(this.tbl_01, 0, 1);
            this.tbl_ramStat.Controls.Add(this.tbl_21, 2, 1);
            this.tbl_ramStat.Controls.Add(this.tbl_00, 0, 0);
            this.tbl_ramStat.Controls.Add(this.tbl_10, 1, 0);
            this.tbl_ramStat.Controls.Add(this.tbl_20, 2, 0);
            this.tbl_ramStat.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbl_ramStat.Location = new System.Drawing.Point(12, 27);
            this.tbl_ramStat.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_ramStat.Name = "tbl_ramStat";
            this.tbl_ramStat.RowCount = 3;
            this.tbl_ramStat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_ramStat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_ramStat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_ramStat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_ramStat.Size = new System.Drawing.Size(327, 141);
            this.tbl_ramStat.TabIndex = 1;
            this.tbl_ramStat.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_ramStat_Paint);
            // 
            // tbl_12
            // 
            this.tbl_12.AutoSize = true;
            this.tbl_12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_12.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbl_12.Location = new System.Drawing.Point(112, 93);
            this.tbl_12.Name = "tbl_12";
            this.tbl_12.Size = new System.Drawing.Size(101, 47);
            this.tbl_12.TabIndex = 8;
            this.tbl_12.Text = "Used %";
            this.tbl_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbl_12.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_ramStat_Paint);
            // 
            // tbl_02
            // 
            this.tbl_02.AutoSize = true;
            this.tbl_02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_02.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbl_02.Location = new System.Drawing.Point(4, 93);
            this.tbl_02.Name = "tbl_02";
            this.tbl_02.Size = new System.Drawing.Size(101, 47);
            this.tbl_02.TabIndex = 7;
            this.tbl_02.Text = "Free %";
            this.tbl_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbl_02.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_ramStat_Paint);
            // 
            // tbl_22
            // 
            this.tbl_22.AutoSize = true;
            this.tbl_22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_22.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbl_22.Location = new System.Drawing.Point(220, 93);
            this.tbl_22.Name = "tbl_22";
            this.tbl_22.Size = new System.Drawing.Size(103, 47);
            this.tbl_22.TabIndex = 6;
            this.tbl_22.Text = "100 %";
            this.tbl_22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_11
            // 
            this.tbl_11.AutoSize = true;
            this.tbl_11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_11.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbl_11.Location = new System.Drawing.Point(112, 47);
            this.tbl_11.Name = "tbl_11";
            this.tbl_11.Size = new System.Drawing.Size(101, 45);
            this.tbl_11.TabIndex = 3;
            this.tbl_11.Text = "Used MB";
            this.tbl_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbl_11.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_ramStat_Paint);
            // 
            // tbl_01
            // 
            this.tbl_01.AutoSize = true;
            this.tbl_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_01.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbl_01.Location = new System.Drawing.Point(4, 47);
            this.tbl_01.Name = "tbl_01";
            this.tbl_01.Size = new System.Drawing.Size(101, 45);
            this.tbl_01.TabIndex = 4;
            this.tbl_01.Text = "free MB";
            this.tbl_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbl_01.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_ramStat_Paint);
            // 
            // tbl_21
            // 
            this.tbl_21.AutoSize = true;
            this.tbl_21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_21.Font = new System.Drawing.Font("Calibri", 14F);
            this.tbl_21.Location = new System.Drawing.Point(220, 47);
            this.tbl_21.Name = "tbl_21";
            this.tbl_21.Size = new System.Drawing.Size(103, 45);
            this.tbl_21.TabIndex = 5;
            this.tbl_21.Text = "Total MB";
            this.tbl_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_00
            // 
            this.tbl_00.AutoSize = true;
            this.tbl_00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbl_00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_00.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.tbl_00.Location = new System.Drawing.Point(4, 1);
            this.tbl_00.Name = "tbl_00";
            this.tbl_00.Size = new System.Drawing.Size(101, 45);
            this.tbl_00.TabIndex = 0;
            this.tbl_00.Text = "Free";
            this.tbl_00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_10
            // 
            this.tbl_10.AutoSize = true;
            this.tbl_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbl_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.tbl_10.Location = new System.Drawing.Point(112, 1);
            this.tbl_10.Name = "tbl_10";
            this.tbl_10.Size = new System.Drawing.Size(101, 45);
            this.tbl_10.TabIndex = 1;
            this.tbl_10.Text = "Used";
            this.tbl_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_20
            // 
            this.tbl_20.AutoSize = true;
            this.tbl_20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbl_20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_20.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.tbl_20.Location = new System.Drawing.Point(220, 1);
            this.tbl_20.Name = "tbl_20";
            this.tbl_20.Size = new System.Drawing.Size(103, 45);
            this.tbl_20.TabIndex = 2;
            this.tbl_20.Text = "Total";
            this.tbl_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prg_ramUsage
            // 
            this.prg_ramUsage.Location = new System.Drawing.Point(12, 174);
            this.prg_ramUsage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prg_ramUsage.Name = "prg_ramUsage";
            this.prg_ramUsage.Size = new System.Drawing.Size(327, 34);
            this.prg_ramUsage.Step = 1;
            this.prg_ramUsage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prg_ramUsage.TabIndex = 0;
            // 
            // prg_progressbar
            // 
            this.prg_progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prg_progressbar.ForeColor = System.Drawing.Color.LawnGreen;
            this.prg_progressbar.Location = new System.Drawing.Point(35, 284);
            this.prg_progressbar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prg_progressbar.Name = "prg_progressbar";
            this.prg_progressbar.Size = new System.Drawing.Size(630, 34);
            this.prg_progressbar.Step = 1;
            this.prg_progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prg_progressbar.TabIndex = 2;
            // 
            // grp_cleanStats
            // 
            this.grp_cleanStats.Controls.Add(this.lbl_cleanedRam_data);
            this.grp_cleanStats.Controls.Add(this.lbl_ramAfter_data);
            this.grp_cleanStats.Controls.Add(this.lbl_ramBefore_data);
            this.grp_cleanStats.Controls.Add(this.lbl_cleanedRam);
            this.grp_cleanStats.Controls.Add(this.lbl_ramAfter);
            this.grp_cleanStats.Controls.Add(this.lbl_ramBefore);
            this.grp_cleanStats.Controls.Add(this.lbl_startDate_data);
            this.grp_cleanStats.Controls.Add(this.lbl_elapsedTime_data);
            this.grp_cleanStats.Controls.Add(this.lbl_finishDate_data);
            this.grp_cleanStats.Controls.Add(this.lbl_finishDate);
            this.grp_cleanStats.Controls.Add(this.lbl_elapsedTime);
            this.grp_cleanStats.Controls.Add(this.lbl_startDate);
            this.grp_cleanStats.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grp_cleanStats.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grp_cleanStats.Location = new System.Drawing.Point(35, 349);
            this.grp_cleanStats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_cleanStats.Name = "grp_cleanStats";
            this.grp_cleanStats.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_cleanStats.Size = new System.Drawing.Size(630, 110);
            this.grp_cleanStats.TabIndex = 3;
            this.grp_cleanStats.TabStop = false;
            this.grp_cleanStats.Text = "Clean statistics";
            // 
            // lbl_cleanedRam_data
            // 
            this.lbl_cleanedRam_data.AutoSize = true;
            this.lbl_cleanedRam_data.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_cleanedRam_data.Location = new System.Drawing.Point(511, 73);
            this.lbl_cleanedRam_data.Name = "lbl_cleanedRam_data";
            this.lbl_cleanedRam_data.Size = new System.Drawing.Size(0, 19);
            this.lbl_cleanedRam_data.TabIndex = 11;
            // 
            // lbl_ramAfter_data
            // 
            this.lbl_ramAfter_data.AutoSize = true;
            this.lbl_ramAfter_data.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_ramAfter_data.Location = new System.Drawing.Point(511, 50);
            this.lbl_ramAfter_data.Name = "lbl_ramAfter_data";
            this.lbl_ramAfter_data.Size = new System.Drawing.Size(0, 19);
            this.lbl_ramAfter_data.TabIndex = 10;
            // 
            // lbl_ramBefore_data
            // 
            this.lbl_ramBefore_data.AutoSize = true;
            this.lbl_ramBefore_data.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_ramBefore_data.Location = new System.Drawing.Point(511, 27);
            this.lbl_ramBefore_data.Name = "lbl_ramBefore_data";
            this.lbl_ramBefore_data.Size = new System.Drawing.Size(0, 19);
            this.lbl_ramBefore_data.TabIndex = 9;
            // 
            // lbl_cleanedRam
            // 
            this.lbl_cleanedRam.AutoSize = true;
            this.lbl_cleanedRam.Location = new System.Drawing.Point(325, 73);
            this.lbl_cleanedRam.Name = "lbl_cleanedRam";
            this.lbl_cleanedRam.Size = new System.Drawing.Size(102, 19);
            this.lbl_cleanedRam.TabIndex = 8;
            this.lbl_cleanedRam.Text = "Cleaned RAM:";
            // 
            // lbl_ramAfter
            // 
            this.lbl_ramAfter.AutoSize = true;
            this.lbl_ramAfter.Location = new System.Drawing.Point(325, 50);
            this.lbl_ramAfter.Name = "lbl_ramAfter";
            this.lbl_ramAfter.Size = new System.Drawing.Size(160, 19);
            this.lbl_ramAfter.TabIndex = 7;
            this.lbl_ramAfter.Text = "RAM usage after clean:";
            // 
            // lbl_ramBefore
            // 
            this.lbl_ramBefore.AutoSize = true;
            this.lbl_ramBefore.Location = new System.Drawing.Point(325, 27);
            this.lbl_ramBefore.Name = "lbl_ramBefore";
            this.lbl_ramBefore.Size = new System.Drawing.Size(180, 19);
            this.lbl_ramBefore.TabIndex = 6;
            this.lbl_ramBefore.Text = "RAM useage before clean:";
            // 
            // lbl_startDate_data
            // 
            this.lbl_startDate_data.AutoSize = true;
            this.lbl_startDate_data.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_startDate_data.Location = new System.Drawing.Point(134, 27);
            this.lbl_startDate_data.Name = "lbl_startDate_data";
            this.lbl_startDate_data.Size = new System.Drawing.Size(0, 19);
            this.lbl_startDate_data.TabIndex = 5;
            // 
            // lbl_elapsedTime_data
            // 
            this.lbl_elapsedTime_data.AutoSize = true;
            this.lbl_elapsedTime_data.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_elapsedTime_data.Location = new System.Drawing.Point(134, 50);
            this.lbl_elapsedTime_data.Name = "lbl_elapsedTime_data";
            this.lbl_elapsedTime_data.Size = new System.Drawing.Size(0, 19);
            this.lbl_elapsedTime_data.TabIndex = 4;
            // 
            // lbl_finishDate_data
            // 
            this.lbl_finishDate_data.AutoSize = true;
            this.lbl_finishDate_data.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_finishDate_data.Location = new System.Drawing.Point(133, 73);
            this.lbl_finishDate_data.Name = "lbl_finishDate_data";
            this.lbl_finishDate_data.Size = new System.Drawing.Size(0, 19);
            this.lbl_finishDate_data.TabIndex = 3;
            // 
            // lbl_finishDate
            // 
            this.lbl_finishDate.AutoSize = true;
            this.lbl_finishDate.Location = new System.Drawing.Point(16, 73);
            this.lbl_finishDate.Name = "lbl_finishDate";
            this.lbl_finishDate.Size = new System.Drawing.Size(106, 19);
            this.lbl_finishDate.TabIndex = 2;
            this.lbl_finishDate.Text = "Clean finished:";
            // 
            // lbl_elapsedTime
            // 
            this.lbl_elapsedTime.AutoSize = true;
            this.lbl_elapsedTime.Location = new System.Drawing.Point(17, 50);
            this.lbl_elapsedTime.Name = "lbl_elapsedTime";
            this.lbl_elapsedTime.Size = new System.Drawing.Size(100, 19);
            this.lbl_elapsedTime.TabIndex = 1;
            this.lbl_elapsedTime.Text = "Elapsed time:";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(17, 27);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(101, 19);
            this.lbl_startDate.TabIndex = 0;
            this.lbl_startDate.Text = "Clean started:";
            // 
            // grp_intelligentClean
            // 
            this.grp_intelligentClean.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grp_intelligentClean.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grp_intelligentClean.Location = new System.Drawing.Point(35, 485);
            this.grp_intelligentClean.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_intelligentClean.Name = "grp_intelligentClean";
            this.grp_intelligentClean.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grp_intelligentClean.Size = new System.Drawing.Size(630, 116);
            this.grp_intelligentClean.TabIndex = 4;
            this.grp_intelligentClean.TabStop = false;
            this.grp_intelligentClean.Text = "Intelligent cleaning";
            // 
            // lbl_progress
            // 
            this.lbl_progress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_progress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_progress.Enabled = false;
            this.lbl_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_progress.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_progress.Location = new System.Drawing.Point(35, 321);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(630, 19);
            this.lbl_progress.TabIndex = 5;
            this.lbl_progress.Text = "Progress: 0%";
            this.lbl_progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_progress.UseMnemonic = false;
            this.lbl_progress.Visible = false;
            // 
            // lbl_smart
            // 
            this.lbl_smart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_smart.BackColor = System.Drawing.Color.Chartreuse;
            this.lbl_smart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_smart.Location = new System.Drawing.Point(35, 284);
            this.lbl_smart.Name = "lbl_smart";
            this.lbl_smart.Size = new System.Drawing.Size(630, 34);
            this.lbl_smart.TabIndex = 6;
            this.lbl_smart.Text = "Running smart cleaning";
            this.lbl_smart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_smart.Visible = false;
            // 
            // lbl_smartPercent
            // 
            this.lbl_smartPercent.AutoSize = true;
            this.lbl_smartPercent.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_smartPercent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_smartPercent.Location = new System.Drawing.Point(191, 142);
            this.lbl_smartPercent.Name = "lbl_smartPercent";
            this.lbl_smartPercent.Size = new System.Drawing.Size(20, 19);
            this.lbl_smartPercent.TabIndex = 10;
            this.lbl_smartPercent.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(698, 635);
            this.Controls.Add(this.lbl_smart);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.grp_cleanStats);
            this.Controls.Add(this.grp_intelligentClean);
            this.Controls.Add(this.prg_progressbar);
            this.Controls.Add(this.grp_ramStats);
            this.Controls.Add(this.grp_cleanOptions);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAM Cleaner 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grp_cleanOptions.ResumeLayout(false);
            this.grp_cleanOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_smart)).EndInit();
            this.grp_ramStats.ResumeLayout(false);
            this.tbl_ramStat.ResumeLayout(false);
            this.tbl_ramStat.PerformLayout();
            this.grp_cleanStats.ResumeLayout(false);
            this.grp_cleanStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public GroupBox grp_cleanOptions;
        public GroupBox grp_ramStats;
        public ProgressBar prg_progressbar;
        public GroupBox grp_cleanStats;
        public GroupBox grp_intelligentClean;
        public RadioButton rb_deep;
        public RadioButton rb_normal;
        public RadioButton rb_fast;
        public Button btn_startClean;
        public ProgressBar prg_ramUsage;
        public TableLayoutPanel tbl_ramStat;
        public Label tbl_00;
        public Label tbl_10;
        public Label tbl_20;
        public Label tbl_11;
        public Label tbl_01;
        public Label tbl_21;
        public Label tbl_12;
        public Label tbl_02;
        public Label tbl_22;
        private Label lbl_finishDate;
        private Label lbl_elapsedTime;
        private Label lbl_startDate;
        private Label lbl_startDate_data;
        private Label lbl_elapsedTime_data;
        private Label lbl_finishDate_data;
        private Label lbl_cleanedRam;
        private Label lbl_ramAfter;
        private Label lbl_ramBefore;
        private Label lbl_cleanedRam_data;
        private Label lbl_ramAfter_data;
        private Label lbl_ramBefore_data;
        private Label lbl_progress;
        private Label lbl_estimatedDeep;
        private Label lbl_estimatedNormal;
        private Label lbl_estimatedFast;
        public RadioButton rb_smart;
        private Label lbl_smart;
        private LinkLabel linkLabel1;
        private NumericUpDown num_smart;
        private Label lbl_smartPercent;
    }
}

