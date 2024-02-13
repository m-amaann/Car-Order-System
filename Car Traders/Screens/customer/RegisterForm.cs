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

namespace Car_Traders.Screens.customer
{

    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Retrieve values from input fields
            string firstName = Firstltxtbox.Text;
            string lastName = Lastltxtbox.Text;
            string username = Usernameltxtbox.Text;
            string email = Emailtxtbox.Text;
            string password = PasstxtBox.Text;
            string phoneNumber = Phonetxtbox.Text;
            string address = Addressltxtbox.Text;

            // Check if required fields are empty
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Attempt to register the customer
            CustomersController controller = new CustomersController();
            bool registrationSuccess = controller.Register(firstName, lastName, username, password, email, phoneNumber, address);

            if (registrationSuccess)
            {
                MessageBox.Show("Registration successful!");

                // Clear fields
                ClearFields();

                // Optionally, navigate to the login form
                Login_Form login = new Login_Form();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }



        // Method to clear all input fields
        private void ClearFields()
        {
            Firstltxtbox.Clear();
            Lastltxtbox.Clear();
            Usernameltxtbox.Clear();
            Emailtxtbox.Clear();
            PasstxtBox.Clear();
            Phonetxtbox.Clear();
            Addressltxtbox.Clear();
        }
    }
}
