// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRecommendTaskDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeRecommendTaskDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeRecommendTaskDetailResponseBodyResultObject : TeaModel {
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("expectVelocities")]
            [Validation(Required=false)]
            public List<string> ExpectVelocities { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("normalSize")]
            [Validation(Required=false)]
            public long? NormalSize { get; set; }

            [NameInMap("recommendRuleDTOs")]
            [Validation(Required=false)]
            public List<DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOs> RecommendRuleDTOs { get; set; }
            public class DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOs : TeaModel {
                [NameInMap("computeExpression")]
                [Validation(Required=false)]
                public string ComputeExpression { get; set; }

                [NameInMap("hitSample")]
                [Validation(Required=false)]
                public long? HitSample { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("notHitSample")]
                [Validation(Required=false)]
                public long? NotHitSample { get; set; }

                [NameInMap("recommendRules")]
                [Validation(Required=false)]
                public List<DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOsRecommendRules> RecommendRules { get; set; }
                public class DescribeRecommendTaskDetailResponseBodyResultObjectRecommendRuleDTOsRecommendRules : TeaModel {
                    [NameInMap("left")]
                    [Validation(Required=false)]
                    public string Left { get; set; }

                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("right")]
                    [Validation(Required=false)]
                    public string Right { get; set; }

                }

                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("velocities")]
                [Validation(Required=false)]
                public string Velocities { get; set; }

            }

            [NameInMap("recommendVariableDTOs")]
            [Validation(Required=false)]
            public List<DescribeRecommendTaskDetailResponseBodyResultObjectRecommendVariableDTOs> RecommendVariableDTOs { get; set; }
            public class DescribeRecommendTaskDetailResponseBodyResultObjectRecommendVariableDTOs : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("riskSize")]
            [Validation(Required=false)]
            public long? RiskSize { get; set; }

            [NameInMap("sampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

            [NameInMap("sampleScene")]
            [Validation(Required=false)]
            public string SampleScene { get; set; }

            [NameInMap("sampleSceneName")]
            [Validation(Required=false)]
            public string SampleSceneName { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

    }

}
