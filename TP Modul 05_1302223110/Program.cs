using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_05_1302223110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan data");
            String input = Console.ReadLine();

            DataGeneric<string> dataGeneric = new DataGeneric<string>(input);
            dataGeneric.PrintData();
        }
    }
}
