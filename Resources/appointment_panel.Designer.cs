namespace project_DB_FORMS.Resources
{
    partial class appointment_panel
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
            appnt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tm = new TextBox();
            label4 = new Label();
            docid = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            pid = new TextBox();
            label6 = new Label();
            dtp1 = new DateTimePicker();
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 94);
            panel1.TabIndex = 2;
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
            // appnt
            // 
            appnt.Location = new Point(358, 165);
            appnt.Name = "appnt";
            appnt.Size = new Size(252, 23);
            appnt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 165);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 4;
            label2.Text = "AppointmentID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(143, 200);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 4;
            label3.Text = "Date";
            label3.Click += label2_Click;
            // 
            // tm
            // 
            tm.Location = new Point(358, 235);
            tm.Name = "tm";
            tm.Size = new Size(252, 23);
            tm.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 235);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 4;
            label4.Text = "Time";
            label4.Click += label2_Click;
            // 
            // docid
            // 
            docid.Location = new Point(358, 276);
            docid.Name = "docid";
            docid.Size = new Size(252, 23);
            docid.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 276);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 4;
            label5.Text = "DoctorID";
            label5.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(143, 433);
            button1.Name = "button1";
            button1.Size = new Size(116, 42);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(274, 433);
            button2.Name = "button2";
            button2.Size = new Size(116, 42);
            button2.TabIndex = 5;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlText;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(414, 433);
            button3.Name = "button3";
            button3.Size = new Size(116, 42);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.download__1__removebg_preview;
            pictureBox2.Location = new Point(758, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 233);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pid
            // 
            pid.Location = new Point(358, 317);
            pid.Name = "pid";
            pid.Size = new Size(252, 23);
            pid.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(143, 317);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 4;
            label6.Text = "PatientID";
            label6.Click += label2_Click;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(358, 200);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(252, 23);
            dtp1.TabIndex = 7;
            dtp1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // appointment_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 749);
            Controls.Add(dtp1);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(pid);
            Controls.Add(label5);
            Controls.Add(docid);
            Controls.Add(label4);
            Controls.Add(tm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(appnt);
            Controls.Add(panel1);
            Name = "appointment_panel";
            Text = "appointment_panel";
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
        private TextBox appnt;
        private Label label2;
        private Label label3;
        private TextBox tm;
        private Label label4;
        private TextBox docid;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private TextBox pid;
        private Label label6;
        private DateTimePicker dtp1;
    }
}