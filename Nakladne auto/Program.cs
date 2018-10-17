using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakladne_auto
{
    class Program
    {
        static void Main(string[] args)
        {
            NakladneAuto nakladiak = new NakladneAuto();
            nakladiak.Zostatok();
            nakladiak.Nalozit(10000);
            nakladiak.Nalozit(500);
            nakladiak.Vylozit(300);
            nakladiak.Vylozit(1000);
            nakladiak.Zostatok();
        }
    }
}
