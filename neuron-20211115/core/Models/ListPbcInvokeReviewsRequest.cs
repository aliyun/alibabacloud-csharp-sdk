// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListPbcInvokeReviewsRequest : TeaModel {
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public int? OrderDirection { get; set; }

        [NameInMap("orderby")]
        [Validation(Required=false)]
        public int? Orderby { get; set; }

        [NameInMap("reviewer")]
        [Validation(Required=false)]
        public string Reviewer { get; set; }

    }

}
