using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monetary.Common.Interfaces;
using Monetary.InterestRate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monetary.Tests
{
    [TestClass]
    public class InterestRateTests
    {
        public IInterestRate _interestRate = new CreditInterestRate();
        
        [TestMethod]
        public void InterestRateForLowFutureDebt_ReturnThree()
        {
            var interestRate = _interestRate.GetInterestRate(5000, 14000);
            Assert.AreEqual(3, interestRate);
        }

        [TestMethod]
        public void InterestRateForMediumFutureDebt_ReturnFour()
        {
            var interestRate = _interestRate.GetInterestRate(5000, 20000);
            Assert.AreEqual(4, interestRate);
        }

        [TestMethod]
        public void InterestRateForHigherFutureDebt_ReturnFive()
        {
            var interestRate = _interestRate.GetInterestRate(5000, 40000);
            Assert.AreEqual(5, interestRate);
        }

        [TestMethod]
        public void InterestRateForHighestFutureDebt_ReturnSix()
        {
            var interestRate = _interestRate.GetInterestRate(5000, 60000);
            Assert.AreEqual(6, interestRate);
        }
    }
}
