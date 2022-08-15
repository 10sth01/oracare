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
using System.Windows.Forms;

namespace OraCare
{
    public partial class AppointmentWindow : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=SAMIKO\SQLEXPRESS01;Integrated Security=True");
        dbcontrol sql = new dbcontrol();

        public AppointmentWindow()
        {
            InitializeComponent();
        }

        void retrieveUser()
        {
            // Retrieves the current user's first name, last name, and username
            con.Open();
            SqlCommand cmd = new SqlCommand("select userName, fname, lname from tbluser where userName = '" + LoginWindow.nameString + "'", con);
            SqlDataReader srd = cmd.ExecuteReader();
            while (srd.Read())
            {
                txtFname.Text = srd.GetValue(1).ToString();
                txtLname.Text = srd.GetValue(2).ToString();
                txtUsername.Text = srd.GetValue(0).ToString();

            }
            con.Close();

        }

        void displayAppointments()
        {
            // Displays the current user's appointments
            con.Open();
            SqlCommand cmd = new SqlCommand("select date, time, dentist, phoneNum, serviceCategory, comments from tblAppointment where username = '" + LoginWindow.nameString + "'", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            dt = new DataTable();
            sda.Fill(dt);

            dgvAppointment.DataSource = dt;
            con.Close();
        }

        void newAppointment()
        {
            // Creates a new appointment

            if (!ValidatePhoneNum())
            {
                MessageBox.Show("Please check you inputs and try again.");
                return;
            }

            sql.Param("@username", txtUsername.Text);
            sql.Param("@fname", txtFname.Text);
            sql.Param("@lname", txtLname.Text);
            sql.Param("@age", txtAge.Text);
            sql.Param("@phoneNum", txtPhoneNum.Text);
            sql.Param("@date", txtDate.Text);
            sql.Param("@time", txtTime.GetItemText(txtTime.SelectedItem));
            sql.Param("@dentist", txtDentist.GetItemText(txtDentist.SelectedItem));
            sql.Param("@serviceCategory", txtServiceCategory.GetItemText(txtServiceCategory.SelectedItem));
            sql.Param("@comments", txtComments.Text);

            con.Open();
            SqlCommand checkAppointment = new SqlCommand("SELECT * FROM tblAppointment WHERE ([date] = @date) AND ([time] = @time)", con);
            checkAppointment.Parameters.AddWithValue("@date", txtDate.Text);
            checkAppointment.Parameters.AddWithValue("@time", txtTime.GetItemText(txtTime.SelectedItem));
            SqlDataReader reader = checkAppointment.ExecuteReader();
            if (!(reader.HasRows))
            {
                // Runs if there is no conflicting schedule
                sql.query("insert into tblAppointment (username, fname, lname, age, phoneNum, date, time, dentist, serviceCategory, comments) values (@username, @fname, @lname, @age, @phoneNum, @date, @time, @dentist, @serviceCategory, @comments)");
                if (sql.Check4error(true))
                {
                    return;
                }
                MessageBox.Show("Appointment created!");
                con.Close();
            }
            else
            {
                // Runs if there is conflicting schedule
                MessageBox.Show("Choose a different schedule.");
                con.Close();
            }
        }

        void reset()
        {
            // Clears the text boxes in the appointment form
            txtAge.Clear();
            txtPhoneNum.Clear();
            txtDate.Value = DateTime.Today;
            txtTime.SelectedItem = null;
            txtDentist.SelectedItem = null;
            txtServiceCategory.SelectedItem = null;
            txtComments.Clear();
        }

        private bool ValidatePhoneNum()
        {
            // Checks if the phone number is valid
            if ((txtPhoneNum.TextLength == 11) && (txtPhoneNum.Text.StartsWith("09")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        void txtFname_TextChanged(object sender, EventArgs e)
            {

            }

        void button2_Click(object sender, EventArgs e)
        {

        }


        void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        void label6_Click(object sender, EventArgs e)
        {

        }

        void label7_Click(object sender, EventArgs e)
        {

        }

        void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        void label8_Click(object sender, EventArgs e)
        {

        }

        void label9_Click(object sender, EventArgs e)
        {

        }

        void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        void pictureBox1_Click(object sender, EventArgs e)
        {
            // Closes the current window and opens the main window
            this.Close();
            MainWindow nform = new MainWindow();
            nform.Show();
        }

        void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            // Phone number validation text formatting
            if (ValidatePhoneNum() == true)
            {
                txtPhoneNum.ForeColor = Color.Black;
            }
            else
            {
                txtPhoneNum.ForeColor = Color.Red;
            }
        }

        private void txtPhoneNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Phone number validation
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, a phone number cannot contain letters");
            }
        }

        private void AppointmentWindow_Load_1(object sender, EventArgs e)
        {
            // Runs when the appointment window loads
            retrieveUser();
            displayAppointments();


            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "MMM/dd/yyyy";
            txtDate.MinDate = DateTime.Now;

            dgvAppointment.ForeColor = Color.Black;

            dgvAppointment.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            dgvAppointment.Columns.Insert(6, buttoncolumn);
            buttoncolumn.HeaderText = "Delete Row";
            buttoncolumn.Width = 100;
            buttoncolumn.Text = "Delete";
            buttoncolumn.UseColumnTextForButtonValue = true;
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            // Runs when the user clicks on the create appointment button
            newAppointment();
            displayAppointments();
            reset();
            txtFname.Focus();
        }

        private void dgvAppointment_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Runs when the user clicks on the delete button
            SqlConnection con = new SqlConnection(@"Data Source=SAMIKO\SQLEXPRESS01;Integrated Security=True");

            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dgvAppointment.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete this appointment?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Runs when the user clicks yes on the confirmation window
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=SAMIKO\SQLEXPRESS01;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from tblAppointment where date=@date and time=@time", con1))
                        {
                            cmd.Parameters.AddWithValue("date", row.Cells["date"].Value);
                            cmd.Parameters.AddWithValue("time", row.Cells["time"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }
                    }
                    displayAppointments();
                }
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, age can't contain letters!");
            }
        }
    }
    }

