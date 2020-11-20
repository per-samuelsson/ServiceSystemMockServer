using System.Collections.Generic;

namespace Storm.Connect.Order
{
    public class Payment
    {
        public IList<CodeValue> AdditionalInfo { get; set; }

        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; }

        public int PaymentCode { get; set; }

        public string PaymentMethodCode { get; set; }

        public string PaymentRef { get; set;}
    }
}