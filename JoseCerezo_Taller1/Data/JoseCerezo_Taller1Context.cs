﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JoseCerezo_Taller1.Models;

namespace JoseCerezo_Taller1.Data
{
    public class JoseCerezo_Taller1Context : DbContext
    {
        public JoseCerezo_Taller1Context (DbContextOptions<JoseCerezo_Taller1Context> options)
            : base(options)
        {
        }

        public DbSet<JoseCerezo_Taller1.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<JoseCerezo_Taller1.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<JoseCerezo_Taller1.Models.Estadio> Estadio { get; set; } = default!;
    }
}