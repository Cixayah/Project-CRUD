using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            txtName.Enabled = false;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseManager.DatabaseConnection.ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
