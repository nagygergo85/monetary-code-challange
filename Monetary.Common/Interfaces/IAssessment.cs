using Monetary.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monetary.Common.Interfaces
{
    public interface IAssessment
    {
        MonetaryOutput GetMonetaryAssessment(MonetaryInput input);
    }
}
