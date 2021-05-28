using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vaivoa_challenge.Migrations
{
    public partial class AddCardCreatedAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Cards",
                type: "timestamp",
                nullable: true,
                defaultValue: DateTime.Now);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Cards");
        }
    }
}