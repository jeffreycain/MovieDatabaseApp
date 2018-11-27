namespace MovieDatabaseApp
{
    partial class YourQuery
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
            this.GenreTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.YearMin = new System.Windows.Forms.NumericUpDown();
            this.RunTimeMax = new System.Windows.Forms.NumericUpDown();
            this.RunTimeMin = new System.Windows.Forms.NumericUpDown();
            this.YearMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GenreButton = new System.Windows.Forms.Button();
            this.YearReleasedButton = new System.Windows.Forms.Button();
            this.RuntimeButton = new System.Windows.Forms.Button();
            this.GenresWithMovieBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GenresWithMovieButton = new System.Windows.Forms.Button();
            this.DirectorTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DirectorButton = new System.Windows.Forms.Button();
            this.MoviePartialButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.MoviePartialTB = new System.Windows.Forms.TextBox();
            this.FirstNameMovieButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ActorFNTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MovieTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RecentMovieDTB = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.MovieCount = new System.Windows.Forms.NumericUpDown();
            this.RecentMovieByButton = new System.Windows.Forms.Button();
            this.MovieCountRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieCountButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieCountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GOfMovieTB = new System.Windows.Forms.TextBox();
            this.GOfMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunTimeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCount)).BeginInit();
            this.SuspendLayout();
            // 
            // GenreTB
            // 
            this.GenreTB.Location = new System.Drawing.Point(129, 12);
            this.GenreTB.Name = "GenreTB";
            this.GenreTB.Size = new System.Drawing.Size(129, 20);
            this.GenreTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MoviesWithGenre";
            // 
            // YearMin
            // 
            this.YearMin.Location = new System.Drawing.Point(129, 76);
            this.YearMin.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.YearMin.Minimum = new decimal(new int[] {
            1894,
            0,
            0,
            0});
            this.YearMin.Name = "YearMin";
            this.YearMin.Size = new System.Drawing.Size(129, 20);
            this.YearMin.TabIndex = 13;
            this.YearMin.Value = new decimal(new int[] {
            1894,
            0,
            0,
            0});
            // 
            // RunTimeMax
            // 
            this.RunTimeMax.Location = new System.Drawing.Point(332, 114);
            this.RunTimeMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.RunTimeMax.Name = "RunTimeMax";
            this.RunTimeMax.Size = new System.Drawing.Size(129, 20);
            this.RunTimeMax.TabIndex = 14;
            this.RunTimeMax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // RunTimeMin
            // 
            this.RunTimeMin.Location = new System.Drawing.Point(129, 114);
            this.RunTimeMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.RunTimeMin.Name = "RunTimeMin";
            this.RunTimeMin.Size = new System.Drawing.Size(129, 20);
            this.RunTimeMin.TabIndex = 15;
            // 
            // YearMax
            // 
            this.YearMax.Location = new System.Drawing.Point(332, 76);
            this.YearMax.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.YearMax.Minimum = new decimal(new int[] {
            1894,
            0,
            0,
            0});
            this.YearMax.Name = "YearMax";
            this.YearMax.Size = new System.Drawing.Size(129, 20);
            this.YearMax.TabIndex = 16;
            this.YearMax.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Between";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Between";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Year Released";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Run Time(Minutes)";
            // 
            // GenreButton
            // 
            this.GenreButton.Location = new System.Drawing.Point(264, 12);
            this.GenreButton.Name = "GenreButton";
            this.GenreButton.Size = new System.Drawing.Size(96, 24);
            this.GenreButton.TabIndex = 25;
            this.GenreButton.Text = "Confirm";
            this.GenreButton.UseVisualStyleBackColor = true;
            this.GenreButton.Click += new System.EventHandler(this.GenreButton_Click);
            // 
            // YearReleasedButton
            // 
            this.YearReleasedButton.Location = new System.Drawing.Point(467, 76);
            this.YearReleasedButton.Name = "YearReleasedButton";
            this.YearReleasedButton.Size = new System.Drawing.Size(96, 24);
            this.YearReleasedButton.TabIndex = 27;
            this.YearReleasedButton.Text = "Confirm";
            this.YearReleasedButton.UseVisualStyleBackColor = true;
            this.YearReleasedButton.Click += new System.EventHandler(this.YearReleasedButton_Click);
            // 
            // RuntimeButton
            // 
            this.RuntimeButton.Location = new System.Drawing.Point(467, 110);
            this.RuntimeButton.Name = "RuntimeButton";
            this.RuntimeButton.Size = new System.Drawing.Size(96, 24);
            this.RuntimeButton.TabIndex = 28;
            this.RuntimeButton.Text = "Confirm";
            this.RuntimeButton.UseVisualStyleBackColor = true;
            this.RuntimeButton.Click += new System.EventHandler(this.RuntimeButton_Click);
            // 
            // GenresWithMovieBox
            // 
            this.GenresWithMovieBox.Location = new System.Drawing.Point(129, 38);
            this.GenresWithMovieBox.Name = "GenresWithMovieBox";
            this.GenresWithMovieBox.Size = new System.Drawing.Size(129, 20);
            this.GenresWithMovieBox.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "GenresWithMovie";
            // 
            // GenresWithMovieButton
            // 
            this.GenresWithMovieButton.Location = new System.Drawing.Point(264, 38);
            this.GenresWithMovieButton.Name = "GenresWithMovieButton";
            this.GenresWithMovieButton.Size = new System.Drawing.Size(96, 24);
            this.GenresWithMovieButton.TabIndex = 31;
            this.GenresWithMovieButton.Text = "Confirm";
            this.GenresWithMovieButton.UseVisualStyleBackColor = true;
            this.GenresWithMovieButton.Click += new System.EventHandler(this.GenresWithMovieButton_Click);
            // 
            // DirectorTB
            // 
            this.DirectorTB.Location = new System.Drawing.Point(129, 140);
            this.DirectorTB.Name = "DirectorTB";
            this.DirectorTB.Size = new System.Drawing.Size(129, 20);
            this.DirectorTB.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Director of Movie";
            // 
            // DirectorButton
            // 
            this.DirectorButton.Location = new System.Drawing.Point(264, 137);
            this.DirectorButton.Name = "DirectorButton";
            this.DirectorButton.Size = new System.Drawing.Size(96, 24);
            this.DirectorButton.TabIndex = 34;
            this.DirectorButton.Text = "Confirm";
            this.DirectorButton.UseVisualStyleBackColor = true;
            this.DirectorButton.Click += new System.EventHandler(this.DirectorButton_Click);
            // 
            // MoviePartialButton
            // 
            this.MoviePartialButton.Location = new System.Drawing.Point(264, 165);
            this.MoviePartialButton.Name = "MoviePartialButton";
            this.MoviePartialButton.Size = new System.Drawing.Size(96, 24);
            this.MoviePartialButton.TabIndex = 37;
            this.MoviePartialButton.Text = "Confirm";
            this.MoviePartialButton.UseVisualStyleBackColor = true;
            this.MoviePartialButton.Click += new System.EventHandler(this.MoviePartialButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Movie Partial Title:";
            // 
            // MoviePartialTB
            // 
            this.MoviePartialTB.Location = new System.Drawing.Point(129, 168);
            this.MoviePartialTB.Name = "MoviePartialTB";
            this.MoviePartialTB.Size = new System.Drawing.Size(129, 20);
            this.MoviePartialTB.TabIndex = 35;
            // 
            // FirstNameMovieButton
            // 
            this.FirstNameMovieButton.Location = new System.Drawing.Point(403, 191);
            this.FirstNameMovieButton.Name = "FirstNameMovieButton";
            this.FirstNameMovieButton.Size = new System.Drawing.Size(96, 24);
            this.FirstNameMovieButton.TabIndex = 40;
            this.FirstNameMovieButton.Text = "Confirm";
            this.FirstNameMovieButton.UseVisualStyleBackColor = true;
            this.FirstNameMovieButton.Click += new System.EventHandler(this.FirstNameMovieButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Actor:";
            // 
            // ActorFNTB
            // 
            this.ActorFNTB.Location = new System.Drawing.Point(52, 195);
            this.ActorFNTB.Name = "ActorFNTB";
            this.ActorFNTB.Size = new System.Drawing.Size(129, 20);
            this.ActorFNTB.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(198, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "and Movie:";
            // 
            // MovieTB
            // 
            this.MovieTB.Location = new System.Drawing.Point(264, 194);
            this.MovieTB.Name = "MovieTB";
            this.MovieTB.Size = new System.Drawing.Size(129, 20);
            this.MovieTB.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Most Recent Movie By:";
            // 
            // RecentMovieDTB
            // 
            this.RecentMovieDTB.Location = new System.Drawing.Point(136, 331);
            this.RecentMovieDTB.Name = "RecentMovieDTB";
            this.RecentMovieDTB.Size = new System.Drawing.Size(129, 20);
            this.RecentMovieDTB.TabIndex = 44;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 360);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 17);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Multiple recent movies";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MovieCount
            // 
            this.MovieCount.Enabled = false;
            this.MovieCount.Location = new System.Drawing.Point(151, 357);
            this.MovieCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MovieCount.Name = "MovieCount";
            this.MovieCount.Size = new System.Drawing.Size(115, 20);
            this.MovieCount.TabIndex = 46;
            this.MovieCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RecentMovieByButton
            // 
            this.RecentMovieByButton.Location = new System.Drawing.Point(271, 331);
            this.RecentMovieByButton.Name = "RecentMovieByButton";
            this.RecentMovieByButton.Size = new System.Drawing.Size(96, 24);
            this.RecentMovieByButton.TabIndex = 47;
            this.RecentMovieByButton.Text = "Confirm";
            this.RecentMovieByButton.UseVisualStyleBackColor = true;
            this.RecentMovieByButton.Click += new System.EventHandler(this.RecentMovieByButton_Click);
            // 
            // MovieCountRole
            // 
            this.MovieCountRole.Location = new System.Drawing.Point(333, 225);
            this.MovieCountRole.Name = "MovieCountRole";
            this.MovieCountRole.Size = new System.Drawing.Size(129, 20);
            this.MovieCountRole.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "and Role:";
            // 
            // MovieCountButton
            // 
            this.MovieCountButton.Location = new System.Drawing.Point(472, 222);
            this.MovieCountButton.Name = "MovieCountButton";
            this.MovieCountButton.Size = new System.Drawing.Size(96, 24);
            this.MovieCountButton.TabIndex = 50;
            this.MovieCountButton.Text = "Confirm";
            this.MovieCountButton.UseVisualStyleBackColor = true;
            this.MovieCountButton.Click += new System.EventHandler(this.MovieCountButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Movie Count Name:";
            // 
            // MovieCountName
            // 
            this.MovieCountName.Location = new System.Drawing.Point(121, 226);
            this.MovieCountName.Name = "MovieCountName";
            this.MovieCountName.Size = new System.Drawing.Size(129, 20);
            this.MovieCountName.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Genres of Movie:";
            // 
            // GOfMovieTB
            // 
            this.GOfMovieTB.Location = new System.Drawing.Point(106, 257);
            this.GOfMovieTB.Name = "GOfMovieTB";
            this.GOfMovieTB.Size = new System.Drawing.Size(129, 20);
            this.GOfMovieTB.TabIndex = 54;
            // 
            // GOfMovieButton
            // 
            this.GOfMovieButton.Location = new System.Drawing.Point(241, 254);
            this.GOfMovieButton.Name = "GOfMovieButton";
            this.GOfMovieButton.Size = new System.Drawing.Size(96, 24);
            this.GOfMovieButton.TabIndex = 55;
            this.GOfMovieButton.Text = "Confirm";
            this.GOfMovieButton.UseVisualStyleBackColor = true;
            this.GOfMovieButton.Click += new System.EventHandler(this.GOfMovieButton_Click);
            // 
            // YourQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.GOfMovieButton);
            this.Controls.Add(this.GOfMovieTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MovieCountRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieCountButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovieCountName);
            this.Controls.Add(this.RecentMovieByButton);
            this.Controls.Add(this.MovieCount);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RecentMovieDTB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.MovieTB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.FirstNameMovieButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ActorFNTB);
            this.Controls.Add(this.MoviePartialButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MoviePartialTB);
            this.Controls.Add(this.DirectorButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DirectorTB);
            this.Controls.Add(this.GenresWithMovieButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GenresWithMovieBox);
            this.Controls.Add(this.RuntimeButton);
            this.Controls.Add(this.YearReleasedButton);
            this.Controls.Add(this.GenreButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.YearMax);
            this.Controls.Add(this.RunTimeMin);
            this.Controls.Add(this.RunTimeMax);
            this.Controls.Add(this.YearMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenreTB);
            this.Name = "YourQuery";
            this.Text = "YourQuery";
            ((System.ComponentModel.ISupportInitialize)(this.YearMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunTimeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GenreTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown YearMin;
        private System.Windows.Forms.NumericUpDown RunTimeMax;
        private System.Windows.Forms.NumericUpDown RunTimeMin;
        private System.Windows.Forms.NumericUpDown YearMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button GenreButton;
        private System.Windows.Forms.Button YearReleasedButton;
        private System.Windows.Forms.Button RuntimeButton;
        private System.Windows.Forms.TextBox GenresWithMovieBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button GenresWithMovieButton;
        private System.Windows.Forms.TextBox DirectorTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DirectorButton;
        private System.Windows.Forms.Button MoviePartialButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MoviePartialTB;
        private System.Windows.Forms.Button FirstNameMovieButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ActorFNTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MovieTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RecentMovieDTB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown MovieCount;
        private System.Windows.Forms.Button RecentMovieByButton;
        private System.Windows.Forms.TextBox MovieCountRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MovieCountButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MovieCountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GOfMovieTB;
        private System.Windows.Forms.Button GOfMovieButton;
    }
}