// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcInvokeCreateCmd : TeaModel {
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("invokePbcId")]
        [Validation(Required=false)]
        public long? InvokePbcId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

        [NameInMap("reviewer")]
        [Validation(Required=false)]
        public string Reviewer { get; set; }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

        [NameInMap("visible")]
        [Validation(Required=false)]
        public bool? Visible { get; set; }

    }

}
