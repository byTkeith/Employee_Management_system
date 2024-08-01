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

        }
    }
}
