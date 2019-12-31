using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SignifydCore.Client.Model
{
    public enum GuaranteeDisposition
    {
        Approved,
        Declined,
        Pending,
        Cancelled,
        [Description("In_Review")] InReview
    }

    public enum Status
    {
        Open,
        Dismissed
    }

    public enum ReviewDisposition
    {
        Good,
        Fraudulent,
        Unset
    }

    public enum Event
    {
        [Description("Case_Creation")] CaseCreation,
        [Description("Case_Rescore")] CaseRescore,
        [Description("Case_Review")] CaseReview,
        [Description("Guarentee_Completion")] GuarenteeCompletion,
        [Description("Claim_Reviewed")] ClaimReviewed
    }
}
