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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://robor.nl");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.saxion.nl/onderzoek/smart-industry/advanced-forensic-technology");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.brandweer.nl/twente");
        }
    }
}
