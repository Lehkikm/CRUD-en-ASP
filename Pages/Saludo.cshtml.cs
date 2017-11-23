using System;   
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; // Aquí es donde se encuentra la clase PageModel.
using laboratorio.Services;

namespace laboratorio.Pages
{
    public class SaludoModel : PageModel
    {
        private ISaludo _saludo;
        public string SaludoActual { get; set; }

        public SaludoModel(ISaludo saludo)
        {
            _saludo = saludo;
        }
        public void OnGet(string nombre)
        {
            SaludoActual = $"{nombre} : {_saludo.GetMensajeDelDia()}";
        }
    }
}