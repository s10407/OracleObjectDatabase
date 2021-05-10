using Oracle.DataAccess.Client;
using System;
using System.Configuration;

namespace OracleObjectDatabase.DAL
{
    public class OracleObjectContext
    {
        private readonly string connectionString;
        private static OracleObjectContext _instance;
        private static readonly object padlock = new object();

        public static OracleObjectContext Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new OracleObjectContext();
                    }
                    return _instance;
                }
            }
        }

        private OracleObjectContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["oracle"].ConnectionString;
        }

        public void ExecuteQuery(string sql, params OracleParameter[] parameters)
        {
            try
            {
                using (var conn = new OracleConnection(connectionString))
                {
                    var command = conn.CreateCommand();
                    foreach (var parameter in parameters)
                        command.Parameters.Add(parameter);
                    command.CommandText = sql;
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}