using System;
using CsvHelper;
using System.IO;

namespace ExcelParsing
{
   

 }
    class Program
    {
        static void Main(string[] args)
        {
         using (TextReader reader = new StreamReader("sample.csv"))
         {
            var csvReader = new CsvReader(reader);
         }

        }
    }
}
