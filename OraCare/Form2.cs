using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraCare
{
    public partial class LoginWindow : Form
    {
        public static string nameString;

        public LoginWindow()
        {
            InitializeComponent();
        }

        dbcontrol sql = new dbcontrol();

        bool Login()
        {
            // Retrieves the user's account details if there are any. Returns true if the login was successful, otherwise returns false if unsuccessful.
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Please choose a stronger password. Minimum length is 8 characters.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            sql.Param("@userName", txtUsername.Text);
            sql.Param("@password", txtPassword.Text);
            sql.query("select count(*) from tbluser where userName=@userName and password=@password");
            if ((int)sql.dt.Rows[0][0] == 1) 
            {
                return true;
            }
            MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            return false;
        }

        public string Get_Form1Text()
        {
            // Gets the user's username.
            return txtUsername.Text; 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Closes the current window and opens the sign up window.
            this.Hide();
            SignupWindow nform = new SignupWindow();
            nform.ShowDialog(); 

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Replaces the password text box's characters with '*'
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Runs if the user has successfully logged in, displays a message, closes the current window, and opens the main window.
            if (Login() == true)
            {
                nameString = txtUsername.Text; 
                MessageBox.Show("Successfully Logged-In");
                this.Hide();
                MainWindow nform = new MainWindow();
                nform.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            BackColor = Color.Transparent;
        }

    }
}
