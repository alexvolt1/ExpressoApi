﻿// <auto-generated />
using System;
using ExpressoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpressoApi.Migrations
{
    [DbContext(typeof(ExpressoDbContext))]
    [Migration("20190328192901_addInitialMigration")]
    partial class addInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://i.imgur.com/32myl6t.jpg",
                            Name = "Coffee"
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://i.imgur.com/BbJvKUl.jpg",
                            Name = "Tea"
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://i.imgur.com/Rfvwsti.jpg",
                            Name = "Cold Drinks"
                        });
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

                    b.Property<int>("MenuId");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("SubMenus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with double espresso, and steamed milk foam.",
                            Image = "https://s15.postimg.cc/gs8p61egb/cappuccino.jpg",
                            MenuId = 1,
                            Name = "Cappuccino",
                            Price = 10
                        },
                        new
                        {
                            Id = 2,
                            Description = "Caffè Americano is a type of coffee prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from traditionally brewed coffee.",
                            Image = "https://s15.postimg.cc/nvgklnc63/americano.jpg",
                            MenuId = 1,
                            Name = "Americano",
                            Price = 10
                        },
                        new
                        {
                            Id = 3,
                            Description = "A caffè mocha, also called mocaccino, is a chocolate-flavored variant of a caffè latte. Other commonly used spellings are mochaccino and also mochachino.",
                            Image = "https://s15.postimg.cc/dle5mfh5n/mocha.jpg",
                            MenuId = 1,
                            Name = "Mocha",
                            Price = 15
                        },
                        new
                        {
                            Id = 4,
                            Description = "Green tea is a type of tea that is made from Camellia sinensis leaves that have not undergone the same withering and oxidation process used to make oolong teas and black teas.",
                            Image = "https://i.imgur.com/LmUJk2V.jpg",
                            MenuId = 2,
                            Name = "Green Tea",
                            Price = 10
                        },
                        new
                        {
                            Id = 5,
                            Description = "Black tea is a type of tea that is more oxidized than oolong, green, and white teas.",
                            Image = "https://i.imgur.com/aNp2kUe.jpg",
                            MenuId = 2,
                            Name = "Black Tea",
                            Price = 10
                        },
                        new
                        {
                            Id = 6,
                            Description = "Apple juice is a fruit juice made by the maceration and pressing of an apple.",
                            Image = "https://i.imgur.com/cKMstjY.jpg",
                            MenuId = 3,
                            Name = "Apple Juice",
                            Price = 15
                        },
                        new
                        {
                            Id = 7,
                            Description = "Orange juice is the liquid extract of the orange tree fruit, produced by squeezing oranges.",
                            Image = "https://i.imgur.com/PC6f3Dc.jpg",
                            MenuId = 3,
                            Name = "Orange Juice",
                            Price = 20
                        });
                });

            modelBuilder.Entity("ExpressoApi.Models.SubMenu", b =>
                {
                    b.HasOne("ExpressoApi.Models.Menu")
                        .WithMany("SubMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}