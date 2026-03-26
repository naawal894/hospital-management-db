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
    public partial class view_available : Form
    {
        public view_available()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_available_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT A.AvailabilityId, A.Availability,D.DoctorID,D.FirstName, D.LastName, D.Specialization " +
                                      "FROM AVAILABILITY A " +
                                      "INNER JOIN DOCTOR D ON A.DoctorId = D.DoctorId";

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
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
                    string avalibilityid = avid.Text;
                    string doctorid = docid.Text;
                    string avalibility = av.Text;


                    string strCommand = "INSERT AVAILABILITY (AvailabilityID, Availability, DoctorId) VALUES (@AvailabilityID, @Availability, @DoctorId)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@AvailabilityID", avalibilityid);
                        cmd.Parameters.AddWithValue("@Availability", avalibility);
                        cmd.Parameters.AddWithValue("@DoctorId", doctorid);
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show("Record Inserted.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}");
                }


            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT A.AvailabilityId, A.Availability,D.DoctorID,D.FirstName, D.LastName, D.Specialization " +
                                      "FROM AVAILABILITY A " +
                                      "INNER JOIN DOCTOR D ON A.DoctorId = D.DoctorId";

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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

                    int availabilityId = Convert.ToInt32(avid.Text);
                    string availability = av.Text;
                    int doctorId = Convert.ToInt32(docid.Text);

                    string strCommand = "UPDATE AVAILABILITY SET " +
                                        "Availability = @Availability, " +
                                        "DoctorId = @DoctorId " +
                                        "WHERE AvailabilityId = @AvailabilityId";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@AvailabilityId", availabilityId);
                        cmd.Parameters.AddWithValue("@Availability", availability);
                        cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record Updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT A.AvailabilityId, A.Availability,D.DoctorID,D.FirstName, D.LastName, D.Specialization " +
                                      "FROM AVAILABILITY A " +
                                      "INNER JOIN DOCTOR D ON A.DoctorId = D.DoctorId";

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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

                    int availabilityId = Convert.ToInt32(avid.Text);

                    string strCommand = "DELETE FROM AVAILABILITY WHERE AvailabilityId = @AvailabilityId";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@AvailabilityId", availabilityId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT A.AvailabilityId, A.Availability,D.DoctorID,D.FirstName, D.LastName, D.Specialization " +
                                      "FROM AVAILABILITY A " +
                                      "INNER JOIN DOCTOR D ON A.DoctorId = D.DoctorId";

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            doctor_panel doctorform= new doctor_panel();
            doctorform.Show();
        }
    }
}
