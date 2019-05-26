namespace FFD_GUI
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.lblBaud = new System.Windows.Forms.Label();
            this.btnConn = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDatabits = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.byte_counter_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datalogger_options_panel = new System.Windows.Forms.Panel();
            this.datalogger_append_radiobutton = new System.Windows.Forms.RadioButton();
            this.datalogger_checkbox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.alert_messege = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.datalogger_options_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(90, 33);
            this.cbPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(104, 28);
            this.cbPorts.TabIndex = 5;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.CbPorts_SelectedIndexChanged);
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(90, 70);
            this.cbBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(104, 28);
            this.cbBaud.TabIndex = 5;
            // 
            // btnDisConn
            // 
            this.btnDisConn.Location = new System.Drawing.Point(213, 84);
            this.btnDisConn.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(137, 35);
            this.btnDisConn.TabIndex = 0;
            this.btnDisConn.Text = "Disconnect";
            this.btnDisConn.UseVisualStyleBackColor = true;
            this.btnDisConn.Click += new System.EventHandler(this.BtnDisConn_Click);
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaud.Location = new System.Drawing.Point(8, 78);
            this.lblBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(48, 20);
            this.lblBaud.TabIndex = 1;
            this.lblBaud.Text = "Baud";
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(213, 41);
            this.btnConn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(137, 35);
            this.btnConn.TabIndex = 0;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(8, 41);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(40, 20);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDatabits);
            this.groupBox1.Controls.Add(this.cbPorts);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.btnDisConn);
            this.groupBox1.Controls.Add(this.lblBaud);
            this.groupBox1.Controls.Add(this.btnConn);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(367, 152);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data bits";
            // 
            // cbDatabits
            // 
            this.cbDatabits.FormattingEnabled = true;
            this.cbDatabits.Location = new System.Drawing.Point(90, 106);
            this.cbDatabits.Margin = new System.Windows.Forms.Padding(4);
            this.cbDatabits.Name = "cbDatabits";
            this.cbDatabits.Size = new System.Drawing.Size(104, 28);
            this.cbDatabits.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byte_counter_label,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(398, 24);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // byte_counter_label
            // 
            this.byte_counter_label.Name = "byte_counter_label";
            this.byte_counter_label.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 19);
            this.toolStripStatusLabel1.Text = "No Connection";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "figure";
            this.saveFileDialog1.Filter = "PNG|.png| JPEG|.jpg";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datalogger_options_panel);
            this.groupBox2.Location = new System.Drawing.Point(13, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(367, 71);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data logger";
            // 
            // datalogger_options_panel
            // 
            this.datalogger_options_panel.Controls.Add(this.datalogger_append_radiobutton);
            this.datalogger_options_panel.Controls.Add(this.datalogger_checkbox);
            this.datalogger_options_panel.Location = new System.Drawing.Point(8, 23);
            this.datalogger_options_panel.Margin = new System.Windows.Forms.Padding(4);
            this.datalogger_options_panel.Name = "datalogger_options_panel";
            this.datalogger_options_panel.Size = new System.Drawing.Size(338, 37);
            this.datalogger_options_panel.TabIndex = 28;
            // 
            // datalogger_append_radiobutton
            // 
            this.datalogger_append_radiobutton.AutoSize = true;
            this.datalogger_append_radiobutton.Checked = true;
            this.datalogger_append_radiobutton.Enabled = false;
            this.datalogger_append_radiobutton.Location = new System.Drawing.Point(205, 9);
            this.datalogger_append_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.datalogger_append_radiobutton.Name = "datalogger_append_radiobutton";
            this.datalogger_append_radiobutton.Size = new System.Drawing.Size(78, 21);
            this.datalogger_append_radiobutton.TabIndex = 28;
            this.datalogger_append_radiobutton.TabStop = true;
            this.datalogger_append_radiobutton.Text = "Append";
            this.datalogger_append_radiobutton.UseVisualStyleBackColor = true;
            // 
            // datalogger_checkbox
            // 
            this.datalogger_checkbox.AutoSize = true;
            this.datalogger_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.datalogger_checkbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.datalogger_checkbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.datalogger_checkbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalogger_checkbox.Location = new System.Drawing.Point(4, 7);
            this.datalogger_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.datalogger_checkbox.MaximumSize = new System.Drawing.Size(533, 23);
            this.datalogger_checkbox.Name = "datalogger_checkbox";
            this.datalogger_checkbox.Size = new System.Drawing.Size(160, 23);
            this.datalogger_checkbox.TabIndex = 15;
            this.datalogger_checkbox.Text = "Enable Data logger";
            this.datalogger_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.datalogger_checkbox.UseVisualStyleBackColor = false;
            this.datalogger_checkbox.CheckedChanged += new System.EventHandler(this.Datalogger_checkbox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "log_file";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // alert_messege
            // 
            this.alert_messege.Text = "notifyIcon1";
            this.alert_messege.Visible = true;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.datalogger_options_panel.ResumeLayout(false);
            this.datalogger_options_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Button btnDisConn;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel byte_counter_label;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cbDatabits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel datalogger_options_panel;
        private System.Windows.Forms.CheckBox datalogger_checkbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NotifyIcon alert_messege;
        private System.Windows.Forms.RadioButton datalogger_append_radiobutton;
    }
}