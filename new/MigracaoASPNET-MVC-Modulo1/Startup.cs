using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace MigracaoASPNET_MVC_Modulo1
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Hello}/{action=Index}/{id?}");
            });
        }
    }
}
