using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class WebhooksResponse
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Event EventType { get; set; }
        public Team Team { get; set; }
        public string EventDisplayText { get; set; }
    }
}
