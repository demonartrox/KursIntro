using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1 // işlemi yapan ksım manager kısmıdır.
{
    class ProductManager //ürünle ilgili operasyonlar içerir. Create, Read, Update, Delete ,CRUD operasyonlarıdır. veri tabanı programlamada kullanlan yöntemlerdir.
    {
        //encapsulation, Product.cs içinde tanımlanan özelliklerin tamamını içerir.
        public void Add(Product product)
            //add operasyonunu kullanarak ekleme işlemini simüle edeceğiz. Product türünde produnt ver.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        //    product.ProductName = "Kamera";
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

 //       public int Topla(int sayi1, int sayi2) //burda hesaplanan değer hafızada tutulur, daha sonra kullanılabilir.
 //       {
 //           return sayi1 + sayi2;
 //       }

 //       public void Topla2(int sayi1, int sayi2) // void ile yazarsam emrederim, bir defa yapar ve olay biter. bu değeri bir daha kullanamam.
 //       {
 //           Console.WriteLine(sayi1 + sayi2);
 //       }
        //  public void BiseyYap (int sayi)
        //  {
        //       sayi = 99;
        //  }
    }
}
