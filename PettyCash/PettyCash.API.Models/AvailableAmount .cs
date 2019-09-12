using System;
using System.Collections.Generic;
using System.Text;

namespace PettyCash.API.Models
{
    public class AvailableAmount : BaseEntity
    {
        public double NewAmount { get; set; }
        public double OverallBalance { get; set; }
        public string DepositedUserId { get; set; }
    }
}
