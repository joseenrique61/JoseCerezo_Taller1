using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JoseCerezo_Taller1.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        [Required]
        public string Ciudad {  get; set; }

        [Required]
        public int Capacidad { get; set; }
    }
}
