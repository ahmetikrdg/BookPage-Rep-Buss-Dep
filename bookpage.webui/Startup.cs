using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using bookpage.business.Abstract;
using bookpage.business.Concrate;
using bookpage.data.Abstract;
using bookpage.data.Concrate.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace bookpage.webui
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {//serisleri proje içine dahil ederiz
            services.AddScoped<IProductRepository,EfCoreProductRepository>();//mysql kullanmak istiyosam onu yazarım
            services.AddScoped<IProductServices,ProductManager>();
            services.AddControllersWithViews();//mvc yapısını kullandım controlleri kullanacağım dedim
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();//wwwroot altındaki klasörler açılır
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider=new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"
               
            });
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
           

            app.UseEndpoints(endpoints =>//uygulamanın ana dizinine sahip istek geldiğinde bir response string ifade göndermek
            {
                endpoints.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Product}/{action=Index}/{id?}"
                //controller=home dedim yani sen birşey çağırmasan bile ilk olarak home çıkar karşına actionu ise ındex
                );
            });
        }
    }
}
