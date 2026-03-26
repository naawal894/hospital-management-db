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
    public partial class pharmacy : Form
    {
        public pharmacy()
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
                    string pharmacyid = pharid.Text;
                    string name = nm.Text;
                    string location = loc.Text;
                    string contactnum = contact.Text;

                    string strCommand = "INSERT PHARMACY (PharmacyID, Name, Location, ContactNumber) VALUES (@PharmacyID, @Name, @Location, @ContactNumber)";
                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@PharmacyID", pharmacyid);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Location", location);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string pharmacyid = pharid.Text;
                    string name = nm.Text;
                    string location = loc.Text;
                    string contactnum = contact.Text;

                    string strCommand = "UPDATE PHARMACY SET " +
                                        "PharmacyID = @PharmacyID, " +
                                        "Name = @LastName, " +
                                        "Location = @Specialization, " +
                                        "ContactNumber = @ContactNumber";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@PharmacyID", pharmacyid);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Location", location);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactnum);

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

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Example@2024;database=hms";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string pharmacyid = pharid.Text;

                    string strCommand = "DELETE FROM PHARMACY WHERE PharmacyID = @PharmacyID";

                    using (MySqlCommand cmd = new MySqlCommand(strCommand, con))
                    {
                        cmd.Parameters.AddWithValue("@PharmacyID", pharmacyid);
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
