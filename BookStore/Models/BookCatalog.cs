using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Data
{
    public static class BookCatalog
    {

        public static List<Book> Books {get;set;} = new List<Book>
        {
            new Book {Id = 1, Name = "C sharp", Description = "A book on C sharp", Price = 200, ImageName = "c-sharp.PNG"},
            new Book {Id = 2, Name = "PHP", Description = "PHP Rocks", Price = 200, ImageName = "php.PNG"},
            new Book {Id = 3, Name = "Ruby on Rails", Description = "It is not so old yet", Price = 200, ImageName = "ruby-on-rails.PNG"},
            new Book {Id = 4, Name = "JavaScript", Description = "You should use a framework", Price = 200, ImageName = "javascript.PNG"}
        };

        public static void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}
