namespace project_DB_FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtpassword.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && txtpassword.Text == "123")
            {
                new Form2().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("The user name or password is incorrect");
                textBox1.Clear();
                txtpassword.Clear();
                textBox1.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
