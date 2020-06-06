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
    public partial class Payment_Info : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Payment_Info()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\login.accdb;
Persist Security Info=False;";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                double Am = Convert.ToDouble(RemainingtextBox.Text) - Convert.ToDouble(PaymenttextBox.Text);
                double Ad = Convert.ToDouble(AdvtextBox.Text) + Convert.ToDouble(PaymenttextBox.Text);
                if (Ad>=0)
                {
                    string query = "update BookingData set AdvancePayment='" + Ad + "' where ID =" + IDtextBox.Text + " ";
                    MessageBox.Show(query);
                    command.CommandText = query;
                    if (Am == 0)
                        MessageBox.Show("Amount paid ");
                    else if (Am > 0)
                        MessageBox.Show("Amount is not fully paid ");
                }
                



                command.ExecuteNonQuery();
                MessageBox.Show("data saved");
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                IDtextBox.Clear();
                AdvtextBox.Clear();
                TotalAmounttextBox.Clear();
                RemainingtextBox.Clear();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from BookingData";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT * FROM BookingData WHERE ID LIKE '" + IDtextBox.Text + "%'";
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDtextBox.Text = row.Cells[0].Value.ToString();
                AdvtextBox.Text = row.Cells[9].Value.ToString();
                RemainingtextBox.Text = row.Cells[11].Value.ToString();
                TotalAmounttextBox.Text = row.Cells[13].Value.ToString();

            }
        }
    }
}
