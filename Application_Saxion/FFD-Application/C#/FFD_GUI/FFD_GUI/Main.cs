using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;


namespace FFD_GUI
{
    public partial class Main : Form
    {
        class Settings
        {
            public string[] returndata = new string[65];
            public string[] Yaxis = new string[13];
            public string[] Xaxis = new string[13];
            public string[] Danger1 = new string[13];
            public string[] Danger2 = new string[13];
            public string[] Danger3 = new string[13];
            public string[] sensor_data = new string[13];
        }
        class Datacon
        {
            public string[] rdata = new string[28];
            public string[] dataport_sensor = new string[28];
        }
        Datacon d = new Datacon();
        Settings u = new Settings();
        int TickStart1;
        int TickStart2;
        int TickStart3;
        int TickStart4;
        int TickStart5;
        int TickStart6;
        int TickStart7;
        int TickStart8;
        int TickStart9;
        int TickStart10;
        int TickStart11;
        int TickStart12;
        int TickStart13;
        public string port_sensor1 { get { return d.rdata[0]; } set { d.dataport_sensor[0] = value; } }
        public string port_sensor2 { get { return d.rdata[1]; } set { d.dataport_sensor[1] = value; } }
        public string port_sensor3 { get { return d.rdata[2]; } set { d.dataport_sensor[2] = value; } }
        public string port_sensor4 { get { return d.rdata[3]; } set { d.dataport_sensor[3] = value; } }
        public string port_sensor5 { get { return d.rdata[4]; } set { d.dataport_sensor[4] = value; } }
        public string port_sensor6 { get { return d.rdata[5]; } set { d.dataport_sensor[5] = value; } }
        public string port_sensor7 { get { return d.rdata[6]; } set { d.dataport_sensor[6] = value; } }
        public string port_sensor8 { get { return d.rdata[7]; } set { d.dataport_sensor[7] = value; } }
        public string port_sensor9 { get { return d.rdata[8]; } set { d.dataport_sensor[8] = value; } }
        public string port_sensor10 { get { return d.rdata[9]; } set { d.dataport_sensor[9] = value; } }
        public string port_sensor11 { get { return d.rdata[10]; } set { d.dataport_sensor[10] = value; } }
        public string port_sensor12 { get { return d.rdata[11]; } set { d.dataport_sensor[11] = value; } }
        public string port_sensor13 { get { return d.rdata[12]; } set { d.dataport_sensor[12] = value; } }
        public string port_sensor14 { get { return d.rdata[13]; } set { d.dataport_sensor[13] = value; } }
        public string port_sensor15 { get { return d.rdata[14]; } set { d.dataport_sensor[14] = value; } }
        public string port_sensor16 { get { return d.rdata[15]; } set { d.dataport_sensor[15] = value; } }
        public string port_sensor17 { get { return d.rdata[16]; } set { d.dataport_sensor[16] = value; } }
        public string port_sensor18 { get { return d.rdata[17]; } set { d.dataport_sensor[17] = value; } }
        public string port_sensor19 { get { return d.rdata[18]; } set { d.dataport_sensor[18] = value; } }
        public string port_sensor20 { get { return d.rdata[19]; } set { d.dataport_sensor[19] = value; } }
        public string port_sensor21 { get { return d.rdata[20]; } set { d.dataport_sensor[20] = value; } }
        public string port_sensor22 { get { return d.rdata[21]; } set { d.dataport_sensor[21] = value; } }
        public string port_sensor23 { get { return d.rdata[22]; } set { d.dataport_sensor[22] = value; } }
        public string port_sensor24 { get { return d.rdata[23]; } set { d.dataport_sensor[23] = value; } }
        public string port_sensor25 { get { return d.rdata[24]; } set { d.dataport_sensor[24] = value; } }
        public string port_sensor26 { get { return d.rdata[25]; } set { d.dataport_sensor[25] = value; } }
        public string port_sensor27 { get { return d.rdata[26]; } set { d.dataport_sensor[26] = value; } }
        public string port_sensor28 { get { return d.rdata[27]; } set { d.dataport_sensor[27] = value; } }
        public string port_sensor29 { get { return d.rdata[28]; } set { d.dataport_sensor[28] = value; } }
        public string value_sensor1_y { get { return u.returndata[0]; } set { u.Yaxis[0] = value; } }
        public string value_sensor2_y { get { return u.returndata[1]; } set { u.Yaxis[1] = value; } }
        public string value_sensor3_y { get { return u.returndata[2]; } set { u.Yaxis[2] = value; } }
        public string value_sensor4_y { get { return u.returndata[3]; } set { u.Yaxis[3] = value; } }
        public string value_sensor5_y { get { return u.returndata[4]; } set { u.Yaxis[4] = value; } }
        public string value_sensor6_y { get { return u.returndata[5]; } set { u.Yaxis[5] = value; } }
        public string value_sensor7_y { get { return u.returndata[6]; } set { u.Yaxis[6] = value; } }
        public string value_sensor8_y { get { return u.returndata[7]; } set { u.Yaxis[7] = value; } }
        public string value_sensor9_y { get { return u.returndata[8]; } set { u.Yaxis[8] = value; } }
        public string value_sensor10_y { get { return u.returndata[9]; } set { u.Yaxis[9] = value; } }
        public string value_sensor11_y { get { return u.returndata[10]; } set { u.Yaxis[10] = value; } }
        public string value_sensor12_y { get { return u.returndata[11]; } set { u.Yaxis[11] = value; } }
        public string value_sensor13_y { get { return u.returndata[12]; } set { u.Yaxis[12] = value; } }
        public string value_sensor1_x { get { return u.returndata[13]; } set { u.Xaxis[0] = value; } }
        public string value_sensor2_x { get { return u.returndata[14]; } set { u.Xaxis[1] = value; } }
        public string value_sensor3_x { get { return u.returndata[15]; } set { u.Xaxis[2] = value; } }
        public string value_sensor4_x { get { return u.returndata[16]; } set { u.Xaxis[3] = value; } }
        public string value_sensor5_x { get { return u.returndata[17]; } set { u.Xaxis[4] = value; } }
        public string value_sensor6_x { get { return u.returndata[18]; } set { u.Xaxis[5] = value; } }
        public string value_sensor7_x { get { return u.returndata[19]; } set { u.Xaxis[6] = value; } }
        public string value_sensor8_x { get { return u.returndata[20]; } set { u.Xaxis[7] = value; } }
        public string value_sensor9_x { get { return u.returndata[21]; } set { u.Xaxis[8] = value; } }
        public string value_sensor10_x { get { return u.returndata[22]; } set { u.Xaxis[9] = value; } }
        public string value_sensor11_x { get { return u.returndata[23]; } set { u.Xaxis[10] = value; } }
        public string value_sensor12_x { get { return u.returndata[24]; } set { u.Xaxis[11] = value; } }
        public string value_sensor13_x { get { return u.returndata[25]; } set { u.Xaxis[12] = value; } }
        public string value_sensor1_d1 { get { return u.returndata[26]; } set { u.Danger1[0] = value; } }
        public string value_sensor2_d1 { get { return u.returndata[27]; } set { u.Danger1[1] = value; } }
        public string value_sensor3_d1 { get { return u.returndata[28]; } set { u.Danger1[2] = value; } }
        public string value_sensor4_d1 { get { return u.returndata[29]; } set { u.Danger1[3] = value; } }
        public string value_sensor5_d1 { get { return u.returndata[30]; } set { u.Danger1[4] = value; } }
        public string value_sensor6_d1 { get { return u.returndata[31]; } set { u.Danger1[5] = value; } }
        public string value_sensor7_d1 { get { return u.returndata[32]; } set { u.Danger1[6] = value; } }
        public string value_sensor8_d1 { get { return u.returndata[33]; } set { u.Danger1[7] = value; } }
        public string value_sensor9_d1 { get { return u.returndata[34]; } set { u.Danger1[8] = value; } }
        public string value_sensor10_d1 { get { return u.returndata[35]; } set { u.Danger1[9] = value; } }
        public string value_sensor11_d1 { get { return u.returndata[36]; } set { u.Danger1[10] = value; } }
        public string value_sensor12_d1 { get { return u.returndata[37]; } set { u.Danger1[11] = value; } }
        public string value_sensor13_d1 { get { return u.returndata[38]; } set { u.Danger1[12] = value; } }
        public string value_sensor1_d2 { get { return u.returndata[39]; } set { u.Danger2[0] = value; } }
        public string value_sensor2_d2 { get { return u.returndata[40]; } set { u.Danger2[1] = value; } }
        public string value_sensor3_d2 { get { return u.returndata[41]; } set { u.Danger2[2] = value; } }
        public string value_sensor4_d2 { get { return u.returndata[42]; } set { u.Danger2[3] = value; } }
        public string value_sensor5_d2 { get { return u.returndata[43]; } set { u.Danger2[4] = value; } }
        public string value_sensor6_d2 { get { return u.returndata[44]; } set { u.Danger2[5] = value; } }
        public string value_sensor7_d2 { get { return u.returndata[45]; } set { u.Danger2[6] = value; } }
        public string value_sensor8_d2 { get { return u.returndata[46]; } set { u.Danger2[7] = value; } }
        public string value_sensor9_d2 { get { return u.returndata[47]; } set { u.Danger2[8] = value; } }
        public string value_sensor10_d2 { get { return u.returndata[48]; } set { u.Danger2[9] = value; } }
        public string value_sensor11_d2 { get { return u.returndata[49]; } set { u.Danger2[10] = value; } }
        public string value_sensor12_d2 { get { return u.returndata[50]; } set { u.Danger2[11] = value; } }
        public string value_sensor13_d2 { get { return u.returndata[51]; } set { u.Danger2[12] = value; } }
        public string value_sensor1_d3 { get { return u.returndata[52]; } set { u.Danger3[0] = value; } }
        public string value_sensor2_d3 { get { return u.returndata[53]; } set { u.Danger3[1] = value; } }
        public string value_sensor3_d3 { get { return u.returndata[54]; } set { u.Danger3[2] = value; } }
        public string value_sensor4_d3 { get { return u.returndata[55]; } set { u.Danger3[3] = value; } }
        public string value_sensor5_d3 { get { return u.returndata[56]; } set { u.Danger3[4] = value; } }
        public string value_sensor6_d3 { get { return u.returndata[57]; } set { u.Danger3[5] = value; } }
        public string value_sensor7_d3 { get { return u.returndata[58]; } set { u.Danger3[6] = value; } }
        public string value_sensor8_d3 { get { return u.returndata[59]; } set { u.Danger3[7] = value; } }
        public string value_sensor9_d3 { get { return u.returndata[60]; } set { u.Danger3[8] = value; } }
        public string value_sensor10_d3 { get { return u.returndata[61]; } set { u.Danger3[9] = value; } }
        public string value_sensor11_d3 { get { return u.returndata[62]; } set { u.Danger3[10] = value; } }
        public string value_sensor12_d3 { get { return u.returndata[63]; } set { u.Danger3[11] = value; } }
        public string value_sensor13_d3 { get { return u.returndata[64]; } set { u.Danger3[12] = value; } }
        private About about;

