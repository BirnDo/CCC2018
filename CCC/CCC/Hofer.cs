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
            int[,] Output = new int[3000, 3000];

            StreamReader reader = new StreamReader(path);
            
            Input = reader.ReadToEnd();
            reader.Close();



            return Output;
        }
    }   
}
