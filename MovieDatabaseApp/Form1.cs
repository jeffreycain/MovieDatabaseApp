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


        public void SQLQueryConnection(string query)
        {

            tableBox.Items.Clear();

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
                Object[] MyObject = new object[dataReader.FieldCount];
                int columns = dataReader.GetValues(MyObject);
                //tableBox.Items.Add(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3));
                string inserts = "";
                for (int x = 0; x < columns; x++)
                {
                    inserts += dataReader.GetValue(x);
                    if (x < columns - 1)
                        inserts += " - ";
                }
                tableBox.Items.Add(inserts);

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
                SQLQueryConnection(b.Text);
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
    }
}
