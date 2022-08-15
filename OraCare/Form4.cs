using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OraCare
{
    public partial class SignupWindow : Form
    {
        public SignupWindow()
        {
            InitializeComponent();
            txtFirstname.Focus();
        }

        dbcontrol sql = new dbcontrol();
        void register()
        {
            // Creates a new user account

            if (ValidateEmail() == false)
            {
                MessageBox.Show("Please check your e-mail address and try again.");
                return;
            } else if (ValidatePassword() == false)
            {
                MessageBox.Show("Please check your password length and try again. Password should be at least 8 characters long.");
                return;
            }

            sql.Param("@userName", txtUsername.Text);
            sql.Param("@password", txtPassword.Text);
            sql.Param("@fname", txtFirstname.Text);
            sql.Param("@lname", txtLastname.Text);
            sql.Param("@emailAdd", txtEmail.Text);
            sql.query("insert into tbluser (userName, password, fname, lname, emailAdd) values (@userName, @password, @fname, @lname, @emailAdd)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("Registered successfully!"); 
        }

        void reset()
        {
            // Clears all the text boxes
            txtFirstname.Clear();
            txtLastname.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtFirstname.Focus();
        }

        private bool ValidateEmail()
        {
            // Checks if the user has entered a valid email address
            string regexEmail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, regexEmail))
                return true;
            else
                return false;
        }

        private bool ValidatePassword()
        {
            // Checks if the user has entered a valid password
            if (txtPassword.Text.Length < 8)
            {
                return false;
            } 
            else
            {
                return true; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Closes the current window and opens the login window
            this.Hide();
            LoginWindow nform = new LoginWindow();
            nform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Runs and calls the register and reset methods if the user clicks the register button

                register();
                reset();
        }

        private void SignupWindow_Load(object sender, EventArgs e)
        {
            // Replaces the password text box with '*' characters
            txtPassword.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Sets the forecolor for txtEmail red unless the email address is valid
            if (!(ValidateEmail()))
            {
                txtEmail.ForeColor = Color.Red;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Sets the forecolor for txtpassword red unless the password is valid
            if (!(ValidatePassword()))
            {
                txtPassword.ForeColor = Color.Red;
            }
            else
            {
                txtPassword.ForeColor = Color.Black;
            }
        }
    }
}
