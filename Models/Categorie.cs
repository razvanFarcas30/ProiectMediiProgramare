namespace ProiectMediiProgramare.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string NumeCategorie { get; set; }
        public ICollection<Salon>? Saloane { get; set; }
    }
}
