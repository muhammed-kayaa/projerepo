using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordApp.Migrations
{
    public partial class Seed100Words : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "WordID", "EngWordName", "Picture", "TurWordName" },
                values: new object[,]
                {
                    { 1, "apple", "C:/words/apple.jpg", "elma" },
                    { 2, "book", "C:/words/book.jpg", "kitap" },
                    { 3, "cat", "C:/words/cat.jpg", "kedi" },
                    { 4, "dog", "C:/words/dog.jpg", "köpek" },
                    { 5, "car", "C:/words/car.jpg", "araba" },
                    { 6, "house", "C:/words/house.jpg", "ev" },
                    { 7, "tree", "C:/words/tree.jpg", "ağaç" },
                    { 8, "water", "C:/words/water.jpg", "su" },
                    { 9, "sun", "C:/words/sun.jpg", "güneş" },
                    { 10, "moon", "C:/words/moon.jpg", "ay" },
                    { 11, "star", "C:/words/star.jpg", "yıldız" },
                    { 12, "phone", "C:/words/phone.jpg", "telefon" },
                    { 13, "computer", "C:/words/computer.jpg", "bilgisayar" },
                    { 14, "table", "C:/words/table.jpg", "masa" },
                    { 15, "chair", "C:/words/chair.jpg", "sandalye" },
                    { 16, "window", "C:/words/window.jpg", "pencere" },
                    { 17, "door", "C:/words/door.jpg", "kapı" },
                    { 18, "pen", "C:/words/pen.jpg", "kalem" },
                    { 19, "pencil", "C:/words/pencil.jpg", "kurşun kalem" },
                    { 20, "notebook", "C:/words/notebook.jpg", "defter" },
                    { 21, "bag", "C:/words/bag.jpg", "çanta" },
                    { 22, "shoe", "C:/words/shoe.jpg", "ayakkabı" },
                    { 23, "shirt", "C:/words/shirt.jpg", "gömlek" },
                    { 24, "pants", "C:/words/pants.jpg", "pantolon" },
                    { 25, "hat", "C:/words/hat.jpg", "şapka" },
                    { 26, "clock", "C:/words/clock.jpg", "saat" },
                    { 27, "watch", "C:/words/watch.jpg", "kol saati" },
                    { 28, "milk", "C:/words/milk.jpg", "süt" },
                    { 29, "bread", "C:/words/bread.jpg", "ekmek" },
                    { 30, "cheese", "C:/words/cheese.jpg", "peynir" },
                    { 31, "egg", "C:/words/egg.jpg", "yumurta" },
                    { 32, "butter", "C:/words/butter.jpg", "tereyağı" },
                    { 33, "salt", "C:/words/salt.jpg", "tuz" },
                    { 34, "sugar", "C:/words/sugar.jpg", "şeker" },
                    { 35, "meat", "C:/words/meat.jpg", "et" },
                    { 36, "fish", "C:/words/fish.jpg", "balık" },
                    { 37, "chicken", "C:/words/chicken.jpg", "tavuk" },
                    { 38, "rice", "C:/words/rice.jpg", "pirinç" },
                    { 39, "soup", "C:/words/soup.jpg", "çorba" },
                    { 40, "salad", "C:/words/salad.jpg", "salata" },
                    { 41, "orange", "C:/words/orange.jpg", "portakal" },
                    { 42, "banana", "C:/words/banana.jpg", "muz" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "WordID", "EngWordName", "Picture", "TurWordName" },
                values: new object[,]
                {
                    { 43, "grape", "C:/words/grape.jpg", "üzüm" },
                    { 44, "lemon", "C:/words/lemon.jpg", "limon" },
                    { 45, "peach", "C:/words/peach.jpg", "şeftali" },
                    { 46, "pear", "C:/words/pear.jpg", "armut" },
                    { 47, "plum", "C:/words/plum.jpg", "erik" },
                    { 48, "strawberry", "C:/words/strawberry.jpg", "çilek" },
                    { 49, "cherry", "C:/words/cherry.jpg", "kiraz" },
                    { 50, "melon", "C:/words/melon.jpg", "kavun" },
                    { 51, "potato", "C:/words/potato.jpg", "patates" },
                    { 52, "tomato", "C:/words/tomato.jpg", "domates" },
                    { 53, "onion", "C:/words/onion.jpg", "soğan" },
                    { 54, "garlic", "C:/words/garlic.jpg", "sarımsak" },
                    { 55, "carrot", "C:/words/carrot.jpg", "havuç" },
                    { 56, "cucumber", "C:/words/cucumber.jpg", "salatalık" },
                    { 57, "pepper", "C:/words/pepper.jpg", "biber" },
                    { 58, "eggplant", "C:/words/eggplant.jpg", "patlıcan" },
                    { 59, "lettuce", "C:/words/lettuce.jpg", "marul" },
                    { 60, "spinach", "C:/words/spinach.jpg", "ıspanak" },
                    { 61, "broccoli", "C:/words/broccoli.jpg", "brokoli" },
                    { 62, "cauliflower", "C:/words/cauliflower.jpg", "karnabahar" },
                    { 63, "pumpkin", "C:/words/pumpkin.jpg", "balkabağı" },
                    { 64, "corn", "C:/words/corn.jpg", "mısır" },
                    { 65, "bean", "C:/words/bean.jpg", "fasulye" },
                    { 66, "pea", "C:/words/pea.jpg", "bezelye" },
                    { 67, "mushroom", "C:/words/mushroom.jpg", "mantar" },
                    { 68, "olive", "C:/words/olive.jpg", "zeytin" },
                    { 69, "honey", "C:/words/honey.jpg", "bal" },
                    { 70, "jam", "C:/words/jam.jpg", "reçel" },
                    { 71, "cake", "C:/words/cake.jpg", "pasta" },
                    { 72, "pie", "C:/words/pie.jpg", "turta" },
                    { 73, "cookie", "C:/words/cookie.jpg", "kurabiye" },
                    { 74, "ice cream", "C:/words/icecream.jpg", "dondurma" },
                    { 75, "juice", "C:/words/juice.jpg", "meyve suyu" },
                    { 76, "tea", "C:/words/tea.jpg", "çay" },
                    { 77, "coffee", "C:/words/coffee.jpg", "kahve" },
                    { 78, "soda", "C:/words/soda.jpg", "soda" },
                    { 79, "cola", "C:/words/cola.jpg", "kola" },
                    { 80, "butcher", "C:/words/butcher.jpg", "kasap" },
                    { 81, "baker", "C:/words/baker.jpg", "fırıncı" },
                    { 82, "driver", "C:/words/driver.jpg", "şoför" },
                    { 83, "teacher", "C:/words/teacher.jpg", "öğretmen" },
                    { 84, "doctor", "C:/words/doctor.jpg", "doktor" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "WordID", "EngWordName", "Picture", "TurWordName" },
                values: new object[,]
                {
                    { 85, "nurse", "C:/words/nurse.jpg", "hemşire" },
                    { 86, "police", "C:/words/police.jpg", "polis" },
                    { 87, "fireman", "C:/words/fireman.jpg", "itfaiyeci" },
                    { 88, "soldier", "C:/words/soldier.jpg", "asker" },
                    { 89, "student", "C:/words/student.jpg", "öğrenci" },
                    { 90, "engineer", "C:/words/engineer.jpg", "mühendis" },
                    { 91, "lawyer", "C:/words/lawyer.jpg", "avukat" },
                    { 92, "judge", "C:/words/judge.jpg", "hakim" },
                    { 93, "pilot", "C:/words/pilot.jpg", "pilot" },
                    { 94, "artist", "C:/words/artist.jpg", "sanatçı" },
                    { 95, "actor", "C:/words/actor.jpg", "oyuncu" },
                    { 96, "singer", "C:/words/singer.jpg", "şarkıcı" },
                    { 97, "dancer", "C:/words/dancer.jpg", "dansçı" },
                    { 98, "writer", "C:/words/writer.jpg", "yazar" },
                    { 99, "poet", "C:/words/poet.jpg", "şair" },
                    { 100, "scientist", "C:/words/scientist.jpg", "bilim insanı" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordID",
                keyValue: 100);
        }
    }
}
