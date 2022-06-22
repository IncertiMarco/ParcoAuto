﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ParcoAuto.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Auto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("AutoId");

                    b.Property<string>("Targa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auto");
                });

            modelBuilder.Entity("Entities.Models.Note", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("NotaId");

                    b.Property<string>("Annotazione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PrenotazioniId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PrenotazioniId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("Entities.Models.Prenotazioni", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PrenotazioniId");

                    b.Property<Guid>("AutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Chilometri")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFinePrenotazione")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInizioPrenotazione")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UtentiId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AutoId");

                    b.HasIndex("UtentiId");

                    b.ToTable("Prenotazioni");
                });

            modelBuilder.Entity("Entities.Models.SpecificheAuto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ModelloId");

                    b.Property<Guid>("AutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modello")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutoId")
                        .IsUnique();

                    b.ToTable("SpecificheAuto");
                });

            modelBuilder.Entity("Entities.Models.Utenti", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UtentiId");

                    b.Property<string>("Cognome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utenti");
                });

            modelBuilder.Entity("Entities.Models.Note", b =>
                {
                    b.HasOne("Entities.Models.Prenotazioni", "Prenotazioni")
                        .WithMany("Note")
                        .HasForeignKey("PrenotazioniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prenotazioni");
                });

            modelBuilder.Entity("Entities.Models.Prenotazioni", b =>
                {
                    b.HasOne("Entities.Models.Auto", "Auto")
                        .WithMany("Prenotazioni")
                        .HasForeignKey("AutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Utenti", "Utenti")
                        .WithMany("Prenotazioni")
                        .HasForeignKey("UtentiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auto");

                    b.Navigation("Utenti");
                });

            modelBuilder.Entity("Entities.Models.SpecificheAuto", b =>
                {
                    b.HasOne("Entities.Models.Auto", "Auto")
                        .WithOne("specificheAuto")
                        .HasForeignKey("Entities.Models.SpecificheAuto", "AutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auto");
                });

            modelBuilder.Entity("Entities.Models.Auto", b =>
                {
                    b.Navigation("Prenotazioni");

                    b.Navigation("specificheAuto");
                });

            modelBuilder.Entity("Entities.Models.Prenotazioni", b =>
                {
                    b.Navigation("Note");
                });

            modelBuilder.Entity("Entities.Models.Utenti", b =>
                {
                    b.Navigation("Prenotazioni");
                });
#pragma warning restore 612, 618
        }
    }
}
