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
    public partial class CheckUp_Records : Form
    {
        public CheckUp_Records()
        {
            InitializeComponent();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Hide();
            db.Show();
        }

        private void CheckUp_Records_Load(object sender, EventArgs e)
        {
            dgvCRecords.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvCRecords.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "patientid", "firstname", "bloodpressure", "coldfever", "animalbites", "skindisease", "othersymptoms" };

            dgvCRecords.ColumnCount = 7;


           

            for (int a = 0; a < columnNames.Length; a++)
            {
                dgvCRecords.Columns[a].Name = columnNames[a];
            }

            string query = "SELECT * FROM checkup";
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
                        dgvCRecords.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void dgvCRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow;
                selectedrow = e.RowIndex;
                DataGridViewRow row = dgvCRecords.Rows[selectedrow];

                Connection.IdContent = row.Cells[0].Value.ToString();
                Connection.checkUp = true;


                Patient mf = new Patient();
                this.Hide();
                mf.Show();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
    }
}
