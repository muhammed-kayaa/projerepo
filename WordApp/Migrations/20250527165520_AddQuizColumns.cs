using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordApp.Migrations
{
    public partial class AddQuizColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorrectStreak",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsKnown",
                table: "Words",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastCorrectDate",
                table: "Words",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RepeatCount",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Words",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectStreak",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "IsKnown",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "LastCorrectDate",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "RepeatCount",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Words");
        }
    }
}
