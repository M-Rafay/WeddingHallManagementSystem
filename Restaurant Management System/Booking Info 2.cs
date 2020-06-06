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
    public partial class Booking_Info_2 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Booking_Info_2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\login.accdb;
Persist Security Info=False;";
        }

        private void Booking_Info_2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payment_Info f = new Payment_Info();
            f.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            NametextBox.Clear();
            EmailtextBox.Clear();
            PhonenumbertextBox.Clear();
            EventSessiontextBox.Clear();
            EventTypetextBox.Clear();
            AddresstextBox.Clear();
            AssignHalltextBox.Clear();
            EstimatedGueststextBox.Clear();
            AdvancetextBox.Clear();
            CitytextBox.Clear();
            TotalAmounttextBox.Clear();
        }

        private void BookinginfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                


                DataGridViewRow row = BookinginfoDataGridView.Rows[e.RowIndex];
                IDtextBox.Text = row.Cells[0].Value.ToString();
                NametextBox.Text = row.Cells[1].Value.ToString();
                AddresstextBox.Text = row.Cells[2].Value.ToString();
                PhonenumbertextBox.Text = row.Cells[3].Value.ToString();
                EmailtextBox.Text = row.Cells[4].Value.ToString();
                CitytextBox.Text = row.Cells[5].Value.ToString();
                EventSessiontextBox.Text = row.Cells[6].Value.ToString();
                EventTypetextBox.Text = row.Cells[7].Value.ToString();
                EstimatedGueststextBox.Text = row.Cells[8].Value.ToString();
                AdvancetextBox.Text = row.Cells[9].Value.ToString();
                EventDatedateTimePicker.Text = row.Cells[10].Value.ToString();
                AssignHalltextBox.Text = row.Cells[12].Value.ToString();
                TotalAmounttextBox.Text = row.Cells[13].Value.ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from BookingData";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                BookinginfoDataGridView.DataSource = dt;
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        public string update_1()
        {
            string query = "update BookingData set Name='" + NametextBox.Text + "', Email='" + EmailtextBox.Text + "', PhoneNumber='" + PhonenumbertextBox.Text + "', EventSession='" + EventSessiontextBox.Text + "', EventType='" + EventTypetextBox.Text + "', NumberOfGuests='" + EstimatedGueststextBox.Text + "', AdvancePayment='" + AdvancetextBox.Text + "', Address='" + AddresstextBox.Text + "', City='" + CitytextBox.Text + "',TotalAmount='" + TotalAmounttextBox.Text + "' ,AssigningHall='" + AssignHalltextBox.Text + "', EventDate='" + EventDatedateTimePicker.Text + "'  where ID =" + IDtextBox.Text + "";

            return query;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string s = update_1();
                MessageBox.Show(s);
                command.CommandText = s;

                command.ExecuteNonQuery();
                MessageBox.Show("data edit successful");
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "delete from BookingData where ID =" + IDtextBox.Text + " ";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("data deleted successful");
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                BookinginfoDataGridView.DataSource = dt;
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
