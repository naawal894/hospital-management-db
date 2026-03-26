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
    public partial class appointment_panel : Form
    {
        public appointment_panel()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string appointid = appnt.Text;
                    string doctorid = docid.Text;
                    string patientid = pid.Text;
                    string dates = dtp1.Value.ToString("yyyy-MM-dd");
                    string times = tm.Text;

                    string strCommand = "INSERT APPOINTMENT (DATE, Time, PatientId, DoctorID) VALUES (@DATE,@Time, @PatientId, @DoctorID)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@DATE", dates);
                        cmd.Parameters.AddWithValue("@Time", times);
                        cmd.Parameters.AddWithValue("@PatientId", patientid);
                        cmd.Parameters.AddWithValue("@DoctorID", doctorid);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
                    string appointid = appnt.Text;
                    string doctorid = docid.Text;
                    string patientid = pid.Text;
                    string dates = dtp1.Value.ToString("yyyy-MM-dd");
                    string times = tm.Text;

                    string strCommand = "UPDATE APPOINTMENT SET " +
                                        "AppointmentID = @AppointmentID, " +
                                        "Date = @Date, " +
                                        "Time = @Age, " +
                                        "PatientId = @ContactNumber, " +
                                        "DoctorID = @Gender " +
                                        "WHERE  AppointmentID= @AppointmentID";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointid);
                        cmd.Parameters.AddWithValue("@Date", dates);
                        cmd.Parameters.AddWithValue("@Time", times);
                        cmd.Parameters.AddWithValue("@DoctorID", docid);
                        cmd.Parameters.AddWithValue("@patientid", pid);

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
                    int appointmentId = Convert.ToInt32(appnt.Text);

                    string deleteAppointment = "DELETE FROM APPOINTMENT WHERE AppointmentID = @AppointmentID";

                    using (MySqlCommand cmd = new MySqlCommand(deleteAppointment, con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
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
    }
}
