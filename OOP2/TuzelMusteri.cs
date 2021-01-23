using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{//CoorporateEntity
    class TuzelMusteri:Musteri     // tüzel müsteri bir müşteridir. bu yazım inheritance dir. yani miras. 
                                   //burada müşteri ebeveyndir. ebeveyndeki özellikler ortaktır.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
