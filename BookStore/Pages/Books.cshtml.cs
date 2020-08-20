using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //If Books list is empty then returns an empty object.
            //To avoid errors on Books.cshtml page
            FavoriteBook = Books.Count > 0 ? BookCatalog.Books.ElementAt(new Random().Next(BookCatalog.Books.Count)) : new Book();
        }
    }
}
