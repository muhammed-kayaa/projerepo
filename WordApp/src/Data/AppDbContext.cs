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
                .HasForeignKey(ws => ws.WordID);            // Seed kelime kaldırıldı, sadece uygulama üzerinden eklenenler olacak
            // modelBuilder.Entity<Word>().HasData();
        }
    }
}