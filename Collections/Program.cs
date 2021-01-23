using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack            //heap(bellek adresini aldi)
            string[] isimler = new string[] {"Engin", "Kerem","Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler[4] = "ilker"; //index was out of bound error
                                  //new denildigi anda bellekte yeni bir alan olusur.
                                  //dizilerdeki problem dizileri genisletemiyoruz, degerleri kaybediyoruz.
                                  //bu yuzdeen koleksiyonlar var.


            //deger tipler sadwece stack i kullanir referans tipler heap ve stacki kullanir.
            // yani o sol tarafta olan isimler aslinda pointer new komutuyla adres alani acip orayi gostertiyoruz.
            //int sayi=3 mesela burada sayi sadece 3 degerini tutar 
            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");
            //veya
            //<> generic yapi demek.
            List<string> isimler3 = new List<string> {"Murat", "Kerem" };
            //ctrl k toplu komment alma geri almak icin ctrl u
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[4]);

        }
    }
}
