using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brgy_TambisII_Health_Care
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static void UsernameMethod(TextBox username)
        {
            if (username.Text != "admin")
            {
                username.Text = "Username";
                username.ForeColor = Color.DimGray;
            }
        }

        private static void PassMethod(TextBox pass, CheckBox ckBox)
        {
            if (pass.Text != "admin")
            {
                pass.Text = "Password";
                pass.ForeColor = Color.DimGray;
                pass.UseSystemPasswordChar = false;
                ckBox.Enabled = false;
            }
            else
            {
                ckBox.Enabled = true;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username" || tbPassword.Text == "Password")
            {
                MessageBox.Show("Please enter your username and password to log in", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string username = tbUsername.Text;
                string password = tbPassword.Text;

                string hashedPassword = HashPassword(password);

                string query = "SELECT * FROM user WHERE username = '" + username + "'";

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
                            string pass = reader.GetString(1);

                            if (pass == hashedPassword && username == reader.GetString(0))
                            {
                                DashBoard mf = new DashBoard();
                                this.Hide();
                                mf.Show();
                            }
                            else
                            {
                                MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbShowPassword.Enabled = false;

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.DimGray;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.DimGray;
                tbPassword.UseSystemPasswordChar = false;
                cbShowPassword.Enabled = false;
            }
            else
            {
                cbShowPassword.Enabled = true;
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbUsername.Text == "Username" || tbPassword.Text == "Password")
                {
                    MessageBox.Show("Please enter your username and password to log in", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string username = tbUsername.Text;
                    string password = tbPassword.Text;

                    string hashedPassword = HashPassword(password);

                    string query = "SELECT * FROM user WHERE username = '" + username + "'";

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
                                string pass = reader.GetString(1);

                                if (pass == hashedPassword && username == reader.GetString(0))
                                {
                                    DashBoard mf = new DashBoard();
                                    this.Hide();
                                    mf.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Query error: " + x.Message);
                    }
                }
            }
        }
    }
}
