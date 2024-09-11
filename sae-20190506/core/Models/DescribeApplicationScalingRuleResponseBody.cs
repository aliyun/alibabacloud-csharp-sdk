// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationScalingRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRuleResponseBodyData Data { get; set; }
        public class DescribeApplicationScalingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The time when the auto scaling policy was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            /// <summary>
            /// The time when the auto scaling policy was last disabled.
            /// </summary>
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            /// <summary>
            /// The details of the metric-based auto scaling policy.
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public DescribeApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class DescribeApplicationScalingRuleResponseBodyDataMetric : TeaModel {
                /// <summary>
                /// The maximum number of instances.
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// The list of metrics that are used to trigger the auto scaling policy.
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    /// <summary>
                    /// The limit on the metric.
                    /// 
                    /// *   The limit on the CPU utilization. Unit: percentage.
                    /// *   The limit on the memory usage. Unit: percentage.
                    /// *   The limit on the average number of active TCP connections per second.
                    /// *   The limit on the QPS of the Internet-facing SLB instance.
                    /// *   The limit on the response time of the Internet-facing SLB instance. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    /// <summary>
                    /// The metric that is used to trigger the auto scaling policy. Valid values:
                    /// 
                    /// *   **CPU**: the CPU utilization.
                    /// *   **MEMORY**: the memory usage.
                    /// *   **tcpActiveConn**: the average number of active TCP connections for an instance in 30 seconds.
                    /// *   **SLB_QPS**: the average QPS of the Internet-facing SLB instance associated with an application instance in 15 seconds.
                    /// *   **SLB_RT**: the average response time of the Internet-facing SLB instance in 15 seconds.
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    [NameInMap("SlbLogstore")]
                    [Validation(Required=false)]
                    public string SlbLogstore { get; set; }

                    [NameInMap("SlbProject")]
                    [Validation(Required=false)]
                    public string SlbProject { get; set; }

                    [NameInMap("Vport")]
                    [Validation(Required=false)]
                    public string Vport { get; set; }

                }

                /// <summary>
                /// The execution status of the metric-based auto scaling policy.
                /// </summary>
                [NameInMap("MetricsStatus")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus MetricsStatus { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus : TeaModel {
                    /// <summary>
                    /// The metrics that is used to trigger the current auto scaling policy.
                    /// </summary>
                    [NameInMap("CurrentMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics> CurrentMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics : TeaModel {
                        /// <summary>
                        /// The current value of the metric.
                        /// </summary>
                        [NameInMap("CurrentValue")]
                        [Validation(Required=false)]
                        public long? CurrentValue { get; set; }

                        /// <summary>
                        /// The name of the metric.
                        /// 
                        /// *   **cpu**: the CPU utilization.
                        /// *   **memory**: the memory usage.
                        /// *   **tcpActiveConn**: the number of active TCP connections.
                        /// *   **slb_incall_qps**: the QPS of the Internet-facing SLB instance.
                        /// *   **slb_incall_rt**: the response time of the Internet-facing SLB instance.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The type of the data. This parameter corresponds to the metric.
                        /// 
                        /// *   **Resource**: used when the metric is the **CPU utilization** or **memory usage**.
                        /// *   **Pods**: used when the metric is the **number of active TCP connections**.
                        /// *   **External**: used when the metric is about the **SLB** instance or from **Application Real-Time Monitoring Service (ARMS)**.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// The current number of instances.
                    /// </summary>
                    [NameInMap("CurrentReplicas")]
                    [Validation(Required=false)]
                    public long? CurrentReplicas { get; set; }

                    /// <summary>
                    /// The expected number of instances.
                    /// </summary>
                    [NameInMap("DesiredReplicas")]
                    [Validation(Required=false)]
                    public long? DesiredReplicas { get; set; }

                    /// <summary>
                    /// The time when the auto scaling policy was last triggered.
                    /// </summary>
                    [NameInMap("LastScaleTime")]
                    [Validation(Required=false)]
                    public string LastScaleTime { get; set; }

                    /// <summary>
                    /// The metrics that are used to trigger the auto scaling policy next time.
                    /// </summary>
                    [NameInMap("NextScaleMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics> NextScaleMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics : TeaModel {
                        /// <summary>
                        /// The name of the metric.
                        /// 
                        /// *   **cpu**: the CPU utilization.
                        /// *   **memory**: the memory usage.
                        /// *   **tcpActiveConn**: the number of active TCP connections.
                        /// *   **slb_incall_qps**: the QPS of the Internet-facing SLB instance.
                        /// *   **slb_incall_rt**: the response time of the Internet-facing SLB instance.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The metric value as a percentage that triggers the application scale-in next time.
                        /// </summary>
                        [NameInMap("NextScaleInAverageUtilization")]
                        [Validation(Required=false)]
                        public int? NextScaleInAverageUtilization { get; set; }

                        /// <summary>
                        /// The metric value as a percentage that triggers the application scale-out next time.
                        /// </summary>
                        [NameInMap("NextScaleOutAverageUtilization")]
                        [Validation(Required=false)]
                        public int? NextScaleOutAverageUtilization { get; set; }

                    }

                    /// <summary>
                    /// The duration for which the metric-based auto scaling policy takes effect next time.
                    /// </summary>
                    [NameInMap("NextScaleTimePeriod")]
                    [Validation(Required=false)]
                    public int? NextScaleTimePeriod { get; set; }

                }

                /// <summary>
                /// The minimum number of instances.
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

                /// <summary>
                /// Rules that determine the application scale-in.
                /// </summary>
                [NameInMap("ScaleDownRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules ScaleDownRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules : TeaModel {
                    /// <summary>
                    /// Indicates whether the application scale-in is disabled. Valid values:
                    /// 
                    /// *   **true**: disabled.
                    /// *   **false**: enabled.
                    /// 
                    /// >  When this parameter is set to true, the application instances are never reduced. This prevents risks to your business in peak hours. By default, this parameter is set to false.
                    /// </summary>
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// The cooldown time of the scale-in. Valid values: 0 to 3600. Unit: seconds. Default value: 0.
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }

                    /// <summary>
                    /// The step size for the scale-in. The maximum number of instances that can be reduced within a specific period of time.
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

                /// <summary>
                /// Rules that determine the application scale-out.
                /// </summary>
                [NameInMap("ScaleUpRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules ScaleUpRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules : TeaModel {
                    /// <summary>
                    /// Indicates whether the application scale-in is disabled. Valid values:
                    /// 
                    /// *   **true**: The application scale-in is disabled.
                    /// *   **false**: The application scale-in is enabled.
                    /// 
                    /// >  When this parameter is set to true, the application instances are never reduced. This prevents risks to your business in peak hours. By default, this parameter is set to false.
                    /// </summary>
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// The cooldown time of the scale-out. Valid values: 0 to 3600. Unit: seconds. Default value: 0.
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }

                    /// <summary>
                    /// The step size for the scale-out. The maximum number of instances that can be added within a specific period of time.
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

            }

            [NameInMap("MinReadyInstanceRatio")]
            [Validation(Required=false)]
            public int? MinReadyInstanceRatio { get; set; }

            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }

            /// <summary>
            /// Indicates whether the auto scaling policy is enabled. Valid values:
            /// 
            /// *   **true**: enabled
            /// *   **false**: disabled
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }

            /// <summary>
            /// The name of the auto scaling policy.
            /// </summary>
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            /// <summary>
            /// The type of the auto scaling policy. Valid values:
            /// 
            /// *   **timing**: the scheduled auto scaling policy.
            /// *   **metric**: the metric-based auto scaling policy.
            /// *   **mix**: the hybrid auto scaling policy.
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// The details of the scheduled auto scaling policy.
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public DescribeApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class DescribeApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// The start date of the validity period of the scheduled auto scaling policy. Valid values:
                /// 
                /// *   If both the **BeginDate** and **EndDate** parameters are set to **null**, the auto scaling policy can always be triggered. The default value for these parameters is null.
                /// *   If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if **BeginDate** is **2021-03-25** and **EndDate** is **2021-04-25**, the auto scaling policy is valid for one month.
                /// </summary>
                [NameInMap("BeginDate")]
                [Validation(Required=false)]
                public string BeginDate { get; set; }

                /// <summary>
                /// The end date of the validity period of the scheduled auto scaling policy. Valid values:
                /// 
                /// *   If both the **BeginDate** and **EndDate** parameters are set to **null**, the auto scaling policy can always be triggered. The default value for these parameters is null.
                /// *   If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if **BeginDate** is **2021-03-25** and **EndDate** is **2021-04-25**, the auto scaling policy is valid for one month.
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// The days on which the scheduled auto scaling policy takes effect. Valid values:
                /// 
                /// *   **\\* \\* \\***: The scheduled auto scaling policy takes effect at a specified time every day.
                /// 
                /// *   **\\* \\* Fri,Mon**: The scheduled auto scaling policy takes effect at a specified time on one or multiple days of a week. The specified time is in the GMT+8 time zone. Valid values:
                /// 
                ///     *   **Sun**: Sunday
                ///     *   **Mon**: Monday
                ///     *   **Tue**: Tuesday
                ///     *   **Wed**: Wednesday
                ///     *   **Thu**: Thursday
                ///     *   **Fri**: Friday
                ///     *   **Sat**: Saturday
                /// 
                /// *   **1,2,3,28,31 \\* \\***: The scheduled auto scaling policy takes effect at a specified time on one or multiple days of a month. Valid values: 1 to 31. If the month does not have a 31st day, the auto scaling policy takes effect on the specified days other than the 31st day.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The points in time when the auto scaling policy is triggered within one day.
                /// </summary>
                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    /// <summary>
                    /// The point in time. Format: **Hour:Minute**.
                    /// </summary>
                    [NameInMap("AtTime")]
                    [Validation(Required=false)]
                    public string AtTime { get; set; }

                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                    /// <summary>
                    /// The expected number of instances.
                    /// </summary>
                    [NameInMap("TargetReplicas")]
                    [Validation(Required=false)]
                    public int? TargetReplicas { get; set; }

                }

            }

            /// <summary>
            /// The time when the auto scaling policy was updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. The ID is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
