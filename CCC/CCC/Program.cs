using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCC
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] split0 = Einlesen("../../level2/level2_0.in");
            ifBuildings(split0);

            int[] split1 = Einlesen("../../level2/level2_1.in");
            ifBuildings(split0);

            int[] split2 = Einlesen("../../level2/level2_2.in");
            ifBuildings(split0);

            int[] split3 = Einlesen("../../level2/level2_3.in");
            ifBuildings(split0);

            int[] split4 = Einlesen("../../level2/level2_4.in");
            ifBuildings(split0);
        }
    }
}
