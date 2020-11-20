namespace Storm.Connect.Order
{
    public class PriceListItem
    {
        public bool IsActive { get; set; }
        
        public bool IsStandardPriceList { get; set; }

        public string PriceListName { get; set; }

        public int QtyBreak { get; set; }

        public decimal UnitPrice { get; set; }
    }
}