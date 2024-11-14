using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbbb
{
    public class Database
    {
        private string connectionString = "Server=HOAN\\HOAN12345;Database=SanBay;Integrated Security=True;";
        private SqlConnection connection;

        public Database()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public DataTable ExecuteQuery(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
