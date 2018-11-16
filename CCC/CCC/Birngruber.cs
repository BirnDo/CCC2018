using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CCC
{
    static class Birngruber
    {
        public static void Ausgabe(string s, string path)
        {
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(s);
        }

        public static string SortBuildings(List<Buildings> list)
        {
            string output = "";
            int i = 0;

            list.Sort();

            foreach(Buildings building in list)
            {
                output += (i + building.size);
                i++;
            }

            return output;
        }
        
        public static int[] getXY (int[,] input)
        {
            int x=0;
            int y=0;

            for (int i = 0, j = 0; input[i+1,j+1] != 0; i++)
            {
                while (input[i, j] != 0)
                {
                    x = j;
                    j++;
                }
                y = i;
            }

            int[] output = { x, y };

            return output;
        }
    }
}
