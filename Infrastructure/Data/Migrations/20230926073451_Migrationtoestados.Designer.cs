﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.migrations
{
    [DbContext(typeof(InventarioContext))]
    [Migration("20230926073451_Migrationtoestados")]
    partial class Migrationtoestados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.entities.Estado", b =>
                {
                    b.Property<string>("codEstado")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombreEstado")
                        .HasColumnType("longtext");

                    b.Property<string>("codPais")
                        .HasColumnType("longtext");

                    b.Property<string>("paiscodPais")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("codEstado");

                    b.HasIndex("paiscodPais");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Core.entities.Pais", b =>
                {
                    b.Property<string>("codPais")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombrePais")
                        .HasColumnType("longtext");

                    b.HasKey("codPais");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Core.entities.Region", b =>
                {
                    b.Property<string>("codRegion")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombreRegion")
                        .HasColumnType("longtext");

                    b.Property<string>("codEstado")
                        .HasColumnType("longtext");

                    b.Property<string>("estadocodEstado")
                        .HasColumnType("varchar(255)");

                    b.HasKey("codRegion");

                    b.HasIndex("estadocodEstado");

                    b.ToTable("Regiones");
                });

            modelBuilder.Entity("Core.entities.Estado", b =>
                {
                    b.HasOne("Core.entities.Pais", "pais")
                        .WithMany("estados")
                        .HasForeignKey("paiscodPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pais");
                });

            modelBuilder.Entity("Core.entities.Region", b =>
                {
                    b.HasOne("Core.entities.Estado", "estado")
                        .WithMany("Regiones")
                        .HasForeignKey("estadocodEstado");

                    b.Navigation("estado");
                });

            modelBuilder.Entity("Core.entities.Estado", b =>
                {
                    b.Navigation("Regiones");
                });

            modelBuilder.Entity("Core.entities.Pais", b =>
                {
                    b.Navigation("estados");
                });
#pragma warning restore 612, 618
        }
    }
}
