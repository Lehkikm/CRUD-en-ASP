using laboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace laboratorio.ViewModels
{
    public class RestauranteEditModel
    {
        [Required, MaxLength(80)]
        public string Nombre { get; set; }
        public TipoCocina Cocina { get; set; }

    } 
}