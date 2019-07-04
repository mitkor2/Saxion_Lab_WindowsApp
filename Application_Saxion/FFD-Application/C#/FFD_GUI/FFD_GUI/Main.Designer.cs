namespace FFD_GUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lblsensor1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl5 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl6 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl7 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl8 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl9 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl10 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl11 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl12 = new ZedGraph.ZedGraphControl();
            this.lblsensor2 = new System.Windows.Forms.Label();
            this.lblsensor3 = new System.Windows.Forms.Label();
            this.lblsensor4 = new System.Windows.Forms.Label();
            this.lblsensor5 = new System.Windows.Forms.Label();
            this.lblsensor6 = new System.Windows.Forms.Label();
            this.lblsensor7 = new System.Windows.Forms.Label();
            this.lblsensor8 = new System.Windows.Forms.Label();
            this.lblsensor9 = new System.Windows.Forms.Label();
            this.lblsensor10 = new System.Windows.Forms.Label();
            this.lblsensor11 = new System.Windows.Forms.Label();
            this.lblsensor12 = new System.Windows.Forms.Label();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsensor15 = new System.Windows.Forms.Label();
            this.lblsensor14 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(1916, 26);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip2_ItemClicked);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.optionsToolStripMenuItem1});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.toolStripMenuItem2.Text = "Connection";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.IsScrollY2 = true;
            this.zedGraphControl2.IsShowPointValues = true;
            this.zedGraphControl2.Location = new System.Drawing.Point(893, 640);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(427, 295);
            this.zedGraphControl2.TabIndex = 47;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(1328, 640);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(402, 295);
            this.zedGraphControl1.TabIndex = 46;
            this.zedGraphControl1.Load += new System.EventHandler(this.ZedGraphControl1_Load);
            // 
            // lblsensor1
            // 
            this.lblsensor1.AutoSize = true;
            this.lblsensor1.BackColor = System.Drawing.Color.White;
            this.lblsensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor1.Location = new System.Drawing.Point(1595, 649);
            this.lblsensor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor1.Name = "lblsensor1";
            this.lblsensor1.Size = new System.Drawing.Size(70, 32);
            this.lblsensor1.TabIndex = 55;
            this.lblsensor1.Text = "H2S";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl4.Location = new System.Drawing.Point(453, 335);
            this.zedGraphControl4.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(427, 295);
            this.zedGraphControl4.TabIndex = 67;
            // 
            // zedGraphControl5
            // 
            this.zedGraphControl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl5.Location = new System.Drawing.Point(14, 31);
            this.zedGraphControl5.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl5.Name = "zedGraphControl5";
            this.zedGraphControl5.ScrollGrace = 0D;
            this.zedGraphControl5.ScrollMaxX = 0D;
            this.zedGraphControl5.ScrollMaxY = 0D;
            this.zedGraphControl5.ScrollMaxY2 = 0D;
            this.zedGraphControl5.ScrollMinX = 0D;
            this.zedGraphControl5.ScrollMinY = 0D;
            this.zedGraphControl5.ScrollMinY2 = 0D;
            this.zedGraphControl5.Size = new System.Drawing.Size(427, 295);
            this.zedGraphControl5.TabIndex = 68;
            // 
            // zedGraphControl6
            // 
            this.zedGraphControl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl6.Location = new System.Drawing.Point(453, 641);
            this.zedGraphControl6.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl6.Name = "zedGraphControl6";
            this.zedGraphControl6.ScrollGrace = 0D;
            this.zedGraphControl6.ScrollMaxX = 0D;
            this.zedGraphControl6.ScrollMaxY = 0D;
            this.zedGraphControl6.ScrollMaxY2 = 0D;
            this.zedGraphControl6.ScrollMinX = 0D;
            this.zedGraphControl6.ScrollMinY = 0D;
            this.zedGraphControl6.ScrollMinY2 = 0D;
            this.zedGraphControl6.Size = new System.Drawing.Size(427, 297);
            this.zedGraphControl6.TabIndex = 69;
            // 
            // zedGraphControl7
            // 
            this.zedGraphControl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl7.Location = new System.Drawing.Point(890, 31);
            this.zedGraphControl7.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl7.Name = "zedGraphControl7";
            this.zedGraphControl7.ScrollGrace = 0D;
            this.zedGraphControl7.ScrollMaxX = 0D;
            this.zedGraphControl7.ScrollMaxY = 0D;
            this.zedGraphControl7.ScrollMaxY2 = 0D;
            this.zedGraphControl7.ScrollMinX = 0D;
            this.zedGraphControl7.ScrollMinY = 0D;
            this.zedGraphControl7.ScrollMinY2 = 0D;
            this.zedGraphControl7.Size = new System.Drawing.Size(427, 295);
            this.zedGraphControl7.TabIndex = 70;
            // 
            // zedGraphControl8
            // 
            this.zedGraphControl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl8.Location = new System.Drawing.Point(16, 336);
            this.zedGraphControl8.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl8.Name = "zedGraphControl8";
            this.zedGraphControl8.ScrollGrace = 0D;
            this.zedGraphControl8.ScrollMaxX = 0D;
            this.zedGraphControl8.ScrollMaxY = 0D;
            this.zedGraphControl8.ScrollMaxY2 = 0D;
            this.zedGraphControl8.ScrollMinX = 0D;
            this.zedGraphControl8.ScrollMinY = 0D;
            this.zedGraphControl8.ScrollMinY2 = 0D;
            this.zedGraphControl8.Size = new System.Drawing.Size(427, 295);
            this.zedGraphControl8.TabIndex = 71;
            // 
            // zedGraphControl9
            // 
            this.zedGraphControl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl9.Location = new System.Drawing.Point(451, 31);
            this.zedGraphControl9.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl9.Name = "zedGraphControl9";
            this.zedGraphControl9.ScrollGrace = 0D;
            this.zedGraphControl9.ScrollMaxX = 0D;
            this.zedGraphControl9.ScrollMaxY = 0D;
            this.zedGraphControl9.ScrollMaxY2 = 0D;
            this.zedGraphControl9.ScrollMinX = 0D;
            this.zedGraphControl9.ScrollMinY = 0D;
            this.zedGraphControl9.ScrollMinY2 = 0D;
            this.zedGraphControl9.Size = new System.Drawing.Size(427, 295);
            this.zedGraphControl9.TabIndex = 72;
            // 
            // zedGraphControl10
            // 
            this.zedGraphControl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl10.Location = new System.Drawing.Point(1327, 32);
            this.zedGraphControl10.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl10.Name = "zedGraphControl10";
            this.zedGraphControl10.ScrollGrace = 0D;
            this.zedGraphControl10.ScrollMaxX = 0D;
            this.zedGraphControl10.ScrollMaxY = 0D;
            this.zedGraphControl10.ScrollMaxY2 = 0D;
            this.zedGraphControl10.ScrollMinX = 0D;
            this.zedGraphControl10.ScrollMinY = 0D;
            this.zedGraphControl10.ScrollMinY2 = 0D;
            this.zedGraphControl10.Size = new System.Drawing.Size(403, 294);
            this.zedGraphControl10.TabIndex = 72;
            // 
            // zedGraphControl11
            // 
            this.zedGraphControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl11.Location = new System.Drawing.Point(1328, 335);
            this.zedGraphControl11.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl11.Name = "zedGraphControl11";
            this.zedGraphControl11.ScrollGrace = 0D;
            this.zedGraphControl11.ScrollMaxX = 0D;
            this.zedGraphControl11.ScrollMaxY = 0D;
            this.zedGraphControl11.ScrollMaxY2 = 0D;
            this.zedGraphControl11.ScrollMinX = 0D;
            this.zedGraphControl11.ScrollMinY = 0D;
            this.zedGraphControl11.ScrollMinY2 = 0D;
            this.zedGraphControl11.Size = new System.Drawing.Size(402, 295);
            this.zedGraphControl11.TabIndex = 73;
            // 
            // zedGraphControl12
            // 
            this.zedGraphControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl12.Location = new System.Drawing.Point(890, 336);
            this.zedGraphControl12.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl12.Name = "zedGraphControl12";
            this.zedGraphControl12.ScrollGrace = 0D;
            this.zedGraphControl12.ScrollMaxX = 0D;
            this.zedGraphControl12.ScrollMaxY = 0D;
            this.zedGraphControl12.ScrollMaxY2 = 0D;
            this.zedGraphControl12.ScrollMinX = 0D;
            this.zedGraphControl12.ScrollMinY = 0D;
            this.zedGraphControl12.ScrollMinY2 = 0D;
            this.zedGraphControl12.Size = new System.Drawing.Size(427, 294);
            this.zedGraphControl12.TabIndex = 74;
            // 
            // lblsensor2
            // 
            this.lblsensor2.AutoSize = true;
            this.lblsensor2.BackColor = System.Drawing.Color.White;
            this.lblsensor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor2.Location = new System.Drawing.Point(1191, 649);
            this.lblsensor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor2.Name = "lblsensor2";
            this.lblsensor2.Size = new System.Drawing.Size(74, 36);
            this.lblsensor2.TabIndex = 77;
            this.lblsensor2.Text = "SO2";
            // 
            // lblsensor3
            // 
            this.lblsensor3.AutoSize = true;
            this.lblsensor3.BackColor = System.Drawing.Color.White;
            this.lblsensor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor3.Location = new System.Drawing.Point(314, 652);
            this.lblsensor3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor3.Name = "lblsensor3";
            this.lblsensor3.Size = new System.Drawing.Size(118, 36);
            this.lblsensor3.TabIndex = 78;
            this.lblsensor3.Text = "CL2-A1";
            // 
            // lblsensor4
            // 
            this.lblsensor4.AutoSize = true;
            this.lblsensor4.BackColor = System.Drawing.Color.White;
            this.lblsensor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor4.Location = new System.Drawing.Point(745, 343);
            this.lblsensor4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor4.Name = "lblsensor4";
            this.lblsensor4.Size = new System.Drawing.Size(79, 36);
            this.lblsensor4.TabIndex = 79;
            this.lblsensor4.Text = "HCN";
            // 
            // lblsensor5
            // 
            this.lblsensor5.AutoSize = true;
            this.lblsensor5.BackColor = System.Drawing.Color.White;
            this.lblsensor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor5.Location = new System.Drawing.Point(306, 40);
            this.lblsensor5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor5.Name = "lblsensor5";
            this.lblsensor5.Size = new System.Drawing.Size(112, 36);
            this.lblsensor5.TabIndex = 80;
            this.lblsensor5.Text = "PID-A1";
            // 
            // lblsensor6
            // 
            this.lblsensor6.AutoSize = true;
            this.lblsensor6.BackColor = System.Drawing.Color.White;
            this.lblsensor6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor6.Location = new System.Drawing.Point(745, 652);
            this.lblsensor6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor6.Name = "lblsensor6";
            this.lblsensor6.Size = new System.Drawing.Size(114, 36);
            this.lblsensor6.TabIndex = 81;
            this.lblsensor6.Text = "IRC-A1";
            // 
            // lblsensor7
            // 
            this.lblsensor7.AutoSize = true;
            this.lblsensor7.BackColor = System.Drawing.Color.White;
            this.lblsensor7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor7.Location = new System.Drawing.Point(1184, 39);
            this.lblsensor7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor7.Name = "lblsensor7";
            this.lblsensor7.Size = new System.Drawing.Size(74, 36);
            this.lblsensor7.TabIndex = 82;
            this.lblsensor7.Text = "HCL";
            // 
            // lblsensor8
            // 
            this.lblsensor8.AutoSize = true;
            this.lblsensor8.BackColor = System.Drawing.Color.White;
            this.lblsensor8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor8.Location = new System.Drawing.Point(310, 345);
            this.lblsensor8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor8.Name = "lblsensor8";
            this.lblsensor8.Size = new System.Drawing.Size(105, 36);
            this.lblsensor8.TabIndex = 83;
            this.lblsensor8.Text = "CH-D3";
            // 
            // lblsensor9
            // 
            this.lblsensor9.AutoSize = true;
            this.lblsensor9.BackColor = System.Drawing.Color.White;
            this.lblsensor9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor9.Location = new System.Drawing.Point(745, 40);
            this.lblsensor9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor9.Name = "lblsensor9";
            this.lblsensor9.Size = new System.Drawing.Size(134, 36);
            this.lblsensor9.TabIndex = 84;
            this.lblsensor9.Text = "CO-AF-1";
            // 
            // lblsensor10
            // 
            this.lblsensor10.BackColor = System.Drawing.Color.White;
            this.lblsensor10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor10.Location = new System.Drawing.Point(1599, 39);
            this.lblsensor10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor10.Name = "lblsensor10";
            this.lblsensor10.Size = new System.Drawing.Size(114, 28);
            this.lblsensor10.TabIndex = 85;
            this.lblsensor10.Text = "NO2-AE";
            // 
            // lblsensor11
            // 
            this.lblsensor11.AutoSize = true;
            this.lblsensor11.BackColor = System.Drawing.Color.White;
            this.lblsensor11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor11.Location = new System.Drawing.Point(1598, 344);
            this.lblsensor11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor11.Name = "lblsensor11";
            this.lblsensor11.Size = new System.Drawing.Size(101, 32);
            this.lblsensor11.TabIndex = 86;
            this.lblsensor11.Text = "NO-A1";
            // 
            // lblsensor12
            // 
            this.lblsensor12.AutoSize = true;
            this.lblsensor12.BackColor = System.Drawing.Color.White;
            this.lblsensor12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor12.Location = new System.Drawing.Point(1184, 343);
            this.lblsensor12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor12.Name = "lblsensor12";
            this.lblsensor12.Size = new System.Drawing.Size(75, 36);
            this.lblsensor12.TabIndex = 87;
            this.lblsensor12.Text = "NH3";
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl3.Location = new System.Drawing.Point(16, 641);
            this.zedGraphControl3.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(427, 297);
            this.zedGraphControl3.TabIndex = 48;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(1739, 377);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 73);
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(1739, 862);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(172, 73);
            this.pictureBox4.TabIndex = 91;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(1739, 458);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 73);
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1739, 701);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 73);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label63.Location = new System.Drawing.Point(1733, 40);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(171, 29);
            this.label63.TabIndex = 93;
            this.label63.Text = "Temperature:";
            this.label63.Click += new System.EventHandler(this.Label63_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1738, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 94;
            this.label1.Text = "Humidity:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblsensor15
            // 
            this.lblsensor15.AutoSize = true;
            this.lblsensor15.BackColor = System.Drawing.Color.Transparent;
            this.lblsensor15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor15.Location = new System.Drawing.Point(1788, 86);
            this.lblsensor15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor15.Name = "lblsensor15";
            this.lblsensor15.Size = new System.Drawing.Size(59, 36);
            this.lblsensor15.TabIndex = 95;
            this.lblsensor15.Text = "Cel";
            // 
            // lblsensor14
            // 
            this.lblsensor14.AutoSize = true;
            this.lblsensor14.BackColor = System.Drawing.Color.Transparent;
            this.lblsensor14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsensor14.Location = new System.Drawing.Point(1789, 185);
            this.lblsensor14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsensor14.Name = "lblsensor14";
            this.lblsensor14.Size = new System.Drawing.Size(58, 36);
            this.lblsensor14.TabIndex = 96;
            this.lblsensor14.Text = "RH";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(1739, 296);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(172, 73);
            this.pictureBox5.TabIndex = 97;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(1739, 539);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(172, 73);
            this.pictureBox6.TabIndex = 98;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(1739, 781);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(172, 73);
            this.pictureBox7.TabIndex = 99;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.ErrorImage = null;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(1739, 620);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(172, 73);
            this.pictureBox8.TabIndex = 100;
            this.pictureBox8.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1916, 943);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblsensor14);
            this.Controls.Add(this.lblsensor15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblsensor12);
            this.Controls.Add(this.lblsensor11);
            this.Controls.Add(this.lblsensor10);
            this.Controls.Add(this.lblsensor9);
            this.Controls.Add(this.lblsensor8);
            this.Controls.Add(this.lblsensor7);
            this.Controls.Add(this.lblsensor6);
            this.Controls.Add(this.lblsensor5);
            this.Controls.Add(this.lblsensor4);
            this.Controls.Add(this.lblsensor3);
            this.Controls.Add(this.lblsensor2);
            this.Controls.Add(this.zedGraphControl12);
            this.Controls.Add(this.zedGraphControl11);
            this.Controls.Add(this.zedGraphControl10);
            this.Controls.Add(this.zedGraphControl9);
            this.Controls.Add(this.zedGraphControl8);
            this.Controls.Add(this.zedGraphControl7);
            this.Controls.Add(this.zedGraphControl6);
            this.Controls.Add(this.zedGraphControl5);
            this.Controls.Add(this.zedGraphControl4);
            this.Controls.Add(this.lblsensor1);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(904, 528);
            this.Name = "Main";
            this.Text = "Saxion Lab";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label lblsensor1;
        private System.Windows.Forms.Timer timer2;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private ZedGraph.ZedGraphControl zedGraphControl5;
        private ZedGraph.ZedGraphControl zedGraphControl6;
        private ZedGraph.ZedGraphControl zedGraphControl7;
        private ZedGraph.ZedGraphControl zedGraphControl8;
        private ZedGraph.ZedGraphControl zedGraphControl9;
        private ZedGraph.ZedGraphControl zedGraphControl10;
        private ZedGraph.ZedGraphControl zedGraphControl11;
        private ZedGraph.ZedGraphControl zedGraphControl12;
        private System.Windows.Forms.Label lblsensor2;
        private System.Windows.Forms.Label lblsensor3;
        private System.Windows.Forms.Label lblsensor4;
        private System.Windows.Forms.Label lblsensor5;
        private System.Windows.Forms.Label lblsensor6;
        private System.Windows.Forms.Label lblsensor7;
        private System.Windows.Forms.Label lblsensor8;
        private System.Windows.Forms.Label lblsensor9;
        private System.Windows.Forms.Label lblsensor10;
        private System.Windows.Forms.Label lblsensor11;
        private System.Windows.Forms.Label lblsensor12;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsensor15;
        private System.Windows.Forms.Label lblsensor14;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}