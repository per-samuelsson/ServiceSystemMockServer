using System.Linq;
using Heads.Stock;
using Microsoft.AspNetCore.Mvc;

namespace ServiceSystemMockServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockReservationsController : ControllerBase
    {
        [HttpPost]
        public StockReservationResponse Post(StockReservationEntity stockReservation)
        {
            if (stockReservation.Products.Any(p => p.ProductId == "123"))
            {
                return new StockReservationResponse()
                {
                    ReservationId = stockReservation.ReservationId,
                    Deviations = new []
                    {
                        new StockReservationDeviation()
                        {
                            ProductId = "123",
                            InStock = 0,
                            Reserved = 42
                        }
                    }
                };
            }

            return new StockReservationResponse()
            {
                ReservationId = stockReservation.ReservationId
            };
        }
    }
}
