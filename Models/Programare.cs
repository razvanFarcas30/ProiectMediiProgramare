using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace ProiectMediiProgramare.Models
{
    public class Programare
    {
        public int ID { get; set; }
        public int? ClientID { get; set; }
        public Client? Client { get; set; }
        public int? SalonID { get; set; }
        public Salon? Salon { get; set; }
        public int? StilistID { get; set; }
        public Stilist? Stilist { get; set; }

        public DateTime DataProgramarii { get; set; }
    }
}
