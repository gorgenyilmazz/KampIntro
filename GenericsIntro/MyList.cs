using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Ben MyListimde T(type) ile calisacagim demek. Yani her tiple calisabilirim hangi tip verirsem istedigim elemanin turu de o
    class MyList<T>
    {
        //classin butun metodlari erisebilir items'e ama generic oldugu icin T olarak baslatman lazim
        //bunu newlemek zorundasin cunku refeerans yok eklemek icin referans alman lazim ve ben sifir boyutlu baslatmak istiyorum o yuzden constructorla baslangicta sifir elemanli baslatiyoruz.
        T[] items;
        //constructor bir yerde class newlneirse constructor otomatik calisir
        public MyList()
        {
            items = new T[0];
        }
        //hangi tip verirsem istedigim elemanin turu de o
        public void Add(T item) 
        {
            //referansi kaybetmemek icin bu referansi tutmamaiz lazim. yani onceki elemanlari kaybetmemiz lazim
            T[] tempArray = items;
            //bu sekilde ilgili dizinin ref numarasini kaybederiz. items.length+1 aslinda items in eleman sayisi INDIS DEGIL.
            //
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                //items'in eski elemanlarini geri aliyoruz.
                items[i] = tempArray[i];
            }
            //fonk. gelen elemani ekledik.
            items[items.Length - 1] = item;
        
        }
    }
}
