namespace project_DB_FORMS.Resources
{
    partial class admin
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
            sid = new TextBox();
            label2 = new Label();
            fname = new TextBox();
            label3 = new Label();
            lname = new TextBox();
            label4 = new Label();
            contact = new TextBox();
            label5 = new Label();
            dept = new TextBox();
            label6 = new Label();
            pos = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sid
            // 
            sid.Location = new Point(373, 139);
            sid.Name = "sid";
            sid.Size = new Size(275, 23);
            sid.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 139);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 6;
            label2.Text = "StaffID";
            label2.Click += label2_Click;
            // 
            // fname
            // 
            fname.Location = new Point(373, 182);
            fname.Name = "fname";
            fname.Size = new Size(275, 23);
            fname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 182);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 6;
            label3.Text = "FirstName";
            label3.Click += label2_Click;
            // 
            // lname
            // 
            lname.Location = new Point(373, 223);
            lname.Name = "lname";
            lname.Size = new Size(275, 23);
            lname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 223);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 6;
            label4.Text = "LastName";
            label4.Click += label2_Click;
            // 
            // contact
            // 
            contact.Location = new Point(373, 267);
            contact.Name = "contact";
            contact.Size = new Size(275, 23);
            contact.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 267);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 6;
            label5.Text = "ContactNumber";
            label5.Click += label2_Click;
            // 
            // dept
            // 
            dept.Location = new Point(373, 310);
            dept.Name = "dept";
            dept.Size = new Size(275, 23);
            dept.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(160, 310);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 6;
            label6.Text = "Department";
            label6.Click += label2_Click;
            // 
            // pos
            // 
            pos.Location = new Point(373, 353);
            pos.Name = "pos";
            pos.Size = new Size(275, 23);
            pos.TabIndex = 5;
            pos.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(160, 353);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 6;
            label7.Text = "Position";
            label7.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(160, 492);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(308, 492);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlText;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(455, 492);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.download_removebg_preview;
            pictureBox2.Location = new Point(803, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(365, 221);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 79);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.left_arrow_32px2;
            pictureBox1.Location = new Point(23, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(299, 14);
            label1.Name = "label1";
            label1.Size = new Size(602, 47);
            label1.TabIndex = 2;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 749);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(pos);
            Controls.Add(label6);
            Controls.Add(dept);
            Controls.Add(label5);
            Controls.Add(contact);
            Controls.Add(label4);
            Controls.Add(lname);
            Controls.Add(label3);
            Controls.Add(fname);
            Controls.Add(label2);
            Controls.Add(sid);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox sid;
        private Label label2;
        private TextBox fname;
        private Label label3;
        private TextBox lname;
        private Label label4;
        private TextBox contact;
        private Label label5;
        private TextBox dept;
        private Label label6;
        private TextBox pos;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}