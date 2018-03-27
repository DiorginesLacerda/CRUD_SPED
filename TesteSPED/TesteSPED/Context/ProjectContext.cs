using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TesteSPED.Entities;

namespace TesteSPED.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Estado> Estados { get; set; }

    }
}