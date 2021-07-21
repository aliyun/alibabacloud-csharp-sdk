// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertingMetricRuleResourcesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeAlertingMetricRuleResourcesResponseBodyResources Resources { get; set; }
        public class DescribeAlertingMetricRuleResourcesResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResource : TeaModel {
                public string MetricName { get; set; }
                public string RetryTimes { get; set; }
                public string MetricValues { get; set; }
                public string Namespace { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
                public string ProductCategory { get; set; }
                public string StartTime { get; set; }
                public string Resource { get; set; }
                public string LastModifyTime { get; set; }
                public string GroupId { get; set; }
                public string Dimensions { get; set; }
                public string LastAlertTime { get; set; }
                public int? Level { get; set; }
                public string Threshold { get; set; }
                public string Statistics { get; set; }
                public string Enable { get; set; }
                public DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation Escalation { get; set; }
                public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalation : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource> Resource { get; set; }
                    public class DescribeAlertingMetricRuleResourcesResponseBodyResourcesResourceEscalationResource : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("PreCondition")]
                        [Validation(Required=false)]
                        public string PreCondition { get; set; }

                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public int? Times { get; set; }

                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public int? Level { get; set; }

                    }

                }
            }
        };

    }

}
