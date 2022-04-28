using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Donguler birbirine benzeyen işlemleri tekrar etmek için kullanırız.

            for (int i = 0; i < 10; i++) //i=i+2 iki iki artır i+=2
            {
                Console.WriteLine(i);
            }

            string kurs1 = "Yazılım Gerliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçinm Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            Console.WriteLine();
            //Tek tek böyle tanımlamak doğru değil liste tarzında göstermek istediğimiz verileri dizilerde tanımlarız

            //Array - Dizi

            string[] kurslar = new string[] { "Yazılım Gerliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçinm Temel Kurs", "Java","Pyhton","JavaScript","C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            Console.WriteLine("Sayfa Sonu - footer");
            Console.WriteLine();

            //Dizi temelli yapıları tek tek dönmeye yarıyor
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
