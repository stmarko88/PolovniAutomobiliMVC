using Microsoft.EntityFrameworkCore.Migrations;

namespace PolovniAutomobiliMVC.Migrations
{
    public partial class newTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsSpecialOffer",
                value: true);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Description", "DescriptionShort", "FuelTypeId", "ImageUrl", "ImageUrlThumbnail", "IsSpecialOffer", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 3, "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. It's available in both standard-length and long-wheelbase Expedition Max body styles and is powered by a twin-turbocharged V-6 engine with a 10-speed automatic transmission. Rear-wheel drive is standard, but buyers who need four-wheel action can have it on any trim level for a price.", "With room for up to eight passengers plus their cargo and a stout towing capacity, the 2021 Ford Expedition is a workhorse for active families. ", 2, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=2048:*", "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-ford-expedition-mmp-1-1596491024.jpeg?crop=1xw:0.8428720083246618xh;center,top&resize=800:*", false, "Ford Expedition", 51690m },
                    { 5, 2, "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxes—but they're surprisingly more sophisticated than that. So much so that we named the Rio to our Editors' Choice list. The Kia couple shares a cabin design that exudes an elegant simplicity thanks to a smart layout and pleasing materials.", "The 2021 Kia Rio sedan and hatchback are classified as economical subcompact cars—we used to call such cars econoboxes—but they're surprisingly more sophisticated than that.", 1, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=2048:*", "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/medium-14620-electrifiedpowerbigcartechnologyandrefresheddesignforupgradedkiario-1596645908.jpg?crop=0.776xw:0.654xh;0.106xw,0.303xh&resize=800:*", true, "Kia Rio", 17045m },
                    { 6, 1, "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car. Available as either a four-door hatchback or sedan, the little Toyota offers a variety of personalities. Both body styles feature a pair of dutiful four-cylinder engines, and they're also offered with an extremely frugal hybrid powertrain.", "The 2021 Toyota Corolla continues its tradition of being an inexpensive, safety-minded, and well-equipped compact car.", 1, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=2048:*", "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-toyota-corolla-se-apex-mmp-1-1601668779.jpg?crop=0.861xw:0.724xh;0.0641xw,0.194xh&resize=800:*", true, "Toyota Corolla", 21020m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsSpecialOffer",
                value: false);
        }
    }
}
