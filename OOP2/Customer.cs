using System;
using System.Collections.Generic;
using System.Text;
//ozellik tuttugumuz yerde method tutmuyoruz. Method tuttugumuz klasta ozellik tutumuyoruz.
namespace OOP2
{
    class Customer
    { 
        public int CustomerId { get; set; }
        public string CustomerNo { get; set; }

        //NEDEN INT VERILER STRING TUTULUR? EGER BIR VERI UZERINDE ISLEM YAPMIYOSAN TOPLAMA CIKARMA VS 
        //STRING OLARAK TUTMAK DAHA IYYIDIR CUNKU HER SISTEMIN VERI UYUMLULUGU SINIRI FARKLIDIR.
        //EGERKI BIR OZELLIK O NESNEYE AIT GIBI DURMUYORSA ORA DA SOYUTLAMA HATASI YAPIYORSUNDUR.

    }
}
