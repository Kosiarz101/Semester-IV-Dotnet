using System;
using FizzBuzzBazaDanych.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FizzBuzzBazaDanych.Areas.Identity.IdentityHostingStartup))]
namespace FizzBuzzBazaDanych.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FizzBuzzBazaDanychContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FizzBuzzBazaDanychContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FizzBuzzBazaDanychContext>();
            });
        }
    }
}