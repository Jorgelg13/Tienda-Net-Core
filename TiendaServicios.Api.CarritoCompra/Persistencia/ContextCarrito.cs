﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaServicios.Api.CarritoCompra.Modelo;

namespace TiendaServicios.Api.CarritoCompra.Persistencia
{
    public class ContextCarrito :DbContext
    {
        public ContextCarrito(DbContextOptions<ContextCarrito> options):base(options)
        {

        }
        public DbSet<CarritoSesion> CarritoSesion { get; set; }
        public DbSet<CarritoSesionDetalle> CarritoSesionDetalle { get; set; }
    }
}
