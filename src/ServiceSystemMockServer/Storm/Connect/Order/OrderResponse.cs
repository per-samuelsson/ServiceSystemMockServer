namespace Storm.Connect.Order
{
    public class OrderResponse
    {
        public string Description { get; set; }

        public string ErpOrderNo { get; set; }

        public bool HasErpOrderNo { get; set; }

        public string StatusCode { get; set; }
    }
}