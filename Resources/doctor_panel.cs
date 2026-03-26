using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_DB_FORMS.Resources
{
    public partial class doctor_panel : Form
    {

        public doctor_panel()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 mainDashboard = new Form2();
            mainDashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctor_panel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string docid = doctorid.Text;
                    string firstName = fname.Text;
                    string lastName = lname.Text;
                    string specialization = spz.Text;
                    string contactNumber = contact.Text;
                    string email = em.Text;

                    string strCommand = "INSERT DOCTOR (FirstName, LastName, Specialization, ContactNumber, Email) VALUES (@FirstName, @LastName, @Specialization, @ContactNumber, @Email)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", docid);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Specialization", specialization);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.ExecuteNonQuery();
                    }

                    // Inform the user
                    MessageBox.Show("Record Inserted.");
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the connection or execution
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string docid = doctorid.Text;
                    string firstName = fname.Text;
                    string lastName = lname.Text;
                    string specialization = spz.Text;
                    string contactNumber = contact.Text;
                    string email = em.Text;

                    string strCommand = "UPDATE DOCTOR SET " +
                                        "FirstName = @FirstName, " +
                                        "LastName = @LastName, " +
                                        "Specialization = @Specialization, " +
                                        "ContactNumber = @ContactNumber, " +
                                        "Email = @Email " +
                                        "WHERE DoctorID = @DoctorID";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", docid);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Specialization", specialization);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.ExecuteNonQuery();
                    }

                    // Inform the user
                    MessageBox.Show("Record Updated.");
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the connection or execution
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    int docId = Convert.ToInt32(doctorid.Text);

                    // First, delete related records from child tables
                    string deleteRelatedAppointments = "DELETE FROM APPOINTMENT WHERE DoctorID = @DoctorID";
                    string deleteRelatedTreatments = "DELETE FROM TREATMENT WHERE DoctorID = @DoctorID";
                    // Add more delete commands for other related tables if needed

                    using (MySqlCommand cmd = new MySqlCommand(deleteRelatedAppointments, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", docId);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(deleteRelatedTreatments, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", docId);
                        cmd.ExecuteNonQuery();
                    }

                    // Now, delete from the DOCTOR table
                    string deleteDoctor = "DELETE FROM DOCTOR WHERE DoctorID = @DoctorID";

                    using (MySqlCommand cmd = new MySqlCommand(deleteDoctor, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", docId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record Deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            view_available availabledoc = new view_available();
            availabledoc.Show();
        }

        private void doctorid_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(doctorid.Text))
            {
                errorProvider1.SetError(doctorid, " cannot be empty.");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(doctorid, string.Empty);
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void fname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                errorProvider1.SetError(fname, " cannot be empty.");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(fname, string.Empty);
                button1.Enabled = true;
            }
        }

        private void lname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lname.Text))
            {
                errorProvider1.SetError(lname, " cannot be empty.");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(lname, string.Empty);
                button1.Enabled = true;
            }
        }

        private void spz_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(spz.Text))
            {
                errorProvider1.SetError(spz, " cannot be empty.");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(spz, string.Empty);
                button1.Enabled = true;
            }
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void spz_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void em_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contact.Text))
            {
                errorProvider1.SetError(contact, " cannot be empty.");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(contact, string.Empty);
                button1.Enabled = true;
            }
        }
    }
}

        
