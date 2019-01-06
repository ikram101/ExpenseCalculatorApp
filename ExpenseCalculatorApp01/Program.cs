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
            //FileHelper.ReadFileLineByLine("Trip.txt");
            //Console.WriteLine("Enter Filename");
            //var lineRead = Console.ReadLine();

            var lineRead = "CampingTrips.txt";

            if (!string.IsNullOrEmpty(lineRead))
            {
                List<string> fileContent = FileHelper.ReadFileLineByLine(lineRead);
                List<CampingGroup> campingGroupList = CalculateExpenses.ProcessCampingGroups(fileContent);

                FileHelper.WriteFile(campingGroupList);
            }

            else
            {
                Console.WriteLine("Filename Entered Invalid");
            }
        }



    }


}



//                foreach (var g in campingGroupList)
//                {
//                    var totalExp = g.GetTotalExpenses();
//var avg = g.GetAvgExpenses();

//decimal expensePaidPerPerson = 0;
//                    foreach (var p in g.Participants)
//                    {
//                        expensePaidPerPerson = g.GetExpensesPaidPerPerson(p.userId);
//                        var amountOwned = g.GetAmountOwedPerPerson(p.userId);
//                    }
//                }