// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopUaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleHitsTopUa")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopUaResponseBodyRuleHitsTopUa> RuleHitsTopUa { get; set; }
        public class DescribeRuleHitsTopUaResponseBodyRuleHitsTopUa : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Ua")]
            [Validation(Required=false)]
            public string Ua { get; set; }

        }

    }

}
