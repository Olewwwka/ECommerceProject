using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Entities
{
    public class OrderItemEntity
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public int Quantity { get; set; } = 0;
        public decimal UnitPrice { get; set; } = 0;
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
