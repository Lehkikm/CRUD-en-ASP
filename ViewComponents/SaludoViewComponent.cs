using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using laboratorio.Services;

namespace laboratorio.ViewComponents
{
    public class SaludoViewComponent : ViewComponent
    {
        private ISaludo _saludo;
        public SaludoViewComponent(ISaludo saludo)   
        {
            _saludo = saludo;
        }

        public IViewComponentResult Invoke()
        {
            var modelo = _saludo.GetMensajeDelDia();
            return View("Default", modelo);
        }
    }
}