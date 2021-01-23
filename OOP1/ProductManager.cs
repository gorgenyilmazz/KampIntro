using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        //int, double, bool... deger tipidir

        //deger tiplerde atamalar tamamen deger uzerinden olur ve tum baglanti kopar.
        // int sayi diyelim Add fonksyionuna sayiyi gonderip fonk icinde degistirdigimizi dusunelim. sayi degiskeni degismez.
        // biz aslinda sayinin kendisini gondermiyoriz sadece degeri gonderiyoruz. 
        //Referans tiplerde ise atamalar referansin numarasiyla yapilir. Gercekten bellekteki yerinde degisiklik yapilir(bellekteki adresi) ve deger degisir.

        //diziler, classlar, abstract classlar, interfaceler referans tiptir.
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "Eklendi...");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Guncellendi...");
        }

        
    }
}
