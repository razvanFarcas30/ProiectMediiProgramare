using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMediiProgramare.Data;
using ProiectMediiProgramare.Models;

namespace ProiectMediiProgramare.Pages.Orase
{
    public class IndexModel : PageModel
    {
        private readonly ProiectMediiProgramare.Data.ApplicationDbContext _context;

        public IndexModel(ProiectMediiProgramare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Oras> Oras { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Oras != null)
            {
                Oras = await _context.Oras.Include(o => o.Saloane).ToListAsync();

            }
        }
    }
}
