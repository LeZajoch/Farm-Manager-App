using System.Data.SqlClient;

namespace Farm_Manager.logic.database
{
    public class DatabaseConnection
    {
        public SqlConnection Connection { get; set; }
        public SqlConnectionStringBuilder ConnectionStringBuilder { get; set; }
    }
}