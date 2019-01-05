using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
    public static class FileHelper
    {
        public static List<string> ReadFileLineByLine(string fileName)
        {
            int counter = 0;
            string line;

            string path = Path.Combine(Directory.GetCurrentDirectory(), @"Input\" + fileName);

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            List<string> myList = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                myList.Add(line);
                counter++;
            }

            file.Close();

            return myList;
        }
    }
}
