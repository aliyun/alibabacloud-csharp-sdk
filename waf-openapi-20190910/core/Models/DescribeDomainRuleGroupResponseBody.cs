// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeDomainRuleGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleGroupId")]
        [Validation(Required=false)]
        public long? RuleGroupId { get; set; }

        [NameInMap("WafAiStatus")]
        [Validation(Required=false)]
        public int? WafAiStatus { get; set; }

    }

}
