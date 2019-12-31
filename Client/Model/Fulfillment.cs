using System;
using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class Fulfillment
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string RecipientName { get; set; }
        public string DeliveryEmail { get; set; }
        public string FulfillmentStatus { get; set; }
        public string ShipmentStatus { get; set; }
        public string ShippingCarrier { get; set; }
        public IList<string> TrackingNumbers { get; set; }
        public IList<string> TrackingUrls { get; set; }
        public IList<Product> Products { get; set; }
    }
}