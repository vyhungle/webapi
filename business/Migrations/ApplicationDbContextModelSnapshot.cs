﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webapi.Context;

#nullable disable

namespace business.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("model.ViewModel.Customer", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("userid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserId"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customername");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("model.ViewModel.Test", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SysPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("test");
                });

            modelBuilder.Entity("webapi.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("avatar");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision")
                        .HasColumnName("discount");

                    b.Property<double>("Discounta")
                        .HasColumnType("double precision")
                        .HasColumnName("discounta");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<decimal>("SysPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("sysprice");

                    b.HasKey("Id");

                    b.ToTable("product");
                });
#pragma warning restore 612, 618
        }
    }
}
