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
    public partial class doctorsWindow : Form
    {
        public doctorsWindow()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow nform = new MainWindow();
            nform.Show(); 
        }

        private void doctorsWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
