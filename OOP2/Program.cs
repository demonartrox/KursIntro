using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ gerçek müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi= "Demiroğ";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;

            //kodlama.Io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo= "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "9876643210";

            //Gerçek - tüzel nesneleri ikisi de müşteri olmasına ragmen, birbirine benziyor diye birbiri yerine kullanılamazlar.
            //SOLID 
            Musteri musteri3 = new GercekMusteri(); //bir yerde new varsa bu bellekteki bir referans numarasıdır.
            Musteri musteri4 = new TuzelMusteri(); //müşteri classı, kem gerçek müşterinin hem de tüzel müşterinin referansını tutabiliyor.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
