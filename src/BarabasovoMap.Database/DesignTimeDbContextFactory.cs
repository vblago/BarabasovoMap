using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Proxies;
using Microsoft.Extensions.Configuration;

namespace BarabasovoMap.Database
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BarabasovoDbContext>
    {
        public BarabasovoDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BarabasovoDbContext>();

            builder.UseSqlServer(configuration.GetConnectionString("BarabasovoDatabase"));

            builder.UseLazyLoadingProxies();

            return new BarabasovoDbContext(builder.Options);
        }
    }
}