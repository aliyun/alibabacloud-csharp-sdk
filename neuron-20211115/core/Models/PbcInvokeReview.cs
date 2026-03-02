// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcInvokeReview : TeaModel {
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("invokeId")]
        [Validation(Required=false)]
        public long? InvokeId { get; set; }

        [NameInMap("invokePbcId")]
        [Validation(Required=false)]
        public long? InvokePbcId { get; set; }

        [NameInMap("invokePbcName")]
        [Validation(Required=false)]
        public string InvokePbcName { get; set; }

        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

        [NameInMap("pbcName")]
        [Validation(Required=false)]
        public string PbcName { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("reviewer")]
        [Validation(Required=false)]
        public string Reviewer { get; set; }

        [NameInMap("reviewerId")]
        [Validation(Required=false)]
        public string ReviewerId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
