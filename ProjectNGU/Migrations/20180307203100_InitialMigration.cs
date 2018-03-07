using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectNGU.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    StreetAddressLine1 = table.Column<string>(nullable: true),
                    StreetAddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    FormerLegalLastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    LegalFirstName = table.Column<string>(nullable: true),
                    LegalLastName = table.Column<string>(nullable: true),
                    LegalMiddleName = table.Column<string>(nullable: true),
                    MailingAddressAddressId = table.Column<int>(nullable: true),
                    PreferredFirstName = table.Column<string>(nullable: true),
                    ResidentialAddressAddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Address_MailingAddressAddressId",
                        column: x => x.MailingAddressAddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Address_ResidentialAddressAddressId",
                        column: x => x.ResidentialAddressAddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_MailingAddressAddressId",
                table: "Users",
                column: "MailingAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ResidentialAddressAddressId",
                table: "Users",
                column: "ResidentialAddressAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
