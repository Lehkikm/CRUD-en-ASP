using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using laboratorio.Data;
using laboratorio.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace laboratorio
{
    public class Startup
    {
        private IConfiguration _configuracion;

        public Startup(IConfiguration configuracion)
        {
            _configuracion = configuracion;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISaludo, Saludo>();
            services.AddDbContext<LaboratorioDbContext>(
                options => options.UseSqlServer(_configuracion.GetConnectionString("Laboratorio"))
            );
            services.AddScoped<IRestauranteData, SqlRestauranteData>();
            services.AddMvc();
        }

        /*
            app: Es el constructor de aplicaciones. Este hace pasar la petición (request) por el pipeline (línea de trabajo) 
                 que tiene los middlewere (estaciones o módulos). Puedes invocar los middleweres por medio de esta variable.
         */
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ISaludo miSaludo, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // Permite hacer que la peticion pase por los archivos html y css.
            app.UsaNodeModules(env.ContentRootPath); // Despúes de cargar los archivos, le digo al navegador que tome ahora los archivos de node_modules.
            app.UseMvc(ConfiguraRutas);

            // app.Run(async (context) =>
            // { 
            //     // throw new Exception("Excepcion");
            //     string saludo = miSaludo.GetMensajeDelDia();
            //     context.Response.ContentType = "text/plain"; // De esta manera, el navegador interpreta el texto que escriba como texto que puede interpretar.
            //     await context.Response.WriteAsync($"Si estás viendo este mensaje es porque estás en el middleware incorrecto. Lo siento : -/");
            // });
        }
        
        private void ConfiguraRutas(IRouteBuilder constructorRutas)
        {
            constructorRutas.MapRoute("Default",
                "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
