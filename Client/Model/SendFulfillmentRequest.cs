using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class SendFulfillmentRequest
    {
        public IList<Fulfillment> Fulfillments { get; set; }
    }
}