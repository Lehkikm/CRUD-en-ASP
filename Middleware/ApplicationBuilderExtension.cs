using System.IO;
using Microsoft.Extensions.FileProviders;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UsaNodeModules(this IApplicationBuilder app, string directorioRaiz)
        {
            var ruta = Path.Combine(directorioRaiz, "node_modules"); // El método combine permite adaptar la ruta en dependencia del SO usado.
            var proveedorArchivos = new PhysicalFileProvider(ruta); // Almacenando todos los archivos de la node_modules.

            var opciones = new StaticFileOptions();
            opciones.RequestPath = "/node_modules"; // Lugar donde se van a buscar los archivos.
            opciones.FileProvider = proveedorArchivos;

            app.UseStaticFiles(opciones); // Por lo general los archivos "estáticos" están en la carpeta wwwroot.
            return app;
        }
    }
}