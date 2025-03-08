using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Entities
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public int StockQuantity { get; set; } = 0; 
    }
}
