using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mod03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod03
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDataSource, DataSource>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {//middleware
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute(); //Home/Index
            /*app.Use(async(context, next) =>{
                var url = context.Request.Path.Value;

                await context.Response.WriteAsync("hi i m firsst middleware \n");
                await context.Response.WriteAsync($" the value of url = {url} \n");

                next.Invoke();
            });
            app.Map("/User", (map) =>
            {
                map.Use(async (context, next) =>
                {
                    var name = "karanveer Singh";
                    await context.Response.WriteAsync($" the name  is = {name} \n");

                });
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hi There i m run middleware");
            });
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("hi i m 2nd middleware \n");
                next.Invoke();

            });*/
        }
    }
}
