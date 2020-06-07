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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string Gender;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into patientreg values('" + textBox1.Text + "', '" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + Gender + "','" + textBox5.Text + "'," + textBox6.Text + ",'" + textBox7.Text + "','" + textBox8.Text + "','" + textBox2.Text + "');", con);
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + " :record has been inserted");
            con.Close();
            Form1 objform1 = new Form1();
            this.Hide();
            objform1.Show();
        }
        public static void main(string[] args)
        {
            Application.Run(new Form2());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            textBox3.Text = (days / 365).ToString("0");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            SqlDataAdapter ada = new SqlDataAdapter("select isnull (max(cast(id as int)),0)+1 from patientreg", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            textBox2.Text = dt.Rows[0][0].ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "female";
        }
    }
}
