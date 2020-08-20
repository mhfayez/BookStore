using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Book> Books { get; set; }

        public void OnGet()
        {
            Books = BookCatalog.Books;
        }

        public IActionResult OnPostDelete(int id)
        {
            //gets all the books from the catalog and assigns them to the Books list/property of this class 
            Books = BookCatalog.Books;
            //finds the book in the Books list with the id we received in the delete request
            var book = Books.Find(b => b.Id == id);

            if (book == null) return RedirectToPage();
            //removes the book from the Books list property og this class.
            Books.Remove(book);

            return RedirectToPage();
        }
    }
}
