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
    public partial class lab : Form
    {
        public lab()
        {
            InitializeComponent();
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
                    string labid = lbid.Text;
                    string name = nm.Text;
                    string location = loc.Text;
                    string ContactNumber = contact.Text;

                    string strCommand = "INSERT LABORATORY (Name, Location, ContactNumber) VALUES (@Name,@Location, @ContactNumber)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Location", location);
                        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Inserted.");
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
                    string labid = lbid.Text;
                    string name = nm.Text;
                    string location = loc.Text;
                    string ContactNumber = contact.Text;

                    string strCommand = "UPDATE LABORATORY SET " +
                                        "labid = @labid, " +
                                        "name = @name, " +
                                        "location = @Age, " +
                                        "ContactNumber = @ContactNumber, " +
                                        "WHERE PatientID = @PatientID";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@labid", labid);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@location", location);
                        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);

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

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    int labID = int.Parse(lbid.Text); 
                    string deleteDiagnosticTest = "DELETE FROM DIAGNOSTICTEST WHERE LabID = @LabID";
                    using (MySqlCommand cmd = new MySqlCommand(deleteDiagnosticTest, con))
                    {
                        cmd.Parameters.AddWithValue("@LabID", labID);
                        cmd.ExecuteNonQuery();
                    }

                    string deleteLaboratory = "DELETE FROM LABORATORY WHERE LabID = @LabID";
                    using (MySqlCommand cmd = new MySqlCommand(deleteLaboratory, con))
                    {
                        cmd.Parameters.AddWithValue("@LabID", labID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Laboratory Record Deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }
    }
}
