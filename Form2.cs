using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desktop_app_demo
{
    public partial class Form2 : Form
    {
       
       string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.net\\desktop-app-demo\\simplereg.mdf;Integrated Security=True";
        string gender;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO Registration values ('"+nametxt.Text+"','"+passwordtxt.Text+"','"+branchtxt.SelectedItem.ToString()+"','"+citytxt.SelectedItem.ToString()+"','"+gender+"')";
            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Submitted Successfully");

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void branchtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
