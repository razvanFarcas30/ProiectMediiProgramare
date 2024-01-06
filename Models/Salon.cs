using System.Collections;

namespace ProiectMediiProgramare.Models
{
    public class Salon
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public int? OrasID { get; set; }
        public Oras? Oras { get; set; }
        public string Adresa { get; set; }

        public string Pret { get; set; }
        public int? CategorieID { get; set; }
        public Categorie? Categorie { get; set; }
        public ICollection<Stilist>? Stilisti { get; set; }

        public ICollection<Programare>? Programari { get; set; }
    }
}
