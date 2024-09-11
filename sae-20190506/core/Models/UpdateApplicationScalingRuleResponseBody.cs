// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateApplicationScalingRuleResponseBodyData Data { get; set; }
        public class UpdateApplicationScalingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The application ID.
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
            public UpdateApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyDataMetric : TeaModel {
                /// <summary>
                /// The maximum number of instances.
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// The metrics that are used to trigger the auto scaling policy.
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
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
                    /// *   **tcpActiveConn**: the average number of active TCP connections of an application instance within 30 seconds.
                    /// *   **SLB_QPS**: the average QPS of the Internet-facing SLB instance associated with an application instance within 15 seconds.
                    /// *   **SLB_RT**: the average response time of the Internet-facing SLB instance within 15 seconds.
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
                /// The minimum number of instances.
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable the auto scaling policy. Valid values:
            /// 
            /// *   **true**: The auto scaling policy is enabled.
            /// *   **false**: The auto scaling policy is disabled.
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
            /// *   **timing**: a scheduled auto scaling policy
            /// *   **metric**: a metric-based auto scaling policy
            /// *   **mix**: a hybrid auto scaling policy
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// The details of the scheduled auto scaling policy.
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// The start date of the validity period of the scheduled auto scaling policy. Parameter description:
                /// 
                /// *   If **BeginDate** and **EndDate** are set to **null**, the auto scaling policy is a long-term policy. Default values of the beginDate and endDate parameters: null.
                /// *   If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if **BeginDate** is set to 2021-03-25 and **EndDate** is set to 2021-04-25, the auto scaling policy is valid for one month.
                /// </summary>
                [NameInMap("BeginDate")]
                [Validation(Required=false)]
                public string BeginDate { get; set; }

                /// <summary>
                /// The end date of the validity period of the scheduled auto scaling policy. Take note of the following rules:
                /// 
                /// *   If **BeginDate** and **EndDate** are set to **null**, the auto scaling policy is a long-term policy. Default values of the beginDate and endDate parameters: null.
                /// *   If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if **BeginDate** is set to 2021-03-25 and **EndDate** is set to 2021-04-25, the auto scaling policy is valid for one month.
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// The frequency at which the scheduled auto scaling policy is executed. Valid values:
                /// 
                /// *   **\\* \\* \\***: The scheduled auto scaling policy is executed at a specified point in time every day.
                /// 
                /// *   **\\* \\* Fri,Mon**: The scheduled auto scaling policy is executed at a specified point in time on one or more days of each week. GMT+8 is used. Valid values:
                /// 
                ///     *   **Sun**
                ///     *   **Mon**
                ///     *   **Tue**
                ///     *   **Wed**
                ///     *   **Thu**
                ///     *   **Fri**
                ///     *   **Sat**
                /// 
                /// *   **1,2,3,28,31 \\* \\***: The scheduled auto scaling policy is executed at a specified point in time on one or more days of each month. Valid values: 1 to 31. If the month does not have a 31st day, the auto scaling policy is executed on the specified days other than the 31st day.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The points in time at which the auto scaling policy is triggered within one day.
                /// </summary>
                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
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

        /// <summary>
        /// The error code returned. Take note of the following rules:
        /// 
        /// *   If the call is successful, **ErrorCode** is not returned.
        /// *   If the call fails, **ErrorCode** is returned. For more information, see the "**Error codes**" section in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message. Take note of the following rules:
        /// 
        /// *   If the call is successful, **success** is returned.
        /// *   If the call fails, an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Specifies whether the instances are successfully restarted. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
