using Microsoft.EntityFrameworkCore.Migrations;

namespace PolovniAutomobiliMVC.Migrations
{
    public partial class addedFuelType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Gasoline is the most common automobile fuel and is used all over the world to power cars, motorcycles, scooters, boats, lawnmowers, and other machinery.", "Gasoline" });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Diesel fuel is also made from petroleum but is refined using a different method than that used to create gasoline.", "Diesel" });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Diesel fuel that is created using vegetable oils or animal fats is called bio-diesel.", "Bio-Diesel" });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_FuelTypes_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_FuelTypes_FuelTypeId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars");
        }
    }
}
