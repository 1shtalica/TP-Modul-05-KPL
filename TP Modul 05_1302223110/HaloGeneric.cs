using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_05_1302223110
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo " + nama);
        }
    }
}
