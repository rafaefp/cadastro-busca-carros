using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Tarefa42
{
    public class DBConnectionFactory
    {
        public static SqlConnection GetInstance()
        {
            System.Data.SqlClient.SqlConnection connection;

            connection = new System.Data.SqlClient.SqlConnection();

            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            return connection;
        }
    }
}
