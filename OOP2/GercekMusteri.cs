using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class GercekMusteri: Musteri //IndividualEntity // tüzel müsteri bir müşteridir. bu yazım inheritance dir. yani miras. 
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
