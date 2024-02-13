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
    public partial class UsersForm : Form
    {
        private readonly CustomersController customersController;
        private DataTable usersTable;

        public UsersForm()
        {
            InitializeComponent();
            customersController = new CustomersController();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = UserSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                UsersDataGrid.DataSource = usersTable;
                return;
            }

            DataView dv = new DataView(usersTable);
            dv.RowFilter = $"Username LIKE '%{searchText}%' OR Email LIKE '%{searchText}%' OR PhoneNumber LIKE '%{searchText}%'";
            UsersDataGrid.DataSource = dv.ToTable();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            /*PopulateUsersDataGridView();*/
            usersTable = customersController.GetAllUsers();
            UsersDataGrid.DataSource = usersTable;
        }


/*        private void PopulateUsersDataGridView()
        {
            DataTable usersTable = customersController.GetAllUsers();
            UsersDataGrid.DataSource = usersTable;
        }*/
    }
}
