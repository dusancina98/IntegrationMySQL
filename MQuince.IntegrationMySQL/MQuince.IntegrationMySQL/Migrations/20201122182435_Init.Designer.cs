﻿// <auto-generated />
using System;
using MQuince.IntegrationMySQL.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MQuince.IntegrationMySQL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201122182435_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MQuince.IntegrationMySQL.PersistenceEntities.PharmacyPersistence", b =>
                {
                    b.Property<Guid>("ApiKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ApiKey");

                    b.ToTable("Pharmacy");
                });
#pragma warning restore 612, 618
        }
    }
}