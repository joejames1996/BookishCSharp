using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookishCSharp.DataAccess.models;
using Dapper;
using MySql.Data.MySqlClient;

namespace BookishCSharp.DataAccess.daos
{
    class BookDao : Dao
    {
        public List<Book> getAllBooks()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(this.ConnectionString))
            {
                try
                {
                    mySqlConnection.Open();
                    return mySqlConnection.Query<Book>("SELECT * FROM books").ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}
