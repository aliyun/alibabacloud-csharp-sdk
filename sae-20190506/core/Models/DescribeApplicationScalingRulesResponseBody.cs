// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationScalingRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRulesResponseBodyData Data { get; set; }
        public class DescribeApplicationScalingRulesResponseBodyData : TeaModel {
            [NameInMap("ApplicationScalingRules")]
            [Validation(Required=false)]
            public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRules> ApplicationScalingRules { get; set; }
            public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRules : TeaModel {
                public string AppId { get; set; }
                public long? CreateTime { get; set; }
                public long? LastDisableTime { get; set; }
                public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetric Metric { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetric : TeaModel {
                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetrics> Metrics { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetrics : TeaModel {
                        [NameInMap("MetricTargetAverageUtilization")]
                        [Validation(Required=false)]
                        public int? MetricTargetAverageUtilization { get; set; }

                        [NameInMap("MetricType")]
                        [Validation(Required=false)]
                        public string MetricType { get; set; }

                    }

                    [NameInMap("MetricsStatus")]
                    [Validation(Required=false)]
                    public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatus MetricsStatus { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatus : TeaModel {
                        [NameInMap("CurrentMetrics")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusCurrentMetrics> CurrentMetrics { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusCurrentMetrics : TeaModel {
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
                        [NameInMap("MaxReplicas")]
                        [Validation(Required=false)]
                        public long? MaxReplicas { get; set; }
                        [NameInMap("MinReplicas")]
                        [Validation(Required=false)]
                        public long? MinReplicas { get; set; }
                        [NameInMap("NextScaleMetrics")]
                        [Validation(Required=false)]
                        public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusNextScaleMetrics> NextScaleMetrics { get; set; }
                        public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricMetricsStatusNextScaleMetrics : TeaModel {
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
                    public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleDownRules ScaleDownRules { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleDownRules : TeaModel {
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
                    public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleUpRules ScaleUpRules { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesMetricScaleUpRules : TeaModel {
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
                public bool? ScaleRuleEnabled { get; set; }
                public string ScaleRuleName { get; set; }
                public string ScaleRuleType { get; set; }
                public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimer Timer { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimer : TeaModel {
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
                    public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimerSchedules> Schedules { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimerSchedules : TeaModel {
                        [NameInMap("AtTime")]
                        [Validation(Required=false)]
                        public string AtTime { get; set; }

                        [NameInMap("MaxReplicas")]
                        [Validation(Required=false)]
                        public long? MaxReplicas { get; set; }

                        [NameInMap("MinReplicas")]
                        [Validation(Required=false)]
                        public long? MinReplicas { get; set; }

                        [NameInMap("TargetReplicas")]
                        [Validation(Required=false)]
                        public int? TargetReplicas { get; set; }

                    }

                }
                public long? UpdateTime { get; set; }
            }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
