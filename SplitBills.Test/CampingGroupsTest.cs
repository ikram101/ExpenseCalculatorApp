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
            var campingGroup = new CampingGroup(2);

            campingGroup.groupParticipants.Add(new GroupParticipant(1, new List<decimal> { 1.50m }));
            campingGroup.groupParticipants.Add(new GroupParticipant(1, new List<decimal> { 21.5m }));
            campingGroup.groupParticipants.Add(new GroupParticipant(2, new List<decimal> { 13.50m }));
            campingGroup.groupParticipants.Add(new GroupParticipant(2, new List<decimal> { 25m }));

            //assert
            Assert.AreEqual(campingGroup.numberOfParticipant, 2);
            Assert.AreEqual(campingGroup.GetTotalExpenses(), 61.5m);
        }

    }
}
