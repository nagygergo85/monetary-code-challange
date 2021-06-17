using Monetary.Common.Interfaces;
using Monetary.Common.Enums;
using System;

namespace Monetary.CreditDecision
{
    public class CreditDebtDecision : IDecision
    {
        public Decision GetDecision(int amount)
        {
            if ((amount >= 20000) && (amount <= 69000)) {
                return Decision.Yes;
            }
            else
            {
                return Decision.No;
            }
        }
    }
}
