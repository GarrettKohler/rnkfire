using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rankfire.Data;

namespace rankfire.Pages.Retailer
{
    public class DeleteModel : PageModel
    {
        private readonly rankfire.Data.ApplicationDbContext _context;

        public DeleteModel(rankfire.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public rankfire.Data.Retailer Retailer { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Retailer = await _context.Retailer.FirstOrDefaultAsync(m => m.GUID_Retailer == id);

            if (Retailer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Retailer = await _context.Retailer.FindAsync(id);

            if (Retailer != null)
            {
                _context.Retailer.Remove(Retailer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
