using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseApp
{
    public partial class ReportForm : Form
    {
        private Form1 _f1;
        public ReportForm(Form1 f1)
        {
            InitializeComponent();
            _f1 = f1;
        }

        private void YearlyMC_Click(object sender, EventArgs e)
        {
            string SQLexec = "EXEC MovieDB.FetchYearlyMovieCount;";
            _f1.SQLQueryConnection(SQLexec);
            this.Close();
        }

        private void MovieCP_Click(object sender, EventArgs e)
        {
            string SQLexec = "EXEC MovieDB.FetchPersonMovieCountsOrderByPerson;";
            _f1.SQLQueryConnection(SQLexec);
            this.Close();
        }

        private void MovieCC_Click(object sender, EventArgs e)
        {
            string SQLexec = "EXEC MovieDB.FetchPersonMovieCountsOrderByCount;";
            _f1.SQLQueryConnection(SQLexec);
            this.Close();
        }

        private void CastBreakdown_Click(object sender, EventArgs e)
        {
            string SQLexec = "EXEC MovieDB.FetchMovieCastAggregation";
            _f1.SQLQueryConnection(SQLexec);
            this.Close();
        }

        private void MoviesPG_Click(object sender, EventArgs e)
        {
            string SQLexec = "EXEC MovieDB.FetchGenreMovieCounts;";
            _f1.SQLQueryConnection(SQLexec);
            this.Close();
        }
    }
}
