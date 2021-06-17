using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Monetary.Common.Models
{
    public class MonetaryInput
    {
        [Required]
        public int CreditAmount { get; set; }
        [Required]
        public int Term { get; set; }
        [Required]
        public int ExistingAmount { get; set; }
    }
}
