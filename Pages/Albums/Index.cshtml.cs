using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppCrud.Data;
using WebAppCrud.Models;

namespace WebAppCrud.Pages.Albums
{
    public class IndexModel : PageModel
    {
        private readonly WebAppCrud.Data.WebAppCrudContext _context;

        public IndexModel(WebAppCrud.Data.WebAppCrudContext context)
        {
            _context = context;
        }

        public IList<Album> Album { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Album != null)
            {
                Album = await _context.Album
                    .Include(b => b.Artist)
                    .ToListAsync();
            }
        }
    }
}
