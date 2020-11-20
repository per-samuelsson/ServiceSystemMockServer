using System.Collections.Generic;

namespace Storm.Connect.Order
{
    public class OrderItem
    {
        public IList<CodeValue> AdditionalInfo { get; set; }

        public string Comment { get; set; }

        public string Description { get; set; }

        public decimal Discount { get; set; }

        public string ErpPartNo { get; set; }

        public int InternalProductId { get; set; }

        public int LineNo { get; set; }

        public int? ParentLineNo { get; set; }

        public string PartNo { get; set; }

        public int? PriceListNo { get; set; }

        public IList<PriceListItem> PriceLists { get; set; }

        public IList<Promotion> Promotions { get; set; }
        
        public int Quantity { get; set; }

        public decimal? Quantity2 { get; set; }

        public string Type { get; set; }

        public string TypeGroup { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitPriceOriginal { get; set; }

        public decimal UnitVat { get; set; }

        public decimal VatRate { get; set; }
    }
}