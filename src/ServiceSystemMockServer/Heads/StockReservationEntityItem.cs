namespace Heads.Stock
{
    public class StockReservationEntityItem
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Number of products to reserve
        /// </summary>
        public decimal Quantity { get; set; }
    }
}

