using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProiectMediiProgramare.Data;
using ProiectMediiProgramare.Models;

namespace ProiectMediiProgramare.Pages.Saloane
{
    public class IndexModel : PageModel
    {
        private readonly ProiectMediiProgramare.Data.ApplicationDbContext _context;

        public IndexModel(ProiectMediiProgramare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Salon> Salon { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? SelectedCategoryId { get; set; }
        public async Task OnGetAsync()
        {
            ViewData["CategorieID"] = new SelectList(_context.Categorie, "ID", "NumeCategorie");
            

            var query = _context.Salon
            .Include(s => s.Categorie)
            .Include(s => s.Stilisti)
            .Include(s => s.Oras)
            .AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(s => s.Nume.Contains(SearchString));
            }
            if (SelectedCategoryId.HasValue)
            {
                query = query.Where(s => s.CategorieID == SelectedCategoryId);
            }

            Salon = await query.ToListAsync();
        }
    }
}
