using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type safety - Tip Güvenliği
            //Do not repeat yourself - Kendini Tekrarlama
            //Değer tutucu, alias
            //KategoriEtiketi aslında bir değer tutucu yani alias
            //Fonksiyonlar ne için kullanılır Bir kod bloğunu tekrar tekrar kullanmak için.

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }



        }
    }
}
