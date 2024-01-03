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
    public partial class Appointment_Records : Form
    {
        public Appointment_Records()
        {
            InitializeComponent();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Hide();
            db.Show();
        }

        private void Appointment_Records_Load(object sender, EventArgs e)
        {
            dgvARecords.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvARecords.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "residentid", "firstname", "midlename", "lastname", "gender", "age", "dateofbirth", "status", "contactno", "emailaddress"};

            dgvARecords.ColumnCount = 10;

            for (int a = 0; a < columnNames.Length; a++)
            {
                dgvARecords.Columns[a].Name = columnNames[a];
            }

            string query = "SELECT * FROM appointment WHERE statusA = '1'";
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
                        dgvARecords.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void dgvARecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow;
                selectedrow = e.RowIndex;
                DataGridViewRow row = dgvARecords.Rows[selectedrow];

                Connection.IdContent = row.Cells[0].Value.ToString();
                Connection.check = true;


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
