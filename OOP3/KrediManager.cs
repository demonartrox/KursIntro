using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}

//interface arayüz, şablon demek.
// interfaceleri, birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
// burada krediler için hesaplar tüm kredilerde vardır ama hesaplama yöntemleri türlere göre farklıdır.
