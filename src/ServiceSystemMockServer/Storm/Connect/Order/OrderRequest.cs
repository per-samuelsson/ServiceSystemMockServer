using System.Collections.Generic;

namespace Storm.Connect.Order
{
    public class OrderRequest
    {
        public ClientCustomer BillTo { get; set; }

        public string ClientOrderRef { get; set; }

        public string CurrencyCode { get; set; }

        public string CustomerOrderComment { get; set; }

        public string CustomerOrderRef { get; set; }

        public IList<Discount> Discounts { get; set; }

        public Header Header { get; set; }

        public IList<OrderItem> Items { get; set; }

        public IList<Payment> Payments { get; set; }

        public string SalesContactCode { get; set; }

        public string SalesContactDivision { get; set; }

        public ClientCustomer SellTo { get; set; }

        public ClientCustomer ShipTo { get; set; }

        public ShippingAdvice ShippingAdvice { get; set; }

        public string Source { get; set; }

        // Storm send values like "2020-11-17 14:19:47", that is not a 
        // ISO standard, and hence isn't supported by default deserializer
        // TODO:
        public string SubmitDate { get; set; }
    }
}