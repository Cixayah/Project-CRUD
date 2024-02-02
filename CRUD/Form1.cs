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

            // Adiciona o evento Load para verificar a conex�o com o banco de dados quando o formul�rio � carregado
            this.Load += MainWindow_Load;
        }

        private void funcion�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees empWindow = new Employees();
            empWindow.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento Load do formul�rio principal
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Chama o m�todo que verifica a conex�o com o banco de dados quando o formul�rio � carregado
            CheckDatabaseConnection();
        }

        // M�todo para verificar a conex�o com o banco de dados
        private void CheckDatabaseConnection()
        {
            try
            {
                // Tenta abrir uma conex�o com o banco de dados utilizando as informa��es da classe DatabaseManager
                using (MySqlConnection connection = new MySqlConnection(DatabaseManager.DatabaseConnection.ConnectionString))
                {
                    connection.Open();
                    // Se chegou at� aqui, a conex�o foi bem-sucedida
                    lblTestDb.Text = "Database connection successful!";
                }
            }
            catch (Exception ex)
            {
                // Se houver um erro, exibe a mensagem no r�tulo
                lblTestDb.Text = $"Error connecting to the database: {ex.Message}";
            }
        }
    }
}
