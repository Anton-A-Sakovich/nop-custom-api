using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nop.Core.Infrastructure;

namespace Nop.Plugin.CompanyName.Api
{
    public class Startup : INopStartup
    {
        // TODO: Research the precise behavior of this.
        public int Order => 1;

        public void Configure(IApplicationBuilder application)
        {
            var environment = application.ApplicationServices.GetRequiredService<IWebHostEnvironment>();

            application.MapWhen(
                context => context.Request.Path.StartsWithSegments(new PathString("/CompanyName")),
                application =>
                {
                    if (environment.IsDevelopment())
                    {
                        application.UseDeveloperExceptionPage();
                    }

                    application.UseRouting();
                    application.UseEndpoints(endpoints =>
                    {
                        endpoints.MapControllers();
                    });
                });
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}
