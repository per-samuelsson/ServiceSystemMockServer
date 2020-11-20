namespace Storm.Connect.Order
{
    public class ShippingAdvice
    {
        public string DeliveryMethodCode { get; set; }

        public bool DoSMSNotify { get; set; }

        public bool IsComplete { get; set; }

        public bool IsFeeChargedOnce { get; set; }

        public PickupStore PickupStore { get; set; }

        public string ShipAdvisorOrderCode { get; set; }
    }
}