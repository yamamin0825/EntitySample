using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitySample.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Book2Id",
                table: "Book2",
                newName: "Book2ID");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Book",
                newName: "BookID");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "BookCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "BookCategory");

            migrationBuilder.RenameColumn(
                name: "Book2ID",
                table: "Book2",
                newName: "Book2Id");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "Book",
                newName: "BookId");
        }
    }
}
