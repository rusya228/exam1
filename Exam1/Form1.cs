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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
