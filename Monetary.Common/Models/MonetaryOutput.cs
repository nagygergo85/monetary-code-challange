using Monetary.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monetary.Common.Models
{
    public class MonetaryOutput
    {
        public Decision Decision { get; set; }
        public float InterestRate { get; set; }
    }
}
