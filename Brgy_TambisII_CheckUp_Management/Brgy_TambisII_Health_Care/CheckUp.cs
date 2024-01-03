using MySql.Data.MySqlClient;
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

namespace Brgy_TambisII_Health_Care
{
    public partial class CheckUp : Form
    {
        public CheckUp()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            lblname.Text = Connection.name;
            lblPatientid.Text = Connection.id;
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Hide();
            db.Show();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            History db = new History();
            this.Hide();
            db.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime birthdate = dtpBirth.Value;
            int year = birthdate.Year;
            int month = birthdate.Month;
            int day = birthdate.Day;



            string query = "INSERT INTO checkup(patientid,date,bloodpressure,coldfever,animalbite,skindiseases,othersymptoms) VALUES (" +
               lblPatientid.Text + ",'" + year +"-"+month + "-" + day + "','"+ cbBloodPressure.Text + "','"+ cbFever.Text + "','" + cbAnimalBites.Text + "','"+ cbSkinDiseases.Text +"','" +cbOtherSymptoms.Text +"'" +")";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Saved");
                    
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

            string query2 = "UPDATE appointment SET statusA = '2' WHERE residentid = " + Connection.id + "";
            MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command2 = new MySqlCommand(query2, connect2);
            command2.CommandTimeout = 60;

            try
            {
                connect.Open();
                int rowsAffected = command2.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Saved");

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
                connect2.Close();
            } 

        }
    }
}
