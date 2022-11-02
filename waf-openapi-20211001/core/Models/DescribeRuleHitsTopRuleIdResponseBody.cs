// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopRuleIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleHitsTopRuleId")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopRuleIdResponseBodyRuleHitsTopRuleId> RuleHitsTopRuleId { get; set; }
        public class DescribeRuleHitsTopRuleIdResponseBodyRuleHitsTopRuleId : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
