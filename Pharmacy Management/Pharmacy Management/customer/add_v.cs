using Pharmacy_Management.customer;
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

namespace Pharmacy_Management.admin
{
    public partial class add_v : Form
    {
        public add_v()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-SRAA8NA;Initial Catalog=view_adm;Integrated Security=True";


            SqlConnection con = new SqlConnection(ConnectionString);


            // open connection
            con.Open();

            //prepare sql query

            string Query = "SELECT*FROM adm";
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
            custo cua = new custo();
            cua.Show();
            this.Close();
        }
    }
}
