using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //prop bir snippet tir. tab tab yaparsan açılır. bu tip classlarda sadece özellikler olur. aşağıda özellikler yazılıdır.
        public int Id { get; set; } //ana anahtar
        public int CategoryId { get; set; } //referans anahtar, ürün hangi kategoriye ait
        public string ProductName { get; set; }  //ürün ismi
        public double UnitPrice { get; set; } //ürün fiyatı
        public int UnitsInStock { get; set; } //ürünün stoktaki adedi

    }
}
