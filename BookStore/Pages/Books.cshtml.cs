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
        private readonly BookStoreDbContext _context;

        public BooksModel(BookStoreDbContext context)
        {
            _context = context;
        }
 
        public List<Book> Books { get; set; }

        public Book FavoriteBook { get; set; }

        public void OnGet()
        {

            Books = _context.Books.ToList();
            if (Books.Count > 0)
            {
                FavoriteBook = Books.ElementAt(0);
            }
                
        }
    }
}
