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
    public partial class All_List_Patient_And_Illnesses : Form
    {
        public All_List_Patient_And_Illnesses()
        {
            InitializeComponent();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id = 0;
        int co = 0;


        public void load()
        {
            string query3 = "SELECT count(*) from checkup";
            MySqlConnection connect3 = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command3 = new MySqlCommand(query3, connect3);

            connect3.Open();
            long rowCount = (long)command3.ExecuteScalar();
            connect3.Close();
            if (rowCount == 0)
            {
                co = id;
            }
            else
            {
                string query2 = "SELECT id from checkup order by id desc limit 1;";
                MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command2 = new MySqlCommand(query2, connect2);
                connect2.Open();
                id = (int)command2.ExecuteScalar();
                id += 1;
                co = id;
                connect2.Close();
            }


            if (co == 0)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                dgvAllList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvAllList.Font, System.Drawing.FontStyle.Bold);

                // Define the columns you want to display in the DataGridView
                string[] columnNames = new string[] { "firstname", "midlename", "lastname", "gender", "age", "emailaddress", "bloodpressure", "coldfever", "animalbite", "skindiseases", "othersymptoms" };

                dgvAllList.ColumnCount = columnNames.Length;

                for (int a = 0; a < columnNames.Length; a++)
                {
                    dgvAllList.Columns[a].Name = columnNames[a];
                }

                string query = "SELECT a.firstname, a.middlename, a.lastname, a.gender, a.age, a.emailaddress, c.bloodpressure, c.coldfever, c.animalbite, c.skindiseases, c.othersymptoms " +
                               "FROM appointment a " +
                               "INNER JOIN checkup c ON a.residentid = c.patientid";

                MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command = new MySqlCommand(query, connect);
                command.CommandTimeout = 60;

                try
                {
                    connect.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgvAllList.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
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

        private void All_List_Patient_And_Illnesses_Load(object sender, EventArgs e)
        {
            load();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Hide();
            db.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvAllList.Rows.Clear();

            dgvAllList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvAllList.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "firstname", "midlename", "lastname", "gender", "age", "emailaddress", "bloodpressure", "coldfever", "animalbite", "skindiseases", "othersymptoms" };

            dgvAllList.ColumnCount = columnNames.Length;
            string query = "";

            for (int a = 0; a < columnNames.Length; a++)
            {
                dgvAllList.Columns[a].Name = columnNames[a];
            }

            if (int.TryParse(TbxSearch.Text, out _))
            {
                query = "SELECT a.firstname, a.middlename, a.lastname, a.gender, a.age, a.emailaddress, c.bloodpressure, c.coldfever, c.animalbite, c.skindiseases, c.othersymptoms " +
                        "FROM appointment a " +
                        "INNER JOIN checkup c ON a.residentid = c.patientid " +
                        "WHERE a.residentid = " + TbxSearch.Text + " OR a.age = " + TbxSearch.Text + ";";
            }
            else if (!string.IsNullOrEmpty(TbxSearch.Text))
            {
                query = "SELECT a.firstname, a.middlename, a.lastname, a.gender, a.age, a.emailaddress, c.bloodpressure, c.coldfever, c.animalbite, c.skindiseases, c.othersymptoms " +
                        "FROM appointment a " +
                        "INNER JOIN checkup c ON a.residentid = c.patientid " +
                        "WHERE a.firstname = '" + TbxSearch.Text + "' OR a.lastname = '" + TbxSearch.Text + "';";
            }

            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvAllList.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
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

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
