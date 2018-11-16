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
            string output = Nemecek.SizeBuilding(split0);
            Birngruber.Ausgabe(output, "../../level2/level2_0.out");

            int[,] split1 = Hofer.Einlesen("../../level2/level2_1.in");
            output = Nemecek.SizeBuilding(split0);
            Birngruber.Ausgabe(output, "../../level2/level2_1.out");

            int[,] split2 = Hofer.Einlesen("../../level2/level2_2.in");
            output = Nemecek.SizeBuilding(split0);
            Birngruber.Ausgabe(output, "../../level2/level2_2.out");

            int[,] split3 = Hofer.Einlesen("../../level2/level2_3.in");
            output = Nemecek.SizeBuilding(split0);
            Birngruber.Ausgabe(output, "../../level2/level2_3.out");

            int[,] split4 = Hofer.Einlesen("../../level2/level2_4.in");
            output = Nemecek.SizeBuilding(split0);
            Birngruber.Ausgabe(output, "../../level2/level2_4.out");
        }
    }
}
