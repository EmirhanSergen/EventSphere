﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EventSphere.Data;
using EventSphere.Models;
using MvcMovie.Models;



namespace EventSphere
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<EventSphereContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EventSphereContext") ?? throw new InvalidOperationException("Connection string 'EventSphereContext' not found.")));
            

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Feed data with data in Models folder SeedData.cs
            using (var scope = app.Services.CreateScope()) 
            { 
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            
            }


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
