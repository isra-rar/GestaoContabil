﻿// <auto-generated />
using System;
using GestaoContabil.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoContabil.Migrations
{
    [DbContext(typeof(GestaoContabilContext))]
    [Migration("20201223035140_InitialBool")]
    partial class InitialBool
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GestaoContabil.Models.Despesa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Pago")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("GestaoContabil.Models.Receita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Recebido")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
