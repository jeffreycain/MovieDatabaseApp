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
            _f1.updateGenreListBox(GenreBox);
            _f1.updateRoleListBox(RoleBox);
        }

       

        private void addPerson_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || movieTitle.Text == "")
            {
                MessageBox.Show("Error all fields are required to add a person");
            }
            else
            {

                try
                {
                    string pass = "EXEC MovieDB.CreatePerson '" + firstName.Text + "', '" + lastName.Text + "', '" + movieTitle.Text + "', '" + RoleBox.Text + "';";
                    _f1.SQLQueryConnection(_f1.tableBox, "Person has been added.");
                }
                catch (Exception ex)
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
                _f1.SQLQueryConnection(_f1.tableBox, pass);
                _f1.updateRoleListBox(RoleBox);
                MessageBox.Show("Role Added Successfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (movie.Text == "")
                MessageBox.Show("Cannot add a movie without a title");
            else
            {

                string pass = "EXEC MovieDB.AddMovie '" + movie.Text + "', '" + runTime.Value + "', '" + year.Value + "', '" + GenreBox.Text + "';";
                _f1.SQLQueryConnection(_f1.tableBox, pass);
                MessageBox.Show("Movie Added Successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (first.Text == "" || last.Text == "" || newLast.Text == "" || newFirst.Text == "")
                MessageBox.Show("All fields must be filled out");
            else
            {

                try
                {
                    string pass = "EXEC MovieDB.UpdatePerson '" + firstName.Text + "', '" + lastName.Text + "', '" + newFirst.Text + "', '" + newLast.Text + "';";
                    _f1.SQLQueryConnection(_f1.tableBox, "Person has been updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }

}
        
    


