using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookishCSharp.DataAccess.models;

namespace BookishCSharp.DataAccess.daos
{
    internal interface IBookRepository
    {
        List<Book> getBooks();

        Book getBook(int bookId);

        bool insertBook(Book book);

        bool deleteBook(int bookId);

        bool updateBook(Book book);
    }
}
