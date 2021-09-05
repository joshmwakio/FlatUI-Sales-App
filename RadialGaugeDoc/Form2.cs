using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadialGaugeDoc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //create an instance of Bunifu Radial Gauge
            BunifuRadialGauge radialGauge = new BunifuRadialGauge();
            //set the scale for the gauge
            radialGauge.Minimum = 0;
            radialGauge.Maximum = 50;
            //set an initial value for the radial gauge
            radialGauge.Value = 35;
            //set a warning mark value for color change
            radialGauge.WarningMark = 25;
            //set the location of the radial gauge
            radialGauge.Location = new Point(300, 165);
            //add the control to the form
            this.Controls.Add(radialGauge);
        }
    }
}
