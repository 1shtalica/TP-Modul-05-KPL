using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_05_1302223110
{
    internal class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data: " + Data);
        }
    }
}
