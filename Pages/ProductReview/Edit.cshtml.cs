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
    public class EditModel : PageModel
    {
        private readonly rankfire.Data.ApplicationDbContext _context;

        public EditModel(rankfire.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public rankfire.Data.ProductReview ProductReview { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductReview = await _context.ProductReview.FirstOrDefaultAsync(m => m.GUID_ProductReview == id);

            if (ProductReview == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductReviewExists(ProductReview.GUID_ProductReview))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductReviewExists(Guid id)
        {
            return _context.ProductReview.Any(e => e.GUID_ProductReview == id);
        }
    }
}
