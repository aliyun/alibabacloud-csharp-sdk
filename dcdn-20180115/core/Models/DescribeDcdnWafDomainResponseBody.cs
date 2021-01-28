// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OutPutDomains")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDomainResponseBodyOutPutDomains> OutPutDomains { get; set; }
        public class DescribeDcdnWafDomainResponseBodyOutPutDomains : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("CcStatus")]
            [Validation(Required=false)]
            public int? CcStatus { get; set; }

            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public int? AclStatus { get; set; }

            [NameInMap("WafStatus")]
            [Validation(Required=false)]
            public int? WafStatus { get; set; }

        }

    }

}
