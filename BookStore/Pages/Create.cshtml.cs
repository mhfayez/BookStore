using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class CreateModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book NewBook { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //To give the new book an Id
            //We could use GUID in the Catalog to avoid this
            NewBook.Id = BookCatalog.Books.Count + 1;
            BookCatalog.AddBook(NewBook);

            return RedirectToPage("./Index");
        }
    }
}
