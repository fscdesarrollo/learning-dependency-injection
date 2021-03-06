using Leargning.DependencyInjection.Api.Infraestructure.Bootsrap;
using Leargning.DependencyInjection.Api.Infraestructure.Bootsrap.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Leargning.DependencyInjection.Api
{
    public class Startup
    {

        private const string BASE_PATH = "/basepath/";

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration _configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.ConfigureServices(_configuration);
        }


        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            app.UsePathBase(BASE_PATH);
            app.UseMiddleware<RequestResponseLoggingMiddleware>();
            app.Configure(env);
        }
    }
}
