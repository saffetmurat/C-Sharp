using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asalBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACIKLAMA: Girilen sayının asal olup olmadığını özyinemeli olarak bulan fonksiyon");
            Console.Write("Bir sayi girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (asalBulma(2, sayi))
                Console.WriteLine("Girilen sayi asal sayidır.");
            else
                Console.WriteLine("Girilen sayi asal sayi değildir.");

            Console.ReadKey();
        }
        public static bool asalBulma(int i, int sayi)
        {
            bool son = true;
            if (i < sayi && (sayi % i != 0)) son = asalBulma((i += 1), sayi);
            else if (sayi == i) return true;
            else if (sayi % i == 0) return false;
            return son;     
        }
    }
}
