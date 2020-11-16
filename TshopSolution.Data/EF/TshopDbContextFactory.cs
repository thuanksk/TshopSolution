using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TshopSolution.Data.EF
{
    public class TshopDbContextFactory : IDesignTimeDbContextFactory<TshopDBcontext>
    {
        public TshopDBcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();
            var connectionString = configuration.GetConnectionString("TshopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<TshopDBcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TshopDBcontext(optionsBuilder.Options);
        }
    }
}
