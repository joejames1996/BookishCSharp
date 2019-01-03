using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookishCSharp.DataAccess.daos;
using BookishCSharp.DataAccess.models;

namespace BookishCSharp.Web.Controllers
{
    public class BookController : ApiController
    {
        private BookRepository bookRepository = new BookRepository();

        // GET: api/Book
        [Route("Books")]
        [HttpGet]
        public List<Book> Get()
        {
            return bookRepository.getBooks();
        }

        // GET: api/Book/5
        [Route("Books/{id}")]
        [HttpGet]
        public Book Get(int id)
        {
            return bookRepository.getBook(id);
        }

        // POST: api/Book
        [Route("Books")]
        [HttpPost]
        public bool Post([FromBody]Book book)
        {
            return bookRepository.insertBook(book);
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
        }
    }
}
