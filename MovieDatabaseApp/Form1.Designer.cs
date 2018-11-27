namespace MovieDatabaseApp
{
    partial class Form1
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
            this.tableBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Pform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select *\r\nFrom test.Person";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Select *\r\nFrom MovieDB.Genre";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // tableBox
            // 
            this.tableBox.FormattingEnabled = true;
            this.tableBox.Location = new System.Drawing.Point(151, 10);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(953, 420);
            this.tableBox.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1110, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 76);
            this.button3.TabIndex = 3;
            this.button3.Text = "2nd Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pform
            // 
            this.Pform.Location = new System.Drawing.Point(1110, 88);
            this.Pform.Name = "Pform";
            this.Pform.Size = new System.Drawing.Size(216, 95);
            this.Pform.TabIndex = 4;
            this.Pform.Text = "Procedure Form";
            this.Pform.UseVisualStyleBackColor = true;
            this.Pform.Click += new System.EventHandler(this.Pform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 450);
            this.Controls.Add(this.Pform);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox tableBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Pform;
    }
}

