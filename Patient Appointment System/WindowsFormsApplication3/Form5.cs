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
   
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
       // string b;
       // string c;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            FillCombobox();
           
           
        }
         protected void FillCombobox()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            DataSet ds = new DataSet();
           
                conn.Open();
                SqlCommand cmd = new SqlCommand("select id,name from DOCTOR group by id, name", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);              
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = ds.Tables[0];
            }
       
       
        private void button3_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into appoinment values('" + textBox1.Text + "',convert(varchar(50),'" + dateTimePicker1.Text + "'),'" + comboBox1.Text + "','" + textBox2.Text + "');", con);
            
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + " :Appoinment has been sent");

            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
           /* con.Close();
            c = textBox1.Text;
            Form3 f = new Form3();
            f.cd(c.ToString());
            f.Show();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GKVUTI7;Initial Catalog=HOSPITAL;Integrated Security=True");
            
            SqlDataAdapter sda = new SqlDataAdapter("select name,id from DOCTOR where name like'" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
