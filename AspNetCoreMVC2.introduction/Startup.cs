﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC2.introduction.Models;
using AspNetCoreMVC2.introduction.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreMVC2.introduction
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            var connectionString = @"server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=true;";
            services.AddDbContext<SchoolContext>(options => options.UseSqlServer(connectionString));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<ICalculator, Calculate18>();//Servisin örneği oluşturulu her kullanıcı için


            //services.AddSingleton<ICalculator, Calculate18>();//Servisin örneği oluşturulu her kullanıcı için ayrı ayrı değil tek seferde bir kez

            //session bilgisini aktifleştiriyoruz
            services.AddSession();
            //Veriyi bellekte tutmamızı sağlayan kod blokları
            services.AddDistributedMemoryCache();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            //Projeyi canlıya alınca oluşan hata kodları ekrana verilmez
            env.EnvironmentName = EnvironmentName.Production;
            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");

            //});
            app.UseMvc(ConfigureRoutes);
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});



        }

        private void ConfigureRoutes(IRouteBuilder routeBuilders)
        {
            routeBuilders.MapRoute("default", "{controller=Filter}/{action=Index}/{id?}");
            routeBuilders.MapRoute("MyRoutes", "MTS/{controller=Home}/{action=Index3}/{id?}");

            routeBuilders.MapRoute(name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
              
                 
       



        }
    }
}
