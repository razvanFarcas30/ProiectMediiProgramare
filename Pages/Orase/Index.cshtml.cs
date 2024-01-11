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

        
        public IList<Salon> SelectedSaloane { get; set; }
        public string SelectedOrasName { get; set; }
        Oras selectedOras = null;
        public async Task OnGetAsync(int? selectedOrasId)
        {
            Oras = await _context.Oras.ToListAsync();

            if (selectedOrasId.HasValue)
            {
                SelectedSaloane = await _context.Salon
                    .Where(s => s.OrasID == selectedOrasId)
                    .ToListAsync();
                selectedOras = await _context.Oras
            .FirstOrDefaultAsync(o => o.ID == selectedOrasId);
            }
            if (selectedOras != null)
            {
                SelectedOrasName = selectedOras.Nume;
                SelectedSaloane = await _context.Salon
                    .Where(s => s.OrasID == selectedOrasId)
                    .ToListAsync();
            }
        }
    }
}

