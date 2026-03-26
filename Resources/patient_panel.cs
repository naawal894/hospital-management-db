using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_DB_FORMS.Resources
{
    public partial class patient_panel : Form
    {
        public patient_panel()
        {
            InitializeComponent();
        }

        private void patient_panel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 mainDashboard = new Form2();
            mainDashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string firstName = fname.Text;
                    string lastName = lname.Text;
                    string age = ag.Text;
                    string contactnum = contact.Text;
                    string gender = combo1.SelectedItem.ToString();

                    string strCommand = "INSERT PATIENT (FirstName, LastName, Age, Gender, ContactNumber) VALUES (@FirstName, @LastName, @Age, @Gender, @ContactNumber)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactnum);

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

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string firstName = fname.Text;
                    string lastName = lname.Text;
                    string age = ag.Text;
                    string contactnum = contact.Text;
                    string gender = combo1.SelectedItem.ToString();

                    string strCommand = "UPDATE PATIENT SET " +
                                        "FirstName = @FirstName, " +
                                        "LastName = @LastName, " +
                                        "Age = @Age, " +
                                        "ContactNumber = @ContactNumber, " +
                                        "Gender = @Gender " +
                                        "WHERE PatientID = @PatientID";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", pid);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@v", ag);
                        cmd.Parameters.AddWithValue("@ContactNumber", contact);
                        cmd.Parameters.AddWithValue("@Gender", gender);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record Updated.");
                }
                catch (Exception ex)
                {

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
                    int patientId = Convert.ToInt32(pid.Text);

                    string deleteMedicalHistory = "DELETE FROM MEDICAL_HISTORY WHERE PatientID = @PatientID";
                    string deleteAddress = "DELETE FROM ADDRESS WHERE PatientID = @PatientID";
                    string deleteAppointments = "DELETE FROM APPOINTMENT WHERE PatientID = @PatientID";
                    string deleteTreatments = "DELETE FROM TREATMENT WHERE PatientID = @PatientID";
                    string deleteInvoices = "DELETE FROM INVOICE WHERE PatientID = @PatientID";

                    using (MySqlCommand cmd = new MySqlCommand(deleteMedicalHistory, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(deleteAddress, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(deleteAppointments, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(deleteTreatments, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(deleteInvoices, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
                        cmd.ExecuteNonQuery();
                    }

                    string deletePatient = "DELETE FROM PATIENT WHERE PatientID = @PatientID";

                    using (MySqlCommand cmd = new MySqlCommand(deletePatient, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            medicalhistory mdch = new medicalhistory();
            mdch.Show();
        }
    }
}
