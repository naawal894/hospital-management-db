using project_DB_FORMS.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_DB_FORMS
{
    public partial class Form2 : Form
    {
        bool sidebarExpand;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarcontainer.Width -= 10;
                if (sidebarcontainer.Width == sidebarcontainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
                else
                {
                    sidebarcontainer.Width += 10;
                    if (sidebarcontainer.Width == sidebarcontainer.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        sidebartimer.Stop();
                    }
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sidebarcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            doctor_panel doctorPanelForm = new doctor_panel();
            doctorPanelForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patient_panel patientPanelForm = new patient_panel();
            patientPanelForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appointment_panel appPanelForm = new appointment_panel();
            appPanelForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nurse nur = new nurse();
            nur.Show();
            this.Close();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            admin adminPanelForm = new admin();
            adminPanelForm.Show();
            this.Close();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            pharmacy pharform = new pharmacy();
            pharform.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lab labform = new lab();
            labform.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
