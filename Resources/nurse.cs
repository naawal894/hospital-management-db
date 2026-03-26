using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_DB_FORMS.Resources
{
    public partial class nurse : Form
    {
        public nurse()
        {
            InitializeComponent();
        }

        private void nurse_Load(object sender, EventArgs e)
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
                    string NurseID = nid.Text;
                    string FirstName = fname.Text;
                    string LastName = lname.Text;
                    string departement = dept.Text;
                    string ContactNumber = contact.Text;
                    string shift = shft.Text;

                    string strCommand = "INSERT NURSE (FirstName, LastName, Department, ContactNumber,Shift) VALUES (@FirstName,@LastName, @Department, @ContactNumber, @Shift)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Department", departement);
                        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        cmd.Parameters.AddWithValue("@Shift", shift);
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

        private void button4_Click(object sender, EventArgs e)
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
                    int nurseId = Convert.ToInt32(nid.Text);
                    string firstName = fname.Text;
                    string lastName = lname.Text;
                    string department = dept.Text;
                    string contactNumber = contact.Text;
                    string shift = shft.Text;

                    string updateNurse = @"UPDATE NURSE 
                               SET FirstName = @FirstName,
                                   LastName = @LastName,
                                   Department = @Department,
                                   ContactNumber = @ContactNumber,
                                   Shift = @Shift
                               WHERE NurseId = @NurseId";

                    using (MySqlCommand cmd = new MySqlCommand(updateNurse, con))
                    {
                        cmd.Parameters.AddWithValue("@NurseId", nurseId);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Department", department);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Shift", shift);

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
                    int nurseId = Convert.ToInt32(nid.Text);
                    string deletePatientNurse = "DELETE FROM PATIENTNURSE WHERE NurseId = @NurseId";
                    using (MySqlCommand cmd = new MySqlCommand(deletePatientNurse, con))
                    {
                        cmd.Parameters.AddWithValue("@NurseId", nurseId);
                        cmd.ExecuteNonQuery();
                    }
                    string deleteNurse = "DELETE FROM NURSE WHERE NurseId = @NurseId";

                    using (MySqlCommand cmd = new MySqlCommand(deleteNurse, con))
                    {
                        cmd.Parameters.AddWithValue("@NurseId", nurseId);
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
