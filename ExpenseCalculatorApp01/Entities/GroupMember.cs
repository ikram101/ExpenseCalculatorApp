using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculatorApp
{
     
    public class GroupMember
    {
        public int memberId { get; set; }
        public int noOfBills { get; set; }

        public List<decimal> paymentList { get;  set; }

        public GroupMember(int MemberId, int NoOfBills, List<decimal> PaymentList)
        {
            memberId = MemberId;
            noOfBills = NoOfBills;
            paymentList = PaymentList;
        }
    }
}
