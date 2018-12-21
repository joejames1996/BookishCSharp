﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookishCSharp.DataAccess.models
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int BookCategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Slug { get; set; }
        public string Isbn { get; set; }
        public string Subtitle { get; set; }
        public string CoverPhotoUrl { get; set; }

        public Book()
        {

        }

        public override string ToString()
        {
            return "========== " + this.Title + " ==========\n" +
                   "ID: " + this.Id + "\n" +
                   "Author: " + this.Author + "\n" +
                   "==============================";
        }
    }
}
