using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class organization1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "contacts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrganizationEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OrganizationEntity",
                columns: new[] { "Id", "Description", "Name", "Address_City", "Address_PostalCode", "Address_Street" },
                values: new object[,]
                {
                    { 101, "Uczelnia Wyższa", "WSEI", "Kraków", "31-150", "św. Filipa 17" },
                    { 102, "Uczelnia Wyższa", "Koło studenckie VR", "Kraków", "31-150", "św. Filipa 17, pok. 12" }
                });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "contact_id",
                keyValue: 1,
                column: "OrganizationId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "contact_id",
                keyValue: 2,
                column: "OrganizationId",
                value: 101);

            migrationBuilder.CreateIndex(
                name: "IX_contacts_OrganizationId",
                table: "contacts",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_OrganizationEntity_OrganizationId",
                table: "contacts",
                column: "OrganizationId",
                principalTable: "OrganizationEntity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contacts_OrganizationEntity_OrganizationId",
                table: "contacts");

            migrationBuilder.DropTable(
                name: "OrganizationEntity");

            migrationBuilder.DropIndex(
                name: "IX_contacts_OrganizationId",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "contacts");
        }
    }
}
