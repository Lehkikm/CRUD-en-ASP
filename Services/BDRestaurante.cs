using laboratorio.Models;
using System.Collections.Generic;
using laboratorio.Services;
using System;
using System.Linq;

namespace laboratorio.Services
{
    // public class BDRestaurante : IRestauranteData
    // {
    //     List<Restaurante> _restaurantes;

    //     public BDRestaurante()
    //     {
    //         _restaurantes = new List<Restaurante>
    //         {
    //             new Restaurante{Id=1, Nombre = "Taz Restaurante"},
    //             new Restaurante{Id=2, Nombre = "Abraham's Restaurant"},
    //             new Restaurante{Id=3, Nombre = "King's"}
    //         };  
    //     }

    //     public IEnumerable<Restaurante> GetRestaurantes()
    //     {
    //         return _restaurantes.OrderBy(r => r.Nombre);
    //     }

    //     public Restaurante Get(int id)
    //     {
    //         return _restaurantes.FirstOrDefault(r => r.Id == id);
    //     }

    //     public Restaurante Add(Restaurante restaurante)
    //     {
    //         restaurante.Id = _restaurantes.Max(r => r.Id) + 1; // Agregando el campo Id al restaurante proporcionado.
    //         _restaurantes.Add(restaurante);

    //         return restaurante;
    //     }

    //     public Restaurante Update(Restaurante restaurante)
    //     {
    //         throw new NotImplementedException();
    //     }
    // }
}