using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class SendFulfillmentResponse
    {
        public IList<Fulfillment> Fulfillments { get; set; }
    }
}