INSERT INTO sepet (tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyat, tarih)
VALUES ('12345678901', 'Ahmet Yılmaz', '555-1234567', 'ABC123', 'Ürün A', 3, 25.99, 77.97, '2023-12-16 12:34:56'),
       ('98765432109', 'Ayşe Demir', '555-7654321', 'XYZ789', 'Ürün B', 2, 15.5, 31, '2023-12-16 13:45:00');


CREATE TABLE sepet (
    
    tc VARCHAR(20) PRIMARY KEY,
    adsoyad VARCHAR(50),
    telefon VARCHAR(20),
    barkodno VARCHAR(20),
    urunadi VARCHAR(50),
    miktari INTEGER,
    satisfiyati NUMERIC,
    toplamfiyat NUMERIC,
    tarih VARCHAR(255)
);

-- Tabloyu oluştur
CREATE TABLE musteri (
    tc VARCHAR(11) PRIMARY KEY,
    adsoyad VARCHAR(255),
    tel VARCHAR(20),
	adres VARCHAR(255),
	email VARCHAR(255)
);

-- Değerleri ekle
INSERT INTO musteri (tc, adsoyad, tel) VALUES
('12345678901', 'Ahmet Yılmaz', '555-1234567'),
('98765432109', 'Ayşe Demir', '555-7654321');


-- Tabloyu oluştur
CREATE TABLE urun (
    barkodno VARCHAR(50) PRIMARY KEY,
    urunadi VARCHAR(255),
    satisfiyati NUMERIC
);

-- Değerleri ekle
INSERT INTO urun (barkodno, urunadi, satisfiyati) VALUES
('1234567890123', 'Ürün 1', 50.0),
('9876543210987', 'Ürün 2', 75.5);


-- Tabloyu oluştur
ALTER TABLE satis (
    tc VARCHAR(11) PRIMARY KEY,
    adsoyad VARCHAR(255),
    telefon VARCHAR(15),
    barkodno VARCHAR(255),
    urunadi VARCHAR(255),
    miktari INTEGER,
    satisfiyati DOUBLE PRECISION,
    toplamfiyat DOUBLE PRECISION,
    tarih VARCHAR(50)  -- Burada tarih sütunu VARCHAR olarak tanımlandı
);

-- Örnek değerleri ekle
INSERT INTO satis (tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyat, tarih) VALUES
('12345678901', 'Müşteri 1', '5551234567', '1234567890123', 'Ürün 1', 2, 50.0, 100.0, NOW()),
('98765432109', 'Müşteri 2', '5557654321', '9876543210987', 'Ürün 2', 1, 75.5, 75.5, NOW());

-- Sütunun türünü değiştir
ALTER TABLE satis ALTER COLUMN tarih TYPE TIMESTAMP WITHOUT TIME ZONE;

CREATE TABLE urun (
    barkodno VARCHAR(20) PRIMARY KEY,
    kategori VARCHAR(50),
    marka VARCHAR(50),
    urunadi VARCHAR(100),
    miktari INTEGER,
    alisfiyati NUMERIC,
    satisfiyati NUMERIC,
    tarih VARCHAR(255)
);

-- 'urun' tablosuna örnek değerler ekle
INSERT INTO urun (barkodno, kategori, marka, urunadi, miktari, alisfiyati, satisfiyati, tarih)
VALUES
    ('123456789', 'Elektronik', 'Samsung', 'Televizyon', 50, 1500.00, 2000.00, '2023-01-01 12:00:00'),
    ('987654321', 'Giyim', 'Nike', 'Spor Ayakkabı', 100, 200.00, 300.00, '2023-01-02 14:30:00'),
    ('555111222', 'Ev Eşyaları', 'Bosch', 'Çamaşır Makinesi', 30, 1200.00, 1500.00, '2023-01-03 10:45:00');
	
CREATE TABLE markabilgileri(
	marka VARCHAR(255),
	kategori VARCHAR(255)
);

INSERT INTO markabilgileri VALUES('Nike','Giyim'),('Samsung','Elektronik'),('Bosh','Ev Eşyaları');

CREATE TABLE kategoribilgileri(
	marka VARCHAR(255),
	kategori VARCHAR(255)
);

INSERT INTO kategoribilgileri VALUES('Nike','Giyim'),('Samsung','Elektronik'),('Bosh','Ev Eşyaları');

--