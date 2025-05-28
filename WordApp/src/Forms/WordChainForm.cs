using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WordApp.Forms
{
    public class WordChainForm : Form
    {
        public WordChainForm()
        {
            this.Text = "Word Chain (Kelime Zinciri)";
            this.Size = new System.Drawing.Size(500, 400);
            var lblTitle = new Label { Text = "Word Chain: Son harften yeni kelime bul!", Top = 20, Left = 20, Width = 450, Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold) };
            var txtInput = new TextBox { Top = 60, Left = 20, Width = 200 };
            var btnAdd = new Button { Text = "Ekle", Top = 60, Left = 230, Width = 80 };
            var lblChain = new Label { Text = "Zincir: ", Top = 100, Left = 20, Width = 450, Height = 80, Font = new System.Drawing.Font("Segoe UI", 10) };
            var lblInfo = new Label { Text = "Her yeni kelime, zincirdeki son kelimenin son harfiyle başlamalı.", Top = 200, Left = 20, Width = 450, Height = 40, Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Italic) };
            var btnAI = new Button { Text = "Yapay Zeka Önerisi", Top = 250, Left = 20, Width = 150 };
            var chain = new List<string>();
            btnAdd.Click += (s, e) => {
                var word = txtInput.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(word)) return;
                if (chain.Count > 0 && word[0] != chain.Last()[chain.Last().Length - 1])
                {
                    MessageBox.Show($"Kelime '{chain.Last()}' kelimesinin son harfi ile başlamalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                chain.Add(word);
                lblChain.Text = "Zincir: " + string.Join(" → ", chain);
                txtInput.Clear();
            };
            btnAI.Click += (s, e) => {
                if (chain.Count == 0)
                {
                    MessageBox.Show("Başlamak için bir kelime girin!", "AI Önerisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                char last = chain.Last()[chain.Last().Length - 1];
                MessageBox.Show($"Yapay Zeka: '{last}' harfiyle başlayan bir kelime girin!", "AI Önerisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtInput);
            this.Controls.Add(btnAdd);
            this.Controls.Add(lblChain);
            this.Controls.Add(lblInfo);
            this.Controls.Add(btnAI);
        }
    }
}
