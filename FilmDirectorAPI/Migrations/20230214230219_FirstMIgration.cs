﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmDirectorAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMIgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Oscars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FilmLength = table.Column<int>(type: "int", nullable: false),
                    FilmYear = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Oscars" },
                values: new object[,]
                {
                    { 1, 76, "Steven", "Spielberg", 3 },
                    { 2, 68, "James", "Cameron", 3 },
                    { 3, 61, "Peter", "Jackson", 3 },
                    { 4, 59, "Quentin", "Tarantino", 2 },
                    { 5, 56, "Jon", "Favreu", 0 },
                    { 6, 64, "Tim", "Burton", 8 },
                    { 7, 52, "Christopher", "Nolan", 0 }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "DirectorId", "FilmLength", "FilmName", "FilmYear" },
                values: new object[,]
                {
                    { 1, 1, 130, "Schindler's List", 1975 },
                    { 2, 1, 127, "Saving Private Ryan", 1993 },
                    { 3, 2, 196, "Titanic", 1997 },
                    { 4, 2, 162, "Avatar", 2009 },
                    { 5, 3, 178, "Fellowship of the Rings", 2001 },
                    { 6, 3, 201, "King Kong", 2005 },
                    { 7, 4, 154, "Pulp Fiction", 1994 },
                    { 8, 4, 159, "Once Upon a Time in Hollywood", 2019 },
                    { 9, 5, 126, "Iron Man", 2008 },
                    { 10, 5, 97, "Elf", 2003 },
                    { 11, 6, 105, "Sleepy Hollow", 1999 },
                    { 12, 6, 126, "Batman", 1989 },
                    { 13, 7, 152, "Interstellar", 2014 },
                    { 14, 7, 148, "Inseption", 2012 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_DirectorId",
                table: "Films",
                column: "DirectorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
