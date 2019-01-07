using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
    public class CampingGroup
    {
        public int numberOfParticipant { get; set; }
        public List<GroupParticipant> groupParticipants { get; set; }

        public CampingGroup(int numberOfPeople)
        {
            numberOfParticipant = numberOfPeople;
            groupParticipants = new List<GroupParticipant>();
        }

        public decimal GetTotalExpenses()
        {
            var totalExpenses = (from p in groupParticipants
                                 from i in p.paymentList
                                 select i).Sum();
            return totalExpenses;
        }

        public decimal GetAvgExpenses()
        {
            var avg = ((from p in groupParticipants
                        from i in p.paymentList
                        select i).Sum()) / this.numberOfParticipant;
            return avg;
        }

        public decimal GetExpensesPaidPerPerson(int participantId)
        {
            var expensesPaidPerPerson = (from p in groupParticipants
                    .Where(s => s.memberId == participantId).
                    SelectMany(s => s.paymentList)
                                         select p).Sum();

            return expensesPaidPerPerson;
        }

        public decimal GetAmountOwedPerPerson(int participantId)
        {
            return decimal.Round(GetAvgExpenses() - GetExpensesPaidPerPerson(participantId), 2, MidpointRounding.AwayFromZero);
        }
    }

}
