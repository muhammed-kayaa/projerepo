using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WordApp.Data;
using WordApp.Models;

namespace WordApp.Forms
{
    public class QuizForm : Form
    {
        private List<Word> quizWords;
        private int currentIndex = 0;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnNext;
        private int correctCount = 0;
        private User currentUser;
        private DateTime today;
        private int dailyLimit = 10;
        private List<int> quizWordIdsToday;
        private int quizDay = 0;
        private PictureBox pictureBox;

        public QuizForm(User user)
        {
            currentUser = user;
            today = DateTime.Today;
            quizDay = (int)(today - new DateTime(2024, 2, 8)).TotalDays; // örnek tarih başlangıcı
            this.Text = "Sınav Modülü";
            this.Size = new System.Drawing.Size(500, 450);
            lblQuestion = new Label { Top = 30, Left = 40, Width = 400, Height = 40 };
            pictureBox = new PictureBox { Top = 80, Left = 40, Width = 200, Height = 200, SizeMode = PictureBoxSizeMode.StretchImage };
            txtAnswer = new TextBox { Top = 300, Left = 40, Width = 300 };
            btnNext = new Button { Text = "Sonraki", Top = 350, Left = 40, Width = 100 };
            btnNext.Click += BtnNext_Click;
            this.Controls.Add(lblQuestion);
            this.Controls.Add(pictureBox);
            this.Controls.Add(txtAnswer);
            this.Controls.Add(btnNext);
            LoadQuizWords();
            ShowQuestion();
        }

        private async void LoadQuizWords()
        {
            using (var db = new AppDbContext())
            {
                var baseQuery = db.Words.Where(w => w.UserId == null || w.UserId == currentUser.UserId);
                if (quizDay == 0)
                {
                    quizWords = await baseQuery.OrderBy(w => w.WordID).Take(dailyLimit).ToListAsync();
                }
                else
                {
                    var knownQuery = baseQuery.Where(w => w.IsKnown);
                    var lastDay = today.AddDays(-1);
                    var lastDayKnownIds = await knownQuery.Where(w => w.LastCorrectDate == lastDay).Select(w => w.WordID).ToListAsync();
                    var exclude = new HashSet<int>(lastDayKnownIds);
                    quizWords = await baseQuery.Where(w => !exclude.Contains(w.WordID) && !w.IsKnown)
                        .OrderBy(_ => Guid.NewGuid()).Take(dailyLimit).ToListAsync();
                    var lastDayWords = await baseQuery.Where(w => lastDayKnownIds.Contains(w.WordID)).ToListAsync();
                    quizWords.AddRange(lastDayWords);
                    quizWords = quizWords.Take(dailyLimit).ToList();
                }
                quizWordIdsToday = quizWords.Select(w => w.WordID).ToList();
            }
            // Eğer hiç kelime yoksa kullanıcıya uyarı ver ve formu kapat
            if (quizWords == null || quizWords.Count == 0)
            {
                MessageBox.Show("Sınav için yeterli kelime yok! Lütfen önce kelime ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if (quizWords == null || quizWords.Count == 0 || currentIndex >= quizWords.Count)
                return;
            var word = quizWords[currentIndex];
            lblQuestion.Text = $"{word.EngWordName} kelimesinin Türkçesi nedir?";
            txtAnswer.Text = "";
            // Resim dosyası varsa göster, yoksa AI ile üret
            if (!string.IsNullOrWhiteSpace(word.Picture) && System.IO.File.Exists(word.Picture))
            {
                pictureBox.Image = System.Drawing.Image.FromFile(word.Picture);
            }
            else
            {
                // Basit AI: Kelimeye göre bir görsel oluştur (örnek: harflerden renkli bir resim)
                var bmp = new System.Drawing.Bitmap(120, 120);
                using (var g = System.Drawing.Graphics.FromImage(bmp))
                {
                    g.Clear(System.Drawing.Color.White);
                    var font = new System.Drawing.Font("Segoe UI", 32, System.Drawing.FontStyle.Bold);
                    var brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(word.EngWordName[0] * 2 % 255, word.EngWordName.Length * 30 % 255, 180));
                    g.DrawString(word.EngWordName.Substring(0, 1).ToUpper(), font, brush, 30, 30);
                }
                pictureBox.Image = bmp;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex >= quizWords.Count) return;
            var word = quizWords[currentIndex];
            string userAnswer = txtAnswer.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(userAnswer))
            {
                MessageBox.Show("Cevap boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (userAnswer == word.TurWordName.ToLower())
            {
                correctCount++;
                word.CorrectStreak++;
                if (word.CorrectStreak >= 6) word.IsKnown = true;
                word.LastCorrectDate = DateTime.Now;
                word.UserId = currentUser.UserId;
            }
            else
            {
                word.CorrectStreak = 0;
                word.IsKnown = false;
                word.UserId = currentUser.UserId;
            }
            using (var db = new AppDbContext())
            {
                var dbWord = db.Words.FirstOrDefault(w => w.WordID == word.WordID);
                if (dbWord != null)
                {
                    dbWord.CorrectStreak = word.CorrectStreak;
                    dbWord.IsKnown = word.IsKnown;
                    dbWord.LastCorrectDate = word.LastCorrectDate;
                    dbWord.UserId = word.UserId;
                    db.SaveChanges();
                }
            }
            currentIndex++;
            if (currentIndex < quizWords.Count)
                ShowQuestion();
            else
            {
                MessageBox.Show($"Sınav bitti! Doğru sayısı: {correctCount}/{quizWords.Count}", "Sınav Sonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
