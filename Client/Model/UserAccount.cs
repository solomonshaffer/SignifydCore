using System;

namespace SignifydCore.Client.Model
{
    public class UserAccount
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AccountNumber { get; set; }
        public string LastOrderId { get; set; }
        public int AggregateOrderCount { get; set; }
        public int AggregateOrderDollars { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string Rating { get; set; }
    }
}