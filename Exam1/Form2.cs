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


namespace Exam1
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"");
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "dsfs";
            if (conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            string s = $"SELECT * from {comboBox1.Text} ";
            SqlCommand cmd = new SqlCommand(s,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            string s = $"SELECT * from {comboBox1.Text} ";
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
