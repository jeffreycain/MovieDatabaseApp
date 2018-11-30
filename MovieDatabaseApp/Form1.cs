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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void updateGenreListBox(ListBox b)
        {
            SQLQueryConnectionListBox(b, "Select MovieDB.Genre.Name From MovieDB.Genre");


        }
        public void updateRoleListBox(ListBox r)
        {
            SQLQueryConnectionListBox(r, "Select MovieDB.Role.Name From MovieDB.Role");
        }

        public void SQLQueryConnection(ListBox b, string query)
        {

            b.Items.Clear();
            for (int x = 0; x < TableReader.ColumnCount; x++)
                TableReader.Columns.RemoveAt(x);

            string connectionString = null;
            SqlConnection cnn;
            //SqlCommand command;
            //SqlDataReader dataReader;
            connectionString = "Data Source = mssql.cs.ksu.edu;Initial Catalog = CIS560_team10; Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //command = new SqlCommand(query, cnn);
            //           dataReader = command.ExecuteReader();


            //then loop over the number

            //while (dataReader.Read())
            //{
            //    Object[] MyObjectX = new object[dataReader.FieldCount];
            //    int columnsX = dataReader.GetValues(MyObjectX);
            //    tableBox.Items.Add(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3));
            //    string insertsX = "";


            //    for (int x = 0; x < columnsX; x++)
            //    {
            //        insertsX += dataReader.GetValue(x);
            //        if (x < columnsX - 1)
            //            insertsX += " - ";
            //    }
            //    b.Items.Add(insertsX);



            //}

            //dataReader.Close();


            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, cnn);
            adapt.Fill(dt);
            TableReader.DataSource = dt;


            adapt.Dispose();
            //command.Dispose();
            cnn.Close();
        }

        public void SQLQueryConnectionListBox(ListBox b, string query)
        {

            b.Items.Clear();
            for (int x = 0; x < TableReader.ColumnCount; x++)
                TableReader.Columns.RemoveAt(x);

            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            connectionString = "Data Source = mssql.cs.ksu.edu;Initial Catalog = CIS560_team10; Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            command = new SqlCommand(query, cnn);
                       dataReader = command.ExecuteReader();


            //then loop over the number

            while (dataReader.Read())
            {
                Object[] MyObjectX = new object[dataReader.FieldCount];
                int columnsX = dataReader.GetValues(MyObjectX);
                //tableBox.Items.Add(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3));
                string insertsX = "";


                for (int x = 0; x < columnsX; x++)
                {
                    insertsX += dataReader.GetValue(x);
                    if (x < columnsX - 1)
                        insertsX += " - ";
                }
                b.Items.Add(insertsX);



            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            try
            {
                SQLQueryConnection(tableBox, b.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YourQuery YQ = new YourQuery(this);
            YQ.Show();
        }

        private void Pform_Click(object sender, EventArgs e)
        {
            Procedure p = new Procedure(this);
            p.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm RF = new ReportForm(this);
            RF.Show();
        }
    }
}
