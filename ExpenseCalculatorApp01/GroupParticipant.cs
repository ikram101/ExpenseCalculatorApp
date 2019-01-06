using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
     
    public class GroupParticipant
    {
        public int participantId { get; set; }
        public int noOfBills { get; set; }

        public List<decimal> paymentList { get;  set; }

        public GroupParticipant(int UserId, int NoOfBills, List<decimal> PaymentList)
        {
            participantId = UserId;
            noOfBills = NoOfBills;
            paymentList = PaymentList;
        }
    }
}
