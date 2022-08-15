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
    public partial class LoadingWindow : Form
    {
        public LoadingWindow()
        {
            InitializeComponent();
        }

        private void LoadingWindow_Load(object sender, EventArgs e)
        {
            // Starts the timer
            timer1.Start();
        }

        private void LoadingBar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increases the loading bar
            this.loadingBar.Increment(1);
            if (loadingBar.Value >= loadingBar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                LoginWindow nform = new LoginWindow();
                nform.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
