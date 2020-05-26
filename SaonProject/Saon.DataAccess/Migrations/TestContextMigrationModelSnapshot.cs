﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Saon.DataAccess;

namespace Saon.DataAccess.Migrations
{
    [DbContext(typeof(TestContextMigration))]
    partial class TestContextMigrationModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Saon.Entities.Job", b =>
                {
                    b.Property<int>("IdJob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("ExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("IdJob");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            IdJob = 1,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 147, DateTimeKind.Local).AddTicks(8766),
                            Description = "Descripcion about .net developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 148, DateTimeKind.Local).AddTicks(9860),
                            JobTitle = ".NET Developer"
                        },
                        new
                        {
                            IdJob = 2,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(641),
                            Description = "Descripcion about QA Analyst",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(653),
                            JobTitle = ".QA Analyst"
                        },
                        new
                        {
                            IdJob = 3,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(668),
                            Description = "Descripcion about Solution Architec",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(669),
                            JobTitle = "Solution Architec"
                        },
                        new
                        {
                            IdJob = 4,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(671),
                            Description = "Descripcion about Developer Manager",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(672),
                            JobTitle = "Developer Manager"
                        },
                        new
                        {
                            IdJob = 5,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(674),
                            Description = "Descripcion about Human Resource Talent Hunter",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(675),
                            JobTitle = "Human Resource Talent Hunter"
                        },
                        new
                        {
                            IdJob = 6,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(677),
                            Description = "Descripcion about Junior Java Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(678),
                            JobTitle = "Junior Java Developer"
                        },
                        new
                        {
                            IdJob = 7,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(679),
                            Description = "Descripcion about Senior Java Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(680),
                            JobTitle = "Senior Java Developer"
                        },
                        new
                        {
                            IdJob = 8,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(682),
                            Description = "Descripcion about Junior Javascript Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(683),
                            JobTitle = "Junior Javascript Developer"
                        },
                        new
                        {
                            IdJob = 9,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(684),
                            Description = "Descripcion about Senior Javascript Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(685),
                            JobTitle = "Senior Javascript Developer"
                        },
                        new
                        {
                            IdJob = 10,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(687),
                            Description = "Descripcion about Junior React Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(688),
                            JobTitle = "Junior React Developer"
                        },
                        new
                        {
                            IdJob = 11,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(689),
                            Description = "Descripcion about Senior React Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(690),
                            JobTitle = "Senior React Developer"
                        },
                        new
                        {
                            IdJob = 12,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(692),
                            Description = "Descripcion about Junior Phyton Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(693),
                            JobTitle = "Junior Phyton Developer"
                        },
                        new
                        {
                            IdJob = 13,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(694),
                            Description = "Descripcion about Senior Phyton Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(695),
                            JobTitle = "Senior Phyton Developer"
                        },
                        new
                        {
                            IdJob = 14,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(697),
                            Description = "Descripcion about Junior React  Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(698),
                            JobTitle = "Junior React Developer"
                        },
                        new
                        {
                            IdJob = 15,
                            CreatedAt = new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(700),
                            Description = "Descripcion about Senior React Developer",
                            ExpiredAt = new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(701),
                            JobTitle = "Senior React Developer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
