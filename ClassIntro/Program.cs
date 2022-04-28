using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gokhan";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Yetiştirme Kampı C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 45;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni + " : " + kurs1.IzlenmeOrani);

            //Kurs Arrayi tanimladik
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
            /*
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].Egitmeni);
            }
            */


        }
    }

    class Kurs
    {
        //prop tab tab 
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
