﻿// <auto-generated />
using System;
using LaboratorioDeVacinas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaboratorioDeVacinas.Migrations
{
    [DbContext(typeof(LaboratorioVacinasContext))]
    [Migration("20221028000751_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LaboratorioDeVacinas.Models.Vacina", b =>
                {
                    b.Property<int>("VacinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCraicao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("VirusFK")
                        .HasColumnType("int");

                    b.HasKey("VacinaId");

                    b.HasIndex("VirusFK");

                    b.ToTable("Vacina");
                });

            modelBuilder.Entity("LaboratorioDeVacinas.Models.Virus", b =>
                {
                    b.Property<int>("VirusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("TemVacina")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("VirusId");

                    b.ToTable("Virus");
                });

            modelBuilder.Entity("LaboratorioDeVacinas.Models.Vacina", b =>
                {
                    b.HasOne("LaboratorioDeVacinas.Models.Virus", "Virus")
                        .WithMany("Vacinas")
                        .HasForeignKey("VirusFK");

                    b.Navigation("Virus");
                });

            modelBuilder.Entity("LaboratorioDeVacinas.Models.Virus", b =>
                {
                    b.Navigation("Vacinas");
                });
#pragma warning restore 612, 618
        }
    }
}
