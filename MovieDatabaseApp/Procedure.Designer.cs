namespace MovieDatabaseApp
{
    partial class Procedure
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
            this.addPerson = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.runTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.GenreBox = new System.Windows.Forms.ListBox();
            this.Genre = new System.Windows.Forms.Label();
            this.RoleBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.roleName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.runTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // addPerson
            // 
            this.addPerson.Location = new System.Drawing.Point(632, 11);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(86, 20);
            this.addPerson.TabIndex = 0;
            this.addPerson.Text = "Add Person";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(12, 12);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(86, 20);
            this.firstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // movie
            // 
            this.movie.Location = new System.Drawing.Point(12, 38);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(86, 20);
            this.movie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(167, 12);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(86, 20);
            this.lastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Movie Title";
            // 
            // runTime
            // 
            this.runTime.Location = new System.Drawing.Point(167, 38);
            this.runTime.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.runTime.Name = "runTime";
            this.runTime.Size = new System.Drawing.Size(86, 20);
            this.runTime.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Run Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Year Released";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(323, 39);
            this.year.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1870,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(86, 20);
            this.year.TabIndex = 11;
            this.year.Value = new decimal(new int[] {
            1870,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Movie/Update Genre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenreBox
            // 
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Location = new System.Drawing.Point(498, 41);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(86, 17);
            this.GenreBox.TabIndex = 13;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(590, 45);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 14;
            this.Genre.Text = "Genre";
            // 
            // RoleBox
            // 
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Location = new System.Drawing.Point(498, 15);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(86, 17);
            this.RoleBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Role";
            // 
            // movieTitle
            // 
            this.movieTitle.Location = new System.Drawing.Point(323, 11);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(86, 20);
            this.movieTitle.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Movie Title";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 64);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "First Name";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(167, 64);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 20);
            this.textBox6.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Last Name";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(323, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(86, 20);
            this.textBox7.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "New First Name";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(498, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(86, 20);
            this.textBox8.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "New Last Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 25);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update Person";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // roleName
            // 
            this.roleName.Location = new System.Drawing.Point(12, 93);
            this.roleName.Name = "roleName";
            this.roleName.Size = new System.Drawing.Size(86, 20);
            this.roleName.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "New Role";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 25);
            this.button3.TabIndex = 32;
            this.button3.Text = "Add Role";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.roleName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.runTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.addPerson);
            this.Name = "Procedure";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.runTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown runTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox GenreBox;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.ListBox RoleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox roleName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
    }
}