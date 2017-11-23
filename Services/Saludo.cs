using Microsoft.Extensions.Configuration;

namespace laboratorio.Services
{
    public class Saludo : ISaludo
    {
        private IConfiguration _configuracion;

        public Saludo(IConfiguration configuracion)
        {
            _configuracion = configuracion;
        }

        public string GetMensajeDelDia()
        {
            return _configuracion["Saludo"];
        }
    }
}