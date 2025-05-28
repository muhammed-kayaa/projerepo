using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WordApp.Data;
using WordApp.Models;
using WordApp.Services;

namespace WordApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm(loginForm.LoggedInUser));
                }
            }
        }
    }

    // Giriş Formu
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnForgotPassword;
        private Label lblError;
        private ListBox lstUsers;
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            this.Text = "Giriş Yap";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(420, 350);
            // Modern ve düzenli giriş ekranı tasarımı
            this.BackColor = System.Drawing.Color.White;
            var panel = new Panel {
                Left = 20, Top = 20, Width = 360, Height = 290,
                BackColor = System.Drawing.Color.FromArgb(220, 60, 40)
            };
            this.Controls.Add(panel);

            var lblTitle = new Label {
                Text = "Hoşgeldin, giriş yap",
                Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold),
                AutoSize = false,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Top = 15, Left = 0, Width = 360, Height = 40,
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent
            };
            panel.Controls.Add(lblTitle);

            var lblUsername = new Label { Text = "Kullanıcı Adı:", Left = 30, Top = 90, Width = 80, ForeColor = System.Drawing.Color.White, BackColor = System.Drawing.Color.Transparent };
            txtUsername = new TextBox { Left = 110, Top = 85, Width = 210 };
            panel.Controls.Add(lblUsername);
            panel.Controls.Add(txtUsername);

            var lblPassword = new Label { Text = "Şifreniz:", Left = 30, Top = 130, Width = 80, ForeColor = System.Drawing.Color.White, BackColor = System.Drawing.Color.Transparent };
            txtPassword = new TextBox { Left = 110, Top = 125, Width = 210, PasswordChar = '●' };
            panel.Controls.Add(lblPassword);
            panel.Controls.Add(txtPassword);

            var chkRemember = new CheckBox { Text = "Beni hatırla", Left = 30, Top = 165, Width = 100, ForeColor = System.Drawing.Color.White, BackColor = System.Drawing.Color.Transparent };
            panel.Controls.Add(chkRemember);

            btnForgotPassword = new Button {
                Text = "Şifremi unuttum?",
                Left = 200, Top = 160, Width = 120, Height = 25,
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.FromArgb(220, 60, 40),
                FlatStyle = FlatStyle.Flat
            };
            btnForgotPassword.Click += BtnForgotPassword_Click;
            panel.Controls.Add(btnForgotPassword);

            btnLogin = new Button {
                Text = "GİRİŞ",
                Left = 30, Top = 200, Width = 290, Height = 40,
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.FromArgb(220, 60, 40),
                Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnLogin.Click += BtnLogin_Click;
            panel.Controls.Add(btnLogin);

            btnRegister = new Button {
                Text = "Kayıt Ol",
                Left = 30, Top = 250, Width = 290, Height = 30,
                BackColor = System.Drawing.Color.LightGray,
                ForeColor = System.Drawing.Color.FromArgb(220, 60, 40),
                FlatStyle = FlatStyle.Flat
            };
            btnRegister.Click += BtnRegister_Click;
            panel.Controls.Add(btnRegister);

            lblError = new Label {
                ForeColor = System.Drawing.Color.Yellow,
                Left = 30, Top = 235, Width = 290, Height = 20,
                Visible = false,
                BackColor = System.Drawing.Color.Transparent
            };
            panel.Controls.Add(lblError);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Giriş yapma işlemleri
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    LoggedInUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblError.Text = "Kullanıcı adı veya şifre hatalı.";
                    lblError.Visible = true;
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm())
            {
                registerForm.ShowDialog();
            }
        }

        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı girin.");
                return;
            }
            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
                else
                {
                    string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Yeni şifrenizi girin:", "Şifre Yenile");
                    if (!string.IsNullOrWhiteSpace(newPassword))
                    {
                        user.Password = newPassword;
                        db.SaveChanges();
                        MessageBox.Show("Şifreniz başarıyla güncellendi.");
                    }
                }
            }
        }
    }

    // Ana Form
    public class MainForm : Form
    {
        private User currentUser;
        private Label lblWelcome;
        private Button btnSettings;
        private Button btnAddWord;
        private Button btnQuiz;
        private Button btnAnalysis;
        private Button btnWordle;
        private Button btnWordChain;
        private Button btnStartGame;
        private Label lblCommand;
        private int wordCountLimit = 10;

        public MainForm(User user)
        {
            currentUser = user;
            this.Text = "WordApp Ana Ekran";
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 255);

            lblCommand = new Label
            {
                Text = "Hoşgeldiniz! Komutlar ve duyurular burada gösterilecek.",
                Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold),
                AutoSize = false,
                Width = 800,
                Height = 30,
                Top = 0,
                Left = 30,
                ForeColor = System.Drawing.Color.DarkBlue,
                BackColor = System.Drawing.Color.FromArgb(230, 230, 255),
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            };
            this.Controls.Add(lblCommand);

            lblWelcome = new Label
            {
                Text = $"Hoşgeldin, {currentUser.Username}!",
                Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Top = 30,
                Left = 30
            };
            this.Controls.Add(lblWelcome);

            btnSettings = new Button
            {
                Text = "Ayarlar",
                Left = 30,
                Top = 80,
                Width = 120,
                Height = 40,
                BackColor = System.Drawing.Color.FromArgb(0, 120, 215),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSettings.Click += BtnSettings_Click;
            this.Controls.Add(btnSettings);

            btnAddWord = new Button
            {
                Text = "Kelime Ekle",
                Left = 170,
                Top = 80,
                Width = 120,
                Height = 40,
                BackColor = System.Drawing.Color.FromArgb(0, 180, 100),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnAddWord.Click += BtnAddWord_Click;
            this.Controls.Add(btnAddWord);

            btnQuiz = new Button
            {
                Text = "Oyuna Başla", // Değiştirildi
                Left = 310,
                Top = 80,
                Width = 120,
                Height = 40,
                BackColor = System.Drawing.Color.FromArgb(200, 120, 0),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnQuiz.Click += BtnQuiz_Click;
            this.Controls.Add(btnQuiz);

            btnAnalysis = new Button
            {
                Text = "Analiz Raporu",
                Left = 450,
                Top = 80,
                Width = 120,
                Height = 40,
                BackColor = System.Drawing.Color.FromArgb(120, 0, 200),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnAnalysis.Click += BtnAnalysis_Click;
            this.Controls.Add(btnAnalysis);

            btnWordle = new Button
            {
                Text = "Wordle (Bulmaca)",
                Left = 590,
                Top = 80,
                Width = 120,
                Height = 40,
                BackColor = System.Drawing.Color.FromArgb(0, 180, 180),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnWordle.Click += BtnWordle_Click;
            this.Controls.Add(btnWordle);

            btnWordChain = new Button
            {
                Text = "Word Chain",
                Left = 730,
                Top = 80,
                Width = 120,
                Height = 40,
                BackColor = System.Drawing.Color.FromArgb(180, 180, 0),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnWordChain.Click += BtnWordChain_Click;
            this.Controls.Add(btnWordChain);

            btnStartGame = new Button
            {
                Text = "Sınavı Başlat", // Değiştirildi
                Left = 30,
                Top = 130,
                Width = 200,
                Height = 60,
                Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold),
                BackColor = System.Drawing.Color.FromArgb(0, 180, 100),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnStartGame.Click += BtnQuiz_Click; // Artık kelime sınavı başlatacak
            this.Controls.Add(btnStartGame);
            // Ayarlar butonunu öne çıkar
            btnSettings.Top = 210;
            btnSettings.Left = 30;
            btnSettings.Width = 200;
            btnSettings.Height = 50;
            btnSettings.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);

            this.FormClosed += (s, e) => Application.Exit();

            // Buraya ana ekran için ek tasarım ve kontroller ekleyebilirsiniz
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new WordApp.Forms.SettingsForm(wordCountLimit);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                wordCountLimit = settingsForm.GetWordCount();
                MessageBox.Show($"Yeni kelime sınırı: {wordCountLimit}");
            }
        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            var wordForm = new WordApp.Forms.WordForm();
            wordForm.ShowDialog();
        }

        private void BtnQuiz_Click(object sender, EventArgs e)
        {
            var quizForm = new WordApp.Forms.QuizForm(currentUser);
            quizForm.ShowDialog();
        }

        private void BtnAnalysis_Click(object sender, EventArgs e)
        {
            var analysisForm = new WordApp.Forms.AnalysisForm(currentUser);
            analysisForm.ShowDialog();
        }

        private void BtnWordle_Click(object sender, EventArgs e)
        {
            var wordleForm = new WordApp.Forms.WordleForm();
            wordleForm.ShowDialog();
        }

        private void BtnWordChain_Click(object sender, EventArgs e)
        {
            var wordChainForm = new WordApp.Forms.WordChainForm();
            wordChainForm.ShowDialog();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            var wordleForm = new WordApp.Forms.WordleForm();
            wordleForm.ShowDialog();
        }

        // Komut/duyuru güncelleme fonksiyonu
        public void SetCommand(string message)
        {
            if (lblCommand != null)
                lblCommand.Text = message;
        }
    }

    // Ayarlar Formu (örnek)
    public class FormSettings : Form
    {
        public FormSettings()
        {
            this.Text = "Ayarlar";
            this.Size = new System.Drawing.Size(300, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;

            var lblInfo = new Label
            {
                Text = "Ayarlar burada olacak.",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblInfo);
        }
    }
}

