using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class SendTransactionResponse
    {
        public string CheckoutToken { get; set; }
        public IList<Transaction> Transactions { get; set; }
    }
}