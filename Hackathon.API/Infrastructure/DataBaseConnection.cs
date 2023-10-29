using System.Data;
using System.Data.SqlClient;

namespace Hackathon.API.Infrastructure
{
    public class DataBaseConnection
    {

        public DataBaseConnection()
        {
            
        }
        public IDbConnection ConnectToDataBase()
        {
            string conectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=HackathonDataBase";
            IDbConnection connection = new SqlConnection(conectionString);
            connection.Open();
            return connection;
        }
    }
}
