using System.ComponentModel;

namespace SignifydCore.Client.Model
{
    public class Webhook
    {
        public Event Event { get; set; }
        public string Url { get; set; }
    }
}
