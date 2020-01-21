using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description= "Kamera ürünleri"},
                new Category(){Name="Bilgisayar",Description= "Bilgisayar ürünleri"},
                new Category(){Name="Saat",Description= "Saat ürünleri"},
                new Category(){Name="Telefon",Description= "Telefon ürünleri"},
                new Category(){Name="Beyaz Eşya",Description= "Beyaz Eşya ürünleri"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

           var urunler = new List<Product>()
            {
                new Product(){Name="Canon Powershot G1 x Mark Iıı",Description="24,2MP APS-C CMOS Sensör DIGIC 7 Görüntü İşlemcisi 3x Zum Objektif, 24-72mm (35mm Eşdeğeri) Dahili Elektronik Vizör 3.0 Değişken Açılı Dokunmatik LCD 60 fps'de Full HD 1080p Video Kaydı Çift Piksel CMOS AF, Görüntü Sabitleyici ISO 25600, 9 fps Sürekli Çekim Dahili NFC, Bluetooth'lu Wi-Fi Toz ve Suya Dayanıklı Yapı",Price=7801 ,Stock=60, IsApproved=true,CategoryId=1,IsHome=true, Image="kamera.1.jpg"},
                new Product(){Name="Canon Powershot G7 x Mark Iıı Gümüş (2 Yıl Canon Eurasia Garantili)",Description="20.2MP 1 Yığın CMOS SensörüDIGIC 8 Görüntü İşlemci5x Optik Zum f / 1.8-2.8 Objektif24-100mm (35mm Eşdeğeri)7.5cm LCD Dokunmatik Eğimli EkranUHD 4K Video Kaydı20 fps ÇekimDahili Bluetooth ve Wi-FiCanlı Akış ve Dikey Video Desteği",Price=5075 ,Stock=17, IsApproved=true,CategoryId=1,IsHome=true, Image="kamera.2.jpg"},
                new Product(){Name="Canon Powershot G7 x Mark Iıı Siyah (2 Yıl Canon Eurasia Garantili)",Description="20.2MP 1 Yığın CMOS SensörüDIGIC 8 Görüntü İşlemci5x Optik Zum f / 1.8-2.8 Objektif24-100mm (35mm Eşdeğeri)7.5cm LCD Dokunmatik Eğimli EkranUHD 4K Video Kaydı20 fps ÇekimDahili Bluetooth ve Wi-FiCanlı Akış ve Dikey Video Desteği",Price= 5075,Stock=22, IsApproved=false,CategoryId=1,IsHome=true, Image="kamera.3.jpg"},
                new Product(){Name="Canon Powershot G1 x Mark Iı + WP-DC53 (Su Altı Kiti)",Description=" 12.8MP Yüksek Hassasiyet 1.5 CMOS Sensör• DIGIC 6 görüntü işlemci• Canon 5x Optik Zoom Lens• 24-120mm f / 2-3,9 (35mm eşdeğer)• 3.0 1,040K-Dot Devirme Dokunmatik LCD• 30 fps Full HD 1080p Video Kayıt• Dahili Wi-Fi Bağlantı NFC ile• Yüksek Hızlı AF ve 5.2 fps Çekim• HS SİSTEMİ ve Optik Görüntü Sabitleyici• Çift Kontrol Halkalar ve 14-Bit RAW",Price=4699 ,Stock=36, IsApproved=true,CategoryId=1, Image="kamera.4.jpg"},
                new Product(){Name="Canon Powershot Sx520 Hs Dijital Fotoğraf Makinesi",Description="Her olayı çarpıcı detaylarıyla yakalayan çok yönlü ultra taşınabilir 42x zum fotoğraf makinesi. Kolaylığın keyfini çıkarın ya da fotoğrafçılık yeteneklerinizi geliştirin ve kendinizi yaratıcı kontrol ile ifade edin.",Price=1621 ,Stock=41, IsApproved=true,CategoryId=1,IsHome=true, Image="kamera.5.jpg"},

                new Product(){Name="Lenovo Ideapad 330-15ICH Intel Core i7 8750H 16GB 1TB GTX1050 Freedos 15.6 FHD Taşınabilir Bilgisayar 81FK005MTX",Description="Lenovo IdeaPad 300 serisinden; Lenovo 330, tüm 300 serisinde olduğu gibi hem bugünün hem de geleceğin teknolojik gelişmelerine ayak uyduracak teknik özelliklerle tasarlanmıştır. Modern, şık ve hafif tasarımı ile göz zevkinize hitap ederken sabit veya hareket halindeyken bile yüksek performans ve güvenli kullanım avantajı sunar.",Price= 5999,Stock=100, IsApproved=true,CategoryId=2, Image="pc.1.jpg"},
                new Product(){Name="Asus FX505GD-BQ139 Intel Core i7 8750H 8GB 1TB 256GB SSD GTX1050 Freedos 15.6 FHD Taşınabilir Bilgisayar",Description="FX505GD-BQ139SINIRSIZ TASARIM, RAKİPSİZ DAYANIKLILIKASUS TUF Gaming FX505, oyun dizüstü bilgisayarlarına bakış açınızı değiştirecek. Etkileyici bir donanıma sahip ve olağanüstü derecede dayanıklı, agresif tasarımlı kasası ile beklentilerin çok üzerindedir. ",Price=5999 ,Stock=100, IsApproved=true,CategoryId=2,IsHome=true, Image="pc.2.jpg"},
                new Product(){Name="Acer Nitro Intel Core I5 9300H 16GB 512GB SSD Gtx 1650 LINUX15.6 Fhd Taşınabilir Bilgisayar Lnx NH.Q59EY.00F",Description="Acer Nitro Intel Core I5 9300H 16GB 512GB SSD Gtx 1650 LINUX15.6 Fhd Taşınabilir Bilgisayar kullanması çok keyiflidir.",Price=5999 ,Stock=150, IsApproved=true,CategoryId=2,IsHome=true, Image="pc.3.jpg"},
                new Product(){Name="Acer Nitro AN515-52 Intel Core i5 8300H 8GB 1TB + 128GB SSD GTX1050Ti Linux 15.6 FHD Taşınabilir Bilgisayar NH-Q3LEY-010",Description="8300H işlemci ve 4Gb Hafıza kartına sahiptir",Price=5999 ,Stock=200, IsApproved=true,CategoryId=2, Image="pc.4.jpg"},
                new Product(){Name="Monster Huma H4 V2.1 Intel Core i7-8565U 8GB 256GB SSD MX250 Freedos 14.1 FHD Taşınabilir Bilgisayar",Description="8565U işlemci ve 2 Gb ekran kartı hafızasına sahiptir",Price=5999 ,Stock=50, IsApproved=true,CategoryId=2, Image="pc.5.jpg"},

                new Product(){Name="Henry London HL39-M-0008 Unisex Kol Saati",Description="Kasa Çapı: 39 mm - Kasa Tipi: Yuvarlak - Kasa Malzemesi: Çelik - Kasa Rengi: Altın Sarısı - Kordon Malzemesi: Hasır Çelik - Kordon Rengi: Altın Sarısı - Kadran Rengi: Beyaz - Çalışma Tipi: Quartz - Kronometre: Yok - Takvim: Var - Alarm: Yok - Cam: Mineral - Su Geçirmezlik: 3 Atm - Cinsiyet: Unisex Kol Saati - Garantis Süresi: 24 Ay",Price=499 ,Stock=50, IsApproved=true,CategoryId=3, Image="saat.1.jpg"},
                new Product(){Name="Casio EF-500D-1AVUDF Edifice",Description="Casio EF-500D-1AVUDF Erkek Kol Saati",Price=499 ,Stock=50, IsApproved=true,CategoryId=3, Image="saat.2.jpg"},
                new Product(){Name="Beverly Hills Polo Club BH9401-10 Kadın Kol Saati",Description="Beverly Hills Polo Club Beverly Hills Polo Club BH9401-10",Price=499 ,Stock=50, IsApproved=false,CategoryId=3,IsHome=true, Image="saat.3.jpg"},
                new Product(){Name="Slazenger SL.09.1344.4.02 Kadın Kol Saati",Description="Metal Kordon Yuvarlak Kadran Analog Mekanizma Saat",Price=450 ,Stock=100, IsApproved=true,CategoryId=3,IsHome=true, Image="saat.4.jpg"},
                new Product(){Name="Beverly Hills Polo Club BH0037-05 Erkek Kol Saati",Description="Beverly Hills Polo Club Beverly Hills Polo Club BH0037-05",Price= 399,Stock=150, IsApproved=true,CategoryId=3,IsHome=true, Image="saat.5.jpg"},

                new Product(){Name="Samsung Galaxy S10 Plus 512 GB ",Description="Ön (Selfie) Kamera10 MP + 8 MPDahili Hafıza512 GB,RAM Kapasitesi8 GB RAMPil Gücü4100 mAh",Price=7899 ,Stock=100, IsApproved=true,CategoryId=4,IsHome=true, Image="telefon.1.jpg"},
                new Product(){Name="Huawei Mate 20 Pro 128 GB",Description="Ön (Selfie) Kamera24 MPDahili Hafıza128 GB, RAM Kapasitesi6 GB RAMPil Gücü4200 mAh",Price=7090 ,Stock=100, IsApproved=true,CategoryId=4,IsHome=true, Image="telefon.2.jpg"},
                new Product(){Name="Samsung Galaxy S9 Plus 128 GB",Description="Ön (Selfie) Kamera8,0 MPDahili Hafıza128 GB,RAM Kapasitesi6 GB RAMPil Gücü3500 mAh",Price=6349 ,Stock=100, IsApproved=true,CategoryId=4,IsHome=true, Image="telefon.3.jpg"},
                new Product(){Name="Xiaomi Mi 9 128 GB",Description="Ön (Selfie) Kamera20 MPDahili Hafıza128 GB, RAM Kapasitesi6 GB RAMPil Gücü3300 mAh, Ekran Boyutu6,39 inçKamera Çözünürlüğü48 MP + 16 MP +12 MP",Price=5879 ,Stock=100, IsApproved=true,CategoryId=4,IsHome=true, Image="telefon.4.jpg"},
                new Product(){Name="Samsung Galaxy C9 Pro",Description="Ön (Selfie) Kamera16 MPDahili Hafıza64 GBRAM Kapasitesi6 GB RAMPil Gücü4000 mAhEkran Boyutu6,0 inçKamera Çözünürlüğü16 MPİşlemci Kapasitesi1,4 GHz Quad Core + 1,95 GHz Quad Core",Price=2779 ,Stock=100, IsApproved=true,CategoryId=4,IsHome=true, Image="telefon.5.jpg"},

                new Product(){Name="Profilo CMG120DTR A+++ 9 Kg 1200 Devir Çamaşır Makinesi",Description="Enerji SınıfıA+++Genişlik (cm)59.8Maksimum Devir Hızı1200Kurutma ÖzelliğiYokDerinlik (cm)59Yükseklik (cm)84.8Yıkama Kapasitesi9 kg",Price=2084,Stock=100, IsApproved=true,CategoryId=5,IsHome=true, Image="B.eşya.1.jpg"},
                new Product(){Name="Profi̇lo BM4320EG 4 Programli Bulaşik Maki̇nasi",Description="Dondurucu ÖzelliğiNo FrostEnerji SınıfıA+Kullanım ŞekliSoloÜrün TipiGardrop TipiYükseklik (cm)187Derinlik (cm)76Genişlik (cm)88Ses Seviyesi (dB)40Hacim (L)594Yıllık Enerji Tüketimi (kWh)350",Price=9541,Stock=50, IsApproved=true,CategoryId=5,IsHome=true, Image="B.eşya.2.jpg"},
                new Product(){Name="Vestel CM 8710 A+++ 8 kg 1000 Devir Çamaşır Makinesi",Description="RenkInoxSes Seviyesi (dB)47Kapasite15 KişilikEnerji SınıfıA++Yıllık Enerji Tüketimi (kWh)267Kullanım ŞekliAnkastreProgram Sayısı6Derinlik (cm)57Yükseklik (cm)82Genişlik (cm)59.6",Price=2056,Stock=200, IsApproved=true,CategoryId=5,IsHome=true, Image="B.eşya.3.jpg"},
                new Product(){Name="LG F70E1UDNK1 A+++ 3,5 kg 700 Devir Çamaşır Makinesi",Description="Enerji SınıfıA+++Genişlik (cm)70Maksimum Devir Hızı700Kurutma ÖzelliğiYokDerinlik (cm)77Yükseklik (cm)36Yıkama Kapasitesi5 kg",Price= 1564,Stock=140, IsApproved=true,CategoryId=5, Image="B.eşya.4.jpg"},
                new Product(){Name="Beko BK 7722 43 Lt Mini Bar Buzdolabı",Description="Dondurucu ÖzelliğiStatikEnerji SınıfıA+Kullanım ŞekliSoloÜrün TipiBüro TipiYükseklik (cm)56.3Derinlik (cm)46.5Genişlik (cm)43.2Ses Seviyesi (dB)35Hacim (L)43Yıllık Enerji Tüketimi (kWh)176",Price=843 ,Stock=200, IsApproved=true,CategoryId=5,IsHome=true, Image="B.eşya.5.jpg"},
            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();



            base.Seed(context);
        }
    }
}