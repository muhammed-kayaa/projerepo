using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WordApp.Forms
{
    public class WordleForm : Form
    {
        private string targetWord = "PLANET";
        private int currentRow = 0;
        private const int maxRows = 5; // 5 attempts
        private const int wordLength = 6;
        private TextBox inputBox;
        private Button submitButton;
        private Panel gridPanel;
        private Label revealedLettersLabel;
        private bool[] revealedIndexes = new bool[wordLength];
        private Random random = new Random();

        public WordleForm()
        {
            this.Text = "Wordle";
            this.Size = new Size(60 * wordLength + 60, 60 * maxRows + 180);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            gridPanel = new Panel
            {
                Left = 20,
                Top = 50,
                Width = 60 * wordLength,
                Height = 60 * maxRows,
                BackColor = Color.White
            };
            this.Controls.Add(gridPanel);

            revealedLettersLabel = new Label
            {
                Left = 20,
                Top = 10,
                Width = 60 * wordLength + 80,
                Height = 30,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Text = "Revealed: " + GetRevealedLetters()
            };
            this.Controls.Add(revealedLettersLabel);

            inputBox = new TextBox
            {
                Left = 20,
                Top = gridPanel.Bottom + 10,
                Width = 60 * wordLength
            };
            this.Controls.Add(inputBox);

            submitButton = new Button
            {
                Text = "Guess",
                Left = inputBox.Right + 10,
                Top = inputBox.Top,
                Width = 80
            };
            submitButton.Click += SubmitButton_Click;
            this.Controls.Add(submitButton);
        }

        private string GetRevealedLetters()
        {
            char[] display = new char[wordLength];
            for (int i = 0; i < wordLength; i++)
            {
                display[i] = revealedIndexes[i] ? targetWord[i] : '_';
            }
            return string.Join(" ", display);
        }

        private void RevealRandomLetter()
        {
            var hiddenIndexes = Enumerable.Range(0, wordLength).Where(i => !revealedIndexes[i]).ToList();
            if (hiddenIndexes.Count > 0)
            {
                int idx = hiddenIndexes[random.Next(hiddenIndexes.Count)];
                revealedIndexes[idx] = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string guess = inputBox.Text.Trim().ToUpper();
            if (guess.Length != wordLength)
            {
                MessageBox.Show($"Word must be {wordLength} letters.");
                return;
            }

            if (currentRow >= maxRows)
            {
                MessageBox.Show("No more attempts left!");
                return;
            }

            for (int i = 0; i < wordLength; i++)
            {
                Label lbl = new Label
                {
                    Width = 55,
                    Height = 55,
                    Left = i * 60,
                    Top = currentRow * 60,
                    Text = guess[i].ToString(),
                    Font = new Font("Segoe UI", 24, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.FixedSingle
                };

                if (guess[i] == targetWord[i])
                {
                    lbl.BackColor = Color.Green;
                    lbl.ForeColor = Color.White;
                }
                else if (targetWord.Contains(guess[i]))
                {
                    lbl.BackColor = Color.Gold;
                    lbl.ForeColor = Color.Black;
                }
                else
                {
                    lbl.BackColor = Color.LightGray;
                    lbl.ForeColor = Color.Black;
                }

                gridPanel.Controls.Add(lbl);
            }

            if (guess == targetWord)
            {
                MessageBox.Show("Congratulations, you guessed it!");
                this.Close();
                return;
            }

            // Reveal a random letter after a wrong guess
            RevealRandomLetter();
            revealedLettersLabel.Text = "Revealed: " + GetRevealedLetters();

            currentRow++;
            inputBox.Text = "";

            if (currentRow == maxRows)
            {
                MessageBox.Show($"You didn't guess it! The correct word was: {targetWord}");
                this.Close();
            }
        }
    }
}
