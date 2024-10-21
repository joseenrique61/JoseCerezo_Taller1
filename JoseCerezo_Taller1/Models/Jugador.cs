using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoseCerezo_Taller1.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Posición")]
        public string Posicion {  get; set; }

        [Required]
        public int Edad {  get; set; }

        [DisplayName("Equipo")]
        [ForeignKey(nameof(Equipo))]
        public int IdEquipo {  get; set; }
    
        public Equipo? Equipo { get; set; }
    }
}
