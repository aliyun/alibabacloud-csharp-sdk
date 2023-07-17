// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class DescribeDispatchRuleResponseBody : TeaModel {
        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public DescribeDispatchRuleResponseBodyDispatchRule DispatchRule { get; set; }
        public class DescribeDispatchRuleResponseBodyDispatchRule : TeaModel {
            [NameInMap("GroupRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleGroupRules> GroupRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleGroupRules : TeaModel {
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupInterval")]
                [Validation(Required=false)]
                public long? GroupInterval { get; set; }

                [NameInMap("GroupWaitTime")]
                [Validation(Required=false)]
                public long? GroupWaitTime { get; set; }

                [NameInMap("GroupingFields")]
                [Validation(Required=false)]
                public List<string> GroupingFields { get; set; }

            }

            [NameInMap("LabelMatchExpressionGrid")]
            [Validation(Required=false)]
            public DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGrid LabelMatchExpressionGrid { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGrid : TeaModel {
                [NameInMap("LabelMatchExpressionGroups")]
                [Validation(Required=false)]
                public List<DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroups> LabelMatchExpressionGroups { get; set; }
                public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroups : TeaModel {
                    [NameInMap("LabelMatchExpressions")]
                    [Validation(Required=false)]
                    public List<DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions> LabelMatchExpressions { get; set; }
                    public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NotifyRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules> NotifyRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules : TeaModel {
                [NameInMap("NotifyChannels")]
                [Validation(Required=false)]
                public List<string> NotifyChannels { get; set; }

                [NameInMap("NotifyObjects")]
                [Validation(Required=false)]
                public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects> NotifyObjects { get; set; }
                public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("NotifyObjectId")]
                    [Validation(Required=false)]
                    public string NotifyObjectId { get; set; }

                    [NameInMap("NotifyType")]
                    [Validation(Required=false)]
                    public string NotifyType { get; set; }

                }

            }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
