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
    public partial class RegisterForm: Form
    {   
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_sihnupBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm= new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar=signup_showpassword.Checked?'\0':'*';
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void sigup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" ||
                signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {


                        connect.Open();
                        DateTime
                        string insertData = "INSERT INTO users"+"(username, password, date_register)"+"VALUES(@username, @password, @dateReg)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect)) {
                            cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateReg", signup_username.Text.Trim());

                        }

                    
                    } 
                    catch(Exception ex)
                    {
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
}
