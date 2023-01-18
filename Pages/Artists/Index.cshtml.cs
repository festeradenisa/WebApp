using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppCrud.Data;
using WebAppCrud.Models;

namespace WebAppCrud.Pages.Artists
{
    public class IndexModel : PageModel
    {
        private readonly WebAppCrud.Data.WebAppCrudContext _context;

        public IndexModel(WebAppCrud.Data.WebAppCrudContext context)
        {
            _context = context;
        }

        public IList<Artist> Artist { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Artist != null)
            {
                Artist = await _context.Artist.ToListAsync();
            }
        }
    }
}
