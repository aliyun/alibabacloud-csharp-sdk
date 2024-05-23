// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20160722.Models
{
    public class DescribeScalingRulesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public DescribeScalingRulesResponseBodyScalingRules ScalingRules { get; set; }
        public class DescribeScalingRulesResponseBodyScalingRules : TeaModel {
            [NameInMap("ScalingRule")]
            [Validation(Required=false)]
            public List<DescribeScalingRulesResponseBodyScalingRulesScalingRule> ScalingRule { get; set; }
            public class DescribeScalingRulesResponseBodyScalingRulesScalingRule : TeaModel {
                [NameInMap("AdjustmentType")]
                [Validation(Required=false)]
                public string AdjustmentType { get; set; }

                [NameInMap("AdjustmentValue")]
                [Validation(Required=false)]
                public int? AdjustmentValue { get; set; }

                [NameInMap("Cooldown")]
                [Validation(Required=false)]
                public int? Cooldown { get; set; }

                [NameInMap("MaxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                [NameInMap("MinSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                [NameInMap("ScalingGroupId")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                [NameInMap("ScalingRuleAri")]
                [Validation(Required=false)]
                public string ScalingRuleAri { get; set; }

                [NameInMap("ScalingRuleId")]
                [Validation(Required=false)]
                public string ScalingRuleId { get; set; }

                [NameInMap("ScalingRuleName")]
                [Validation(Required=false)]
                public string ScalingRuleName { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
