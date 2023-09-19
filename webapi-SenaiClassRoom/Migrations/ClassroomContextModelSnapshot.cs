﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi_SenaiClassRoom.Contexts;

#nullable disable

namespace webapi_SenaiClassRoom.Migrations
{
    [DbContext(typeof(ClassroomContext))]
    partial class ClassroomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.CalendarioEscolar", b =>
                {
                    b.Property<Guid>("IdCalendarioEscolar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FinalCalendario")
                        .HasColumnType("DATE");

                    b.Property<Guid>("IdInstituicao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InicioCalendario")
                        .HasColumnType("DATE");

                    b.HasKey("IdCalendarioEscolar");

                    b.HasIndex("IdInstituicao");

                    b.ToTable("CalendarioEscolar");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.Curso", b =>
                {
                    b.Property<Guid>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdPeriodoCurso")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSalaDeAula")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<byte>("QuantidadeAlunos")
                        .HasColumnType("TINYINT");

                    b.HasKey("IdCurso");

                    b.HasIndex("IdPeriodoCurso");

                    b.HasIndex("IdSalaDeAula");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.Instituicao", b =>
                {
                    b.Property<Guid>("IdInstituicao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(12)");

                    b.HasKey("IdInstituicao");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.PeriodoCurso", b =>
                {
                    b.Property<Guid>("IdPeriodoCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("IdPeriodoCurso");

                    b.ToTable("PeriodoCurso");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.PeriodoUsuario", b =>
                {
                    b.Property<Guid>("IdPeriodoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdPeriodoUsuario");

                    b.ToTable("PeriodoUsuario");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.SalasDeAula", b =>
                {
                    b.Property<Guid>("IdSalaDeAula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdSetor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdSalaDeAula");

                    b.HasIndex("IdSetor");

                    b.HasIndex("IdUsuario");

                    b.ToTable("SalasDeAula");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.Setor", b =>
                {
                    b.Property<Guid>("IdSetor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdInstituicao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.HasKey("IdSetor");

                    b.HasIndex("IdInstituicao");

                    b.ToTable("Setor");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.TiposUsuario", b =>
                {
                    b.Property<Guid>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TiposUsuario");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdInstituicao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPeriodoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("UsuarioSN")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdInstituicao");

                    b.HasIndex("IdPeriodoUsuario");

                    b.HasIndex("IdTipoUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.CalendarioEscolar", b =>
                {
                    b.HasOne("webapi_SenaiClassRoom.Domains.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.Curso", b =>
                {
                    b.HasOne("webapi_SenaiClassRoom.Domains.PeriodoCurso", "PeriodoCurso")
                        .WithMany()
                        .HasForeignKey("IdPeriodoCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi_SenaiClassRoom.Domains.SalasDeAula", "SalasDeAula")
                        .WithMany()
                        .HasForeignKey("IdSalaDeAula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PeriodoCurso");

                    b.Navigation("SalasDeAula");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.SalasDeAula", b =>
                {
                    b.HasOne("webapi_SenaiClassRoom.Domains.Setor", "Setor")
                        .WithMany()
                        .HasForeignKey("IdSetor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi_SenaiClassRoom.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Setor");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.Setor", b =>
                {
                    b.HasOne("webapi_SenaiClassRoom.Domains.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("webapi_SenaiClassRoom.Domains.Usuario", b =>
                {
                    b.HasOne("webapi_SenaiClassRoom.Domains.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi_SenaiClassRoom.Domains.PeriodoUsuario", "PeriodoUsuario")
                        .WithMany()
                        .HasForeignKey("IdPeriodoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi_SenaiClassRoom.Domains.TiposUsuario", "TiposUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");

                    b.Navigation("PeriodoUsuario");

                    b.Navigation("TiposUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
