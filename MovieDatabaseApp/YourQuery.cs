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
    public partial class YourQuery : Form
    {
        private Form1 _f1;
        public YourQuery(Form1 f1)
        {
            InitializeComponent();
            _f1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movieTitle = "";
            bool MT = false;
            if(MovieTitleTB.Text != string.Empty)
            {
                movieTitle = MovieTitleTB.Text;
                MT = true;
            }

            string firstName = "";
            bool FN = false;
            if (FirstNameTB.Text != string.Empty)
            {
                firstName = FirstNameTB.Text;
                FN = true;
            }

            string lastName = "";
            bool LN = false;
            if (LastNameTB.Text != string.Empty)
            {
                lastName = LastNameTB.Text;
                LN = true;
            }

            string characterName = "";
            bool CN = false;
            if (CharacterNameTB.Text != string.Empty)
            {
                characterName = CharacterNameTB.Text;
                CN = true;
            }

            string genre = "";
            bool G = false;
            if (GenreTB.Text != string.Empty)
            {
                genre = GenreTB.Text;
                G = true;
            }

            string role = "";
            bool R = false;
            if (RoleTB.Text != string.Empty)
            {
                role = RoleTB.Text;
                R = true;
            }

            string yearMin = YearMin.Value.ToString();
            string yearMax = YearMax.Value.ToString();

            string runTimeMin = RunTimeMin.Value.ToString();
            string runTimeMax = RunTimeMax.Value.ToString();

            string query = "SELECT ";
            if (MT)
            {
                query += "M.Title, ";
                query += "M.YearReleased, ";
                query += "M.RunTime ";
            }
            if (FN)
                query += "P.FirstName, ";
            if (LN)
                query += "P.LastName, ";
            if (CN)
                query += "MP.CharacterName, ";
            if (G)
                query += "G.Name, ";
            if (R)
                query += "R.Name, ";
            

            query += "FROM MovieDB.MoviePerson MP";
            query += " INNER JOIN MovieDB.Person P ON P.PersonID = MP.PersonID";
            query += " INNER JOIN MovieDB.Role R ON R.RoleID = MP.RoleID";
            query += " INNER JOIN MovieDB.Movie M ON M.MovieID = MP.MovieID";
            query += " INNER JOIN MovieDB.MovieGenre MG ON MG.MovieID = M.MovieID";
            query += " INNER JOIN MovieDB.Genre G ON MG.GenreID = G.GenreID";
            query += " WHERE M.RunTime >= " + runTimeMin + " AND M.RunTime < " + runTimeMax;


            _f1.SQLQueryConnection("EXEC MovieDB.FetchMoviesWithRunTime 61, 62");
            this.Close();
        }
    }
}
