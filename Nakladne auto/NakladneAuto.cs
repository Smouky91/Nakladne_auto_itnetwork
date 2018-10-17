using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakladne_auto
{
    class NakladneAuto
    {
        private static int naklad;

        public void Nalozit(int a)
        {
            if (a >= 0 && (a + naklad) <= 3000)
                naklad += a;
            else
                Console.WriteLine("Naklad je pritazky!");
        }

        public void Vylozit(int b)
        {
            if (b >= 0 && (naklad -b) >= 0)
                naklad -= b;
            else
                Console.WriteLine("Nie je mozne vylozit!");
        }

        public void Zostatok()
        {
            Console.WriteLine("Zostatok na aute je: {0}", naklad);
            Console.ReadKey();
        }
    }
}
