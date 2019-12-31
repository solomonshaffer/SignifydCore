using System;
using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class Purchase
    {
        public string OrderSessionId { get; set; }
        public string OrderId { get; set; }
        public string CheckoutToken { get; set; }
        public string BrowserIpAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Currency { get; set; }
        public string OrderChannel { get; set; }
        public string ReceivedBy { get; set; }
        public double TotalPrice { get; set; }
        public IList<Product> Products { get; set; }
        public IList<DiscountCode> DiscountCodes { get; set; }
        public IList<Shipment> Shipments { get; set; }
    }
}