using System.Collections.Generic;

namespace Heads.Stock
{
    public class StockReservationEntity
    {
        /// <summary>
        /// Unique identifier of the shop whose stock the reservation target.
        /// </summary>
        public string ShopId { get; set; }
        
        /// <summary>
        /// Identifier of client asking for the stock to be reserved, to allow tracability.
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Identity of this reservation.
        /// </summary>
        public string ReservationId { get; set; }

        /// <summary>
        /// The products to reserve
        /// </summary>
        public IEnumerable<StockReservationEntityItem> Products { get; set; }
    }
}

