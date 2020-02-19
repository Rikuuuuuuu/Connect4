using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Connect4
{
    public partial class Pisteet : Form
    {
        public Pisteet()
        {
            InitializeComponent();
        }

        private void Pisteet_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = ConnectFourScore;User ID=LAPTOP-Q131GA2D\ruots;Trusted_Connection=yes;");
            conn.Open();

            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Score", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;


            conn.Close();

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
