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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load.Width += 3;
            if(load.Width >= 599)
            {
                timer1.Stop();
                new Form1().Show();
                this.Hide();
            }
        }
    }
}
