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

namespace Pharmacy_Management.customer
{
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administor a =new Administor();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_user_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-SRAA8NA;Initial Catalog=admin_addu;Integrated Security=True";

            //establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //open connection

            con.Open();

            //prepare query

            string MId = textBox1.Text;
            string Name = textBox2.Text;
            string Passworda = textBox3.Text;
            string Birthday = textBox5.Text;
            string Roleofuser = textBox4.Text;
            string Contact = textBox6.Text;


            string Query = "INSERT INTO ADDUSER ( MId,Name , Passworda,Birthday,Roleofuser,Contact) VALUES ('" + MId + "','" + Name + "' ,'" + Passworda + "','" + Birthday + "','" + Roleofuser + "','" + Contact + "')";


            //excute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //close Connection
            con.Close();

            MessageBox.Show("Date Has Been Saved");


        }
    }
}
