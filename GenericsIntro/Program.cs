using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Sayit");
            Console.WriteLine(isimler.Length);

            isimler.Add("Lerdorf");
            Console.WriteLine(isimler.Length);


            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
