using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rankfire.Data;

namespace rankfire.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly rankfire.Data.ApplicationDbContext _context;

        public IndexModel(rankfire.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<rankfire.Data.Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
