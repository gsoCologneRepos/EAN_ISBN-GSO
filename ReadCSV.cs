using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class ReadCSV
    {
        public static string[] Read()
        {
            String[] values = File.ReadAllText(@"./output.csv").Split(';');
            return values;
        }
    }
}