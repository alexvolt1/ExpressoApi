using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressoApi.Migrations
{
    public partial class addInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    TotalPeople = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    MenuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[] { 1, "https://i.imgur.com/32myl6t.jpg", "Coffee" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[] { 2, "https://i.imgur.com/BbJvKUl.jpg", "Tea" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[] { 3, "https://i.imgur.com/Rfvwsti.jpg", "Cold Drinks" });

            migrationBuilder.InsertData(
                table: "SubMenus",
                columns: new[] { "Id", "Description", "Image", "MenuId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with double espresso, and steamed milk foam.", "https://s15.postimg.cc/gs8p61egb/cappuccino.jpg", 1, "Cappuccino", 10 },
                    { 2, "Caffè Americano is a type of coffee prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from traditionally brewed coffee.", "https://s15.postimg.cc/nvgklnc63/americano.jpg", 1, "Americano", 10 },
                    { 3, "A caffè mocha, also called mocaccino, is a chocolate-flavored variant of a caffè latte. Other commonly used spellings are mochaccino and also mochachino.", "https://s15.postimg.cc/dle5mfh5n/mocha.jpg", 1, "Mocha", 15 },
                    { 4, "Green tea is a type of tea that is made from Camellia sinensis leaves that have not undergone the same withering and oxidation process used to make oolong teas and black teas.", "https://i.imgur.com/LmUJk2V.jpg", 2, "Green Tea", 10 },
                    { 5, "Black tea is a type of tea that is more oxidized than oolong, green, and white teas.", "https://i.imgur.com/aNp2kUe.jpg", 2, "Black Tea", 10 },
                    { 6, "Apple juice is a fruit juice made by the maceration and pressing of an apple.", "https://i.imgur.com/cKMstjY.jpg", 3, "Apple Juice", 15 },
                    { 7, "Orange juice is the liquid extract of the orange tree fruit, produced by squeezing oranges.", "https://i.imgur.com/PC6f3Dc.jpg", 3, "Orange Juice", 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubMenus_MenuId",
                table: "SubMenus",
                column: "MenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "SubMenus");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
