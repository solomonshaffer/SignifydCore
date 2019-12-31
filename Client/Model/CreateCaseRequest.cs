using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class CreateCaseRequest
    {
        public Purchase Purchase { get; set; }
        public IList<Recipient> Recipients { get; set; }
        public IList<Transaction> Transactions { get; set; }
        public string CustomerOrderRecommendation { get; set; }
        public IList<string> Tags { get; set; }
        public UserAccount UserAccount { get; set; }
        public Seller Seller { get; set; }
    }
}