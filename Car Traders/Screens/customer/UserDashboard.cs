using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Car_Traders.Screens.customer
{
    public partial class UserDashboard : Form
    {
        private string userName;

        /*private Button currentButton;*/
        private Random random;
        private Form activeForm;
        public UserDashboard(string firstName)
        {
            random = new Random();
            InitializeComponent();

            userName = firstName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Screens.customer.Login_Form().Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Welcome, " + userName;
        }




        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();

            childForm.Show();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Screens.customer.UserCarParts(), sender);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Screens.customer.UserCar(), sender);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Screens.customer.OrdersForm(), sender);
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
