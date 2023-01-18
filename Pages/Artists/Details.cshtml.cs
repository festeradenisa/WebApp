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
    public class DetailsModel : PageModel
    {
        private readonly WebAppCrud.Data.WebAppCrudContext _context;

        public DetailsModel(WebAppCrud.Data.WebAppCrudContext context)
        {
            _context = context;
        }

      public Artist Artist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Artist == null)
            {
                return NotFound();
            }

            var artist = await _context.Artist.FirstOrDefaultAsync(m => m.ID == id);
            if (artist == null)
            {
                return NotFound();
            }
            else 
            {
                Artist = artist;
            }
            return Page();
        }
    }
}
