using System;
using System.ComponentModel;

namespace SignifydCore.Client.Model
{
    public class GetCaseResponse
    {
        public GuaranteeDisposition GuaranteeDisposition { get; set; }
        public int InvestigationId { get; set; }
        public int CaseId { get; set; }
        public string Headline { get; set; }
        public Guid Uuid { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status Status { get; set; }
        public ReviewDisposition ReviewDisposition { get; set; }
        public string OrderId { get; set; }
        public decimal OrderAmount { get; set; }
        public string Currency { get; set; }
        public int Score { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool TestInvestigation { get; set; }
        public bool GuaranteeEligible { get; set; }
    }
}