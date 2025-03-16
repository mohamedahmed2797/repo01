using Microsoft.AspNetCore.Routing.Constraints;

namespace repo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello  World!");
            //app.MapGet("/index", () => "Hello from index");
            //app.MapGet("/Pota", () => "Hello World!");
            //app.MapGet("/{name}", async context =>
            //app.MapGet("/X{name}", async context =>
            //{
            // var Name = context.GetRouteValue("name");
            //await context.Response.WriteAsync($"Hello {Name}");
            //await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}");
            //});
            app.UseStaticFiles();
            app.MapControllerRoute
                (name : "default",
                pattern : "{controller=Home}/{action=Index}/{id:int?}"
                //pattern : "{controller=movies}/{action=index}/{id?}"
                //pattern : "{controller=movies}/{action=index}/{id:regex(^\\d{{2}}$)?}"
                //defaults : new { action = "Index", controller = "movies" },
                //constraints : new {id = new IntRouteConstraint()

                );
            app.Run();
        }
    }
}
