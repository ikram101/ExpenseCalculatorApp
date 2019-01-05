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

        public List<GroupParticipant> Participants { get; set; }

        public CampingGroup(int numberOfPeople)
        {
            numberOfParticipant = numberOfPeople;
            Participants = new List<GroupParticipant>();
        }

        public void GetTotalExpenses()
        {
            (this.Participants.SelectMany(p => p.paymentList)).Sum();
        }

    }
    
}
