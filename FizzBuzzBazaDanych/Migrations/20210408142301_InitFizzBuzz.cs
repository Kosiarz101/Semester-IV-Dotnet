using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzzBazaDanych.Migrations
{
    public partial class InitFizzBuzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FizzBuzzData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<string>(nullable: true),
                    SearchedValue = table.Column<int>(nullable: false),
                    LastSearchDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FizzBuzzData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FizzBuzzData");
        }
    }
}
