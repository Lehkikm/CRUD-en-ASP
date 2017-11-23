using laboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace laboratorio.Data
{
    // En esta clase especificas las clases que vas a extrapolar a tablas de base de datos.
    public class LaboratorioDbContext : DbContext
    {
        public LaboratorioDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Restaurante> Restaurantes { get; set; }
    }
}