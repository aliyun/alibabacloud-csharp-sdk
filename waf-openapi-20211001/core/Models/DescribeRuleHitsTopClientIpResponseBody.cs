// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopClientIpResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleHitsTopClientIp")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopClientIpResponseBodyRuleHitsTopClientIp> RuleHitsTopClientIp { get; set; }
        public class DescribeRuleHitsTopClientIpResponseBodyRuleHitsTopClientIp : TeaModel {
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

    }

}
