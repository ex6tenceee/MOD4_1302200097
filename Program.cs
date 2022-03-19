using System;

namespace Modul4_1302200097
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine(Penjumlahan.Jumlahkan(13,02,20));
        }
    }

    class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T inputUser)
        {
            Console.WriteLine("Masukkan tiga angka: " + inputUser);
        }

        public static int Jumlahkan(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}


