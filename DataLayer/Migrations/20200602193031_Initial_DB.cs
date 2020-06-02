using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Initial_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "PageGroups");

            migrationBuilder.DropIndex(
                name: "GroupId_UNIQUE",
                table: "PageGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "PageComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Page",
                table: "Page");

            migrationBuilder.DropIndex(
                name: "PageID_UNIQUE",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "PageGroups");

            migrationBuilder.RenameTable(
                name: "Page",
                newName: "Pages");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "PageGroups",
                newName: "GroupID");

            migrationBuilder.AddColumn<string>(
                name: "GroupTitle",
                table: "PageGroups",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "PageComments",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "PageID",
                table: "PageComments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PageComments",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "PageComments",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PageComments",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "PageComments",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Pages",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<bool>(
                name: "ShowInSlider",
                table: "Pages",
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Pages",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(450)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Pages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Pages",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageGroupsGroupID",
                table: "Pages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Pages",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PageGroups",
                table: "PageGroups",
                column: "GroupID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PageComments",
                table: "PageComments",
                column: "CommentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pages",
                table: "Pages",
                column: "PageID");

            migrationBuilder.CreateIndex(
                name: "IX_PageComments_PageID",
                table: "PageComments",
                column: "PageID");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_PageGroupsGroupID",
                table: "Pages",
                column: "PageGroupsGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_PageComments_Pages_PageID",
                table: "PageComments",
                column: "PageID",
                principalTable: "Pages",
                principalColumn: "PageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_PageGroups_PageGroupsGroupID",
                table: "Pages",
                column: "PageGroupsGroupID",
                principalTable: "PageGroups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageComments_Pages_PageID",
                table: "PageComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_PageGroups_PageGroupsGroupID",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PageGroups",
                table: "PageGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PageComments",
                table: "PageComments");

            migrationBuilder.DropIndex(
                name: "IX_PageComments_PageID",
                table: "PageComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pages",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_PageGroupsGroupID",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "GroupTitle",
                table: "PageGroups");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "PageComments");

            migrationBuilder.DropColumn(
                name: "PageGroupsGroupID",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Pages");

            migrationBuilder.RenameTable(
                name: "Pages",
                newName: "Page");

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "PageGroups",
                newName: "GroupId");

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "PageGroups",
                type: "varchar(45)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "WebSite",
                table: "PageComments",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "PageID",
                table: "PageComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PageComments",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "PageComments",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PageComments",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Page",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<sbyte>(
                name: "ShowInSlider",
                table: "Page",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Page",
                type: "varchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 350)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Page",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Page",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "PageGroups",
                column: "GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "PageComments",
                column: "CommentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Page",
                table: "Page",
                column: "PageID");

            migrationBuilder.CreateIndex(
                name: "GroupId_UNIQUE",
                table: "PageGroups",
                column: "GroupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PageID_UNIQUE",
                table: "Page",
                column: "PageID",
                unique: true);
        }
    }
}
