using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220152
{
    internal class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T in1,T in2,T in3)
        {
            dynamic g = in1 as dynamic;
            dynamic k = in2 as dynamic;
            dynamic h = in3 as dynamic;
            return g + k + h;
        }
    }
}
