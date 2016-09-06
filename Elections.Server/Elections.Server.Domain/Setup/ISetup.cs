using MySql.Data.MySqlClient;

namespace Elections.Server.Domain.Setup
{
    public interface ISetup
    {
        MySqlConnection GetConnection();
    }
}