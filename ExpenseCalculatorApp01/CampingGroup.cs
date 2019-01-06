﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
    public class CampingGroup
    {
        public int numberOfParticipant { get; set; }
        public List<GroupMember> groupMembers { get; set; }

        public CampingGroup(int numberOfPeople)
        {
            numberOfParticipant = numberOfPeople;
            groupMembers = new List<GroupMember>();
        }

        public decimal GetTotalExpenses()
        {
            var totalExpenses = (from p in groupMembers
                                 from i in p.paymentList
                                 select i).Sum();
            return totalExpenses;
        }

        public decimal GetAvgExpenses()
        {
            var avg = ((from p in groupMembers
                        from i in p.paymentList
                        select i).Sum()) / this.numberOfParticipant;
            return avg;
        }

        public decimal GetExpensesPaidPerPerson(int personID)
        {
            var expensesPaidPerPerson = (from p in groupMembers
                    .Where(s => s.memberId == personID).
                    SelectMany(s => s.paymentList)
                                         select p).Sum();

            return expensesPaidPerPerson;
        }

        public decimal GetAmountOwedPerPerson(int personID)
        {
            return decimal.Round(GetAvgExpenses() - GetExpensesPaidPerPerson(personID), 2, MidpointRounding.AwayFromZero);
        }
    }

}
