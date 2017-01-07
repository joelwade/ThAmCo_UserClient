using Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayRepo
{
    public interface IGatewayRepo
    {
        StorePage GetStore();
        OrderPage GetOrders();
    }
}
