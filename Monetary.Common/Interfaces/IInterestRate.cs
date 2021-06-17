using System;
using System.Collections.Generic;
using System.Text;

namespace Monetary.Common.Interfaces
{
    public interface IInterestRate
    {
        float GetInterestRate(int appliedAmount, int currentAmount);
    }
}
