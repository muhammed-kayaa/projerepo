WordApp
├── src
│   ├── Models
│   │   ├── User.cs
│   │   ├── Word.cs
│   │   ├── WordSample.cs
│   │   └── WordCorrectDate.cs
│   ├── Data
│   │   └── AppDbContext.cs
│   ├── Forms
│   │   ├── LoginForm.cs
│   │   ├── RegisterForm.cs
│   │   ├── MainForm.cs
│   │   ├── WordForm.cs
│   │   ├── QuizForm.cs
│   │   ├── AnalysisForm.cs
│   │   ├── WordleForm.cs
│   │   └── WordChainForm.cs
│   ├── Services
│   │   └── UserService.cs
│   ├── Program.cs
├── WordApp.csproj
├── README.md
└── WordApp_sample_data.sql

1. Kullanıcı Yönetimi
Kullanıcılar kayıt olabilir, giriş yapabilir ve şifrelerini yenileyebilir.
Kullanıcı bilgileri veritabanında saklanır.
2. Kelime Yönetimi
İngilizce kelimeler ve Türkçe karşılıkları eklenebilir.
Kelimelere resim ve örnek cümleler eklenebilir.
3. Sınav Modülü
Kullanıcılar, belirlenen algoritmaya göre kelime sınavlarına katılabilir.
6 kez doğru cevaplanan kelimeler "bilinen kelimeler" havuzuna taşınır.
4. Ayarlar Modülü
Kullanıcılar günlük sınavda çıkan kelime sayısını değiştirebilir.
5. Analiz Raporu
Kullanıcılar, başarı oranlarını ve çözdükleri kelimeleri analiz edebilir.
Genel başarı oranı ve kullanıcıya özel başarı oranı görüntülenebilir.
Analiz raporu, yazıcıdan kağıt çıktısı olarak alınabilir.
7. Oyun Modülleri
Wordle (Bulmaca): Kullanıcılar, verilen ipuçlarına göre kelime tahmin eder.
Word Chain (Kelime Zinciri): Kullanıcılar, son harfe göre yeni kelimeler ekleyerek zincir oluşturur.
