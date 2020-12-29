// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeDispatchRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public DescribeDispatchRuleResponseBodyDispatchRule DispatchRule { get; set; }
        public class DescribeDispatchRuleResponseBodyDispatchRule : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
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

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                    }

                }

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("GroupRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleGroupRules> GroupRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleGroupRules : TeaModel {
                public List<string> GroupingFields { get; set; }
                public long? GroupId { get; set; }
                public long? GroupInterval { get; set; }
                public long? GroupWaitTime { get; set; }
            }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
            [NameInMap("NotifyRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules> NotifyRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules : TeaModel {
                public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects> NotifyObjects { get; set; }
                public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects : TeaModel {
                    public string NotifyObjectId { get; set; }
                    public string NotifyType { get; set; }
                    public string Name { get; set; }
                }
                public List<string> NotifyChannels { get; set; }
            }
        };

    }

}
