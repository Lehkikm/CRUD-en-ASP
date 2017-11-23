using System;
using System.Collections.Generic;
using System.Linq;
using laboratorio.Data;
using laboratorio.Models;
using Microsoft.EntityFrameworkCore;

namespace laboratorio.Services
{
    public class SqlRestauranteData : IRestauranteData
    {
        private LaboratorioDbContext _contexto;

        public SqlRestauranteData(LaboratorioDbContext contexto)
        {
            _contexto = contexto;
        }

        public Restaurante Add(Restaurante restaurante)
        {
            _contexto.Add(restaurante);
            _contexto.SaveChanges();

            return restaurante;
        }

        public Restaurante Get(int id)
        {
            return _contexto.Restaurantes.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurante> GetRestaurantes()
        {
            return _contexto.Restaurantes.OrderBy(r => r.Nombre);
        }

        public Restaurante Update(Restaurante restaurante)
        {
            _contexto.Attach(restaurante).State = EntityState.Modified;
            _contexto.SaveChanges();
            return restaurante;
        }
    }
}