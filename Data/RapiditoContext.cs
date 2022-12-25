using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RapiditoWEBAPP.Models;

namespace RapiditoWEBAPP.Data
{
    public class RapiditoContext : DbContext
    {
        public RapiditoContext (DbContextOptions<RapiditoContext> options)
            : base(options)
        {
        }

        public DbSet<RapiditoWEBAPP.Models.CuotaPeso> CuotaPeso { get; set; }

        public DbSet<RapiditoWEBAPP.Models.EnvioPedido> EnvioPedido { get; set; }

        public DbSet<RapiditoWEBAPP.Models.MotoristaZona> MotoristaZona { get; set; }

        public DbSet<RapiditoWEBAPP.Models.Persona> Persona { get; set; }

        public DbSet<RapiditoWEBAPP.Models.TipoPersonas> TipoPersonas { get; set; }

        public DbSet<RapiditoWEBAPP.Models.Usuarios> Usuarios { get; set; }

        public DbSet<RapiditoWEBAPP.Models.Zonass> Zonass { get; set; }
    }
}
