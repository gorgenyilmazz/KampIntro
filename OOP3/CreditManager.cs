using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //imzanin ayni oldugu fakat icerisinin farkli oldugu durumlarda base classini interface yapariz.
    //sablon gorevi gorur
    // her kim interface icerirse onun fonksiyonlarini da icermek zorunda
    //Okunurluk icin I ile baslatilir.
    //Interfaceler genellikle operasyonel durumlarda kullanilir.
    //interfaceleri birbirinin alternatifi olan fakat kod icerikleri farkli olan durumlar icin kullaniriz.
    //LOGLAMA
    interface ICreditManager
    {
        void Calculate();
        void DoSomething();

        
    }
}
