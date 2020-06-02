using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    PageID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    ShortDescription = table.Column<string>(type: "varchar(450)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    Visit = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShowInSlider = table.Column<sbyte>(nullable: true),
                    ImageName = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.PageID);
                });

            migrationBuilder.CreateTable(
                name: "PageComments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PageID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    WebSite = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "PageGroups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PageTitle = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.GroupId);
                });

            migrationBuilder.CreateIndex(
                name: "PageID_UNIQUE",
                table: "Page",
                column: "PageID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "GroupId_UNIQUE",
                table: "PageGroups",
                column: "GroupId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "PageComments");

            migrationBuilder.DropTable(
                name: "PageGroups");
        }
    }
}
