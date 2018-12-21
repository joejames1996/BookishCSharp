using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BookishCSharp.DataAccess.daos;
using BookishCSharp.DataAccess.models;
using MySql.Data.MySqlClient;

namespace BookishCSharp.DataAccess
{
    public class DataAccess
    {
        public static IDbConnection DbConnection { get; set; }

        public static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DbConnection = new MySqlConnection(connectionString);

            foreach (Book b in new BookDao().getAllBooks())
            {
                Console.WriteLine(b.ToString());
            }
        }
    }
}
