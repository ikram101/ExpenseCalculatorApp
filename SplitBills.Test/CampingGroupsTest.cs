using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseCalculatorApp;
using System.Collections.Generic;

namespace SplitBills.Test
{
    [TestClass]
    public class CampingGroupTest
    {

        [TestMethod]
        public void TotalExpenses_ShouldReturnTotalPerTrip()
        {
            //act
            var campingTrip = new CampingGroup(2);

            campingTrip.groupMembers.Add(new GroupMember(1, 1, new List<decimal> { 1.50m }));
            campingTrip.groupMembers.Add(new GroupMember(1, 1, new List<decimal> { 21.5m }));
            campingTrip.groupMembers.Add(new GroupMember(2, 1, new List<decimal> { 13.50m }));
            campingTrip.groupMembers.Add(new GroupMember(2, 1, new List<decimal> { 25m }));

            //assert
            Assert.AreEqual(campingTrip.numberOfParticipant, 2);
            Assert.AreEqual(campingTrip.GetTotalExpenses(), 61.5m);
        }

    }
}
