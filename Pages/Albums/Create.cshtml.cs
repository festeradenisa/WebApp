using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppCrud.Data;
using WebAppCrud.Models;

namespace WebAppCrud.Pages.Albums
{
    public class CreateModel : PageModel
    {
        private readonly WebAppCrud.Data.WebAppCrudContext _context;

        public CreateModel(WebAppCrud.Data.WebAppCrudContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ArtistID"] = new SelectList(_context.Set<Artist>(), "ID", "ArtistName");
            return Page();
        }

        [BindProperty]
        public Album Album { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Album.Add(Album);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
