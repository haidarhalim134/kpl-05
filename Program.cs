﻿namespace modul5_1302220152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan pjm = new Penjumlahan();
            // nim: 13 02 22 0152, tipe float
            Console.WriteLine(pjm.JumlahTigaAngka((float)13.0, (float)02.0, (float)22.0));
            
            SimpleDataBase<float> data = new SimpleDataBase<float>();
            // nim: 13 02 22 0152, tipe float
            data.AddNewData((float)13.0);
            data.AddNewData((float)02.0);
            data.AddNewData((float)22.0);

            data.PrintAllData();
        }
    }
}
