namespace Storm.Connect.Order
{
    public class Fee
    {
        public decimal Amount { get; set; }
        
        public string Description { get; set; }
        
        public int Type { get; set; }	// Shipping = 0, Invoice = 1
        
        public decimal VatRate { get; set; }
    }
}