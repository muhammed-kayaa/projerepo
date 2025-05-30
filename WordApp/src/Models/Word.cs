using System;
using System.Collections.Generic;

namespace WordApp.Models
{
    public class Word
    {
        public int WordID { get; set; }
        public string EngWordName { get; set; }
        public string TurWordName { get; set; }
        public string Picture { get; set; }
        public ICollection<WordSample> WordSamples { get; set; }

        // Sınav algoritması için gerekli alanlar
        public int RepeatCount { get; set; } // Kaç kez sınava girdi
        public int CorrectStreak { get; set; } // Üst üste doğru sayısı
        public DateTime? LastCorrectDate { get; set; } // Son doğru cevap tarihi
        public bool IsKnown { get; set; } // 6 kez doğruysa bilinen havuzda
        public int? UserId { get; set; } // Kullanıcıya özel istatistik için
        public string CorrectDatesJson { get; set; } // Doğru cevap tarihleri (JSON)

        // Parametresiz constructor
        public Word() { }

        // Parametreli constructor (isteğe bağlı)
        public Word(int wordId, string engWordName, string turWordName, string picture)
        {
            WordID = wordId;
            EngWordName = engWordName;
            TurWordName = turWordName;
            Picture = picture;
        }
    }
}