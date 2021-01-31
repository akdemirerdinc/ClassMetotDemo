using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Erdinç";
            musteri.Soyad = "Akdemir";
            musteri.Id = 12358;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Musa";
            musteri2.Soyad = "Kılıç";
            musteri2.Id = 24140;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            

            Musteri[] musteriler = new Musteri[]
            {
                musteri,musteri2
            };

            musteriManager.Listele(musteriler);

        }
    }
}
