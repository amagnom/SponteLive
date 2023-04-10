﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SponteLive.Models;

#nullable disable

namespace SponteLive.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230409182512_UpdateStructureSecondVersion")]
    partial class UpdateStructureSecondVersion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SponteLive.Models.Inscricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("InscritoId")
                        .HasColumnType("int");

                    b.Property<int>("LiveId")
                        .HasColumnType("int");

                    b.Property<bool>("StatusPagamento")
                        .HasColumnType("bit");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("InscritoId");

                    b.HasIndex("LiveId");

                    b.ToTable("Inscricoes");
                });

            modelBuilder.Entity("SponteLive.Models.Inscrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inscritos");
                });

            modelBuilder.Entity("SponteLive.Models.Instrutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instrutores");
                });

            modelBuilder.Entity("SponteLive.Models.Live", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHoraInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DuracaoMinutos")
                        .HasColumnType("int");

                    b.Property<int>("InstrutorId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorInscricao")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("InstrutorId");

                    b.ToTable("Lives");
                });

            modelBuilder.Entity("SponteLive.Models.Inscricao", b =>
                {
                    b.HasOne("SponteLive.Models.Inscrito", "Inscrito")
                        .WithMany()
                        .HasForeignKey("InscritoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SponteLive.Models.Live", "Live")
                        .WithMany()
                        .HasForeignKey("LiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inscrito");

                    b.Navigation("Live");
                });

            modelBuilder.Entity("SponteLive.Models.Live", b =>
                {
                    b.HasOne("SponteLive.Models.Instrutor", "Instrutor")
                        .WithMany()
                        .HasForeignKey("InstrutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrutor");
                });
#pragma warning restore 612, 618
        }
    }
}
