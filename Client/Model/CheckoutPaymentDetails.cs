namespace SignifydCore.Client.Model
{
    public class CheckoutPaymentDetails
    {
        public string HolderName { get; set; }
        public string CardBin { get; set; }
        public string CardLast4 { get; set; }
        public int? CardExpiryMonth { get; set; }
        public int? CardExpiryYear { get; set; }
        public object BankAccountNumber { get; set; }
        public object BankRoutingNumber { get; set; }
        public Address BillingAddress { get; set; }
    }
}