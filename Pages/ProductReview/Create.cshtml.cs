using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using rankfire.Data;

namespace rankfire.Pages.ProductReview
{
    public class CreateModel : PageModel
    {
        private readonly rankfire.Data.ApplicationDbContext _context;

        public CreateModel(rankfire.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(Guid? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Product product = await _context.Product.FirstOrDefaultAsync(m => m.GUID_Product == id);

            if (product == null)
            {
                return NotFound();
            }
        }

        [BindProperty]
        public rankfire.Data.ProductReview ProductReview { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductReview.Add(ProductReview);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.GUID_Product == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
        }
    }
}
