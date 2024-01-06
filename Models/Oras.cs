namespace ProiectMediiProgramare.Models
{
    public class Oras
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public ICollection<Salon>? Saloane { get; set; }
    }
}
