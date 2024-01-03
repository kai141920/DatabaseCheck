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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            Lblname.Text = Connection.name;

            dgvHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvHistory.Font, System.Drawing.FontStyle.Bold);

            // Define the columns you want to display in the DataGridView
            string[] columnNames = new string[] { "firstname", "middlename", "lastname", "gender", "age", "emailaddress", "bloodpressure", "coldfever", "animalbites", "skindisease", "othersymptoms" };

            dgvHistory.ColumnCount = columnNames.Length;

            for (int a = 0; a < columnNames.Length; a++)
            {
                dgvHistory.Columns[a].Name = columnNames[a];
            }

            string query1 = "SELECT * FROM appointment WHERE firstname = '" + Connection.fname + "' AND middlename ='" + Connection.mname + "' AND lastname = '" + Connection.lname + "'";
            MySqlConnection connection1 = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command1 = new MySqlCommand(query1, connection1);
            command1.CommandTimeout = 60;

            try
            {
                connection1.Open();

                MySqlDataReader reader1 = command1.ExecuteReader();

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        string query = "SELECT a.firstname, a.middlename, a.lastname, a.gender, a.age, a.emailaddress, c.bloodpressure, c.coldfever, c.animalbite, c.skindiseases, c.othersymptoms " +
                                       "FROM appointment a " +
                                       "INNER JOIN checkup c ON a.residentid = c.patientid " +
                                       "WHERE a.residentid = @id";

                        MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                        MySqlCommand command = new MySqlCommand(query, connect);
                        command.CommandTimeout = 60;

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@id", reader1["residentid"]);

                        try
                        {
                            connect.Open();

                            MySqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    dgvHistory.Rows.Add(
                                        reader.GetString(0), reader.GetString(1), reader.GetString(2),
                                        reader.GetString(3), reader.GetString(4), reader.GetString(5),
                                        reader.GetString(6), reader.GetString(7), reader.GetString(8),
                                        reader.GetString(9), reader.GetString(10)
                                    );
                                }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection1.Close();
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CheckUp cu = new CheckUp();
            this.Hide();
            cu.Show();
        }
    }
}
