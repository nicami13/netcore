using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Data.Configuration;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Region");
        builder.Property(E=> E.codRegion).HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn).HasMaxLength(3);

        builder.Property(E=> E.NombreRegion)
        .IsRequired()
        .HasMaxLength(50);   

        builder.HasOne(p=> p.estado)
        .WithMany(p=> p.Regiones)
        .HasForeignKey(p=> p.codEstado); 
    }
}
