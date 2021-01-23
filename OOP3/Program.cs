using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Burasını ekandaki listbox gibi düşünüyoruz.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //burada ayrı ayrı çağırırsan ayrı ayrı hesaplandığını göreceksin.
            //basvuru manager de bulunan hesapla fonksiyonu, oraya hangi kredi tipini gönderirsen onu hesaplar.
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
