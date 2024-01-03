using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brgy_TambisII_Health_Care
{
    public partial class Patient : Form
    {
        public Patient()
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


        public void load()
        {
            string query = "SELECT * FROM appointment WHERE residentid = '" + Connection.IdContent + "'";

            using (MySqlConnection connect = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connect))
                {
                    command.CommandTimeout = 60;

                    try
                    {
                        connect.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    lblResidentID1.Text = reader.GetString(0);
                                    tbFName1.Text = reader.GetString(1);
                                    tbMName1.Text = reader.GetString(2);
                                    tbLName1.Text = reader.GetString(3);
                                    cbGender1.Text = reader.GetString(4);
                                    dtpBirth.Text = reader.GetString(6);


                                }
                            }
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Query error: " + x.Message);
                    }
                }
            }
        }

        private void CheckUp_Load(object sender, EventArgs e)
        {

            load();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {

            DateTime birthdate = dtpBirth.Value;

            int year = birthdate.Year;
            int day = birthdate.Day;
            int month = birthdate.Month;



            string query = "UPDATE appointment SET firstname = '" + tbFName1.Text + "', middlename = '" + tbMName1.Text + "' , lastname ='" + tbLName1.Text + "' , gender = '" +  cbGender1.Text + "' , dateofbirth = '" + year +"-" + month +"-"+ day +"' WHERE residentid = " + Connection.IdContent +"";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                }
                else
                {

                    MessageBox.Show("Successfully Updated");

                    lblResidentID1.ResetText();
                    tbFName1.Clear();
                    tbMName1.Clear();
                    tbLName1.Clear();
                    cbGender1.ResetText();
                    dtpBirth.ResetText();
                    load();
                    
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }


        }

        private void btnCheckUP_Click_1(object sender, EventArgs e)
        {
            Connection.fname = tbFName1.Text;
            Connection.mname = tbMName1.Text;
            Connection.lname = tbLName1.Text;
            Connection.name = tbFName1.Text + " " + tbMName1.Text + " " + tbLName1.Text;
            Connection.id = lblResidentID1.Text;
            CheckUp mf = new CheckUp();
            this.Hide();
            mf.Show();
        }
    }
}

