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
    public partial class Patient_Record : Form
    {
        public Patient_Record()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patient_Record_Load(object sender, EventArgs e)
        {

        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Hide();
            db.Show();
        }
    }
}
