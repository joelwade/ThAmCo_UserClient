using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class OrderPage
    {
        public IEnumerable<Cart> cart { get; set; }
        public IEnumerable<Order> orders { get; set; }
    }
}
