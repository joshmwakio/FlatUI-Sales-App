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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuRadialGauge1.ProgressColorLow = Color.FromArgb(232, 74, 208);
            }
            else if(bunifuDropdown1.SelectedIndex == 1)
            {
                bunifuRadialGauge1.ProgressColorLow = Color.FromArgb(120, 188, 97);
            }
            else
            {
                bunifuRadialGauge1.ProgressColorLow = Color.FromArgb(131, 128, 182);
            }
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuRadialGauge1.ValueByTransition = e.Value;
        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuRadialGauge1.Update();
                bunifuRadialGauge1.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
                bunifuRadialGauge1.Refresh();
               
            }
            else
            {
                bunifuRadialGauge1.Update();
                bunifuRadialGauge1.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Round;
             
            }
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuRadialGauge1.ProgressColorHigh = Color.FromArgb(247, 100, 107);
            }
            else
            {                
                bunifuRadialGauge1.ProgressColorHigh = Color.FromArgb(241, 245, 23);
                bunifuRadialGauge1.Update();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bunifuRadialGauge1.Value = 0;
            bunifuRadialGauge1.TransitionValue(72, 1500);
        }
    }
}
