using System;
using System.Collections.Generic;

namespace Foodie360.Models
{
    public partial class OrderedItem
    {
        public int ItemId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public string? Active { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
