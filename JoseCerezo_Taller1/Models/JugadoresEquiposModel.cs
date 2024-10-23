using Microsoft.AspNetCore.Mvc.Rendering;

namespace JoseCerezo_Taller1.Models
{
	public class JugadoresEquiposModel
	{
		public IEnumerable<JugadorModel>? Jugadores { get; set; }

		public SelectList? Equipos { get; set; }

		public string? EquipoFiltro { get; set; }
	}
}
