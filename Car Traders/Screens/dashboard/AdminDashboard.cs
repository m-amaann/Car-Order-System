using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Traders.Screens.dashboard
{
    public partial class AdminDashboard : Form
    {
        //Fields
        /*private Button currentButton;*/
        /*private Random random;*/
        /*private int tempIndex;*/
        private Form activeForm;



        public AdminDashboard()
        {
            InitializeComponent();
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
           /* ActivateButton(btnSender);*/
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();

            lblTitle.Text = childForm.Text;
            childForm.Show();
        }



        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Screens.dashboard.AdminLogin().Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Screens.dashboard.UsersForm(), sender);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Screens.dashboard.CarsForm(), sender);
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
