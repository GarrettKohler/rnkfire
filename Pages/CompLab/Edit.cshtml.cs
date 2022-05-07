using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using rankfire.Data;

namespace rankfire.Pages.CompLab
{
    public class EditModel : PageModel
    {
        private readonly rankfire.Data.ApplicationDbContext _context;

        public EditModel(rankfire.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public rankfire.Data.CompLab CompLab { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompLab = await _context.CompLab.FirstOrDefaultAsync(m => m.GUID_CompLab == id);

            if (CompLab == null)
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

            _context.Attach(CompLab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompLabExists(CompLab.GUID_CompLab))
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

        private bool CompLabExists(Guid id)
        {
            return _context.CompLab.Any(e => e.GUID_CompLab == id);
        }
    }
}
