namespace CRUD
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void funcion�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees EmpWindow = new Employees();
            EmpWindow.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
