using System.Collections.Generic;

namespace Storm.Connect.Order
{
    public class PickupStore
    {
        public IList<CodeValue> AdditionalInfo { get; set; }

        public Address Address { get; set; }

        public string Code { get; set; }

        public bool IsDropPoint { get; set; }

        public string Name { get; set; }
    }
}