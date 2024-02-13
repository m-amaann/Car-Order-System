using Car_Traders.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Traders.Screens.dashboard
{
    public partial class CarsForm : Form
    {
        private readonly CarController carController;


        public CarsForm()
        {
            InitializeComponent();
            carController = new CarController();
        }


        private void CarsForm_Load(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void CarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ClearFields()
        {
            txtCarName.Text = "";
            txtManufacturer.Text = "";
            txtYear.Text = "";
            ModelComboBox.SelectedIndex = -1;
            FuelTypeComboBox.SelectedIndex = -1;
            ColorComboBox.SelectedIndex = -1;
            txtPrice.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string carName = txtCarName.Text;
                string manufacturer = txtManufacturer.Text;
                int year = Convert.ToInt32(txtYear.Text);
                string model = ModelComboBox.SelectedItem?.ToString();
                string fuelType = FuelTypeComboBox.SelectedItem?.ToString();
                string color = ColorComboBox.SelectedItem?.ToString();
                decimal price = Convert.ToDecimal(txtPrice.Text); // Change price to decimal

                if (string.IsNullOrEmpty(carName) || string.IsNullOrEmpty(manufacturer) ||
                    string.IsNullOrEmpty(model) || string.IsNullOrEmpty(fuelType) ||
                    string.IsNullOrEmpty(color) || price <= 0) // Price should be positive
                {
                    MessageBox.Show("Please fill in all fields and enter a valid price.");
                    return;
                }

                bool success = carController.AddCar(carName, model, manufacturer, year, fuelType, color, price);

                if (success)
                {
                    MessageBox.Show("Car added successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add car.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
