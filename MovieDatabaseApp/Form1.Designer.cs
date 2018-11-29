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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.TableReader = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableReader)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXEC MovieDB.FetchMoviesWithRuntime 61, 62;";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "EXEC MovieDB.FetchDirectorOfMovie \'Rasputin\';";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // tableBox
            // 
            this.tableBox.FormattingEnabled = true;
            this.tableBox.Location = new System.Drawing.Point(942, 578);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(10, 17);
            this.tableBox.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(891, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 76);
            this.button3.TabIndex = 3;
            this.button3.Text = "Movie Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pform
            // 
            this.Pform.Location = new System.Drawing.Point(891, 92);
            this.Pform.Name = "Pform";
            this.Pform.Size = new System.Drawing.Size(216, 95);
            this.Pform.TabIndex = 4;
            this.Pform.Text = "Procedure Form";
            this.Pform.UseVisualStyleBackColor = true;
            this.Pform.Click += new System.EventHandler(this.Pform_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(263, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "EXEC MovieDB.FetchMoviesWithGenre \'Biography\';";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "EXEC MovieDB.FetchMoviesWithYears 1919, 1920;";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 134);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(263, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "EXEC MovieDB.FetchGenresWithMovie \'Salesman\';";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Report Type Procedures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Question Type Procedures";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(263, 38);
            this.button7.TabIndex = 10;
            this.button7.Text = "EXEC MovieDB.FetchFullMovieTitleFromPartialTitle \'cruise make\';";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(10, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(263, 47);
            this.button8.TabIndex = 11;
            this.button8.Text = "EXEC MovieDB.FetchActorsNameFromFirstNameAndMovie \'Jenny\', \'outlaw wife\';";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 313);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(263, 47);
            this.button9.TabIndex = 12;
            this.button9.Text = "EXEC MovieDB.FetchActorsNameFromFirstNameAndMovie \'Jenny\', \'outlaw wife\';";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(10, 366);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(263, 47);
            this.button10.TabIndex = 13;
            this.button10.Text = "EXEC MovieDB.FetchMostRecentMovieFromDirector \'Arthur Ashley\';";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(10, 419);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(263, 47);
            this.button11.TabIndex = 14;
            this.button11.Text = "EXEC MovieDB.FetchMostRecentMovieFromDirector \'Charles Seay\', 2;";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(10, 472);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(263, 47);
            this.button12.TabIndex = 15;
            this.button12.Text = "EXEC MovieDB.FetchNumberOfMoviesFromNameAndRole \'George Melford\', \'Director\';";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(10, 525);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(263, 47);
            this.button13.TabIndex = 16;
            this.button13.Text = "EXEC MovieDB.FetchNumberOfMoviesFromNameAndRole \'Baby Rue\', \'Actor\';";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(10, 578);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(263, 25);
            this.button14.TabIndex = 17;
            this.button14.Text = "EXEC MovieDB.FetchGenreOfMovie \'Donna\';";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // TableReader
            // 
            this.TableReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableReader.Location = new System.Drawing.Point(293, 10);
            this.TableReader.Name = "TableReader";
            this.TableReader.Size = new System.Drawing.Size(592, 593);
            this.TableReader.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 637);
            this.Controls.Add(this.TableReader);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Pform);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TableReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Pform;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        public System.Windows.Forms.ListBox tableBox;
        private System.Windows.Forms.Button button14;
        public System.Windows.Forms.DataGridView TableReader;
    }
}

