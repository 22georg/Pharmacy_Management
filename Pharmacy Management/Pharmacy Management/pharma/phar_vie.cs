using Pharmacy_Management.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management.pharma
{
    public partial class phar_vie : Form
    {
        public phar_vie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = " Data Source=DESKTOP-SRAA8NA;Initial Catalog=phar;Integrated Security=True\r\n";


            SqlConnection con = new SqlConnection(ConnectionString);


            // open connection
            con.Open();

            //prepare sql query

            string Query = "SELECT * FROM PHARMACY";
            SqlCommand cmd = new SqlCommand(Query, con);


            //excute

            var reader = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(reader);


            dataGridView1.DataSource = dt;


            //Close Connection

            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            phar cua = new phar();
            cua.Show();
            this.Close();
        }
    }
}
