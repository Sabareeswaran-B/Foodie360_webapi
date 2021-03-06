using System;
using System.Collections.Generic;

namespace Foodie360.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? Active { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
