﻿// <auto-generated />
using System;
using ExpressoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpressoApi.Migrations
{
    [DbContext(typeof(ExpressoDbContext))]
    partial class ExpressoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExpressoApi.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("ExpressoApi.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Time")
                        .IsRequired();

                    b.Property<int>("TotalPeople");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ExpressoApi.Models.SubMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<int?>("MenuId");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("SubMenu");
                });

            modelBuilder.Entity("ExpressoApi.Models.SubMenu", b =>
                {
                    b.HasOne("ExpressoApi.Models.Menu")
                        .WithMany("SubMenus")
                        .HasForeignKey("MenuId");
                });
#pragma warning restore 612, 618
        }
    }
}