using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monetary.Common.Interfaces;
using Monetary.CreditDecision;
using Monetary.Common.Enums;

namespace Monetary.Tests
{
    [TestClass]
    public class DecisionTests
    {
        public IDecision _decision = new CreditDebtDecision();

        [TestMethod]
        public void DecisionForLowNumber_ReturnsNo()
        {
            var decision = _decision.GetDecision(0);
            Assert.AreEqual(decision, Decision.No);
        }

        [TestMethod]
        public void DecisionForHigherNumber_ReturnsNo()
        {
            var decision = _decision.GetDecision(19999);
            Assert.AreEqual(decision, Decision.No);
        }

        [TestMethod]
        public void DecisionForHigherNumber_ReturnsYes()
        {
            var decision = _decision.GetDecision(20001);
            Assert.AreEqual(decision, Decision.Yes);
        }

        [TestMethod]
        public void DecisionForHighestNumber_ReturnsNo()
        {
            var decision = _decision.GetDecision(69500);
            Assert.AreEqual(decision, Decision.No);
        }

    }
}
