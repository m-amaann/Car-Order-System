using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Car_Traders.Controller
{
    public class AdminClass
    {
        private readonly string connectionString;

        public AdminClass()
        {
            connectionString = Properties.Settings.Default.DBConnection;
        }


        //Admin Login Function
        public bool AdminLogin(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Admins WHERE Email = @Email AND Password = @Password;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password); // Plain text password comparison

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
    

