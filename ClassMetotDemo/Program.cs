using ClassMetotDemo;

MusteriManager musteriManager = new MusteriManager();

Musteri musteri1 = new Musteri();

musteri1.Adi = "Atakan";
musteri1.Soyadi = "Çetin";
musteri1.Telefon = "0 506 923 80 85";

Musteri musteri2 = new Musteri();

musteri2.Adi = "Mehmet Yasin";
musteri2.Soyadi = "Cırak";
musteri2.Telefon = "0 555 680 12 70";

musteriManager.ekle(musteri1);

Musteri[] musteriler = { musteri1, musteri2 };
Console.WriteLine("Musteri Listesi...");
foreach (var item in musteriler)
{
    Console.WriteLine(item.Adi + " " + item.Soyadi);
}

musteriManager.sil(musteri2);




