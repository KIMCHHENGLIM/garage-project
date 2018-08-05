namespace Garage_System
{
    partial class Custom_MassageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.circularButton1 = new Garage_System.CircularButton();
            this.circularButton2 = new Garage_System.CircularButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are You Sure Want To Exit ?";
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.Crimson;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.circularButton1.Location = new System.Drawing.Point(59, 59);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(85, 85);
            this.circularButton1.TabIndex = 1;
            this.circularButton1.Text = "YES";
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackColor = System.Drawing.Color.YellowGreen;
            this.circularButton2.FlatAppearance.BorderSize = 0;
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.circularButton2.Location = new System.Drawing.Point(169, 59);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(85, 85);
            this.circularButton2.TabIndex = 2;
            this.circularButton2.Text = "NO";
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // Custom_MassageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 164);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Custom_MassageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom_MassageBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CircularButton circularButton1;
        private CircularButton circularButton2;
    }
}