using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Entities
{
    public class OrderEntity
    {
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public List<OrderItemEntity> Orders { get; set; } = [];
        public OrderStatus OrderStatus { get; set; }
    }
    public enum OrderStatus
    {
        Pending = 1,      
        Processing,   
        Shipped,     
        Delivered, 
        Cancelled  
    }
}
