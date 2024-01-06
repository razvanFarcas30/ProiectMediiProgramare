using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectMediiProgramare.Data;
using ProiectMediiProgramare.Models;

namespace ProiectMediiProgramare.Pages.Stilisti
{
    public class CreateModel : PageModel
    {
        private readonly ProiectMediiProgramare.Data.ApplicationDbContext _context;

        public CreateModel(ProiectMediiProgramare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SalonID"] = new SelectList(_context.Set<Salon>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Stilist Stilist { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Stilist == null || Stilist == null)
            {
                return Page();
            }

            _context.Stilist.Add(Stilist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
