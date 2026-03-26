namespace project_DB_FORMS.Resources
{
    partial class doctor_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            doctorid = new TextBox();
            label2 = new Label();
            button5 = new Button();
            errorProvider1 = new ErrorProvider(components);
            fname = new TextBox();
            lname = new TextBox();
            spz = new TextBox();
            contact = new TextBox();
            em = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 94);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.left_arrow_32px2;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(304, 19);
            label1.Name = "label1";
            label1.Size = new Size(602, 47);
            label1.TabIndex = 1;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(94, 495);
            button1.Name = "button1";
            button1.Size = new Size(123, 46);
            button1.TabIndex = 5;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.doctor;
            pictureBox2.Location = new Point(761, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 240);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(94, 359);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 3;
            label7.Text = "Email";
            label7.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(94, 320);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 3;
            label6.Text = "ContactNumber";
            label6.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 281);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 3;
            label5.Text = "Specialization";
            label5.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 238);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "LastName";
            label4.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 197);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 3;
            label3.Text = "FirstName";
            label3.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(236, 495);
            button2.Name = "button2";
            button2.Size = new Size(123, 46);
            button2.TabIndex = 6;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlText;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(379, 495);
            button3.Name = "button3";
            button3.Size = new Size(123, 46);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // doctorid
            // 
            doctorid.Location = new Point(292, 162);
            doctorid.Name = "doctorid";
            doctorid.Size = new Size(210, 23);
            doctorid.TabIndex = 2;
            doctorid.TextChanged += textBox1_TextChanged;
            doctorid.Validating += doctorid_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 160);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "DoctorID";
            label2.Click += label2_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Brown;
            button5.Location = new Point(805, 410);
            button5.Name = "button5";
            button5.Size = new Size(150, 36);
            button5.TabIndex = 9;
            button5.Text = "View Availability";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // fname
            // 
            fname.Location = new Point(292, 197);
            fname.Name = "fname";
            fname.Size = new Size(210, 23);
            fname.TabIndex = 10;
            fname.TextChanged += textBox1_TextChanged_1;
            fname.Validating += fname_Validating;
            // 
            // lname
            // 
            lname.Location = new Point(292, 240);
            lname.Name = "lname";
            lname.Size = new Size(210, 23);
            lname.TabIndex = 11;
            lname.TextChanged += lname_TextChanged;
            lname.Validating += lname_Validating;
            // 
            // spz
            // 
            spz.Location = new Point(292, 281);
            spz.Name = "spz";
            spz.Size = new Size(210, 23);
            spz.TabIndex = 12;
            spz.TextChanged += spz_TextChanged;
            spz.Validating += spz_Validating;
            // 
            // contact
            // 
            contact.Location = new Point(292, 325);
            contact.Name = "contact";
            contact.Size = new Size(210, 23);
            contact.TabIndex = 13;
            contact.TextChanged += contact_TextChanged;
            contact.Validating += contact_Validating;
            // 
            // em
            // 
            em.Location = new Point(292, 362);
            em.Name = "em";
            em.Size = new Size(210, 23);
            em.TabIndex = 14;
            em.TextChanged += em_TextChanged;
            // 
            // doctor_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 749);
            Controls.Add(em);
            Controls.Add(contact);
            Controls.Add(spz);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(doctorid);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "doctor_panel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "doctor_panel";
            Load += doctor_panel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button3;
        private TextBox doctorid;
        private Label label2;
        private Button button5;
        private ErrorProvider errorProvider1;
        private TextBox fname;
        private TextBox lname;
        private TextBox em;
        private TextBox contact;
        private TextBox spz;
    }
}