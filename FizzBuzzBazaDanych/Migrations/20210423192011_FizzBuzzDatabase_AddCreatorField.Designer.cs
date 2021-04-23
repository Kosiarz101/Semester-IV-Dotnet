﻿// <auto-generated />
using System;
using FizzBuzzBazaDanych.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FizzBuzzBazaDanych.Migrations
{
    [DbContext(typeof(FizzBuzzContext))]
    [Migration("20210423192011_FizzBuzzDatabase_AddCreatorField")]
    partial class FizzBuzzDatabase_AddCreatorField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FizzBuzzBazaDanych.Forms.FizzBuzz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime>("LastSearchDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Result")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("SearchedValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FizzBuzzData");
                });
#pragma warning restore 612, 618
        }
    }
}
