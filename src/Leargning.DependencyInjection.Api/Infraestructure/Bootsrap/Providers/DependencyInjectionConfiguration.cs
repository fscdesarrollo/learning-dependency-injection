using Leargning.DependencyInjection.Api.Domain.Entities;
using Leargning.DependencyInjection.Api.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leargning.DependencyInjection.Api.Infraestructure.Bootsrap.Providers
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IOperationTransient, Operation>();
            services.AddScoped<IOperationScoped, Operation>();
            services.AddSingleton<IOperationSingleton, Operation>();
            services.AddTransient<OperationService>();

            return services;
        }
    }
}
