using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NEW_ALPHAL.Migrations
{
    /// <inheritdoc />
    public partial class newproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Products",
                type: "datetime2",
                nullable: true);
        }
    }
}
