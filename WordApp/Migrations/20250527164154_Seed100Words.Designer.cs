﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WordApp.Data;

#nullable disable

namespace WordApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250527164154_Seed100Words")]
    partial class Seed100Words
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WordApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WordApp.Models.Word", b =>
                {
                    b.Property<int>("WordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WordID"), 1L, 1);

                    b.Property<string>("EngWordName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurWordName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WordID");

                    b.ToTable("Words");

                    b.HasData(
                        new
                        {
                            WordID = 1,
                            EngWordName = "apple",
                            Picture = "C:/words/apple.jpg",
                            TurWordName = "elma"
                        },
                        new
                        {
                            WordID = 2,
                            EngWordName = "book",
                            Picture = "C:/words/book.jpg",
                            TurWordName = "kitap"
                        },
                        new
                        {
                            WordID = 3,
                            EngWordName = "cat",
                            Picture = "C:/words/cat.jpg",
                            TurWordName = "kedi"
                        },
                        new
                        {
                            WordID = 4,
                            EngWordName = "dog",
                            Picture = "C:/words/dog.jpg",
                            TurWordName = "köpek"
                        },
                        new
                        {
                            WordID = 5,
                            EngWordName = "car",
                            Picture = "C:/words/car.jpg",
                            TurWordName = "araba"
                        },
                        new
                        {
                            WordID = 6,
                            EngWordName = "house",
                            Picture = "C:/words/house.jpg",
                            TurWordName = "ev"
                        },
                        new
                        {
                            WordID = 7,
                            EngWordName = "tree",
                            Picture = "C:/words/tree.jpg",
                            TurWordName = "ağaç"
                        },
                        new
                        {
                            WordID = 8,
                            EngWordName = "water",
                            Picture = "C:/words/water.jpg",
                            TurWordName = "su"
                        },
                        new
                        {
                            WordID = 9,
                            EngWordName = "sun",
                            Picture = "C:/words/sun.jpg",
                            TurWordName = "güneş"
                        },
                        new
                        {
                            WordID = 10,
                            EngWordName = "moon",
                            Picture = "C:/words/moon.jpg",
                            TurWordName = "ay"
                        },
                        new
                        {
                            WordID = 11,
                            EngWordName = "star",
                            Picture = "C:/words/star.jpg",
                            TurWordName = "yıldız"
                        },
                        new
                        {
                            WordID = 12,
                            EngWordName = "phone",
                            Picture = "C:/words/phone.jpg",
                            TurWordName = "telefon"
                        },
                        new
                        {
                            WordID = 13,
                            EngWordName = "computer",
                            Picture = "C:/words/computer.jpg",
                            TurWordName = "bilgisayar"
                        },
                        new
                        {
                            WordID = 14,
                            EngWordName = "table",
                            Picture = "C:/words/table.jpg",
                            TurWordName = "masa"
                        },
                        new
                        {
                            WordID = 15,
                            EngWordName = "chair",
                            Picture = "C:/words/chair.jpg",
                            TurWordName = "sandalye"
                        },
                        new
                        {
                            WordID = 16,
                            EngWordName = "window",
                            Picture = "C:/words/window.jpg",
                            TurWordName = "pencere"
                        },
                        new
                        {
                            WordID = 17,
                            EngWordName = "door",
                            Picture = "C:/words/door.jpg",
                            TurWordName = "kapı"
                        },
                        new
                        {
                            WordID = 18,
                            EngWordName = "pen",
                            Picture = "C:/words/pen.jpg",
                            TurWordName = "kalem"
                        },
                        new
                        {
                            WordID = 19,
                            EngWordName = "pencil",
                            Picture = "C:/words/pencil.jpg",
                            TurWordName = "kurşun kalem"
                        },
                        new
                        {
                            WordID = 20,
                            EngWordName = "notebook",
                            Picture = "C:/words/notebook.jpg",
                            TurWordName = "defter"
                        },
                        new
                        {
                            WordID = 21,
                            EngWordName = "bag",
                            Picture = "C:/words/bag.jpg",
                            TurWordName = "çanta"
                        },
                        new
                        {
                            WordID = 22,
                            EngWordName = "shoe",
                            Picture = "C:/words/shoe.jpg",
                            TurWordName = "ayakkabı"
                        },
                        new
                        {
                            WordID = 23,
                            EngWordName = "shirt",
                            Picture = "C:/words/shirt.jpg",
                            TurWordName = "gömlek"
                        },
                        new
                        {
                            WordID = 24,
                            EngWordName = "pants",
                            Picture = "C:/words/pants.jpg",
                            TurWordName = "pantolon"
                        },
                        new
                        {
                            WordID = 25,
                            EngWordName = "hat",
                            Picture = "C:/words/hat.jpg",
                            TurWordName = "şapka"
                        },
                        new
                        {
                            WordID = 26,
                            EngWordName = "clock",
                            Picture = "C:/words/clock.jpg",
                            TurWordName = "saat"
                        },
                        new
                        {
                            WordID = 27,
                            EngWordName = "watch",
                            Picture = "C:/words/watch.jpg",
                            TurWordName = "kol saati"
                        },
                        new
                        {
                            WordID = 28,
                            EngWordName = "milk",
                            Picture = "C:/words/milk.jpg",
                            TurWordName = "süt"
                        },
                        new
                        {
                            WordID = 29,
                            EngWordName = "bread",
                            Picture = "C:/words/bread.jpg",
                            TurWordName = "ekmek"
                        },
                        new
                        {
                            WordID = 30,
                            EngWordName = "cheese",
                            Picture = "C:/words/cheese.jpg",
                            TurWordName = "peynir"
                        },
                        new
                        {
                            WordID = 31,
                            EngWordName = "egg",
                            Picture = "C:/words/egg.jpg",
                            TurWordName = "yumurta"
                        },
                        new
                        {
                            WordID = 32,
                            EngWordName = "butter",
                            Picture = "C:/words/butter.jpg",
                            TurWordName = "tereyağı"
                        },
                        new
                        {
                            WordID = 33,
                            EngWordName = "salt",
                            Picture = "C:/words/salt.jpg",
                            TurWordName = "tuz"
                        },
                        new
                        {
                            WordID = 34,
                            EngWordName = "sugar",
                            Picture = "C:/words/sugar.jpg",
                            TurWordName = "şeker"
                        },
                        new
                        {
                            WordID = 35,
                            EngWordName = "meat",
                            Picture = "C:/words/meat.jpg",
                            TurWordName = "et"
                        },
                        new
                        {
                            WordID = 36,
                            EngWordName = "fish",
                            Picture = "C:/words/fish.jpg",
                            TurWordName = "balık"
                        },
                        new
                        {
                            WordID = 37,
                            EngWordName = "chicken",
                            Picture = "C:/words/chicken.jpg",
                            TurWordName = "tavuk"
                        },
                        new
                        {
                            WordID = 38,
                            EngWordName = "rice",
                            Picture = "C:/words/rice.jpg",
                            TurWordName = "pirinç"
                        },
                        new
                        {
                            WordID = 39,
                            EngWordName = "soup",
                            Picture = "C:/words/soup.jpg",
                            TurWordName = "çorba"
                        },
                        new
                        {
                            WordID = 40,
                            EngWordName = "salad",
                            Picture = "C:/words/salad.jpg",
                            TurWordName = "salata"
                        },
                        new
                        {
                            WordID = 41,
                            EngWordName = "orange",
                            Picture = "C:/words/orange.jpg",
                            TurWordName = "portakal"
                        },
                        new
                        {
                            WordID = 42,
                            EngWordName = "banana",
                            Picture = "C:/words/banana.jpg",
                            TurWordName = "muz"
                        },
                        new
                        {
                            WordID = 43,
                            EngWordName = "grape",
                            Picture = "C:/words/grape.jpg",
                            TurWordName = "üzüm"
                        },
                        new
                        {
                            WordID = 44,
                            EngWordName = "lemon",
                            Picture = "C:/words/lemon.jpg",
                            TurWordName = "limon"
                        },
                        new
                        {
                            WordID = 45,
                            EngWordName = "peach",
                            Picture = "C:/words/peach.jpg",
                            TurWordName = "şeftali"
                        },
                        new
                        {
                            WordID = 46,
                            EngWordName = "pear",
                            Picture = "C:/words/pear.jpg",
                            TurWordName = "armut"
                        },
                        new
                        {
                            WordID = 47,
                            EngWordName = "plum",
                            Picture = "C:/words/plum.jpg",
                            TurWordName = "erik"
                        },
                        new
                        {
                            WordID = 48,
                            EngWordName = "strawberry",
                            Picture = "C:/words/strawberry.jpg",
                            TurWordName = "çilek"
                        },
                        new
                        {
                            WordID = 49,
                            EngWordName = "cherry",
                            Picture = "C:/words/cherry.jpg",
                            TurWordName = "kiraz"
                        },
                        new
                        {
                            WordID = 50,
                            EngWordName = "melon",
                            Picture = "C:/words/melon.jpg",
                            TurWordName = "kavun"
                        },
                        new
                        {
                            WordID = 51,
                            EngWordName = "potato",
                            Picture = "C:/words/potato.jpg",
                            TurWordName = "patates"
                        },
                        new
                        {
                            WordID = 52,
                            EngWordName = "tomato",
                            Picture = "C:/words/tomato.jpg",
                            TurWordName = "domates"
                        },
                        new
                        {
                            WordID = 53,
                            EngWordName = "onion",
                            Picture = "C:/words/onion.jpg",
                            TurWordName = "soğan"
                        },
                        new
                        {
                            WordID = 54,
                            EngWordName = "garlic",
                            Picture = "C:/words/garlic.jpg",
                            TurWordName = "sarımsak"
                        },
                        new
                        {
                            WordID = 55,
                            EngWordName = "carrot",
                            Picture = "C:/words/carrot.jpg",
                            TurWordName = "havuç"
                        },
                        new
                        {
                            WordID = 56,
                            EngWordName = "cucumber",
                            Picture = "C:/words/cucumber.jpg",
                            TurWordName = "salatalık"
                        },
                        new
                        {
                            WordID = 57,
                            EngWordName = "pepper",
                            Picture = "C:/words/pepper.jpg",
                            TurWordName = "biber"
                        },
                        new
                        {
                            WordID = 58,
                            EngWordName = "eggplant",
                            Picture = "C:/words/eggplant.jpg",
                            TurWordName = "patlıcan"
                        },
                        new
                        {
                            WordID = 59,
                            EngWordName = "lettuce",
                            Picture = "C:/words/lettuce.jpg",
                            TurWordName = "marul"
                        },
                        new
                        {
                            WordID = 60,
                            EngWordName = "spinach",
                            Picture = "C:/words/spinach.jpg",
                            TurWordName = "ıspanak"
                        },
                        new
                        {
                            WordID = 61,
                            EngWordName = "broccoli",
                            Picture = "C:/words/broccoli.jpg",
                            TurWordName = "brokoli"
                        },
                        new
                        {
                            WordID = 62,
                            EngWordName = "cauliflower",
                            Picture = "C:/words/cauliflower.jpg",
                            TurWordName = "karnabahar"
                        },
                        new
                        {
                            WordID = 63,
                            EngWordName = "pumpkin",
                            Picture = "C:/words/pumpkin.jpg",
                            TurWordName = "balkabağı"
                        },
                        new
                        {
                            WordID = 64,
                            EngWordName = "corn",
                            Picture = "C:/words/corn.jpg",
                            TurWordName = "mısır"
                        },
                        new
                        {
                            WordID = 65,
                            EngWordName = "bean",
                            Picture = "C:/words/bean.jpg",
                            TurWordName = "fasulye"
                        },
                        new
                        {
                            WordID = 66,
                            EngWordName = "pea",
                            Picture = "C:/words/pea.jpg",
                            TurWordName = "bezelye"
                        },
                        new
                        {
                            WordID = 67,
                            EngWordName = "mushroom",
                            Picture = "C:/words/mushroom.jpg",
                            TurWordName = "mantar"
                        },
                        new
                        {
                            WordID = 68,
                            EngWordName = "olive",
                            Picture = "C:/words/olive.jpg",
                            TurWordName = "zeytin"
                        },
                        new
                        {
                            WordID = 69,
                            EngWordName = "honey",
                            Picture = "C:/words/honey.jpg",
                            TurWordName = "bal"
                        },
                        new
                        {
                            WordID = 70,
                            EngWordName = "jam",
                            Picture = "C:/words/jam.jpg",
                            TurWordName = "reçel"
                        },
                        new
                        {
                            WordID = 71,
                            EngWordName = "cake",
                            Picture = "C:/words/cake.jpg",
                            TurWordName = "pasta"
                        },
                        new
                        {
                            WordID = 72,
                            EngWordName = "pie",
                            Picture = "C:/words/pie.jpg",
                            TurWordName = "turta"
                        },
                        new
                        {
                            WordID = 73,
                            EngWordName = "cookie",
                            Picture = "C:/words/cookie.jpg",
                            TurWordName = "kurabiye"
                        },
                        new
                        {
                            WordID = 74,
                            EngWordName = "ice cream",
                            Picture = "C:/words/icecream.jpg",
                            TurWordName = "dondurma"
                        },
                        new
                        {
                            WordID = 75,
                            EngWordName = "juice",
                            Picture = "C:/words/juice.jpg",
                            TurWordName = "meyve suyu"
                        },
                        new
                        {
                            WordID = 76,
                            EngWordName = "tea",
                            Picture = "C:/words/tea.jpg",
                            TurWordName = "çay"
                        },
                        new
                        {
                            WordID = 77,
                            EngWordName = "coffee",
                            Picture = "C:/words/coffee.jpg",
                            TurWordName = "kahve"
                        },
                        new
                        {
                            WordID = 78,
                            EngWordName = "soda",
                            Picture = "C:/words/soda.jpg",
                            TurWordName = "soda"
                        },
                        new
                        {
                            WordID = 79,
                            EngWordName = "cola",
                            Picture = "C:/words/cola.jpg",
                            TurWordName = "kola"
                        },
                        new
                        {
                            WordID = 80,
                            EngWordName = "butcher",
                            Picture = "C:/words/butcher.jpg",
                            TurWordName = "kasap"
                        },
                        new
                        {
                            WordID = 81,
                            EngWordName = "baker",
                            Picture = "C:/words/baker.jpg",
                            TurWordName = "fırıncı"
                        },
                        new
                        {
                            WordID = 82,
                            EngWordName = "driver",
                            Picture = "C:/words/driver.jpg",
                            TurWordName = "şoför"
                        },
                        new
                        {
                            WordID = 83,
                            EngWordName = "teacher",
                            Picture = "C:/words/teacher.jpg",
                            TurWordName = "öğretmen"
                        },
                        new
                        {
                            WordID = 84,
                            EngWordName = "doctor",
                            Picture = "C:/words/doctor.jpg",
                            TurWordName = "doktor"
                        },
                        new
                        {
                            WordID = 85,
                            EngWordName = "nurse",
                            Picture = "C:/words/nurse.jpg",
                            TurWordName = "hemşire"
                        },
                        new
                        {
                            WordID = 86,
                            EngWordName = "police",
                            Picture = "C:/words/police.jpg",
                            TurWordName = "polis"
                        },
                        new
                        {
                            WordID = 87,
                            EngWordName = "fireman",
                            Picture = "C:/words/fireman.jpg",
                            TurWordName = "itfaiyeci"
                        },
                        new
                        {
                            WordID = 88,
                            EngWordName = "soldier",
                            Picture = "C:/words/soldier.jpg",
                            TurWordName = "asker"
                        },
                        new
                        {
                            WordID = 89,
                            EngWordName = "student",
                            Picture = "C:/words/student.jpg",
                            TurWordName = "öğrenci"
                        },
                        new
                        {
                            WordID = 90,
                            EngWordName = "engineer",
                            Picture = "C:/words/engineer.jpg",
                            TurWordName = "mühendis"
                        },
                        new
                        {
                            WordID = 91,
                            EngWordName = "lawyer",
                            Picture = "C:/words/lawyer.jpg",
                            TurWordName = "avukat"
                        },
                        new
                        {
                            WordID = 92,
                            EngWordName = "judge",
                            Picture = "C:/words/judge.jpg",
                            TurWordName = "hakim"
                        },
                        new
                        {
                            WordID = 93,
                            EngWordName = "pilot",
                            Picture = "C:/words/pilot.jpg",
                            TurWordName = "pilot"
                        },
                        new
                        {
                            WordID = 94,
                            EngWordName = "artist",
                            Picture = "C:/words/artist.jpg",
                            TurWordName = "sanatçı"
                        },
                        new
                        {
                            WordID = 95,
                            EngWordName = "actor",
                            Picture = "C:/words/actor.jpg",
                            TurWordName = "oyuncu"
                        },
                        new
                        {
                            WordID = 96,
                            EngWordName = "singer",
                            Picture = "C:/words/singer.jpg",
                            TurWordName = "şarkıcı"
                        },
                        new
                        {
                            WordID = 97,
                            EngWordName = "dancer",
                            Picture = "C:/words/dancer.jpg",
                            TurWordName = "dansçı"
                        },
                        new
                        {
                            WordID = 98,
                            EngWordName = "writer",
                            Picture = "C:/words/writer.jpg",
                            TurWordName = "yazar"
                        },
                        new
                        {
                            WordID = 99,
                            EngWordName = "poet",
                            Picture = "C:/words/poet.jpg",
                            TurWordName = "şair"
                        },
                        new
                        {
                            WordID = 100,
                            EngWordName = "scientist",
                            Picture = "C:/words/scientist.jpg",
                            TurWordName = "bilim insanı"
                        });
                });

            modelBuilder.Entity("WordApp.Models.WordSample", b =>
                {
                    b.Property<int>("WordSampleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WordSampleId"), 1L, 1);

                    b.Property<string>("Samples")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WordID")
                        .HasColumnType("int");

                    b.HasKey("WordSampleId");

                    b.HasIndex("WordID");

                    b.ToTable("WordSamples");
                });

            modelBuilder.Entity("WordApp.Models.WordSample", b =>
                {
                    b.HasOne("WordApp.Models.Word", "Word")
                        .WithMany("WordSamples")
                        .HasForeignKey("WordID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Word");
                });

            modelBuilder.Entity("WordApp.Models.Word", b =>
                {
                    b.Navigation("WordSamples");
                });
#pragma warning restore 612, 618
        }
    }
}
