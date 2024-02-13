using Car_Traders.Controller;
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
    public partial class AdminLogin : Form
    {
/*        private bool isPasswordVisible = false;
*/
        private readonly AdminClass adminController;

        public AdminLogin()
        {
            InitializeComponent();
            adminController = new AdminClass();
        }

        private void PasstxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn1_Click(object sender, EventArgs e)
        {
            string email = Usertxtbox.Text;
            string password = PasstxtBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            bool loginSuccess = adminController.AdminLogin(email, password);

            if (loginSuccess)
            {
                MessageBox.Show("Admin login successful!");
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin login failed. Invalid email or password.");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // Initially set password textbox to use system password char
            PasstxtBox.UseSystemPasswordChar = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkTogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            PasstxtBox.UseSystemPasswordChar = !checkTogglePassword.Checked;
        }
    }
}
