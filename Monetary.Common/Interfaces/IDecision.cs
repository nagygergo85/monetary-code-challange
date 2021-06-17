using Monetary.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monetary.Common.Interfaces
{
    public interface IDecision
    {
        Decision GetDecision(int amount);
    }
}
