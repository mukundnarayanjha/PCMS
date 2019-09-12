using System;
using System.Collections.Generic;
using System.Text;

namespace PettyCash.API.Models
{
    public class DailyExpense : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public double Amount { get; set; }
        public string ReceivedUserId { get; set; }
        public string Description { get; set; }        
    }
}
