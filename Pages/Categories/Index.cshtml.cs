using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghiran_Ionut_Lab8.Data;
using Ghiran_Ionut_Lab8.Models;

namespace Ghiran_Ionut_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Ghiran_Ionut_Lab8.Data.Ghiran_Ionut_Lab8Context _context;

        public IndexModel(Ghiran_Ionut_Lab8.Data.Ghiran_Ionut_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher).ToListAsync();
        }
    }
}
