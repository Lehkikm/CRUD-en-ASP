using Microsoft.AspNetCore.Mvc;

namespace laboratorio.Controllers
{
    public class AboutController : Controller
    {
        public string NumeroTelefono()
        {
            return "(849) 351 - 8051";
        }

        public string Nombre()
        {
            return "Mikhael";
        }
    }
}