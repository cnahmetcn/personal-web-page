using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options=>options.EnableEndpointRouting = false); // app.UseMvcWithDefaultRoute(); kullanmak için gerekli
            services.AddControllersWithViews().AddRazorRuntimeCompilation(); // Projeyi durdurmadan f5 ile içerik yenilemeyi saðlar
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // wwwroot içindeki dosyalarý açtýk
            app.UseMvcWithDefaultRoute(); // Varsayýlan Controller Home Varsayýlan Action Index id opsiyonel


        }
    }
}
