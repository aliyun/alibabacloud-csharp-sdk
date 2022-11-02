// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFlowTopResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleHitsTopResource")]
        [Validation(Required=false)]
        public List<DescribeFlowTopResourceResponseBodyRuleHitsTopResource> RuleHitsTopResource { get; set; }
        public class DescribeFlowTopResourceResponseBodyRuleHitsTopResource : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

    }

}
