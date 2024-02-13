using Car_Traders.Screens.customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Traders
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int starttime = 0;

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            starttime += 1;
            ProgressBar.Value = starttime;
            if(ProgressBar.Value == 100) 
            {
                ProgressBar.Value = 0;
                SplashTimer.Stop();

                Main home = new Main();
                home.Show();
                this.Hide();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashTimer.Start();
        }
    }
}
