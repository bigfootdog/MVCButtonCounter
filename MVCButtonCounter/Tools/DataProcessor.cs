using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCButtonCounter.Tools
{
    public class DataProcessor
    {
        protected string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public object ExecuteScalar(string query)
        {
            using (var conn = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public object ExecuteNonQuery(string sqlCommand)
        {
            using (var conn = new SqlConnection(connectionstring))
            {
                using (var cmd = new SqlCommand(sqlCommand, conn))
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }

        }

    }
}