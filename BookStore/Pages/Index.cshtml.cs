using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BookStore.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly BookStoreDbContext _context;

        public IndexModel(BookStoreDbContext context)
        {
            _context = context;
        }

        public IList<Book> Books { get; set; }

        public async Task OnGetAsync()
        {
            Books = await _context.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(Guid id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null) return RedirectToPage();

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
