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

        public GroupMember(int UserId, int NoOfBills, List<decimal> PaymentList)
        {
            memberId = UserId;
            noOfBills = NoOfBills;
            paymentList = PaymentList;
        }
    }
}
