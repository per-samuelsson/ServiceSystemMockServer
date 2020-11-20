namespace Heads.Stock
{
    public class StockReservationDeviation
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Total number of products currently in stock
        /// </summary>
        public decimal InStock { get; set; }

        /// <summary>
        /// Reserved number of products
        /// </summary>
        public decimal Reserved { get; set; }

    }
}

