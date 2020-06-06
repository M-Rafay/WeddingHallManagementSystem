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
    public partial class search : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public search()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\login.accdb;
Persist Security Info=False;";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM BookingData WHERE Capacity LIKE '" + comboBox3.Text + "%'";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                /* DataView DV = new DataView(dt);
                DV.RowFilter = string.Format("Name LIKE '%{0}%'", NametextBox.Text);
                BookinginfoDataGridView.DataSource = DV;
                 */
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }
    }
}
