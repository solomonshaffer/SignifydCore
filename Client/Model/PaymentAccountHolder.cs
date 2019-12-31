using System;

namespace SignifydCore.Client.Model
{
    public class PaymentAccountHolder
    {
        public DateTime? AccountCreatedAt { get; set; }
        public string AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountHolderPhone { get; set; }
        public string AccountHolderEmail { get; set; }
        public string AccountHolderDob { get; set; }
        public object AccountHolderAnnualIncome { get; set; }
        public bool? AccountIsVerified { get; set; }
        public bool? AccountIsActive { get; set; }
        public object AccountCreditLine { get; set; }
        public int? AccountBalance { get; set; }
        public Address BillingAddress { get; set; }
    }
}