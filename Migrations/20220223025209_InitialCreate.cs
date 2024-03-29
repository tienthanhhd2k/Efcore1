﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "ntext", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "ntext", maxLength: 200, nullable: false),
                    CityName = table.Column<string>(type: "ntext", maxLength: 200, nullable: false),
                    State = table.Column<string>(type: "ntext", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
