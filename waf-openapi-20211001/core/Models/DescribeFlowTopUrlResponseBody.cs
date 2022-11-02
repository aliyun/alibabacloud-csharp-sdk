// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowTopUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleHitsTopUrl")]
        [Validation(Required=false)]
        public List<DescribeFlowTopUrlResponseBodyRuleHitsTopUrl> RuleHitsTopUrl { get; set; }
        public class DescribeFlowTopUrlResponseBodyRuleHitsTopUrl : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
