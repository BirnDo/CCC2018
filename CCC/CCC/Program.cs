using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCC
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] split0 = Hofer.Einlesen("../../level2/level2_0.in");
            Nemecek.SizeBuilding(split0);

            int[,] split1 = Hofer.Einlesen("../../level2/level2_1.in");
            Nemecek.ifBuildings(split0);

            int[,] split2 = Hofer.Einlesen("../../level2/level2_2.in");
            Nemecek.ifBuildings(split0);

            int[,] split3 = Hofer.Einlesen("../../level2/level2_3.in");
            Nemecek.ifBuildings(split0);

            int[,] split4 = Hofer.Einlesen("../../level2/level2_4.in");
            Nemecek.ifBuildings(split0);
        }
    }
}
