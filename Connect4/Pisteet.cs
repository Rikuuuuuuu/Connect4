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
        //Datagridin bindaaminen sql tauluun
        private void Pisteet_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pisteet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            conn.Open();

            SqlDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Nimi,Väri,Pvm from score", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataAdapter adapter;
            DataTable data = new DataTable();
            adapter = new SqlDataAdapter("select Nimi,Väri,Pvm from Havio", conn);
            adapter.Fill(data);
            dataGridView2.DataSource = data;

            conn.Close();
        }
        //Paluu Main menuun menu stripin kautta
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.ShowDialog();
        }
        //Formin sulkeminen menu stripin kautta
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Paluu Main menuun
        private void button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.ShowDialog();
        }
        //Formin sulkeminen rastista painamalla
        private void Pisteet_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
