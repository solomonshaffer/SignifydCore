using System;

namespace SignifydCore.Client.Model
{
    public class CancelGuaranteeResponse
    {
        public string Disposition { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime ReviewedAt { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime SubmittedAt { get; set; }
        public int RereviewCount { get; set; }
        public int CaseId { get; set; }
        public int GuaranteeId { get; set; }
    }
}