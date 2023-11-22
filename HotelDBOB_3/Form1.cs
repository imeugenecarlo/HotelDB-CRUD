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
using System.Xml.Linq;

namespace HotelDBOB_3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            //SQL connection for database
            conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=HotelDB1;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            //Tekst boks for at vise Databasen er forbundet
            MessageBox.Show("connected");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
                string query = $"insert into facility values('{Facility_ID_textBox.Text.ToString()}','{Hotel_No_textBox.Text.ToString()}','{Facility_Name_textBox.Text}')";
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                cleardata();
                conn.Close();
                displaydata();
        }
        private void cleardata()
            {
                Facility_ID_textBox.Clear();
                Facility_Name_textBox.Clear();
                Hotel_No_textBox.Clear();
                //Hotel_name_textBox.Clear();
            }

        private void Update_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update facility set Facility_name='" + Facility_Name_textBox.Text + /*"',Hotel name='" + Hotel_name_textBox.Text +*/ "',Hotel_No='" + Hotel_No_textBox.Text.ToString() + "' where facility_no='" + Facility_ID_textBox.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void Show_all_button_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from facility";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string query = $"delete from facility where facility_no='{Facility_ID_textBox.Text.ToString()}'AND hotel_no='{Hotel_No_textBox.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void button1_Click(object sender, EventArgs e) //Find button
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Facility where facility_no='" + Find_textBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Facility_Name_textBox.Text = dt.ToString();
            //Hotel_name_textBox.Text = dt.ToString();
            Hotel_No_textBox.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Facility_ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
