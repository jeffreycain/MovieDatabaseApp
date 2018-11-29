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
            this.tableBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Pform = new System.Windows.Forms.Button();
            this.TableReader = new System.Windows.Forms.DataGridView();
            this.ReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableReader)).BeginInit();
            this.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(610, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 76);
            this.button3.TabIndex = 3;
            this.button3.Text = "Movie Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pform
            // 
            this.Pform.Location = new System.Drawing.Point(610, 94);
            this.Pform.Name = "Pform";
            this.Pform.Size = new System.Drawing.Size(216, 95);
            this.Pform.TabIndex = 4;
            this.Pform.Text = "Procedure Form";
            this.Pform.UseVisualStyleBackColor = true;
            this.Pform.Click += new System.EventHandler(this.Pform_Click);
            // 
            // TableReader
            // 
            this.TableReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableReader.Location = new System.Drawing.Point(12, 10);
            this.TableReader.Name = "TableReader";
            this.TableReader.Size = new System.Drawing.Size(592, 593);
            this.TableReader.TabIndex = 18;
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(610, 195);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(216, 95);
            this.ReportButton.TabIndex = 19;
            this.ReportButton.Text = "Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 637);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.TableReader);
            this.Controls.Add(this.Pform);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TableReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Pform;
        public System.Windows.Forms.ListBox tableBox;
        public System.Windows.Forms.DataGridView TableReader;
        private System.Windows.Forms.Button ReportButton;
    }
}

