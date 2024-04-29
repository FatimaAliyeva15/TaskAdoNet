using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext
    {
        readonly string connectionString = "Server=DESKTOP-6KN5926\\SQLEXPRESS;Database=AdoNet;Trusted_connection=true;Integrated security=true";
        SqlConnection sqlConnection;

        public AppDbContext()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command,sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return result;
        }

        public DataTable Query(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;

        }
    }
}
