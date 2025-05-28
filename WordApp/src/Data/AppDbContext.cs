using Microsoft.EntityFrameworkCore;
using WordApp.Models;

namespace WordApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<WordSample> WordSamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sadece Express instance'a bağlan (hata riskini azalt)
            var connStr = "Server=.\\SQLEXPRESS;Database=WordApp;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Word>()
                .HasMany(w => w.WordSamples)
                .WithOne(ws => ws.Word)
                .HasForeignKey(ws => ws.WordID);

            // 20 kelime seed data (WordID negatif verildi)
            modelBuilder.Entity<Word>().HasData(
                new Word { WordID = -1, EngWordName = "apple", TurWordName = "elma", Picture = "C:/words/apple.jpg" },
                new Word { WordID = -2, EngWordName = "book", TurWordName = "kitap", Picture = "C:/words/book.jpg" },
                new Word { WordID = -3, EngWordName = "cat", TurWordName = "kedi", Picture = "C:/words/cat.jpg" },
                new Word { WordID = -4, EngWordName = "dog", TurWordName = "köpek", Picture = "C:/words/dog.jpg" },
                new Word { WordID = -5, EngWordName = "car", TurWordName = "araba", Picture = "C:/words/car.jpg" },
                new Word { WordID = -6, EngWordName = "house", TurWordName = "ev", Picture = "C:/words/house.jpg" },
                new Word { WordID = -7, EngWordName = "tree", TurWordName = "ağaç", Picture = "C:/words/tree.jpg" },
                new Word { WordID = -8, EngWordName = "water", TurWordName = "su", Picture = "C:/words/water.jpg" },
                new Word { WordID = -9, EngWordName = "sun", TurWordName = "güneş", Picture = "C:/words/sun.jpg" },
                new Word { WordID = -10, EngWordName = "moon", TurWordName = "ay", Picture = "C:/words/moon.jpg" },
                new Word { WordID = -11, EngWordName = "star", TurWordName = "yıldız", Picture = "C:/words/star.jpg" },
                new Word { WordID = -12, EngWordName = "phone", TurWordName = "telefon", Picture = "C:/words/phone.jpg" },
                new Word { WordID = -13, EngWordName = "computer", TurWordName = "bilgisayar", Picture = "C:/words/computer.jpg" },
                new Word { WordID = -14, EngWordName = "table", TurWordName = "masa", Picture = "C:/words/table.jpg" },
                new Word { WordID = -15, EngWordName = "chair", TurWordName = "sandalye", Picture = "C:/words/chair.jpg" },
                new Word { WordID = -16, EngWordName = "window", TurWordName = "pencere", Picture = "C:/words/window.jpg" },
                new Word { WordID = -17, EngWordName = "door", TurWordName = "kapı", Picture = "C:/words/door.jpg" },
                new Word { WordID = -18, EngWordName = "pen", TurWordName = "kalem", Picture = "C:/words/pen.jpg" },
                new Word { WordID = -19, EngWordName = "pencil", TurWordName = "kurşun kalem", Picture = "C:/words/pencil.jpg" },
                new Word { WordID = -20, EngWordName = "notebook", TurWordName = "defter", Picture = "C:/words/notebook.jpg" }
            );
        }
    }
}