using System;

namespace SignifydCore.Client.Model
{
    public class Transaction
    {
        public string ParentTransactionId { get; set; }
        public string TransactionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Gateway { get; set; }
        public string PaymentMethod { get; set; }
        public string Type { get; set; }
        public string GatewayStatusCode { get; set; }
        public string GatewayStatusMessage { get; set; }
        public string GatewayErrorCode { get; set; }
        public string Currency { get; set; }
        public int Amount { get; set; }
        public string AvsResponseCode { get; set; }
        public string CvvResponseCode { get; set; }
        public string PaypalPendingReasonCode { get; set; }
        public string PaypalProtectionEligibility { get; set; }
        public string PaypalProtectionEligibilityType { get; set; }
        public CheckoutPaymentDetails CheckoutPaymentDetails { get; set; }
        public PaymentAccountHolder PaymentAccountHolder { get; set; }
    }
}