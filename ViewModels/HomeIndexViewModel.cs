using laboratorio.Models;
using System.Collections.Generic;

namespace laboratorio.ViewModels
{
    // Esta clase encapsula los métodos de las vistas del action Index.
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurante> Restaurantes { get; set; }
        public string MensajeActual { get; set; }
    }
}
