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


        }

        public void updateGenreListBox()
        {
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            connectionString = "Data Source = mssql.cs.ksu.edu;Initial Catalog = CIS560_team10; Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string query = "Select MovieDB.Genre.Name From MovieDB.Genre";
            command = new SqlCommand(query, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                
             GenreBox.Items.Add(dataReader.GetValue(0));
             NewGenreBox.Items.Add(dataReader.GetValue(0));

            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }

        
    
}
