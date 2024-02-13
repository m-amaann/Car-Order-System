using Car_Traders.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Car_Traders.Screens.customer
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Emailtxtbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoginBtn1_Click(object sender, EventArgs e)
        {

            string email = Emailtxtbox.Text;
            string password = PasstxtBox.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                System.Windows.Forms.MessageBox.Show("Please enter both email and password.");
                return;
            }

            // Check login credentials
            CustomersController controller = new CustomersController();
            bool loginSuccess = controller.Login(email, password);

            if (loginSuccess)
            {
                System.Windows.MessageBox.Show("Login successful!");
                this.Close();

                // Get the user's first name
                string firstName = controller.GetFirstName(email);

                UserDashboard home_Form = new UserDashboard(firstName);
                home_Form.Show();
            }
            else
            {
                System.Windows.MessageBox.Show("Login failed. Invalid email or password.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ToRegisterForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void PasstxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        //new Screens.customer.RegisterForm().Show();
    }
}
