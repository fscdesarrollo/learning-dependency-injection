using Leargning.DependencyInjection.Api.Infraestructure.Bootsrap.Providers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leargning.DependencyInjection.Api.Infraestructure.Bootsrap
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDependencyInjectionConfiguration(configuration);

            return services;
        }

        public static IApplicationBuilder Configure(
            this IApplicationBuilder app,
           IWebHostEnvironment webHostEnvironment)
        {

            app.ConfigureMVC(webHostEnvironment);

            return app;
        }
    }
}
