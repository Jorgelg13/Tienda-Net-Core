using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TiendaServicio.Api.Libro.Aplicacion.DTO;
using TiendaServicio.Api.Libro.Modelo;

namespace TiendaServicios.Api.Libro.Test
{
    public class MappingTest: Profile
    {
        public MappingTest()
        {
            CreateMap<LibreriaMaterial, LibroMaterialDto>();
        }
    }
}
