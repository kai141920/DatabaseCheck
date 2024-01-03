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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnAppointmentSched_Click(object sender, EventArgs e)
        {
            Appointment_Scheduling a = new Appointment_Scheduling();
            this.Hide();
            a.Show();
        }

        private void btnCheckUpRecord_Click(object sender, EventArgs e)
        {
            CheckUp_Records c = new CheckUp_Records();
            this.Hide();
            c.Show();
        }

        private void btnAppointRecords_Click(object sender, EventArgs e)
        {
            Appointment_Records a = new Appointment_Records();
            this.Hide();
            a.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Patient_Record a = new Patient_Record();
            this.Hide();
            a.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            All_List_Patient_And_Illnesses a = new All_List_Patient_And_Illnesses();
            this.Hide();
            a.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
