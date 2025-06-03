using System;
using System.Drawing;
using System.Drawing.Printing;
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
        private Button btnPrint;
        private string reportContent;

        public AnalysisForm(User user)
        {
            this.Text = "Analiz Raporu";
            this.Size = new System.Drawing.Size(400, 400);

            lbl = new Label
            {
                Top = 30,
                Left = 30,
                Width = 340,
                Height = 120
            };

            btnRefresh = new Button { Text = "Yenile", Top = 170, Left = 200, Width = 100 };
            btnRefresh.Click += (s, e) => UpdateReport(user);

            btnPrint = new Button { Text = "Yazdır", Top = 220, Left = 30, Width = 150 };
            btnPrint.Click += (s, e) => PrintReport();

            this.Controls.Add(lbl);
            this.Controls.Add(btnRefresh);
            this.Controls.Add(btnPrint);

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

            reportContent = $"Tüm kelimeler: {totalWords}\n" +
                            $"Tüm kullanıcılar için başarı: %{percent:F1}\n\n" +
                            $"Sizin toplam kelimeniz: {userTotal}\n" +
                            $"Sizin başarı oranınız: %{userPercent:F1}";

            lbl.Text = reportContent;
        }

        private void PrintReport()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
                reportContent,
                new Font("Arial", 12),
                Brushes.Black,
                new RectangleF(50, 50, e.PageBounds.Width - 100, e.PageBounds.Height - 100)
            );
        }
    }
}
