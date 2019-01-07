using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
     
    public class GroupParticipant
    {
        public int memberId { get; set; }
        public List<decimal> paymentList { get;  set; }

        public GroupParticipant(int MemberId, List<decimal> PaymentList)
        {
            memberId = MemberId;
             paymentList = PaymentList;
        }
    }
}
