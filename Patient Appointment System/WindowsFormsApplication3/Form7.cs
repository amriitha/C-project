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

namespace WindowsFormsApplication3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from appoinment where  d_id='"+textBox1.Text +"' and date=convert(varchar,'" + dateTimePicker2.Text + "',101);", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into approve values('" + textBox2.Text + "', '" + textBox3.Text + "',convert(varchar(50),'" + dateTimePicker1.Text + "'));", con);
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + " :approve has been recorded");
            con.Close();
            Form7 objform1 = new Form7();
            this.Hide();
            objform1.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
