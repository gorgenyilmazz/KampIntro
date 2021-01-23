using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //tek tirnak kullanilmaz
            //Do not repeat yourself. En buyuk projelerrde bile gorebilirsin bunu
            //deger tutucu, alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu goster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
