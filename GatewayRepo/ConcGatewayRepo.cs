using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos;
using RestSharp;
using Newtonsoft.Json;

namespace GatewayRepo
{
    public class ConcGatewayRepo : IGatewayRepo
    {
        string gatewayUrl = "http://localhost:4356/";
        public OrderPage GetOrders()
        {
            throw new NotImplementedException();
        }

        public StorePage GetStore()
        {
            string storePageUrl = "api/getStorePage?userId=";

            var client = new RestClient(gatewayUrl);
            var request = new RestRequest(storePageUrl, Method.GET);
            var queryResult = client.Execute(request);

            dynamic page = JsonConvert.DeserializeObject<StorePage>(queryResult.Content);
            return page;
        }
    }
}
