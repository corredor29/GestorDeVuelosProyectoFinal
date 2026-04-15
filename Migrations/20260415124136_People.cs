using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorDeVuelosProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class People : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    documenttype_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    document_number = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surnames = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_birth = table.Column<DateTime>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    created_in = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_in = table.Column<DateTime>(type: "datetime", nullable: true),
                    AddressesEntityId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DocumentTypesEntityId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.id);
                    table.ForeignKey(
                        name: "FK_people_addresses_AddressesEntityId",
                        column: x => x.AddressesEntityId,
                        principalTable: "addresses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_people_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_people_document_types_DocumentTypesEntityId",
                        column: x => x.DocumentTypesEntityId,
                        principalTable: "document_types",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_people_document_types_documenttype_id",
                        column: x => x.documenttype_id,
                        principalTable: "document_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_people_address_id",
                table: "people",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_people_AddressesEntityId",
                table: "people",
                column: "AddressesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_people_document_number",
                table: "people",
                column: "document_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_people_documenttype_id",
                table: "people",
                column: "documenttype_id");

            migrationBuilder.CreateIndex(
                name: "IX_people_DocumentTypesEntityId",
                table: "people",
                column: "DocumentTypesEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "people");
        }
    }
}
