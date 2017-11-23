using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; // Aquí es donde se encuentra la clase PageModel.
using laboratorio.Models; // Aquí está el Restaurante.
using laboratorio.Services;

namespace laboratorio.Pages.Restaurantes
{
    public class EditarModel : PageModel
    {
        private IRestauranteData _restauranteData;
        
        [BindProperty]
        public Restaurante Restaurante { get; set; }
        public EditarModel(IRestauranteData restauranteData)
        {
            _restauranteData = restauranteData;
        }

        // Obteniendo el parámetro id pasado por la barra de direcciones
        public IActionResult OnGet(int id)
        {
            Restaurante = _restauranteData.Get(id);
            if(Restaurante == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restauranteData.Update(Restaurante);
                return RedirectToAction("Detalles", "Home", new { id = Restaurante.Id });
            }       

            return Page();
        }
    }
}