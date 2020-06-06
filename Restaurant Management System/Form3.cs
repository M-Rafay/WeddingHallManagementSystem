using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Restaurant_Management_System
{
    
    public partial class Form3 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\login.accdb;
Persist Security Info=False;";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

  

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //string query = "SELECT AssigningHall,EventDate FROM BookingData  ";
                //command.CommandText = query;
                
                command.CommandText = "insert into BookingData (Name,PhoneNumber,Address,AdvancePayment,EventSession,EventType,NumberOfGuests,AssigningHall,Email,City,TotalAmount,EventDate) values('" + txt_name.Text + "','" + txt_phone.Text + "','" + txt_address.Text + "','" + txt_advance.Text + "','" + session.Text + "','" + type.Text + "','" + guests.Text + "','" + assigning_hall.Text + "','" + txt_email.Text + "','" + txt_city.Text + "','" + Total_textBox.Text + "','" + date.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("data saved");
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
