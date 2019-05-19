using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MindFusion.Charting;

namespace RealTimeChart
{
    public partial class Form1 : Form
    {
        //lists for the DateTime values and numbers
        List<DateTime> dates = new List<DateTime>();
        List<double> values = new List<double>();
        Random ran;

        public Form1()
        {
            InitializeComponent();

            //initialize the arrays
            dates = new List<DateTime>();
            values = new List<double>();

            //customize the X-axis
            lineChart1.XAxis.MinValue = 0;
            lineChart1.XAxis.MaxValue = 1;
            lineChart1.XAxis.Interval = 0.1;
            lineChart1.XAxis.Title = "Time";
            lineChart1.ShowXCoordinates = false;

            //customize the Y-axis
            lineChart1.YAxis.MaxValue = 20;
            lineChart1.YAxis.Interval = 2;
            lineChart1.YAxis.MinValue = 0;
            lineChart1.YAxis.Title = "Visitors (in thousands)";
            lineChart1.YAxis.NumberFormat = "N";

            //customize the grid
            lineChart1.GridType = GridType.Vertical;
            lineChart1.Theme.GridLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineChart1.Theme.GridLineColor = Color.FromArgb(192, 192, 192);
            lineChart1.Theme.LegendBackground = new MindFusion.Drawing.SolidBrush(Color.FromArgb(120, 230, 230, 230));
            //stop the grid from moving with the mouse
            lineChart1.PinGrid = true;

            // assign a reb brush for the series
            lineChart1.Plot.SeriesStyle = new MixedSeriesStyle()
            {  
                UniformStrokeThickness = 5,
                UniformStroke = new MindFusion.Drawing.SolidBrush(Color.Red),
                UniformFill = new MindFusion.Drawing.SolidBrush(Color.Red)
            };

            //generate random numbers
            ran = new Random();         
        
            Timer dataTimer = new Timer();
            dataTimer.Tick += new EventHandler(GenerateData);
            dataTimer.Interval = 1000;
            dataTimer.Start();
            
        }

        //generate data and add it to a DateTimeSeries
        private void GenerateData(object sender, EventArgs e)
        {
            dates.Add(DateTime.Now);
            values.Add(2 + ran.NextDouble() * 8.0);

            if (dates.Count > 100)
            {
                dates.RemoveAt(0);
                values.RemoveAt(0);
            }

            //create a new Series
            DateTimeSeries series = new DateTimeSeries(dates, values, dates[0], dates[dates.Count-1]);
            series.MinValue = 0;
			series.MaxValue = 0.1 * dates.Count;
            series.DateTimeFormat = DateTimeFormat.CustomDateTime;
            series.CustomDateTimeFormat = "H:mm:ss";
            series.Title = "Server Requests";

            //check if the data is more than 10     
            if (series.MaxValue > 1)
            {
                lineChart1.XAxis.MaxValue = series.MaxValue;
                lineChart1.XAxis.MinValue = series.MaxValue - 1.0;
            }

            //checl if the series has already been added
            if (lineChart1.Series.Count > 0)
                lineChart1.Series[0] = series;
            else
                lineChart1.Series.Add(series);
            
            
        }
    }
}
