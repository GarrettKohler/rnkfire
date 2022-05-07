using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rankfire.Data;

namespace rankfire.Pages.CompLab
{
    public class DetailsModel : PageModel
    {
        private readonly rankfire.Data.ApplicationDbContext _context;

        public DetailsModel(rankfire.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
