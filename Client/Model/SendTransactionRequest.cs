using System.Collections.Generic;

namespace SignifydCore.Client.Model
{
    public class SendTransactionRequest
    {
        public string CheckoutToken { get; set; }
        public IList<Transaction> Transactions { get; set; }
    }
}