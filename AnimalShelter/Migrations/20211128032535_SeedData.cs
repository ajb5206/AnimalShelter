using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "CatAge", "CatBreed", "CatGender", "CatName" },
                values: new object[,]
                {
                    { 1, 2, "Flame Point", "Male", "Hobbes" },
                    { 8, 7, "Russian Gray", "Male", "Dobby" },
                    { 7, 18, "Orange", "Male", "Mombob" },
                    { 6, 9, "Siamese", "Female", "Loblob" },
                    { 9, 16, "Persian", "Male", "Calvin" },
                    { 4, 21, "Gray", "Male", "Rhode" },
                    { 3, 5, "Black Cat", "Female", "Ash" },
                    { 2, 19, "Tabby", "Male", "Rikki" },
                    { 5, 5, "Tabby", "Male", "Bobob" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "DogAge", "DogBreed", "DogGender", "DogName" },
                values: new object[,]
                {
                    { 8, 7, "Brittany", "Female", "Lob" },
                    { 1, 15, "Jack Russel", "Female", "Clio" },
                    { 2, 19, "Shetland Sheepdog", "Male", "Sparky" },
                    { 3, 11, "Black Lab", "Male", "Alphonse" },
                    { 4, 11, "Golden Doodle", "Male", "Bob" },
                    { 5, 2, "Golden Retriever", "Female", "Rob" },
                    { 6, 1, "Pomeranian", "Male", "Dob" },
                    { 7, 5, "Cocker Spaniel", "Female", "Mob" },
                    { 9, 19, "Australian", "Female", "Cloe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 9);
        }
    }
}
