using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Adiciona o evento Load para verificar a conexão com o banco de dados quando o formulário é carregado
            this.Load += MainWindow_Load;
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees empWindow = new Employees();
            empWindow.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento Load do formulário principal
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Chama o método que verifica a conexão com o banco de dados quando o formulário é carregado
            CheckDatabaseConnection();
        }

        // Método para verificar a conexão com o banco de dados
        private void CheckDatabaseConnection()
        {
            try
            {
                // Tenta abrir uma conexão com o banco de dados utilizando as informações da classe DatabaseManager
                using (MySqlConnection connection = new MySqlConnection(DatabaseManager.DatabaseConnection.ConnectionString))
                {
                    connection.Open();
                    // Se chegou até aqui, a conexão foi bem-sucedida
                    lblTestDb.Text = "Database connection successful!";
                }
            }
            catch (Exception ex)
            {
                // Se houver um erro, exibe a mensagem no rótulo
                lblTestDb.Text = $"Error connecting to the database: {ex.Message}";
            }
        }
    }
}
