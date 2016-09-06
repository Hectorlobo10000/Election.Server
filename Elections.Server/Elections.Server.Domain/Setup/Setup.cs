using System.Configuration;
using MySql.Data.MySqlClient;

namespace Elections.Server.Domain.Setup
{
    public class Setup : ISetup
    {
        public MySqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Elections"].ConnectionString;
            return new MySqlConnection(connectionString);
        }
    }
}
