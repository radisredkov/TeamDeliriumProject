﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeamDeliriumProject.Data;

[assembly: HostingStartup(typeof(TeamDeliriumProject.Data.IdentityHostingStartup))]
namespace TeamDeliriumProject.Data
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<PineContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PineContextConnection")));
            });
        }
    }
}