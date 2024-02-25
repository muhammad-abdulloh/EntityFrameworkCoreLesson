﻿// <auto-generated />
using EntityFrameworkCoreLesson.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFrameworkCoreLesson.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240224200048_erwr")]
    partial class erwr
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkCoreLesson.Applications.CarServices.Probems2", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Probems2");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Probems2");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EntityFrameworkCoreLesson.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("EntityFrameworkCoreLesson.Applications.CarServices.Probems", b =>
                {
                    b.HasBaseType("EntityFrameworkCoreLesson.Applications.CarServices.Probems2");

                    b.HasDiscriminator().HasValue("Probems");
                });
#pragma warning restore 612, 618
        }
    }
}