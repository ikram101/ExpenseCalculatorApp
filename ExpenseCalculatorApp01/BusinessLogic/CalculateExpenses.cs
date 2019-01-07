using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
    public class CalculateExpenses
    {
        public static int index = 0;
        public static List<CampingGroup> ProcessCampingGroups(List<string> fileContentList)
        {
            List<CampingGroup> groups = new List<CampingGroup>(); ;

            for (int i = 0; i < (fileContentList.Count - 1); i = index)
            {
                int noOfPeople = Convert.ToInt32(fileContentList[index].ToString());
                CampingGroup group = new CampingGroup(noOfPeople);

                for (int j = 1; j <= noOfPeople; j++)
                {
                    if (j == 1)
                        index++;

                    int noOfBillsPaid = Convert.ToInt32(fileContentList[index].ToString());
                    List<string> paymentList = fileContentList.GetRange(++index, noOfBillsPaid);

                    var participant = new GroupParticipant(j, paymentList.Select(decimal.Parse).ToList());
                    group.groupParticipants.Add(participant);

                    index = index + noOfBillsPaid;
                }

                groups.Add(group);
            }

            return groups;
        }
    }
}
