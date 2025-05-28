using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordApp.Migrations
{
    public partial class RemoveSeedWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: -1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "WordID", "CorrectStreak", "EngWordName", "IsKnown", "LastCorrectDate", "Picture", "RepeatCount", "TurWordName", "UserId" },
                values: new object[,]
                {
                    { -20, 0, "notebook", false, null, "C:/words/notebook.jpg", 0, "defter", null },
                    { -19, 0, "pencil", false, null, "C:/words/pencil.jpg", 0, "kurşun kalem", null },
                    { -18, 0, "pen", false, null, "C:/words/pen.jpg", 0, "kalem", null },
                    { -17, 0, "door", false, null, "C:/words/door.jpg", 0, "kapı", null },
                    { -16, 0, "window", false, null, "C:/words/window.jpg", 0, "pencere", null },
                    { -15, 0, "chair", false, null, "C:/words/chair.jpg", 0, "sandalye", null },
                    { -14, 0, "table", false, null, "C:/words/table.jpg", 0, "masa", null },
                    { -13, 0, "computer", false, null, "C:/words/computer.jpg", 0, "bilgisayar", null },
                    { -12, 0, "phone", false, null, "C:/words/phone.jpg", 0, "telefon", null },
                    { -11, 0, "star", false, null, "C:/words/star.jpg", 0, "yıldız", null },
                    { -10, 0, "moon", false, null, "C:/words/moon.jpg", 0, "ay", null },
                    { -9, 0, "sun", false, null, "C:/words/sun.jpg", 0, "güneş", null },
                    { -8, 0, "water", false, null, "C:/words/water.jpg", 0, "su", null },
                    { -7, 0, "tree", false, null, "C:/words/tree.jpg", 0, "ağaç", null },
                    { -6, 0, "house", false, null, "C:/words/house.jpg", 0, "ev", null },
                    { -5, 0, "car", false, null, "C:/words/car.jpg", 0, "araba", null },
                    { -4, 0, "dog", false, null, "C:/words/dog.jpg", 0, "köpek", null },
                    { -3, 0, "cat", false, null, "C:/words/cat.jpg", 0, "kedi", null },
                    { -2, 0, "book", false, null, "C:/words/book.jpg", 0, "kitap", null },
                    { -1, 0, "apple", false, null, "C:/words/apple.jpg", 0, "elma", null }
                });
        }
    }
}
