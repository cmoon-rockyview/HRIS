using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data
{
    
    public class ApllicationDBContextFactory : IDesignTimeDbContextFactory<HRContext>
    {

        public HRContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json")
                          .Build();

            var builder = new DbContextOptionsBuilder<HRContext>();
            builder.UseSqlServer(config.GetConnectionString("HRCtx"),
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(HRContext).GetTypeInfo().Assembly.GetName().Name));

            return new HRContext(builder.Options);
        }
    }
}
