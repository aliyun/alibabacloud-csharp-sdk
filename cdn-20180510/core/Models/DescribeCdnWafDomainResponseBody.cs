// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnWafDomainResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OutPutDomains")]
        [Validation(Required=false)]
        public List<DescribeCdnWafDomainResponseBodyOutPutDomains> OutPutDomains { get; set; }
        public class DescribeCdnWafDomainResponseBodyOutPutDomains : TeaModel {
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("CcStatus")]
            [Validation(Required=false)]
            public string CcStatus { get; set; }

            [NameInMap("WafStatus")]
            [Validation(Required=false)]
            public string WafStatus { get; set; }

        }

    }

}
