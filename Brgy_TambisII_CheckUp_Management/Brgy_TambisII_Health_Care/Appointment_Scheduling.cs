using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Brgy_TambisII_Health_Care
{
    public partial class Appointment_Scheduling : Form
    {
        public Appointment_Scheduling()
        {
            InitializeComponent();
        }
        private int id = 1;

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Hide();
            db.Show();
        }

        public void testingP()
        {
            int desiredLength = 11;

            // Check if the length of the text in the TextBox is not equal to the desired length
            if (tbContact.Text.Length != desiredLength)
            {
                number = true;
            }
            else
            {
                number = false;
            }
        }
        bool number = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            testingP();

            if (number == true)
            {
                number = false;
                MessageBox.Show("Phone Numbers too Short", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                // Continue with the insertion query and the rest of the code...
                DateTime birthdate = dtpBirth.Value;
                int year = birthdate.Year;
                int month = birthdate.Month;
                int day = birthdate.Day;

                // Validate email address
                string email = tbEAdd.Text.Trim();
                if (!email.ToLower().EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Invalid email address. Please enter a valid Gmail address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method without executing the insertion query
                }

                string query = "INSERT INTO appointment(residentid, firstname, middlename, lastname, gender, dateofbirth, age, status, contactno, emailaddress,statusA ) VALUES (" + lblResidentID.Text + ",'" + tbFName.Text + "','" + tbMName.Text + "','" + tbLName.Text + "','" +
                                cbGender.Text + "','" + year + "-" + month + "-" + day + "','" + tbAge.Text + "','" + cbStatus.Text + "','" + tbContact.Text + "','" + email + "','1' );";

                MySqlCommand command = new MySqlCommand(query, connect);
                command.CommandTimeout = 60;

                try
                {
                    connect.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Saved");
                        tbFName.Clear();
                        tbMName.Clear();
                        tbLName.Clear();
                        dtpBirth.ResetText();
                        tbAge.Clear();
                        cbGender.ResetText();
                        cbStatus.ResetText();
                        tbContact.Clear();
                        tbEAdd.Clear();
                        id++;
                        lblResidentID.Text = id.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Save");
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void Appointment_Scheduling_Load(object sender, EventArgs e)
        {
           
                string query = "SELECT count(*) from appointment";
                MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command = new MySqlCommand(query, connect);

                connect.Open();
                long rowCount = (long)command.ExecuteScalar();
                connect.Close();
                if (rowCount == 0)
                {
                    lblResidentID.Text = id.ToString();
                }
                else
                {
                    string query2 = "SELECT residentId from appointment order by residentId desc limit 1;";
                    MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
                    MySqlCommand command2 = new MySqlCommand(query2, connect2);
                    connect2.Open();
                    id = (int)command2.ExecuteScalar();
                    id += 1;
                    lblResidentID.Text = id.ToString();
                    connect2.Close();
                }
        }

       
        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 46)
            {
                e.Handled = true;
            }
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 46)
            {
                e.Handled = true;
            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
