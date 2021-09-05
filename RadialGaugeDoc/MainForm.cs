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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int saleValue = 0;
        int initialSaleValue = 220000;
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            Random random1 = new Random();
            Random random2 = new Random();
            saleValue = random.Next(122000, 400000);
            int revenueValue = random.Next(4, 15);
            int customerValue = random.Next(12, 30);

            salesBunifuRadialGauge.TransitionValue(saleValue, 270);
            bunifuRadialGauge2.TransitionValue(revenueValue, 270);
            bunifuRadialGauge3.TransitionValue(customerValue, 270);
            totalSalesBunifuLabel.Text = (0).ToString();
            timer1.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int totalSales = Convert.ToInt32(totalSalesBunifuLabel.Text);

            if (totalSales<saleValue)
            {
                totalSalesBunifuLabel.Text= (totalSales += 20000).ToString();
            }
            else
            {
                timer1.Stop();
                totalSalesBunifuLabel.Text = saleValue.ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            bunifuRadialGauge2.TransitionValue(7, 3300);
            bunifuRadialGauge3.TransitionValue(25,2310);
            salesBunifuRadialGauge.TransitionValue(initialSaleValue, 3300);
            timer2.Start();
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int totalSales = Convert.ToInt32(totalSalesBunifuLabel.Text);
            if (totalSales < initialSaleValue)
            {
                totalSalesBunifuLabel.Text = (totalSales += 10763).ToString();
            }
            else
            {
                timer2.Stop();
                totalSalesBunifuLabel.Text = initialSaleValue.ToString();
            }
        }
    }
}
