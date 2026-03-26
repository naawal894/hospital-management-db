namespace project_DB_FORMS.Resources
{
    partial class patient_panel
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
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pid = new TextBox();
            label2 = new Label();
            fname = new TextBox();
            label3 = new Label();
            lname = new TextBox();
            label4 = new Label();
            ag = new TextBox();
            label5 = new Label();
            label6 = new Label();
            contact = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            combo1 = new ComboBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 19);
            label1.Name = "label1";
            label1.Size = new Size(602, 47);
            label1.TabIndex = 1;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 94);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.left_arrow_32px2;
            pictureBox1.Location = new Point(24, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pid
            // 
            pid.Location = new Point(286, 147);
            pid.Name = "pid";
            pid.Size = new Size(225, 23);
            pid.TabIndex = 2;
            pid.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 147);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 3;
            label2.Text = "PatientId";
            // 
            // fname
            // 
            fname.Location = new Point(286, 185);
            fname.Name = "fname";
            fname.Size = new Size(225, 23);
            fname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 185);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 3;
            label3.Text = "FirstName";
            // 
            // lname
            // 
            lname.Location = new Point(286, 222);
            lname.Name = "lname";
            lname.Size = new Size(225, 23);
            lname.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 222);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "LastName";
            // 
            // ag
            // 
            ag.Location = new Point(286, 258);
            ag.Name = "ag";
            ag.Size = new Size(225, 23);
            ag.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 258);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 3;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 299);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 3;
            label6.Text = "Gender";
            // 
            // contact
            // 
            contact.Location = new Point(286, 334);
            contact.Name = "contact";
            contact.Size = new Size(225, 23);
            contact.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(111, 334);
            label7.Name = "label7";
            label7.Size = new Size(155, 25);
            label7.TabIndex = 3;
            label7.Text = "ContactNumber";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(111, 466);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 4;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(251, 466);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlText;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(385, 466);
            button3.Name = "button3";
            button3.Size = new Size(112, 41);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.download;
            pictureBox2.Location = new Point(668, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(411, 275);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // combo1
            // 
            combo1.FormattingEnabled = true;
            combo1.Items.AddRange(new object[] { "Male", "Female" });
            combo1.Location = new Point(286, 299);
            combo1.Name = "combo1";
            combo1.Size = new Size(225, 23);
            combo1.TabIndex = 6;
            combo1.SelectedIndexChanged += combo1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(64, 64, 64);
            button4.Location = new Point(668, 423);
            button4.Name = "button4";
            button4.Size = new Size(185, 41);
            button4.TabIndex = 7;
            button4.Text = "Medical History";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // patient_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 749);
            Controls.Add(button4);
            Controls.Add(combo1);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(contact);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ag);
            Controls.Add(label4);
            Controls.Add(lname);
            Controls.Add(label3);
            Controls.Add(fname);
            Controls.Add(label2);
            Controls.Add(pid);
            Controls.Add(panel1);
            Name = "patient_panel";
            Text = "patient_panel";
            Load += patient_panel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox pid;
        private Label label2;
        private TextBox fname;
        private Label label3;
        private TextBox lname;
        private Label label4;
        private TextBox ag;
        private Label label5;
        private Label label6;
        private TextBox contact;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private ComboBox combo1;
        private Button button4;
    }
}