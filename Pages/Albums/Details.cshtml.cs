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
    public class DetailsModel : PageModel
    {
        private readonly WebAppCrud.Data.WebAppCrudContext _context;

        public DetailsModel(WebAppCrud.Data.WebAppCrudContext context)
        {
            _context = context;
        }

      public Album Album { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Album == null)
            {
                return NotFound();
            }

            var album = await _context.Album.Include(b => b.Artist).FirstOrDefaultAsync(m => m.ID == id);
            if (album == null)
            {
                return NotFound();
            }
            else 
            {
                Album = album;
            }
            return Page();
        }
    }
}
