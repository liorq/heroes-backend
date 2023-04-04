﻿// <auto-generated />
using System;
using JwtWebApi.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtWebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230402175119_MigrationName")]
    partial class MigrationName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JwtWebApi.tables.Hero", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Ability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AmountOfTimeHeroTrained")
                        .HasColumnType("int");

                    b.Property<double?>("CurrentPower")
                        .HasColumnType("float");

                    b.Property<int?>("FirstDayHeroTrained")
                        .HasColumnType("int");

                    b.Property<string>("LastTimeHeroTrained")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("StartingPower")
                        .HasColumnType("float");

                    b.Property<string>("SuitColors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AllHeroes");
                });

            modelBuilder.Entity("JwtWebApi.tables.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Expiry_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsLock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JwtWebApi.tables.Hero", b =>
                {
                    b.HasOne("JwtWebApi.tables.User", null)
                        .WithMany("Heroes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("JwtWebApi.tables.User", b =>
                {
                    b.Navigation("Heroes");
                });
#pragma warning restore 612, 618
        }
    }
}