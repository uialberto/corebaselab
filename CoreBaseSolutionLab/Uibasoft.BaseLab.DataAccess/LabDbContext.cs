using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Dominio;

namespace Uibasoft.BaseLab.DataAccess
{
    public class LabDbContext : DbContext
    {
        public LabDbContext()
        {
        }

        public LabDbContext(DbContextOptions<LabDbContext> options) : base(options)
        {
        }

        public DbSet<FootbalTeam> Teams { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();

            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new ParametroConfig());
        }

    }
}
