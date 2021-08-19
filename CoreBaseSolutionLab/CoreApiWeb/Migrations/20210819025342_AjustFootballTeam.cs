using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApiWeb.Migrations
{
    public partial class AjustFootballTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Manager",
                table: "Teams");
        }
    }
}
