using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace RoutingPractice
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Display", //Custom route
                    pattern: "{controller}/{action}/{id}/page{num}/{cat}");
                endpoints.MapAreaControllerRoute(
                    name: "admin", //Admin route
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default", //This is the default route
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
