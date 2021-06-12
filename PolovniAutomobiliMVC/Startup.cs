using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolovniAutomobiliMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolovniAutomobiliMVC
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
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //addDefaultIdentity - uključuje funkcionalnosti za rad za Identity klasa
            //AddEntityFrameworkStores - podaci se čuvaju kroz EF Core kroz AppDbContext
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();

            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            //na ovaj nacin GetCart se poziva odmah prilikom request-a (pogledajte GetCart implementaciju).
            //ako postoji, bice prosledjena postojeca korpa. 
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddHttpContextAccessor(); // pristupamo mu iz ShoppingCart-a da bismo pristupili sesiji
            services.AddSession(); // preduslov za koriscenje sesija
            services.AddControllersWithViews();
            services.AddRazorPages(); // preduslov zbog Scaffolded funkcionalnosti
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession(); // mora da se pozove pre UseRouting
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id:int?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
