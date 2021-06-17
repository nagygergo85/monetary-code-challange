using Monetary.Common.Interfaces;
using System;

namespace Monetary.InterestRate
{
    public class CreditInterestRate : IInterestRate
    {
        public float GetInterestRate(int appliedAmount, int currentAmount)
        {
            var totalFutureDebt = appliedAmount + currentAmount;

            if (totalFutureDebt < 20000)
            {
                return 3;
            }
            else if ((totalFutureDebt <= 20000) && (totalFutureDebt < 40000))
            {
                return 4;
            }
            else if ((totalFutureDebt <= 40000) && (totalFutureDebt < 60000))
            {
                return 5;
            }
            else return 6;
        }
    }
}
