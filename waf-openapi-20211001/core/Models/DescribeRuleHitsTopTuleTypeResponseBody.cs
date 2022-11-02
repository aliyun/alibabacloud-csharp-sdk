// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopTuleTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleHitsTopTuleType")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType> RuleHitsTopTuleType { get; set; }
        public class DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

    }

}
