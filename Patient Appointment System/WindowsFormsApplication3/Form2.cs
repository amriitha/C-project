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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string Gender;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
         SqlDataAdapter ada = new SqlDataAdapter("select isnull (max(cast(id as varchar)),10000)+1 from DOCTOR",con);
         DataTable dt = new DataTable();
         ada.Fill(dt);
         textBox12.Text =  dt.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into DOCTOR values('" + textBox1.Text + "', '" + textBox2.Text + "','" + Gender + "','" + textBox4.Text + "'," + textBox5.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'," + textBox9.Text + ",'" + textBox10.Text + "','" + dateTimePicker1.Text + "','" + textBox11.Text + "','" + textBox12.Text + "');", con);
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o+" :record has been inserted");
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
            textBox11.Text = (days / 365).ToString("0");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "female";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
