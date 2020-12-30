// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeDomainBasicConfigsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeDomainBasicConfigsResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeDomainBasicConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("CcMode")]
            [Validation(Required=false)]
            public int? CcMode { get; set; }

            [NameInMap("CcStatus")]
            [Validation(Required=false)]
            public int? CcStatus { get; set; }

            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public int? AclStatus { get; set; }

            [NameInMap("WafStatus")]
            [Validation(Required=false)]
            public int? WafStatus { get; set; }

            [NameInMap("WafMode")]
            [Validation(Required=false)]
            public int? WafMode { get; set; }

        }

    }

}
