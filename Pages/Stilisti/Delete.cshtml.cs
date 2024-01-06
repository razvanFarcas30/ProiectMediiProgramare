using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiProgramare.Data;
using ProiectMediiProgramare.Models;

namespace ProiectMediiProgramare.Pages.Stilisti
{
    public class DeleteModel : PageModel
    {
        private readonly ProiectMediiProgramare.Data.ApplicationDbContext _context;

        public DeleteModel(ProiectMediiProgramare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Stilist Stilist { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Stilist == null)
            {
                return NotFound();
            }

            var stilist = await _context.Stilist.FirstOrDefaultAsync(m => m.ID == id);

            if (stilist == null)
            {
                return NotFound();
            }
            else 
            {
                Stilist = stilist;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Stilist == null)
            {
                return NotFound();
            }
            var stilist = await _context.Stilist.FindAsync(id);

            if (stilist != null)
            {
                Stilist = stilist;
                _context.Stilist.Remove(Stilist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
