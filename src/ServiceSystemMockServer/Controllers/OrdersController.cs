using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Storm.Connect.Order;

namespace ServiceSystemMockServer.Controllers
{
    public class Order
    {
        public string Id { get; init; }
    }
    
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        static readonly IList<Order> _orders = new List<Order>();

        [HttpGet]
        public IEnumerable<Order> Get() => _orders;

        [HttpPost]
        public OrderResponse Post(OrderRequest orderRequest)
        {
            var order = new Order()
            {
                Id = orderRequest.ClientOrderRef + "-" + _orders.Count.ToString()
            };

            _orders.Add(order);

            return new OrderResponse()
            {
                StatusCode = "OK",
                Description = "No error",
                HasErpOrderNo = true,
                ErpOrderNo = order.Id
            };
        }
    }
}
