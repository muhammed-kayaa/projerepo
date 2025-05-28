using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WordApp.Data;
using WordApp.Models;

namespace WordApp.Forms
{
    public class WordleForm : Form
    {
        private List<Word> words;
        private string answer;
        private int attempts = 0;
        private TextBox txtGuess;
        private Button btnCheck;
        private Label lblResult;
        private FlowLayoutPanel panelGuesses;
        private int maxAttempts = 6;
        private List<string> guessHistory = new List<string>();

        public WordleForm()
        {
            this.Text = "Wordle (Bulmaca)";
            this.Size = new System.Drawing.Size(420, 500);
            Word selectedWord = null;
            using (var db = new AppDbContext())
            {
                // Uygun uzunlukta kelimelerden rastgele birini doğrudan veritabanından seç
                var query = db.Words.Where(w => w.EngWordName.Length >= 4 && w.EngWordName.Length <= 7);
                int count = query.Count();
                if (count == 0)
                {
                    MessageBox.Show("Bulmaca için uygun uzunlukta kelime yok! Lütfen önce kelime ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                var rnd = new Random();
                int skip = rnd.Next(count);
                selectedWord = query.Skip(skip).FirstOrDefault();
            }
            answer = selectedWord.EngWordName.ToUpper();
            txtGuess = new TextBox { Top = 30, Left = 30, Width = 200, MaxLength = answer.Length };
            btnCheck = new Button { Text = "Tahmin Et", Top = 70, Left = 30, Width = 100 };
            btnCheck.Click += BtnCheck_Click;
            lblResult = new Label { Top = 120, Left = 30, Width = 350, Height = 40, Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold) };
            panelGuesses = new FlowLayoutPanel { Top = 170, Left = 30, Width = 340, Height = 220, AutoScroll = true };
            var btnAI = new Button { Text = "Yapay Zeka İpucu", Top = 70, Left = 150, Width = 120 };
            btnAI.Click += (s, e) => {
                string hint = $"Kelime {answer.Length} harfli ve '{answer[0]}' harfiyle başlıyor.";
                MessageBox.Show($"AI İpucu: {hint}", "Yapay Zeka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            this.Controls.Add(txtGuess);
            this.Controls.Add(btnCheck);
            this.Controls.Add(btnAI);
            this.Controls.Add(lblResult);
            this.Controls.Add(panelGuesses);
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (attempts >= maxAttempts) return;
            string guess = txtGuess.Text.Trim().ToUpper();
            if (guess.Length != answer.Length)
            {
                lblResult.Text = $"Kelime {answer.Length} harfli olmalı!";
                return;
            }
            if (!words.Any(w => w.EngWordName.ToUpper() == guess))
            {
                lblResult.Text = "Bu kelime veritabanında yok!";
                return;
            }
            attempts++;
            guessHistory.Add(guess);
            DrawGuess(guess);
            if (guess == answer)
            {
                lblResult.Text = $"Tebrikler! {attempts}. denemede buldunuz.";
                txtGuess.Enabled = false;
                btnCheck.Enabled = false;
            }
            else if (attempts == maxAttempts)
            {
                lblResult.Text = $"Bilemediniz! Doğru cevap: {answer}";
                txtGuess.Enabled = false;
                btnCheck.Enabled = false;
            }
            else
            {
                lblResult.Text = $"Yanlış! Kalan hakkınız: {maxAttempts - attempts}";
            }
        }
        private void DrawGuess(string guess)
        {
            var panel = new FlowLayoutPanel { FlowDirection = FlowDirection.LeftToRight, Width = 40 * guess.Length, Height = 40 };
            for (int i = 0; i < guess.Length; i++)
            {
                var lbl = new Label { Text = guess[i].ToString(), Width = 35, Height = 35, TextAlign = System.Drawing.ContentAlignment.MiddleCenter, BorderStyle = BorderStyle.FixedSingle, Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold) };
                if (guess[i] == answer[i])
                    lbl.BackColor = System.Drawing.Color.LightGreen;
                else if (answer.Contains(guess[i]))
                    lbl.BackColor = System.Drawing.Color.Khaki;
                else
                    lbl.BackColor = System.Drawing.Color.LightGray;
                panel.Controls.Add(lbl);
            }
            panelGuesses.Controls.Add(panel);
        }
    }
}
