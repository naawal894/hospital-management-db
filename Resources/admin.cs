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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project_DB_FORMS.Resources
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
                    string SatffID = sid.Text;
                    string FirstName = fname.Text;
                    string LastName = lname.Text;
                    string departement = dept.Text;
                    string ContactNumber = contact.Text;
                    string position = pos.Text;

                    string strCommand = "INSERT ADMIN (FirstName, LastName, Department,ContactNumber, Position) VALUES (@FirstName,@LastName, @Department, @ContactNumber, @Position)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Department", departement);
                        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        cmd.Parameters.AddWithValue("@Position", pos);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 mainDashboard = new Form2();
            mainDashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string SatffID = sid.Text;
                    string FirstName = fname.Text;
                    string LastName = lname.Text;
                    string departement = dept.Text;
                    string ContactNumber = contact.Text;
                    string position = pos.Text;

                    string strCommand = "UPDATE ADMIN SET " +
                                        "StaffID = @StaffID, " +
                                        "LastName = @LastName, " +
                                        "Department = @Department, " +
                                        "ContactNumber = @ContactNumber, " +
                                        "Position = @Position " +
                                        "WHERE  StaffID= @StaffID";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Department", departement);
                        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        cmd.Parameters.AddWithValue("@Position", pos);

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
                    string StaffID = sid.Text;
                    string deletePatientDoctor = "DELETE FROM PATIENTDOCTOR WHERE DoctorID = @DoctorID";
                    using (MySqlCommand cmd = new MySqlCommand(deletePatientDoctor, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", StaffID);
                        cmd.ExecuteNonQuery();
                    }

                    string deletePatientNurse = "DELETE FROM PATIENTNURSE WHERE NurseID = @NurseID";
                    using (MySqlCommand cmd = new MySqlCommand(deletePatientNurse, con))
                    {
                        cmd.Parameters.AddWithValue("@NurseID", StaffID);
                        cmd.ExecuteNonQuery();
                    }
                    string strCommand = "DELETE FROM ADMIN WHERE StaffID = @StaffID";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", StaffID);
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
