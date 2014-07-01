using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;

namespace KWebStartup
{
	public class Startup
	{
		public void Configure(IBuilder app)
		{
			app.UseErrorPage();

			app.UseServices(services =>
			{
				services.AddMvc();
			});

			app.UseMvc(routes =>
			{
				routes.MapRoute("areaRoute", "{area:exists}/{controller}/{action}");

				routes.MapRoute(
					"controllerActionRoute",
					"{controller}/{action}",
					new { controller = "Home", action = "Index" });

				routes.MapRoute(
					"controllerRoute",
					"{controller}",
					new { controller = "Home" });
			});
			app.UseWelcomePage();
		}       
	}
}
