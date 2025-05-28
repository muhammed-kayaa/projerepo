-- WordApp örnek veri scripti
-- Kullanıcı ekle
INSERT INTO [Users] (Username, Password) VALUES ('testuser', '1234');

-- Kelimeler (örnek)
INSERT INTO [Words] (EngWordName, TurWordName, Picture, UserId) VALUES ('apple', 'elma', 'words/apple.jpg', (SELECT TOP 1 UserId FROM [Users] WHERE Username='testuser'));
INSERT INTO [Words] (EngWordName, TurWordName, Picture, UserId) VALUES ('book', 'kitap', 'words/book.jpg', (SELECT TOP 1 UserId FROM [Users] WHERE Username='testuser'));
INSERT INTO [Words] (EngWordName, TurWordName, Picture, UserId) VALUES ('cat', 'kedi', 'words/cat.jpg', (SELECT TOP 1 UserId FROM [Users] WHERE Username='testuser'));

-- Örnek cümleler (isteğe bağlı)
INSERT INTO [WordSamples] (WordID, Samples) VALUES ((SELECT TOP 1 WordID FROM [Words] WHERE EngWordName='apple'), 'This is an apple.');
INSERT INTO [WordSamples] (WordID, Samples) VALUES ((SELECT TOP 1 WordID FROM [Words] WHERE EngWordName='book'), 'I read a book.');
INSERT INTO [WordSamples] (WordID, Samples) VALUES ((SELECT TOP 1 WordID FROM [Words] WHERE EngWordName='cat'), 'The cat is sleeping.');
