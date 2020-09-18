using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Charts : UserControl
    {
        public Charts()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllPlayer().Tables[0];
        }

        DataSet GetAllPlayer()
        {
            DataSet data = new DataSet();
            string query = "select Username,Email,Score from Player order by Score DESC";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

    }
}
