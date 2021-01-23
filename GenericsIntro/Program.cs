using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //ben generic yapiyim bana tipimi soyle der ve buna kizar
            // MyList isimler = new MyList();
            //List koleksiyonu arka planda array kullanir.
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Gorgen");
            Console.WriteLine("Hello World!");
        }
    }
}
