using laboratorio.Models;
using System;
using System.Collections.Generic;

namespace laboratorio.Services
{
    public interface IRestauranteData
    {
        IEnumerable<Restaurante> GetRestaurantes();
        Restaurante Get(int id);
        Restaurante Add(Restaurante restaurante); 
        Restaurante Update(Restaurante restaurante);
    }
}