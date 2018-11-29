namespace MovieDatabaseApp
{
    partial class ReportForm
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
            this.YearlyMC = new System.Windows.Forms.Button();
            this.MoviesPG = new System.Windows.Forms.Button();
            this.CastBreakdown = new System.Windows.Forms.Button();
            this.MovieCC = new System.Windows.Forms.Button();
            this.MovieCP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YearlyMC
            // 
            this.YearlyMC.Location = new System.Drawing.Point(24, 12);
            this.YearlyMC.Name = "YearlyMC";
            this.YearlyMC.Size = new System.Drawing.Size(195, 57);
            this.YearlyMC.TabIndex = 0;
            this.YearlyMC.Text = "Yearly Movie Count";
            this.YearlyMC.UseVisualStyleBackColor = true;
            this.YearlyMC.Click += new System.EventHandler(this.YearlyMC_Click);
            // 
            // MoviesPG
            // 
            this.MoviesPG.Location = new System.Drawing.Point(24, 264);
            this.MoviesPG.Name = "MoviesPG";
            this.MoviesPG.Size = new System.Drawing.Size(195, 57);
            this.MoviesPG.TabIndex = 1;
            this.MoviesPG.Text = "Movies Per Genre";
            this.MoviesPG.UseVisualStyleBackColor = true;
            this.MoviesPG.Click += new System.EventHandler(this.MoviesPG_Click);
            // 
            // CastBreakdown
            // 
            this.CastBreakdown.Location = new System.Drawing.Point(24, 201);
            this.CastBreakdown.Name = "CastBreakdown";
            this.CastBreakdown.Size = new System.Drawing.Size(195, 57);
            this.CastBreakdown.TabIndex = 2;
            this.CastBreakdown.Text = "Cast Breakdown";
            this.CastBreakdown.UseVisualStyleBackColor = true;
            this.CastBreakdown.Click += new System.EventHandler(this.CastBreakdown_Click);
            // 
            // MovieCC
            // 
            this.MovieCC.Location = new System.Drawing.Point(24, 138);
            this.MovieCC.Name = "MovieCC";
            this.MovieCC.Size = new System.Drawing.Size(195, 57);
            this.MovieCC.TabIndex = 3;
            this.MovieCC.Text = "Movie Count (By Count)";
            this.MovieCC.UseVisualStyleBackColor = true;
            this.MovieCC.Click += new System.EventHandler(this.MovieCC_Click);
            // 
            // MovieCP
            // 
            this.MovieCP.Location = new System.Drawing.Point(24, 75);
            this.MovieCP.Name = "MovieCP";
            this.MovieCP.Size = new System.Drawing.Size(195, 57);
            this.MovieCP.TabIndex = 4;
            this.MovieCP.Text = "Movie Count (By Person)";
            this.MovieCP.UseVisualStyleBackColor = true;
            this.MovieCP.Click += new System.EventHandler(this.MovieCP_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 337);
            this.Controls.Add(this.MovieCP);
            this.Controls.Add(this.MovieCC);
            this.Controls.Add(this.CastBreakdown);
            this.Controls.Add(this.MoviesPG);
            this.Controls.Add(this.YearlyMC);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YearlyMC;
        private System.Windows.Forms.Button MoviesPG;
        private System.Windows.Forms.Button CastBreakdown;
        private System.Windows.Forms.Button MovieCC;
        private System.Windows.Forms.Button MovieCP;
    }
}