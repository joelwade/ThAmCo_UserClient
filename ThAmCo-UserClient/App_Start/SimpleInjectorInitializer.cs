using GatewayRepo;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThAmCo_UserClient.App_Start
{
    public class SimpleInjectorInitializer
    {
        public static void SimpleInjectorInitalizer()
        {
            var container = new Container();

            // Register your types, for instance:
            container.Register<IGatewayRepo, ConcGatewayRepo>(Lifestyle.Scoped);

            container.Verify();
        }
    }
}