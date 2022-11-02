// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeMajorProtectionBlackIpsResponseBody : TeaModel {
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<DescribeMajorProtectionBlackIpsResponseBodyIpList> IpList { get; set; }
        public class DescribeMajorProtectionBlackIpsResponseBodyIpList : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
