using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzzBazaDanych.Migrations
{
    public partial class FizzBuzzDatabase_AddCreatorField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "FizzBuzzData",
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creator",
                table: "FizzBuzzData");
        }
    }
}
