using RoutingExample.Attributes;
using RoutingExample.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class Order_V1Controller : ApiController
    {
        [VersionedRoute("api/Order", 1)]
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return null;
        }
    }
}