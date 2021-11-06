﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghiran_Ionut_Lab8.Data;
using Ghiran_Ionut_Lab8.Models;

namespace Ghiran_Ionut_Lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Ghiran_Ionut_Lab8.Data.Ghiran_Ionut_Lab8Context _context;

        public DetailsModel(Ghiran_Ionut_Lab8.Data.Ghiran_Ionut_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.Publisher).FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
