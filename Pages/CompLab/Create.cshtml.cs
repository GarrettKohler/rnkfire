using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using rankfire.Data;

namespace rankfire.Pages.CompLab
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
        public rankfire.Data.CompLab CompLab { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var lab = new rankfire.Data.CompLab();
            
                if (await TryUpdateModelAsync<rankfire.Data.CompLab>(
                lab,
                "lab",   // Prefix for form value.
                l => l.Name))

            {
                _context.CompLab.Add(CompLab);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            _context.CompLab.Add(CompLab);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
