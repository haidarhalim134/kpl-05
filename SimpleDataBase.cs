using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220152
{
    internal class SimpleDataBase<T>
    {
        List<T> storeData;
        List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storeData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storeData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storeData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi {storeData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }
}
