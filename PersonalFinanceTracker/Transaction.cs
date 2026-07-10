using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinanceTracker
{
    public class Transaction
    {
        public DateTime Date { get; set; }

        public string Type { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public string Notes { get; set; } = string.Empty;
    }
}
