using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProiectMediiProgramare.Models;

namespace ProiectMediiProgramare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProiectMediiProgramare.Models.Stilist>? Stilist { get; set; }
        public DbSet<ProiectMediiProgramare.Models.Salon>? Salon { get; set; }
        public DbSet<ProiectMediiProgramare.Models.Programare>? Programare { get; set; }
        public DbSet<ProiectMediiProgramare.Models.Oras>? Oras { get; set; }
        public DbSet<ProiectMediiProgramare.Models.Client>? Client { get; set; }
        public DbSet<ProiectMediiProgramare.Models.Categorie>? Categorie { get; set; }
    }
}
