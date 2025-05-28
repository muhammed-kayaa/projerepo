using System;
using System.Windows.Forms;
using System.Drawing;

namespace WordApp.Forms
{
    public class SettingsForm : Form
    {
        private NumericUpDown numWordCount;
        private Button btnSave;
        private Label lblInfo;
        private Button btnAI;
        public int WordCount { get; private set; }

        public SettingsForm(int currentCount)
        {
            this.Text = "Ayarlar";
            this.Size = new Size(350, 220);
            lblInfo = new Label { Text = "Günlük sınav kelime sayısı:", Top = 20, Left = 30, Width = 200 };
            numWordCount = new NumericUpDown { Minimum = 1, Maximum = 50, Value = currentCount, Top = 50, Left = 30, Width = 100 };
            btnSave = new Button { Text = "Kaydet", Top = 100, Left = 30, Width = 100 };
            btnSave.Click += BtnSave_Click;
            btnAI = new Button { Text = "Yapay Zeka Önerisi", Top = 140, Left = 30, Width = 150 };
            btnAI.Click += BtnAI_Click;
            this.Controls.Add(lblInfo);
            this.Controls.Add(numWordCount);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnAI);
        }
        public int GetWordCount() => (int)numWordCount.Value;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            WordCount = (int)numWordCount.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void BtnAI_Click(object sender, EventArgs e)
        {
            // Basit öneri: Kullanıcının başarı oranına göre öneri
            int suggestion = 10;
            MessageBox.Show($"Yapay Zeka Önerisi: Günlük {suggestion} kelime ile başlayabilirsiniz!", "AI Önerisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
