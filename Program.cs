using System;

namespace Modul4_1302200097
{

    // Daffa Aqilah - 1302200097 - SE4401
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.Jumlahkan(13,02,20));

            SimpleDataBase objData = new SimpleDataBase();
            objData.AddNewData("13" + DateTime.Now);
            objData.AddNewData("02" + DateTime.Now);
            objData.AddNewData("20" + DateTime.Now);

            objData.PrintAllData();



        }
    }

    // Daffa Aqilah - 1302200097 - SE4401
    class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T inputUser)
        {
            Console.WriteLine("Masukkan tiga angka: " + inputUser);
        }

        // Daffa Aqilah - 1302200097 - SE4401
        public static int Jumlahkan<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;

            return tempA + tempB + tempC;
        }
    }

    // Daffa Aqilah - 1302200097 - SE4401
    class SimpleDataBase<T>
    {
        private List <T> storedData;
        private List <DateTime> inputDates;

        // Daffa Aqilah - 1302200097 - SE4401
        public SimpleDataBase()
        {
            storedData = new List<T>();
        }

        // Daffa Aqilah - 1302200097 - SE4401
        public void AddNewData(T MasukkinData, DateTime tanggal)
        {
            storedData.Add(MasukkinData);
            inputDates.Add(DateTime.Now);
        }

        // Daffa Aqilah - 1302200097 - SE4401
        public void PrintAllData()
        {
            Console.WriteLine("Data 1 berisi : " + storedData.Count + "yang disimpan pada waktu : " + inputDates.Now);
        }
    }
}


