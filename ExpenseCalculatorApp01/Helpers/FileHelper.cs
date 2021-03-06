﻿using System;
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

            var rootFolderPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path = Path.Combine(rootFolderPath, @"InputOutput\" + fileName);

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            List<string> fileContentList = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                fileContentList.Add(line);
                counter++;
            }

            file.Close();
            return fileContentList;
        }

        public static void WriteFile(IList<CampingGroup> groups)
        {
            var rootFolderPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path = Path.Combine(rootFolderPath, @"InputOutput\CampingTrips.txt.out");

            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (CampingGroup group in groups)
                {
                    WritePesonExpense(group, tw);
                    tw.WriteLine("");
                }
            }
        }

        public static void WritePesonExpense(CampingGroup group, TextWriter tw)
        {
            for (var person = 1; person <= group.numberOfParticipant; person++)
            {
               Console.WriteLine(group.GetAmountOwedPerPerson(person) > 0 ? "$" + group.GetAmountOwedPerPerson(person).ToString() : string.Format("(${0})", Math.Abs(group.GetAmountOwedPerPerson(person)).ToString()));
               tw.WriteLine(group.GetAmountOwedPerPerson(person) > 0 ? "$" + group.GetAmountOwedPerPerson(person).ToString() : string.Format("(${0})", Math.Abs(group.GetAmountOwedPerPerson(person)).ToString()));
            }
        }
    }
}
