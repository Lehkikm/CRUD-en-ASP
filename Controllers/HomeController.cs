using laboratorio.Models;
using laboratorio.Services;
using laboratorio.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace laboratorio.Controllers
{
    public class HomeController : Controller
    {
        private IRestauranteData _restauranteData;
        private ISaludo _saludo;

        public HomeController(IRestauranteData restauranteData, ISaludo saludo)
        {
            _restauranteData = restauranteData;
            _saludo = saludo;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();

            model.Restaurantes = _restauranteData.GetRestaurantes();
            model.MensajeActual = _saludo.GetMensajeDelDia();

            return View(model);
        }

        public IActionResult Detalles(int id)
        {
            var restaurante = _restauranteData.Get(id);

            if(restaurante == null)
            {
                return RedirectToAction(nameof (Index));
            }

            return View(restaurante);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }   

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(RestauranteEditModel modelo)
        {
            if (ModelState.IsValid)
            {
                var nuevoRestaurante = new Restaurante();
                nuevoRestaurante.Nombre = modelo.Nombre;
                nuevoRestaurante.Cocina = modelo.Cocina;

                nuevoRestaurante = _restauranteData.Add(nuevoRestaurante);
               
                return RedirectToAction("Detalles", new { Id=nuevoRestaurante.Id});  // RedirectToAction(Action, parámetro a añadir a la barra de direcciones).
                // Podrias haber hecho algo así: return RedirectToAction("Detalles", new { Id = nuevoRestaurante.Id, parametro2 = [valor]});
            }
            else
            {
                return View();
            }
        } 
    }
}