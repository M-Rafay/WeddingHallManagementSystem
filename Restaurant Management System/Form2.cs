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
    public partial class Form2 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\login.accdb;
Persist Security Info=False;";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Table1 where UserName='" + textBox2.Text + "'and Password='" + textBox1.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("correct");
                Form5 f = new Form5();
                f.Show();
                this.Hide();

            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate User Name and Password !");
            }
            else
            {
                MessageBox.Show("invalid");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
      
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                connection.Open();

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void textBox2_Enter(object sender, DragEventArgs e)
        {
            if (textBox2.Text == "USER NAME")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "USER NAME";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "PASSWORD";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "PASSWORD")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
