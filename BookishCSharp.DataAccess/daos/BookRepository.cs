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
    public class BookRepository : Dao, IBookRepository
    {
        public List<Book> getBooks()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(this.ConnectionString))
            {
                return mySqlConnection.Query<Book>("SELECT * FROM books").ToList();
            }
        }

        public Book getBook(int bookId)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(this.ConnectionString))
            {
                return mySqlConnection.QuerySingle<Book>(
                    "SELECT * FROM books WHERE id = @id",
                    new {id = bookId});
            }
        }

        public bool insertBook(Book book)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(this.ConnectionString))
            {
//                int rowsAffected = mySqlConnection.Execute(@"INSERT Book(")
            }
            throw new NotImplementedException();
        }

        public bool deleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public bool updateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
