using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;

using System.Diagnostics;
using System.IO.Ports;

namespace kayChartTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kayChart serialDataChart;
        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort aSerialPort = new SerialPort("COM8");
            aSerialPort.BaudRate = 9600;
            aSerialPort.Parity = Parity.None;
            aSerialPort.StopBits = StopBits.One;
            aSerialPort.DataBits = 8;
            aSerialPort.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);

        }

        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sData = sender as SerialPort;
            string recvData = sData.ReadLine();


            serialData.Invoke((MethodInvoker)delegate { serialData.AppendText("Received: " +recvData); });

            // initialization of chart update
            double data;
            bool result = Double.TryParse(recvData, out data);
            if(result)
            {
                serialDataChart.TriggeredUpdate(data);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialDataChart = new kayChart(chart1, 60);
            serialDataChart.serieName = "serialRead";
        }

        private void serialData_TextChanged(object sender, EventArgs e)
        {
            serialData.SelectionStart = serialData.Text.Length;
            serialData.ScrollToCaret();
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
