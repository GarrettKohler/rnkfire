using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using rankfire.Data;

namespace rankfire.Pages.Retailer
{
    public class CreateModel : PageModel
    {
        private readonly rankfire.Data.ApplicationDbContext _context;

        public CreateModel(rankfire.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public rankfire.Data.Retailer Retailer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Retailer.Add(Retailer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
