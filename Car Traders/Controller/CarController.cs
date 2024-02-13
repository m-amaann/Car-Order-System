using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;



namespace Car_Traders.Controller
{
    public class CarController
    {
        private readonly string connectionString;

        public CarController()
        {
            connectionString = Properties.Settings.Default.DBConnection;
        }


        //
        public bool AddCar(string carName, string model, string manufacturer, int year, string fuelType, string color, decimal price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Product (CarName, Model, Manufacturer, Year, FuelType, Color, Price)
                             VALUES (@CarName, @Model, @Manufacturer, @Year, @FuelType, @Color, @Price);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarName", carName);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@FuelType", fuelType);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@Price", price);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

    }
}
