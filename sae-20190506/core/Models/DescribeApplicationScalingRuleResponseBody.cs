// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationScalingRuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRuleResponseBodyData Data { get; set; }
        public class DescribeApplicationScalingRuleResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public DescribeApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class DescribeApplicationScalingRuleResponseBodyDataMetric : TeaModel {
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                }

                [NameInMap("MetricsStatus")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus MetricsStatus { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus : TeaModel {
                    [NameInMap("CurrentMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics> CurrentMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics : TeaModel {
                        public long? CurrentValue { get; set; }
                        public string Name { get; set; }
                        public string Type { get; set; }
                    }
                    [NameInMap("CurrentReplicas")]
                    [Validation(Required=false)]
                    public long? CurrentReplicas { get; set; }
                    [NameInMap("DesiredReplicas")]
                    [Validation(Required=false)]
                    public long? DesiredReplicas { get; set; }
                    [NameInMap("LastScaleTime")]
                    [Validation(Required=false)]
                    public string LastScaleTime { get; set; }
                    [NameInMap("NextScaleMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics> NextScaleMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics : TeaModel {
                        public string Name { get; set; }
                        public int? NextScaleInAverageUtilization { get; set; }
                        public int? NextScaleOutAverageUtilization { get; set; }
                    }
                    [NameInMap("NextScaleTimePeriod")]
                    [Validation(Required=false)]
                    public int? NextScaleTimePeriod { get; set; }
                };

                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                [NameInMap("ScaleDownRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules ScaleDownRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules : TeaModel {
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }
                };

                [NameInMap("ScaleUpRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules ScaleUpRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules : TeaModel {
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }
                };

            }
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public DescribeApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class DescribeApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                [NameInMap("BeginDate")]
                [Validation(Required=false)]
                public string BeginDate { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    [NameInMap("AtTime")]
                    [Validation(Required=false)]
                    public string AtTime { get; set; }

                    [NameInMap("TargetReplicas")]
                    [Validation(Required=false)]
                    public int? TargetReplicas { get; set; }

                }

            }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
