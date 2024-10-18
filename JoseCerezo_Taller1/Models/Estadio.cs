﻿using System.ComponentModel.DataAnnotations;

namespace JoseCerezo_Taller1.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Ciudad {  get; set; }

        public int Capacidad { get; set; }
    }
}