        public Main()
        {
            InitializeComponent();
            timer2.Tick += new EventHandler(DoUpdate); // Everytime timer ticks, timer_Tick will be called
            timer2.Enabled = true;                       // Enable the timer
            timer2.Start();                              // Start the timer
            timer1.Start();
        }


        public void DoUpdate(object sender, EventArgs e)
        {
        }
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection(this); // connection = new Connection();
            connection.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options(this); // options = new Options();
            options.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about = new About();
            about.Show();
        }
        //
        private void Main_Load(object sender, EventArgs e)
        {

            GraphPane myPane1 = zedGraphControl1.GraphPane;
            myPane1.Title.Text = "H2S";
            myPane1.XAxis.Title.Text = "Time, Seconds";
            myPane1.YAxis.Title.Text = "Angle, Deg";

            RollingPointPairList list1 = new RollingPointPairList(60000);
            LineItem Curve1 = myPane1.AddCurve("H2S Value", list1, Color.Blue, SymbolType.None);
            /* myPane1.XAxis.Scale.Min = -10;
             myPane1.XAxis.Scale.Max = 10;
             myPane1.YAxis.Scale.Min = -10;
             myPane1.YAxis.Scale.Max = 10;*/
            myPane1.YAxis.Scale.MinAuto = true;
            myPane1.YAxis.Scale.MaxAuto = true;
            myPane1.XAxis.Scale.MinAuto = true;
            myPane1.XAxis.Scale.MaxAuto = true;
            myPane1.XAxis.MajorGrid.IsVisible = true;
            myPane1.YAxis.MajorGrid.IsVisible = true;
            zedGraphControl1.AxisChange();
            TickStart1 = Environment.TickCount;

            /*Display the graph 2 of contents*/
            //Psidot graph//
            GraphPane myPane2 = zedGraphControl2.GraphPane;
            myPane2.Title.Text = "SO2";
            myPane2.XAxis.Title.Text = "Time, Seconds";
            myPane2.YAxis.Title.Text = "Angle, Deg";
            myPane2.XAxis.MajorGrid.IsVisible = true;
            myPane2.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem Curve2 = myPane2.AddCurve("SO2 Value", list2, Color.Blue, SymbolType.None);
            //
            myPane2.XAxis.Scale.Min = 0;
            myPane2.XAxis.Scale.Max = 10;
            myPane2.YAxis.Scale.Min = -540;
            myPane2.YAxis.Scale.Max = 540;

            zedGraphControl2.AxisChange();
            TickStart2 = Environment.TickCount;

            /*Display the graph 3 of contents*/
            //Theta graph//
            GraphPane myPane3 = zedGraphControl3.GraphPane;
            myPane3.Title.Text = "CL2-A1";//Ten do thi
            myPane3.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane3.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane3.XAxis.MajorGrid.IsVisible = true;
            myPane3.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list3 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve3 = myPane3.AddCurve("CL2-A1 Vallue", list3, Color.Blue, SymbolType.None);//Chon mau cho net ve

            myPane3.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane3.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane3.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane3.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl3.AxisChange();//Tu do Scroll do thi
            TickStart3 = Environment.TickCount;

            GraphPane myPane4 = zedGraphControl4.GraphPane;
            myPane4.Title.Text = "HCN";//Ten do thi
            myPane4.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane4.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane4.XAxis.MajorGrid.IsVisible = true;
            myPane4.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list4 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve4 = myPane4.AddCurve("HCN Vallue", list4, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane4.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane4.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane4.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane4.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl4.AxisChange();//Tu do Scroll do thi
            TickStart4 = Environment.TickCount;

            GraphPane myPane5 = zedGraphControl5.GraphPane;
            myPane5.Title.Text = "PID-A1";//Ten do thi
            myPane5.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane5.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane5.XAxis.MajorGrid.IsVisible = true;
            myPane5.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list5 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve5 = myPane5.AddCurve("PID-A1 Vallue", list5, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane5.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane5.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane5.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane5.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl5.AxisChange();//Tu do Scroll do thi
            TickStart5 = Environment.TickCount;

            GraphPane myPane6 = zedGraphControl6.GraphPane;
            myPane6.Title.Text = "IRC-A1";//Ten do thi
            myPane6.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane6.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane6.XAxis.MajorGrid.IsVisible = true;
            myPane6.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list6 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve6 = myPane6.AddCurve("IRC-A1 Vallue", list6, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane6.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane6.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane6.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane6.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl6.AxisChange();//Tu do Scroll do thi
            TickStart6 = Environment.TickCount;

            GraphPane myPane7 = zedGraphControl7.GraphPane;
            myPane7.Title.Text = "HCL";//Ten do thi
            myPane7.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane7.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane7.XAxis.MajorGrid.IsVisible = true;
            myPane7.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list7 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve7 = myPane7.AddCurve("HCL Vallue", list7, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane7.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane7.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane7.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane7.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl7.AxisChange();//Tu do Scroll do thi
            TickStart7 = Environment.TickCount;

            GraphPane myPane8 = zedGraphControl8.GraphPane;
            myPane8.Title.Text = "CH-D3";//Ten do thi
            myPane8.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane8.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane8.XAxis.MajorGrid.IsVisible = true;
            myPane8.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list8 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve8 = myPane8.AddCurve("CH-D3 Vallue", list8, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane8.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane8.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane8.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane8.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl8.AxisChange();//Tu do Scroll do thi
            TickStart8 = Environment.TickCount;

            GraphPane myPane9 = zedGraphControl9.GraphPane;
            myPane9.Title.Text = "CO-AF(1)";//Ten do thi
            myPane9.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane9.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane9.XAxis.MajorGrid.IsVisible = true;
            myPane9.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list9 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve9 = myPane9.AddCurve("CO-AF(1) Vallue", list9, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane9.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane9.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane9.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane9.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl9.AxisChange();//Tu do Scroll do thi
            TickStart9 = Environment.TickCount;

            GraphPane myPane10 = zedGraphControl10.GraphPane;
            myPane10.Title.Text = "NO2-AE";//Ten do thi
            myPane10.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane10.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane10.XAxis.MajorGrid.IsVisible = true;
            myPane10.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list10 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve10 = myPane10.AddCurve("NO2-AE Vallue", list10, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane10.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane10.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane10.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane10.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl10.AxisChange();//Tu do Scroll do thi
            TickStart10 = Environment.TickCount;

            GraphPane myPane11 = zedGraphControl11.GraphPane;
            myPane11.Title.Text = "NO-A1";//Ten do thi
            myPane11.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane11.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane11.XAxis.MajorGrid.IsVisible = true;
            myPane11.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list11 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve11 = myPane11.AddCurve("NO-A1 Vallue", list11, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane11.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane11.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane11.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane11.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl11.AxisChange();//Tu do Scroll do thi
            TickStart11 = Environment.TickCount;

            GraphPane myPane12 = zedGraphControl12.GraphPane;
            myPane12.Title.Text = "NH3";//Ten do thi
            myPane12.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane12.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane12.XAxis.MajorGrid.IsVisible = true;
            myPane12.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list12 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve12 = myPane12.AddCurve("NH3 Vallue", list12, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane12.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane12.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane12.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane12.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl12.AxisChange();//Tu do Scroll do thi
            TickStart12 = Environment.TickCount;

            GraphPane myPane13 = zedGraphControl13.GraphPane;
            myPane13.Title.Text = "CO-AF(2)";//Ten do thi
            myPane13.XAxis.Title.Text = "Time, Seconds";//Noi dung truc X
            myPane13.YAxis.Title.Text = "Angle, Deg";//Noi dung truc Y
            myPane13.XAxis.MajorGrid.IsVisible = true;
            myPane13.YAxis.MajorGrid.IsVisible = true;
            RollingPointPairList list13 = new RollingPointPairList(60000);//So diem hien thi tren do thi
            LineItem Curve13 = myPane13.AddCurve("CO-AF(2) Vallue", list13, Color.Blue, SymbolType.None);//Chon mau cho net ve


            myPane13.XAxis.Scale.Min = 0;//Gia tri nho nhat cua truc X
            myPane13.XAxis.Scale.Max = 10;//Gia tri lon nhat cua truc X
            myPane13.YAxis.Scale.Min = -120;//Gia tri nho nhat cua truc Y
            myPane13.YAxis.Scale.Max = 120;//Gia tri lon nhat cua truc Y

            zedGraphControl13.AxisChange();//Tu do Scroll do thi
            TickStart13 = Environment.TickCount;
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Chart14_Click(object sender, EventArgs e)
        {

        }
        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(u.Yaxis[0]);
            //  Console.WriteLine(u.Xaxis[0]);
            // Console.WriteLine(u.Danger1[0]);
            //Console.WriteLine(u.Danger2[0]);
            //Console.WriteLine(u.Danger3[0]);
            Console.WriteLine(d.dataport_sensor[0]);
            Console.WriteLine(d.dataport_sensor[1]);
            Console.WriteLine(d.dataport_sensor[2]);
            Console.WriteLine(d.dataport_sensor[3]);
            Console.WriteLine(d.dataport_sensor[4]);

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection(this);
            connection.Show();
        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CpuChart_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Draw();
           // d.dataport_sensor[0] = 
            //display value on graph
            // text color and value
            lblsensor1.ForeColor = Color.Blue;
            lblsensor1.Text = d.dataport_sensor[0];
            lblsensor2.ForeColor = Color.Blue;
            lblsensor2.Text = d.dataport_sensor[1];
            lblsensor3.ForeColor = Color.Blue;
            lblsensor3.Text = d.dataport_sensor[2];
            lblsensor4.ForeColor = Color.Blue;
            lblsensor4.Text = d.dataport_sensor[3];
            lblsensor5.ForeColor = Color.Blue;
            lblsensor5.Text = d.dataport_sensor[4];
            lblsensor6.ForeColor = Color.Blue;
            lblsensor6.Text = d.dataport_sensor[5];
            lblsensor7.ForeColor = Color.Blue;
            lblsensor7.Text = d.dataport_sensor[6];
            lblsensor8.ForeColor = Color.Blue;
            lblsensor8.Text = d.dataport_sensor[7];
            lblsensor9.ForeColor = Color.Blue;
            lblsensor9.Text = d.dataport_sensor[8];
            lblsensor10.ForeColor = Color.Blue;
            lblsensor10.Text = d.dataport_sensor[9];
            lblsensor11.ForeColor = Color.Blue;
            lblsensor11.Text = d.dataport_sensor[10];
            lblsensor12.ForeColor = Color.Blue;
            lblsensor12.Text = d.dataport_sensor[11];
            lblsensor13.ForeColor = Color.Blue;
            lblsensor13.Text = d.dataport_sensor[12];

        }

        private void ChartTest_Click(object sender, EventArgs e)
        {
        }

        private void Draw()
        {
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl2.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl3.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl4.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl5.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl6.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl7.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl8.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl9.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl10.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl11.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl12.GraphPane.CurveList.Count <= 0)
                return;
            if (zedGraphControl13.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = zedGraphControl2.GraphPane.CurveList[0] as LineItem;
            LineItem curve3 = zedGraphControl3.GraphPane.CurveList[0] as LineItem;
            LineItem curve4 = zedGraphControl4.GraphPane.CurveList[0] as LineItem;
            LineItem curve5 = zedGraphControl5.GraphPane.CurveList[0] as LineItem;
            LineItem curve6 = zedGraphControl6.GraphPane.CurveList[0] as LineItem;
            LineItem curve7 = zedGraphControl7.GraphPane.CurveList[0] as LineItem;
            LineItem curve8 = zedGraphControl8.GraphPane.CurveList[0] as LineItem;
            LineItem curve9 = zedGraphControl9.GraphPane.CurveList[0] as LineItem;
            LineItem curve10 = zedGraphControl10.GraphPane.CurveList[0] as LineItem;
            LineItem curve11 = zedGraphControl11.GraphPane.CurveList[0] as LineItem;
            LineItem curve12 = zedGraphControl12.GraphPane.CurveList[0] as LineItem;
            LineItem curve13 = zedGraphControl13.GraphPane.CurveList[0] as LineItem;

            if (curve1 == null)
                return;
            if (curve2 == null)
                return;
            if (curve3 == null)
                return;
            if (curve4 == null)
                return;
            if (curve5 == null)
                return;
            if (curve6 == null)
                return;
            if (curve7 == null)
                return;
            if (curve8 == null)
                return;
            if (curve9 == null)
                return;
            if (curve10 == null)
                return;
            if (curve11 == null)
                return;
            if (curve12 == null)
                return;
            if (curve13 == null)
                return;
            //
            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            IPointListEdit list3 = curve3.Points as IPointListEdit;
            IPointListEdit list4 = curve4.Points as IPointListEdit;
            IPointListEdit list5 = curve5.Points as IPointListEdit;
            IPointListEdit list6 = curve6.Points as IPointListEdit;
            IPointListEdit list7 = curve7.Points as IPointListEdit;
            IPointListEdit list8 = curve8.Points as IPointListEdit;
            IPointListEdit list9 = curve9.Points as IPointListEdit;
            IPointListEdit list10 = curve10.Points as IPointListEdit;
            IPointListEdit list11 = curve11.Points as IPointListEdit;
            IPointListEdit list12 = curve12.Points as IPointListEdit;
            IPointListEdit list13 = curve13.Points as IPointListEdit;
            //
            if (list1 == null)
                return;
            if (list2 == null)
                return;
            if (list3 == null)
                return;
            if (list4 == null)
                return;
            if (list5 == null)
                return;
            if (list6 == null)
                return;
            if (list7 == null)
                return;
            if (list8 == null)
                return;
            if (list9 == null)
                return;
            if (list10 == null)
                return;
            if (list11 == null)
                return;
            if (list12 == null)
                return;
            if (list13 == null)
                return;
            //
            double time1 = (Environment.TickCount - TickStart1) / 1000.0;
            double time2 = (Environment.TickCount - TickStart2) / 1000.0;
            double time3 = (Environment.TickCount - TickStart3) / 1000.0;
            double time4 = (Environment.TickCount - TickStart4) / 1000.0;
            double time5 = (Environment.TickCount - TickStart5) / 1000.0;
            double time6 = (Environment.TickCount - TickStart6) / 1000.0;
            double time7 = (Environment.TickCount - TickStart7) / 1000.0;
            double time8 = (Environment.TickCount - TickStart8) / 1000.0;
            double time9 = (Environment.TickCount - TickStart9) / 1000.0;
            double time10 = (Environment.TickCount - TickStart10) / 1000.0;
            double time11 = (Environment.TickCount - TickStart11) / 1000.0;
            double time12 = (Environment.TickCount - TickStart12) / 1000.0;
            double time13 = (Environment.TickCount - TickStart13) / 1000.0;
            //
            list1.Add(time1, Convert.ToDouble(d.dataport_sensor[0]));
            list2.Add(time2, Convert.ToDouble(d.dataport_sensor[1]));
            list3.Add(time3, Convert.ToDouble(d.dataport_sensor[2]));
            list4.Add(time4, Convert.ToDouble(d.dataport_sensor[3]));
            list5.Add(time5, Convert.ToDouble(d.dataport_sensor[4]));
            list6.Add(time6, Convert.ToDouble(d.dataport_sensor[5]));
            list7.Add(time7, Convert.ToDouble(d.dataport_sensor[6]));
            list8.Add(time8, Convert.ToDouble(d.dataport_sensor[7]));
            list9.Add(time9, Convert.ToDouble(d.dataport_sensor[8]));
            list10.Add(time10, Convert.ToDouble(d.dataport_sensor[9]));
            list11.Add(time11, Convert.ToDouble(d.dataport_sensor[10]));
            list12.Add(time12, Convert.ToDouble(d.dataport_sensor[11]));
            list13.Add(time13, Convert.ToDouble(d.dataport_sensor[12]));


            Scale xScale1 = zedGraphControl1.GraphPane.XAxis.Scale;
            Scale xScale2 = zedGraphControl2.GraphPane.XAxis.Scale;
            Scale xScale3 = zedGraphControl3.GraphPane.XAxis.Scale;
            Scale xScale4 = zedGraphControl4.GraphPane.XAxis.Scale;
            Scale xScale5 = zedGraphControl5.GraphPane.XAxis.Scale;
            Scale xScale6 = zedGraphControl6.GraphPane.XAxis.Scale;
            Scale xScale7 = zedGraphControl7.GraphPane.XAxis.Scale;
            Scale xScale8 = zedGraphControl8.GraphPane.XAxis.Scale;
            Scale xScale9 = zedGraphControl9.GraphPane.XAxis.Scale;
            Scale xScale10 = zedGraphControl10.GraphPane.XAxis.Scale;
            Scale xScale11 = zedGraphControl11.GraphPane.XAxis.Scale;
            Scale xScale12 = zedGraphControl12.GraphPane.XAxis.Scale;
            Scale xScale13 = zedGraphControl13.GraphPane.XAxis.Scale;
            //
            Scale yScale1 = zedGraphControl1.GraphPane.YAxis.Scale;
            Scale yScale2 = zedGraphControl2.GraphPane.YAxis.Scale;
            Scale yScale3 = zedGraphControl3.GraphPane.YAxis.Scale;
            Scale yScale4 = zedGraphControl4.GraphPane.YAxis.Scale;
            Scale yScale5 = zedGraphControl5.GraphPane.YAxis.Scale;
            Scale yScale6 = zedGraphControl6.GraphPane.YAxis.Scale;
            Scale yScale7 = zedGraphControl7.GraphPane.YAxis.Scale;
            Scale yScale8 = zedGraphControl8.GraphPane.YAxis.Scale;
            Scale yScale9 = zedGraphControl9.GraphPane.YAxis.Scale;
            Scale yScale10 = zedGraphControl10.GraphPane.YAxis.Scale;
            Scale yScale11 = zedGraphControl11.GraphPane.YAxis.Scale;
            Scale yScale12 = zedGraphControl12.GraphPane.YAxis.Scale;
            Scale yScale13 = zedGraphControl13.GraphPane.YAxis.Scale;
            //
            if (time1 > xScale1.Max - xScale1.MajorStep)
            {
                xScale1.Max = time1 + xScale1.MajorStep;
                xScale1.Min = xScale1.Max - 30;//Auto scale x axis in limit tim
            }
            if (time2 > xScale2.Max - xScale2.MajorStep)
            {
                xScale2.Max = time2 + xScale2.MajorStep;
                xScale2.Min = xScale2.Max - 30;
            }
            if (time3 > xScale3.Max - xScale3.MajorStep)
            {
                xScale3.Max = time3 + xScale3.MajorStep;
                xScale3.Min = xScale3.Max - 30;
            }
            if (time4 > xScale4.Max - xScale4.MajorStep)
            {
                xScale4.Max = time4 + xScale4.MajorStep;
                xScale4.Min = xScale4.Max - 30;
            }
            if (time5 > xScale5.Max - xScale5.MajorStep)
            {
                xScale5.Max = time5 + xScale5.MajorStep;
                xScale5.Min = xScale5.Max - 30;
            }
            if (time6 > xScale6.Max - xScale6.MajorStep)
            {
                xScale6.Max = time6 + xScale6.MajorStep;
                xScale6.Min = xScale6.Max - 30;
            }
            if (time7 > xScale7.Max - xScale7.MajorStep)
            {
                xScale7.Max = time7 + xScale7.MajorStep;
                xScale7.Min = xScale7.Max - 30;
            }
            if (time8 > xScale8.Max - xScale8.MajorStep)
            {
                xScale8.Max = time8 + xScale8.MajorStep;
                xScale8.Min = xScale8.Max - 30;
            }
            if (time9 > xScale9.Max - xScale9.MajorStep)
            {
                xScale9.Max = time9 + xScale9.MajorStep;
                xScale9.Min = xScale9.Max - 30;
            }
            if (time10 > xScale10.Max - xScale10.MajorStep)
            {
                xScale10.Max = time10 + xScale10.MajorStep;
                xScale10.Min = xScale10.Max - 30;
            }
            if (time11 > xScale11.Max - xScale11.MajorStep)
            {
                xScale11.Max = time11 + xScale11.MajorStep;
                xScale11.Min = xScale11.Max - 30;
            }
            if (time12 > xScale12.Max - xScale12.MajorStep)
            {
                xScale12.Max = time12 + xScale12.MajorStep;
                xScale12.Min = xScale12.Max - 30;
            }
            if (time13 > xScale13.Max - xScale13.MajorStep)
            {
                xScale13.Max = time13 + xScale13.MajorStep;
                xScale13.Min = xScale13.Max - 30;
            }
            //
            zedGraphControl1.AxisChange();
            zedGraphControl2.AxisChange();
            zedGraphControl3.AxisChange();
            zedGraphControl4.AxisChange();
            zedGraphControl5.AxisChange();
            zedGraphControl6.AxisChange();
            zedGraphControl7.AxisChange();
            zedGraphControl8.AxisChange();
            zedGraphControl9.AxisChange();
            zedGraphControl10.AxisChange();
            zedGraphControl11.AxisChange();
            zedGraphControl12.AxisChange();
            zedGraphControl13.AxisChange();
            //
            zedGraphControl1.Invalidate();
            zedGraphControl2.Invalidate();
            zedGraphControl3.Invalidate();
            zedGraphControl4.Invalidate();
            zedGraphControl5.Invalidate();
            zedGraphControl6.Invalidate();
            zedGraphControl7.Invalidate();
            zedGraphControl8.Invalidate();
            zedGraphControl9.Invalidate();
            zedGraphControl10.Invalidate();
            zedGraphControl11.Invalidate();
            zedGraphControl12.Invalidate();
            zedGraphControl13.Invalidate();
        }

        private void ZedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(double.Parse(u.Xaxis[0]));
            string mitko = "10";
            GraphPane myPane1 = zedGraphControl1.GraphPane;
            myPane1.YAxis.Scale.Min = -10;
            myPane1.YAxis.Scale.Max = double.Parse(mitko); 
        }

        private void Lblsensor13_Click(object sender, EventArgs e)
        {

        }
    }
}
