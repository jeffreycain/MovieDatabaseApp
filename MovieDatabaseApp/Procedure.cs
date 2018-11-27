using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieDatabaseApp
{
    public partial class Procedure : Form
    {
        private Form1 _f1;
        public Procedure(Form1 f1)
        {
            InitializeComponent();
            _f1 = f1;
            updateGenreListBox();
            updateRoleListBox();
        }

        public void updateGenreListBox()
        {
            _f1.SQLQueryConnection(GenreBox,"Select MovieDB.Genre.Name From MovieDB.Genre");
            

        }
        public void updateRoleListBox()
        {
            _f1.SQLQueryConnection(RoleBox, "Select MovieDB.Role.Name From MovieDB.Role");
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || movieTitle.Text == "")
            {
                MessageBox.Show("Error all fields are required to add a person");
            }
            else {

                try
                {
                    _f1.SQLQueryConnection(results, "Exec MovieDB.ThrowError");
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (roleName.Text == "")
                MessageBox.Show("Cannot add empty role");
            else
            {
                string pass = "EXEC MovieDB.AddRole '" + roleName.Text + "';";
                _f1.SQLQueryConnection(results, pass);
                updateRoleListBox();
                MessageBox.Show ("Role Added Successfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (movie.Text == "")
                MessageBox.Show("Cannot add a movie without a title");
            else
            {
  
                string pass = "EXEC MovieDB.AddMovie '" + movie.Text + "', '" + runTime.Value + "', '" + year.Value + "', '" + GenreBox.Text + "';";
                _f1.SQLQueryConnection(results, pass);
                MessageBox.Show("Movie Added Successfully");
            }
        }
    }

        
    
}
