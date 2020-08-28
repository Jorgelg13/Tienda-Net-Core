using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaServicio.Api.Libro.Modelo;

namespace TiendaServicio.Api.Libro.Persistencia
{
    public class ContextoLibreria :DbContext
    {
        public ContextoLibreria(DbContextOptions<ContextoLibreria> options) : base(options)
        {

        }

        public DbSet<LibreriaMaterial> LibreriaMaterial { get; set; }
    }
}
