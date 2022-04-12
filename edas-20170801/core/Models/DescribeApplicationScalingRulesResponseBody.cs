// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeApplicationScalingRulesResponseBody : TeaModel {
        [NameInMap("AppScalingRules")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRulesResponseBodyAppScalingRules AppScalingRules { get; set; }
        public class DescribeApplicationScalingRulesResponseBodyAppScalingRules : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult> Result { get; set; }
            public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResult : TeaModel {
                public string AppId { get; set; }
                public long? CreateTime { get; set; }
                public long? LastDisableTime { get; set; }
                public int? MaxReplicas { get; set; }
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetric Metric { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetric : TeaModel {
                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetricMetrics> Metrics { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultMetricMetrics : TeaModel {
                        [NameInMap("MetricTargetAverageUtilization")]
                        [Validation(Required=false)]
                        public int? MetricTargetAverageUtilization { get; set; }

                        [NameInMap("MetricType")]
                        [Validation(Required=false)]
                        public string MetricType { get; set; }

                    }

                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                }
                public int? MinReplicas { get; set; }
                public bool? ScaleRuleEnabled { get; set; }
                public string ScaleRuleName { get; set; }
                public string ScaleRuleType { get; set; }
                public DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger Trigger { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTrigger : TeaModel {
                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                    [NameInMap("Triggers")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTriggerTriggers> Triggers { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyAppScalingRulesResultTriggerTriggers : TeaModel {
                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public string MetaData { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }
                public long? UpdateTime { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
