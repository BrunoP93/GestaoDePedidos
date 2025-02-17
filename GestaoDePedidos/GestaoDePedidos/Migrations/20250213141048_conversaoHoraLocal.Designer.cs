﻿// <auto-generated />
using System;
using GestaoDePedidos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestaoDePedidos.Migrations
{
    [DbContext(typeof(PedidoContext))]
    [Migration("20250213141048_conversaoHoraLocal")]
    partial class conversaoHoraLocal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GestaoDePedidos.Model.PedidoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cliente");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dataCriacao");

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("produto");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("tb_pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
