using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoseCerezo_Taller1.Models
{
    public class EquipoModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Ciudad {  get; set; }

        [Required]
        [DisplayName("Títulos")]
        public int Titulos { get; set; }

        [DisplayName("Acepta extranjeros")]
        public bool AceptaExtranjeros {  get; set; }

        [Required]
        [DisplayName("Estadio")]
        [ForeignKey(nameof(Estadio))]
        public int IdEstadio { get; set; }

        public EstadioModel? Estadio { get; set; }


        public ICollection<JugadorModel>? Jugadores { get; } = [];
    }
}
