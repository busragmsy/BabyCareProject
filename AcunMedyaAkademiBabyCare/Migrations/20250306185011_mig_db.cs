using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedyaAkademiBabyCare.Migrations
{
    public partial class mig_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagerUrl",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameSurname",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClassTime",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LessonCount",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StudentCount",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "AboutLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ImagerUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "NameSurname",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Header",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ClassTime",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "LessonCount",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AboutLists");
        }
    }
}
