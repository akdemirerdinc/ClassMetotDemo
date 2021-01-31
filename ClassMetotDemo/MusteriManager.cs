using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi:"+musteri.Ad+" "+musteri.Soyad+" Id:"+musteri.Id);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi:" + musteri.Ad + " " + musteri.Soyad + " Id:" + musteri.Id);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach(var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad+" "+musteri.Soyad);
            }
        }
        
    }
}
