using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Giriş Kursu";
            string kurs3 = "PHP ile Web Geliştirme Kursu";
            string kurs4 = "Başlangıç seviye Go Programlama Kursu";
            string kurs5 = "İleri Seviye C++ Prgramlama Kursu";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            // array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Giriş Kursu",
                "PHP ile Web Geliştirme Kursu",
                "İleri Seviye C++ Prgramlama Kursu" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti...");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");




            
        }
    }
}
