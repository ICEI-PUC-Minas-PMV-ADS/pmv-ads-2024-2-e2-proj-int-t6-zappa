using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace front_back.Migrations
{
    /// <inheritdoc />
    public partial class AddNewAttributesToAlimentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Consumo",
                table: "Alimentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DespensaId",
                table: "Alimentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Validade",
                table: "Alimentos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consumo",
                table: "Alimentos");

            migrationBuilder.DropColumn(
                name: "DespensaId",
                table: "Alimentos");

            migrationBuilder.DropColumn(
                name: "Validade",
                table: "Alimentos");
        }
    }
}
