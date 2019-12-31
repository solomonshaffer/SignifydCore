using System;
using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class Seller
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Domain { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AccountNumber { get; set; }
        public int AggregateOrderCount { get; set; }
        public double AggregateOrderDollars { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string OnboardingIpAddress { get; set; }
        public string OnboardingEmail { get; set; }
        public IList<string> Tags { get; set; }
        public string Rating { get; set; }
        public Address ShipFromAddress { get; set; }
        public Address CorporateAddress { get; set; }
    }
}