// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeRuleGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleGroups")]
        [Validation(Required=false)]
        public List<DescribeRuleGroupsResponseBodyRuleGroups> RuleGroups { get; set; }
        public class DescribeRuleGroupsResponseBodyRuleGroups : TeaModel {
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public List<string> DomainList { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            [NameInMap("RuleCnt")]
            [Validation(Required=false)]
            public int? RuleCnt { get; set; }

            [NameInMap("RuleGroupTemplateName")]
            [Validation(Required=false)]
            public string RuleGroupTemplateName { get; set; }

            [NameInMap("RuleGroupUpdateTime")]
            [Validation(Required=false)]
            public long? RuleGroupUpdateTime { get; set; }

            [NameInMap("TemplatePolicyId")]
            [Validation(Required=false)]
            public long? TemplatePolicyId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("WafVersion")]
            [Validation(Required=false)]
            public long? WafVersion { get; set; }

        }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("WafTaskId")]
        [Validation(Required=false)]
        public string WafTaskId { get; set; }

    }

}
