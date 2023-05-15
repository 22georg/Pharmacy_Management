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
    public partial class add_vieuser : Form
    {
        public add_vieuser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administor ad = new Administor();
            ad.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-SRAA8NA;Initial Catalog=admin_addu;Integrated Security=True";


            SqlConnection con = new SqlConnection(ConnectionString);


            // open connection
            con.Open();

            //prepare sql query

            string Query = "SELECT*FROM ADDUSER";
            SqlCommand cmd = new SqlCommand(Query, con);


            //excute

            var reader = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(reader);


            dataGridView1.DataSource = dt;


            //Close Connection

            con.Close();
        }
    }
}
