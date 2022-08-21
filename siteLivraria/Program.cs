using Microsoft.EntityFrameworkCore;
using siteLivraria.Data;
using siteLivraria.repository;

namespace siteLivraria
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<BancoContext>
                (options => options.UseSqlServer
                ("Data Source=LAPTOP-GVC6IS5K;Initial catalog=Contatos;Integrated Security=False;User ID=sa;Password=teste;connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));

            builder.Services.AddScoped<IContatoRepository, ContatoRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}