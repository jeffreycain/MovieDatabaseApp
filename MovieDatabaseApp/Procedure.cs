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
            _f1.SQLQueryConnection(NewGenreBox, "Select MovieDB.Genre.Name From MovieDB.Genre");

        }
        public void updateRoleListBox()
        {
            _f1.SQLQueryConnection(RoleBox, "Select MovieDB.Role.Name From MovieDB.Role");
        }
    }

        
    
}
