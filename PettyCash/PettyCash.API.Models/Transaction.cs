using System;
using System.Collections.Generic;
using System.Text;

namespace PettyCash.API.Models
{
    public class Transaction : BaseEntity
    {
        public double? IncomeMoneyIn { get; set; }
        public double? ExpenseMoneyOut { get; set; }
        public double OverallBalance { get; set; }
        public string Description{ get; set; }
        public string ModeOfType { get; set; }       

    }
}
