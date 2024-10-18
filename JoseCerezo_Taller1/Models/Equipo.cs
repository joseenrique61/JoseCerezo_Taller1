using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoseCerezo_Taller1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public string Ciudad {  get; set; }

        public int Titulos { get; set; }

        public bool AceptaExtranjeros {  get; set; }

        [ForeignKey(nameof(Estadio))]
        public int IdEstadio { get; set; }

        public Estadio? Estadio { get; set; }
    }
}
