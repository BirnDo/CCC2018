using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CCC
{
    static class Hofer
    {
    
        static public int[,] Einlesen(string path)
        {
            string Input;
            string[] InString = new string[10000];
            int[,] Output = new int[3000, 3000];

            StreamReader reader = new StreamReader(path);
            
            Input = reader.ReadToEnd();
            reader.Close();

            InString = Input.Split('\n');

            for (int i = 1; InString[i+1] != null; i++)
            {
                string s = InString[i];

                string[] s1 = new string[1000];

                s1 = s.Split(' ');

                for (int j = 0; s1[j + 1] != null; j++)
                {
                    Output[i, j] = Convert.ToInt16(s1[j]);
                }
            } 

            return Output;
        }
    }   
}
