using System.Collections.Generic;

namespace Heads.Stock
{
    public class StockReservationResponse
    {
        /// <summary>
        /// Unique identity of the reservation we respond to.
        /// </summary>
        public string ReservationId { get; set; }

        /// <summary>
        /// Deviations detected, such as products whose stock is not enough to cover
        /// a requested reservation.
        /// </summary>
        public IEnumerable<StockReservationDeviation> Deviations { get; set; }
    }
}

