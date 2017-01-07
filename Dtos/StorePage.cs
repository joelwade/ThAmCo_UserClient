using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class StorePage
    {
        public IEnumerable<Cart> cart { get; set; }
        public IEnumerable<GiftBox> giftBoxes { get; set; }
    }
}