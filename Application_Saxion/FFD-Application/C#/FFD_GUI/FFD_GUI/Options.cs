using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFD_GUI
{
    public partial class Options : Form
    {
        private Main mainForm = null;
        public Options(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as Main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Apply_sensor1_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor1_y = nudY1.Text;
            this.mainForm.value_sensor1_x = nudX1.Text;
            this.mainForm.value_sensor1_d1 = dng11.Text;
            this.mainForm.value_sensor1_d2 = dng12.Text;
            this.mainForm.value_sensor1_d3 = dng13.Text;
            this.mainForm.calibration1 = cal1.Text;
        }
        private void alert(string text)
        {
            alert_messege.Icon = Icon;
            alert_messege.Visible = true;
            alert_messege.ShowBalloonTip(5000, "Saxion Lab", text, ToolTipIcon.Error);
        }

        private void Sensor1_yaxis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label79_Click(object sender, EventArgs e)
        {

        }

        private void BtnAxisFit_Click(object sender, EventArgs e)
        {

        }

        private void Button24_Click(object sender, EventArgs e)
        {

        }

        private void Dng2_3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown15_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown27_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown63_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown60_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown21_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown46_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dng735_ValueChanged(object sender, EventArgs e)
        {

        }

        private void H_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor2_y = nudY2.Text;
            this.mainForm.value_sensor2_x = nudX2.Text;
            this.mainForm.value_sensor2_d1 = dng21.Text;
            this.mainForm.value_sensor2_d2 = dng22.Text;
            this.mainForm.value_sensor2_d3 = dng23.Text;
            this.mainForm.calibration2 = cal2.Text;
        }

        private void Apply_sensor3_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor3_y = nudY3.Text;
            this.mainForm.value_sensor3_x = nudX3.Text;
            this.mainForm.value_sensor3_d1 = dng31.Text;
            this.mainForm.value_sensor3_d2 = dng32.Text;
            this.mainForm.value_sensor3_d3 = dng33.Text;
            this.mainForm.calibration3 = cal3.Text;
        }

        private void Apply_sensor4_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor4_y = nudY4.Text;
            this.mainForm.value_sensor4_x = nudX4.Text;
            this.mainForm.value_sensor4_d1 = dng41.Text;
            this.mainForm.value_sensor4_d2 = dng42.Text;
            this.mainForm.value_sensor4_d3 = dng43.Text;
            this.mainForm.calibration4 = cal4.Text;
        }

        private void Apply_sensor5_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor5_y = nudY5.Text;
            this.mainForm.value_sensor5_x = nudX5.Text;
            this.mainForm.value_sensor5_d1 = dng51.Text;
            this.mainForm.value_sensor5_d2 = dng52.Text;
            this.mainForm.value_sensor5_d3 = dng53.Text;
            this.mainForm.calibration5 = cal5.Text;
        }

        private void Apply_sensor6_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor6_y = nudY6.Text;
            this.mainForm.value_sensor6_x = nudX6.Text;
            this.mainForm.value_sensor6_d1 = dng61.Text;
            this.mainForm.value_sensor6_d2 = dng62.Text;
            this.mainForm.value_sensor6_d3 = dng63.Text;
            this.mainForm.calibration6 = cal6.Text;
        }

        private void Apply_sensor7_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor7_y = nudY7.Text;
            this.mainForm.value_sensor7_x = nudX7.Text;
            this.mainForm.value_sensor7_d1 = dng71.Text;
            this.mainForm.value_sensor7_d2 = dng72.Text;
            this.mainForm.value_sensor7_d3 = dng73.Text;
            this.mainForm.calibration7 = cal7.Text;
        }

        private void Apply_sensor8_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor8_y = nudY8.Text;
            this.mainForm.value_sensor8_x = nudX8.Text;
            this.mainForm.value_sensor8_d1 = dng81.Text;
            this.mainForm.value_sensor8_d2 = dng82.Text;
            this.mainForm.value_sensor8_d3 = dng83.Text;
            this.mainForm.calibration8 = cal8.Text;
        }

        private void Apply_sensor9_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor9_y = nudY9.Text;
            this.mainForm.value_sensor9_x = nudX9.Text;
            this.mainForm.value_sensor9_d1 = dng91.Text;
            this.mainForm.value_sensor9_d2 = dng92.Text;
            this.mainForm.value_sensor9_d3 = dng93.Text;
            this.mainForm.calibration9 = cal9.Text;
        }

        private void Apply_sensor10_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor10_y = nudY10.Text;
            this.mainForm.value_sensor10_x = nudX10.Text;
            this.mainForm.value_sensor10_d1 = dng101.Text;
            this.mainForm.value_sensor10_d2 = dng102.Text;
            this.mainForm.value_sensor10_d3 = dng103.Text;
            this.mainForm.calibration10 = cal10.Text;
        }

        private void Apply_sensor11_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor11_y = nudY11.Text;
            this.mainForm.value_sensor11_x = nudX11.Text;
            this.mainForm.value_sensor11_d1 = dng111.Text;
            this.mainForm.value_sensor11_d2 = dng112.Text;
            this.mainForm.value_sensor11_d3 = dng113.Text;
            this.mainForm.calibration11 = cal11.Text;
        }

        private void Apply_sensor12_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor12_y = nudY12.Text;
            this.mainForm.value_sensor12_x = nudX12.Text;
            this.mainForm.value_sensor12_d1 = dng121.Text;
            this.mainForm.value_sensor12_d2 = dng122.Text;
            this.mainForm.value_sensor12_d3 = dng123.Text;
            this.mainForm.calibration12 = cal12.Text;
        }


        private void Button13_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void Label79_Click_1(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("https://www.saxion.nl/onderzoek/smart-industry/advanced-forensic-technology");
            }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor14_d1 = dng141.Text;
            this.mainForm.value_sensor14_d2 = dng142.Text;
            this.mainForm.value_sensor14_d3 = dng143.Text;
        }

        private void Apply_sensor15_Click(object sender, EventArgs e)
        {
            this.mainForm.value_sensor15_d1 = dng151.Text;
            this.mainForm.value_sensor15_d2 = dng152.Text;
            this.mainForm.value_sensor15_d3 = dng153.Text;
        }

        private void Dng93_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
