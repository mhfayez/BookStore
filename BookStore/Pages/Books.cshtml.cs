using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class BooksModel : PageModel
    {
 
        public List<Book> Books { get; set; }
        public Book FavoriteBook { get; set; }

        public void OnGet()
        {
             Books = BookCatalog.Books;
             FavoriteBook = BookCatalog.Books.ElementAt(new Random().Next(BookCatalog.Books.Count));

        }
    }
}
