using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookishCSharp.DataAccess.daos
{
    public abstract class Dao
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultMySQLConnection"].ConnectionString;

        public string ConnectionString
        {
            get => connectionString;
        }
    }
}
