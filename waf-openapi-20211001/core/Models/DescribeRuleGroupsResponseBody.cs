// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleGroups")]
        [Validation(Required=false)]
        public List<DescribeRuleGroupsResponseBodyRuleGroups> RuleGroups { get; set; }
        public class DescribeRuleGroupsResponseBodyRuleGroups : TeaModel {
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("RuleGroupId")]
            [Validation(Required=false)]
            public long? RuleGroupId { get; set; }

            [NameInMap("RuleGroupName")]
            [Validation(Required=false)]
            public string RuleGroupName { get; set; }

            [NameInMap("RuleTotalCount")]
            [Validation(Required=false)]
            public int? RuleTotalCount { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
