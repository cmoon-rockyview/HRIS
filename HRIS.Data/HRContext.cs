using HRIS.Domain.RV;
using HRIS.Domain.TRN;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data
{
    public class HRContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()                            
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            // define the database to use
            object opt = optionsBuilder
                         .UseSqlServer(config.GetConnectionString("HRCtx"));
        }  

        public HRContext(DbContextOptions<HRContext> options): base(options)
        {

        }

        public HRContext()
        {

        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<TrainingRequest> TrainingRequest { get; set; }


    }
}
