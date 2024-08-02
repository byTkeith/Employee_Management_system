using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Employee_Management_system
{
    public partial class Form1 : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {   

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();//exits the application on completion
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();//creating a new object for register
            regForm.Show();
            this.Hide();
        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpassword.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();    
                }
            }
        }
    }
}
