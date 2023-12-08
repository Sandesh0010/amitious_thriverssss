namespace hackathonproject
{
    partial class Quizcat
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
            this.generalk = new System.Windows.Forms.Button();
            this.Science = new System.Windows.Forms.Button();
            this.Technology = new System.Windows.Forms.Button();
            this.previous1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generalk
            // 
            this.generalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalk.Location = new System.Drawing.Point(720, 176);
            this.generalk.Name = "generalk";
            this.generalk.Size = new System.Drawing.Size(311, 93);
            this.generalk.TabIndex = 0;
            this.generalk.Text = "General Knowledge";
            this.generalk.UseVisualStyleBackColor = true;
            this.generalk.Click += new System.EventHandler(this.generalk_Click);
            // 
            // Science
            // 
            this.Science.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Science.Location = new System.Drawing.Point(720, 310);
            this.Science.Name = "Science";
            this.Science.Size = new System.Drawing.Size(311, 93);
            this.Science.TabIndex = 1;
            this.Science.Text = "Science";
            this.Science.UseVisualStyleBackColor = true;
            this.Science.Click += new System.EventHandler(this.Science_Click);
            // 
            // Technology
            // 
            this.Technology.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technology.Location = new System.Drawing.Point(720, 437);
            this.Technology.Name = "Technology";
            this.Technology.Size = new System.Drawing.Size(311, 93);
            this.Technology.TabIndex = 2;
            this.Technology.Text = "Technology";
            this.Technology.UseVisualStyleBackColor = true;
            // 
            // previous1
            // 
            this.previous1.Location = new System.Drawing.Point(12, 512);
            this.previous1.Name = "previous1";
            this.previous1.Size = new System.Drawing.Size(97, 38);
            this.previous1.TabIndex = 3;
            this.previous1.Text = "Previous";
            this.previous1.UseVisualStyleBackColor = true;
            this.previous1.Click += new System.EventHandler(this.previous1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-25, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2555, 111);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hackathonproject.Properties.Resources.Screenshot_2023_12_07_225419;
            this.pictureBox1.Location = new System.Drawing.Point(745, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Quizcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1644, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.previous1);
            this.Controls.Add(this.Technology);
            this.Controls.Add(this.Science);
            this.Controls.Add(this.generalk);
            this.Name = "Quizcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Categories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generalk;
        private System.Windows.Forms.Button Science;
        private System.Windows.Forms.Button Technology;
        private System.Windows.Forms.Button previous1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}