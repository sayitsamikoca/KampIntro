using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Linux";
            kurs1.Egitmen = "Sayit Sami KOCA";
            kurs1.IzlenmeOrani = 54;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = " Anders Hejlsberg";
            kurs2.IzlenmeOrani = 64500;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PHP";
            kurs3.Egitmen = "Rasmus Lerdorf";
            kurs3.IzlenmeOrani = 97850;



            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
