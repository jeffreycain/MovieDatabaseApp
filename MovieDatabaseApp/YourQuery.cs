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
            _f1.updateGenreListBox(GenreTB);
            _f1.updateRoleListBox(MovieCountRole);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string movieTitle = "";
            //bool MT = false;
            //if(MovieTitleTB.Text != string.Empty)
            //{
            //    movieTitle = MovieTitleTB.Text;
            //    MT = true;
            //}

            //string firstName = "";
            //bool FN = false;
            //if (FirstNameTB.Text != string.Empty)
            //{
            //    firstName = FirstNameTB.Text;
            //    FN = true;
            //}

            //string lastName = "";
            //bool LN = false;
            //if (LastNameTB.Text != string.Empty)
            //{
            //    lastName = LastNameTB.Text;
            //    LN = true;
            //}

            //string characterName = "";
            //bool CN = false;
            //if (CharacterNameTB.Text != string.Empty)
            //{
            //    characterName = CharacterNameTB.Text;
            //    CN = true;
            //}
            

            //string role = "";
            //bool R = false;
            //if (RoleTB.Text != string.Empty)
            //{
            //    role = RoleTB.Text;
            //    R = true;
            //}


            //_f1.SQLQueryConnection(query);
            this.Close();
        }

        private void RuntimeButton_Click(object sender, EventArgs e)
        {
            string runTimeMin = RunTimeMin.Value.ToString();
            string runTimeMax = RunTimeMax.Value.ToString();
            string SQLexec = "EXEC MovieDB.FetchMoviesWithRuntime " + runTimeMin + ", " + runTimeMax + ";";
            //MessageBox.Show(SQLexec);
            _f1.SQLQueryConnection(SQLexec);
            this.Close();
        }

        private void YearReleasedButton_Click(object sender, EventArgs e)
        {
            string yearMin = YearMin.Value.ToString();
            string yearMax = YearMax.Value.ToString();
            string SQLexec = "EXEC MovieDB.FetchMoviesWithYears " + yearMin + ", " + yearMax + ";";
            _f1.SQLQueryConnection(SQLexec);
            this.Close();
        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            string genre = "";
            if (GenreTB.Text != string.Empty)
            {
                genre = GenreTB.Text;
                string SQLexec = "EXEC MovieDB.FetchMoviesWithGenre '" + genre + "';";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }

        private void GenresWithMovieButton_Click(object sender, EventArgs e)
        {
            string movie = "";
            if (GenresWithMovieBox.Text != string.Empty)
            {
                movie = GenresWithMovieBox.Text;
                string SQLexec = "EXEC MovieDB.FetchGenresWithMovie '" + movie + "';";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }

        private void DirectorButton_Click(object sender, EventArgs e)
        {
            string DirOfMovie = "";
            if (DirectorTB.Text != string.Empty)
            {
                DirOfMovie = DirectorTB.Text;
                string SQLexec = "EXEC MovieDB.FetchDirectorOfMovie '" + DirOfMovie + "';";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }

        private void MoviePartialButton_Click(object sender, EventArgs e)
        {
            string MoviePT = "";
            if (MoviePartialTB.Text != string.Empty)
            {
                MoviePT = MoviePartialTB.Text;
                string SQLexec = "EXEC MovieDB.FetchFullMovieTitleFromPartialTitle '" + MoviePT + "';";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }

        private void FirstNameMovieButton_Click(object sender, EventArgs e)
        {
            if (MovieTB.Text != string.Empty && ActorFNTB.Text != string.Empty)
            {
                string movie= MovieTB.Text;
                string actor = ActorFNTB.Text;
                string SQLexec = "EXEC MovieDB.FetchActorsNameFromFirstNameAndMovie'" + actor + "', '" + movie + "';";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }



        private void RecentMovieByButton_Click(object sender, EventArgs e)
        {
            if (RecentMovieDTB.Text != string.Empty)
            {
                string director = RecentMovieDTB.Text;
                string SQLexec = "EXEC MovieDB.FetchMostRecentMovieFromDirector '" + director + "'";
                string number = MovieCount.Value.ToString();
                SQLexec += ", " + number;
                SQLexec += ";";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }

        private void MovieCountButton_Click(object sender, EventArgs e)
        {
            if (MovieCountName.Text != string.Empty && MovieCountRole.Text != string.Empty)
            {
                string actor = MovieCountName.Text;
                string role = MovieCountRole.Text;
                string SQLexec = "EXEC MovieDB.FetchNumberOfMoviesFromNameAndRole '" + actor + "', '" + role + "';";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }

        private void GOfMovieButton_Click(object sender, EventArgs e)
        {
            if (GOfMovieTB.Text != string.Empty)
            {
                string movie = GOfMovieTB.Text;
                string SQLexec = "EXEC MovieDB.FetchGenreOfMovie '" + movie + "';";
                _f1.SQLQueryConnection(SQLexec);
                this.Close();
            }
        }

 
    }
}
