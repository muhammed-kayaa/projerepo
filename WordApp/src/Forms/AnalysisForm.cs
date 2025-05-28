using System;
using System.Linq;
using WordApp.Data;
using WordApp.Models;
using System.Windows.Forms;

namespace WordApp.Forms
{
    public class AnalysisForm : Form
    {
        private Label lbl;
        private Button btnRefresh;
        public AnalysisForm(User user)
        {
            this.Text = "Analiz Raporu";
            this.Size = new System.Drawing.Size(400, 350);
            lbl = new Label {
                Top = 30, Left = 30, Width = 340, Height = 120
            };
            btnRefresh = new Button { Text = "Yenile", Top = 170, Left = 200, Width = 100 };
            btnRefresh.Click += (s, e) => UpdateReport(user);
            var btnAI = new Button { Text = "Yapay Zeka Analizi", Top = 170, Left = 30, Width = 150 };
            btnAI.Click += (s, e) => {
                double userPercent = GetUserPercent(user);
                string msg = userPercent < 50 ? "Daha çok tekrar yapmalısınız!" : "Harika gidiyorsunuz!";
                MessageBox.Show($"AI Analiz: {msg}", "Yapay Zeka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            this.Controls.Add(lbl);
            this.Controls.Add(btnAI);
            this.Controls.Add(btnRefresh);
            UpdateReport(user);
        }

        private void UpdateReport(User user)
        {
            int totalWords = 0;
            int solvedWords = 0;
            int userTotal = 0;
            int userSolved = 0;
            using (var db = new AppDbContext())
            {
                // Sadece kullanıcıya ait kelimeler
                userTotal = db.Words.Count(w => w.UserId == user.UserId);
                userSolved = db.Words.Count(w => w.UserId == user.UserId && w.CorrectStreak > 0);
                // Genel başarı için tüm kullanıcıların çözdüğü kelime oranı
                totalWords = db.Words.Count();
                solvedWords = db.Words.Count(w => w.CorrectStreak > 0);
            }
            double percent = totalWords == 0 ? 0 : (solvedWords * 100.0 / totalWords);
            double userPercent = userTotal == 0 ? 0 : (userSolved * 100.0 / userTotal);
            lbl.Text = $"Tüm kelimeler: {totalWords}\nTüm kullanıcılar için başarı: %{percent:F1}\n\nSizin toplam kelimeniz: {userTotal}\nSizin başarı oranınız: %{userPercent:F1}";
        }

        private double GetUserPercent(User user)
        {
            int userTotal = 0;
            int userSolved = 0;
            using (var db = new AppDbContext())
            {
                userTotal = db.Words.Count(w => w.UserId == user.UserId);
                userSolved = db.Words.Count(w => w.UserId == user.UserId && w.CorrectStreak > 0);
            }
            return userTotal == 0 ? 0 : (userSolved * 100.0 / userTotal);
        }
    }
}
