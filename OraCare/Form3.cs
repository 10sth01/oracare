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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Closes the main window and opens the appointment window.
            this.Hide();
            AppointmentWindow nform = new AppointmentWindow();
            nform.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Closes the main window and opens the services window.
            this.Close();
            Form7 nform = new Form7();
            nform.Show(); 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Closes the main window and opens the login window.
            this.Hide();
            LoginWindow nform = new LoginWindow();
            nform.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Closes the main window and opens the doctors window 
            this.Close();
            doctorsWindow nform = new doctorsWindow();
            nform.Show(); 

        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            txtName.Text = LoginWindow.nameString; 
        }
    }
}
