using ChatSystem.Context;
using ChatSystem.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace ChatSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR();

            builder.Services.AddDbContext<LabChatSystemContext>(opts => opts.UseSqlServer(
                builder.Configuration.GetConnectionString("DbConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapHub<ChatHub>("/chathub");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Chat}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
