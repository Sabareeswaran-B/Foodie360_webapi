using System;
using System.Collections.Generic;

namespace Foodie360.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderedItems = new HashSet<OrderedItem>();
        }

        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public int? TotalPrice { get; set; }
        public DateTime? OrderedAt { get; set; }
        public string? Active { get; set; }
        public int? OrderStatus { get; set; }

        public virtual OrderStatus? OrderStatusNavigation { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<OrderedItem> OrderedItems { get; set; }
    }
}
