using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Entities
{
    public class ShoppingCartEntity
    {
        public int CartId { get; set; }
        public int UserId {  get; set; }
        public List<ProductEntity> Products { get; set; } = [];
    }
}
