﻿namespace air
{
    partial class Flight_Details
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Time";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Date";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fare";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "visit_country\r\n";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(399, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Confirm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 29);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 29);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 29);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 397);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 29);
            this.textBox4.TabIndex = 8;
            // 
            // Flight_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 537);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Flight_Details";
            this.Text = "Flight_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}