using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T type demek.
    {
        T[] items; // bu satır doğrudan class ın içinde, altta yazılacak metotların tamamı ile bu satıra erişebilirim.
        //constractor, ctor yazıp tab tab.
        public MyList()
        {
            items = new T[0]; //önce items diye bir tane 0 elemanlı array oluşturuluyor.
        }
        public void Add(T item)//item eleman demek.
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        //public int Length
        //{
        //    get 
        //}
    }
}
