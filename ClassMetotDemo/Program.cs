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

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Sil(musteri);
        }
    }
}
