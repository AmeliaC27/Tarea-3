using Microsoft.Extensions.DependencyInjection;
using Renta_y_venta_de_peliculas.BLL.Contract;
using Renta_y_venta_de_peliculas.BLL.Services;

namespace Renta_y_venta_de_peliculas._API
{
    public class StartupBase
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddControllersWithViews();
            services.AddTransient<IPeliculaService, PeliculaService>();
        }
    }
}