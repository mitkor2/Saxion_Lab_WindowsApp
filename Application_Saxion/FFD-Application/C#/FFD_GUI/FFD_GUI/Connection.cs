﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using System.Threading;
using System.Timers;

namespace FFD_GUI
{
    public partial class Connection : Form
    {
        string[] arrList;
        System.IO.StreamWriter out_file;
        private Main mainForm = null;
        public Connection(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as Main;
            openFileDialog1.Filter = "Text|*.txt";
        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPorts.Text != "")
                {
                    if (cbBaud.Text != "")
                    {
                        serialPort1.PortName = cbPorts.Text;
                        serialPort1.BaudRate = Convert.ToInt32(cbBaud.Text);
                        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
                        serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopbits.Text);
                        serialPort1.DataBits = Convert.ToInt32(cbDatabits.Text);
                        serialPort1.Handshake = Handshake.None;
                        serialPort1.RtsEnable = true;
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                        UserControl_state(true);
                        if (serialPort1.IsOpen) return;
                        serialPort1.Open();
                        btnConn.Enabled = false;
                        btnDisConn.Enabled = true;
                        //
                        cbBaud.Enabled = false;
                        cbPorts.Enabled = false;
                        cbDatabits.Enabled = false;
                        cbStopbits.Enabled = false;
                        cbParity.Enabled = false;
                        if (datalogger_checkbox.Checked)
                        {
                            try
                            {
                                out_file = new System.IO.StreamWriter(datalogger_checkbox.Text, datalogger_append_radiobutton.Checked);
                            }
                            catch
                            {
                                alert("Can't open " + datalogger_checkbox.Text + " file, it might be used in another program");
                                return;
                            }
                        }
                        if (datalogger_checkbox.Checked)
                            try { out_file.Dispose(); }
                            catch {/*ignore*/ }

                    }
                    else
                        return;
                }
                else
                    return;
            }
            catch
            {
                return;
            }
        }
        private void alert(string text)
        {
            alert_messege.Icon = Icon;
            alert_messege.Visible = true;
            alert_messege.ShowBalloonTip(5000, "Saxion Lab", text, ToolTipIcon.Error);
        }
        private void BtnDisConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false) return;
                serialPort1.Close();
                btnConn.Enabled = true;
                btnDisConn.Enabled = false;
                //
                cbBaud.Enabled = true;
                cbPorts.Enabled = true;
                cbDatabits.Enabled = true;
                cbStopbits.Enabled = true;
                cbParity.Enabled = true;
            }
            catch
            {
                return;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            { 
                //split data receive from serialport
                arrList = serialPort1.ReadLine().Split(';');
                this.mainForm.port_sensor1 = arrList[0];
                this.mainForm.port_sensor2 = arrList[1];
                this.mainForm.port_sensor3 = arrList[2];
                this.mainForm.port_sensor4 = arrList[3];
                this.mainForm.port_sensor5 = arrList[4];
                this.mainForm.port_sensor6 = arrList[5];
                this.mainForm.port_sensor7 = arrList[6];
                this.mainForm.port_sensor8 = arrList[7];
                this.mainForm.port_sensor9 = arrList[8];
                this.mainForm.port_sensor10 = arrList[9];
                this.mainForm.port_sensor11 = arrList[10];
                this.mainForm.port_sensor12 = arrList[11];
                this.mainForm.port_sensor13 = arrList[12];
                this.mainForm.port_sensor14 = arrList[13];
                this.mainForm.port_sensor15 = arrList[14];
                this.mainForm.port_sensor16 = arrList[15];
                this.mainForm.port_sensor17 = arrList[16];
                this.mainForm.port_sensor18 = arrList[17];
                this.mainForm.port_sensor19 = arrList[18];
                this.mainForm.port_sensor20 = arrList[19];
                this.mainForm.port_sensor21 = arrList[20];
                this.mainForm.port_sensor22 = arrList[21];
                this.mainForm.port_sensor23 = arrList[22];
                this.mainForm.port_sensor24 = arrList[23];
                this.mainForm.port_sensor25 = arrList[24];
                this.mainForm.port_sensor26 = arrList[25];
                this.mainForm.port_sensor27 = arrList[26];
                this.mainForm.port_sensor28 = arrList[27];
                this.mainForm.port_sensor29 = arrList[28];
               

            }
            catch
            {
                return;
            }
        }
        public void logger_saveinfo()
        {
            try
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@datalogger_checkbox.Text, true))
                {
                    // file.WriteLine("H2S:" + arrList[0] + "HCN:" + arrList[1] + "HCL:" + arrList[2] + "NO2-AE:" + arrList[4] + "CO-AF:" + arrList[6] + "PID-A1:" + arrList[7]);
                    //file.WriteLine("CH-D3:" + arrList[8] + "NO-A1:" + arrList[9] + "CL2-A1:" + arrList[11] + "IRC-A1:" + arrList[12] + "CO-A1:" + arrList[13] + "NH3:" + arrList[14]+ "SO2:" + arrList[15]);
                    //H2S,HCN,HCL,NO2-AE,CO-AF,PID-A1,CH-D3,NO-A1,CL2-A1,IRC-A1,CO-A1,NH3,SO2,RH,TEMP
                    file.WriteLine(arrList[0] + "," + arrList[1] + "," + arrList[2] + "," + arrList[4] + "," + arrList[6] + "," + arrList[7]+"," + arrList[8] + "," + arrList[9] + "," + arrList[11] + "," + arrList[12] + "," + arrList[13] + "," + arrList[14] + "," + arrList[15] + "," + arrList[20] + "," + arrList[21]);
                }
            }
            catch
            {
                return;
            }
        }

        int intlen = 0;
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            logger_saveinfo();
            //auto detect COM port//
            string[] ports = SerialPort.GetPortNames();
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                cbPorts.Items.Clear();
                for (int j = 0; j < intlen; j++)
                {
                    cbPorts.Items.Add(ports[j]);
                }
            }
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            cbBaud.Enabled = true;
            cbPorts.Enabled = true;
            cbDatabits.Enabled = true;
            cbStopbits.Enabled = true;
            cbParity.Enabled = true;
            //Disable button control

            //Load value//
            cbBaud.Items.Add(9600);
            cbBaud.Items.Add(14400);
            cbBaud.Items.Add(19200);
            cbBaud.Items.Add(38400);
            cbBaud.Items.Add(57600);
            cbBaud.Items.Add(74880);
            cbBaud.Items.Add(115200);
            cbBaud.Items.Add(230400);
            cbBaud.Items.Add(256000);
            cbBaud.Items.Add(460800);
            cbBaud.Items.Add(921600);

            cbDatabits.Items.Add(8);
            cbDatabits.Items.Add(7);
            cbDatabits.Items.Add(6);
            cbDatabits.Items.Add(5);

            cbStopbits.Items.Add("One");
            cbStopbits.Items.Add("OnePointFive");
            cbStopbits.Items.Add("Two");

            cbParity.Items.Add("None");
            cbParity.Items.Add("Even");
            cbParity.Items.Add("Odd");
            cbParity.Items.Add("Mark");
            cbParity.Items.Add("Space");
            btnDisConn.Enabled = false;
            }
        private void UserControl_state(bool value)
        {
            if (value)
            {
                toolStripStatusLabel1.Text = "Connected port: " + serialPort1.PortName + " @ " + serialPort1.BaudRate + " bps";
            }
            else
            {
                toolStripStatusLabel1.Text = "No Connection";
            }
        }

        private void CbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Datalogger_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (datalogger_checkbox.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    datalogger_checkbox.Text = openFileDialog1.FileName;
                    datalogger_append_radiobutton.Enabled = true;
                    datalogger_append_radiobutton.Enabled = true;

                }
                else
                {
                    datalogger_checkbox.Checked = false;
                    datalogger_append_radiobutton.Enabled = false;
                    datalogger_append_radiobutton.Enabled = false;
                }
            }
            else
            {
                datalogger_append_radiobutton.Enabled = false;
                datalogger_checkbox.Text = "Enable Data logger";
            }
        }

        private void Datalogger_overwrite_radiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CbBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}


