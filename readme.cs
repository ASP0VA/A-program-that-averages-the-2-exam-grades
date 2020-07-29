# A-program-that-averages-the-2-exam-grades

using System;

namespace Çalışmalarım1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, numara;
            int vize_1, vize_2;
            double ortalama;
            Console.WriteLine("Adınızı giriniz :");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz :");
            soyad = Console.ReadLine();
            Console.WriteLine("Numaranızı giriniz : ");
            numara = Console.ReadLine();
            Console.WriteLine("Birinci Vizeyi Giriniz:");
            vize_1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İkinci Vizeyi Giriniz:");
            vize_2 = Convert.ToInt16(Console.ReadLine());
            ortalama = (vize_1 + vize_2) / 2;
            Console.WriteLine("\nAdınız : {0} \nSoyadınız : {1} \nNumaranız : {2} \nBirinci Vize notunuz : {3} \nİkinci Vize notunuz : {4} Ortalamanız : {5}", ad, soyad, numara, vize_1, vize_2, ortalama);
            Console.ReadLine();
        }
    }
}
