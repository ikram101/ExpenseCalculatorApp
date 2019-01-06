using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter filename (CampingTrips.txt) located in inputoutput project folder.");
            var lineRead = Console.ReadLine();

            if (!string.IsNullOrEmpty(lineRead))
            {
                try
                {
                    List<string> fileContent = FileHelper.ReadFileLineByLine(lineRead);
                    List<CampingGroup> campingGroupList = CalculateExpenses.ProcessCampingGroups(fileContent);

                    Console.WriteLine();
                    FileHelper.WriteFile(campingGroupList);

                    Console.WriteLine("\n\nPlease find the file in InputOutput directory.");
                    Console.WriteLine("\n\n\nClick to exist the program.");

                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            else
            {
                Console.WriteLine("Filename is Invalid.Please try again.");
            }
        }



    }


}


