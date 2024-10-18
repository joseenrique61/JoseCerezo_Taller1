using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoseCerezo_Taller1.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Posicion {  get; set; }

        public int Edad {  get; set; }

        [ForeignKey(nameof(Equipo))]
        public int IdEquipo {  get; set; }
    
        public Equipo? Equipo { get; set; }
    }
}
