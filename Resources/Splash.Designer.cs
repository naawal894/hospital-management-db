namespace project_DB_FORMS.Resources
{
    partial class Splash
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
            load = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // load
            // 
            load.BackColor = Color.FromArgb(100, 210, 145);
            load.Location = new Point(2, 330);
            load.Name = "load";
            load.Size = new Size(121, 15);
            load.TabIndex = 0;
            load.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(2, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 15);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(209, 136);
            label2.Name = "label2";
            label2.Size = new Size(159, 37);
            label2.TabIndex = 3;
            label2.Text = "LOADING...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(599, 345);
            Controls.Add(label2);
            Controls.Add(load);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += splash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel load;
        private Panel panel2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}