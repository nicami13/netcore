using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext>options):   base(options){

        }
        public DbSet<Pais> Paises {get; set;}
        public DbSet<Estado> Estados {get; set;}
        public DbSet<Region> Regiones {get; set;}

        protected void OModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}