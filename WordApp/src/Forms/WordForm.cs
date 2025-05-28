using System;
using System.Windows.Forms;
using WordApp.Models;
using WordApp.Data;
using System.Linq;

namespace WordApp.Forms
{
    public class WordForm : Form
    {
        private TextBox txtEng;
        private TextBox txtTur;
        private TextBox txtPicture;
        private Button btnSave;

        public WordForm()
        {
            this.Text = "Kelime Ekle";
            this.Size = new System.Drawing.Size(400, 300);
            txtEng = new TextBox { PlaceholderText = "İngilizce Kelime", Top = 30, Left = 30, Width = 300 };
            txtTur = new TextBox { PlaceholderText = "Türkçe Karşılığı", Top = 70, Left = 30, Width = 300 };
            txtPicture = new TextBox { PlaceholderText = "Resim Yolu (opsiyonel)", Top = 110, Left = 30, Width = 300 };
            txtPicture.Text = "C:\\words\\";
            this.Controls.Add(txtPicture);
            btnSave = new Button { Text = "Kaydet", Top = 160, Left = 30, Width = 100 };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(txtEng);
            this.Controls.Add(txtTur);
            this.Controls.Add(txtPicture);
            this.Controls.Add(btnSave);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEng.Text) || string.IsNullOrWhiteSpace(txtTur.Text))
            {
                MessageBox.Show("İngilizce ve Türkçe alanları zorunludur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Resim yolu boşsa veya sadece klasörse, otomatik olarak words klasörüne dosya adını ekle
            string picturePath = txtPicture.Text.Trim();
            if (string.IsNullOrWhiteSpace(picturePath) || picturePath == @"C:\\words\\")
            {
                picturePath = $"words\\{txtEng.Text.Trim().ToLower()}.jpg";
            }
            else if (!picturePath.StartsWith("words") && !picturePath.StartsWith(@"C:\\") && !picturePath.Contains(":\\"))
            {
                // Kullanıcı sadece dosya adı girdiyse, words klasörüne ekle
                picturePath = $"words\\{picturePath}";
            }
            using (var db = new AppDbContext())
            {
                if (db.Words.Any(w => w.EngWordName == txtEng.Text.Trim()))
                {
                    MessageBox.Show("Bu İngilizce kelime zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var word = new Word
                {
                    EngWordName = txtEng.Text.Trim(),
                    TurWordName = txtTur.Text.Trim(),
                    Picture = picturePath
                };
                db.Words.Add(word);
                db.SaveChanges();
                MessageBox.Show("Kelime kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
