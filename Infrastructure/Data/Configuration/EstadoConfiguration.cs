using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
{
    public void Configure(EntityTypeBuilder<Estado> builder)
    {
        builder.ToTable("Estado");
        builder.Property(E=> E.codEstado).HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn).HasMaxLength(3);

        builder.Property(E=> E.NombreEstado)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p=> p.pais)
        .WithMany(p=> p.estados)
        .HasForeignKey(p=> p.codPais);
    }
}
