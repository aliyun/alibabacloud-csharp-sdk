// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or a POP error code.</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client-side error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server-side error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateApplicationScalingRuleResponseBodyData Data { get; set; }
        public class UpdateApplicationScalingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the scaling policy was created, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616642248938</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable idle mode.</para>
            /// </summary>
            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            /// <summary>
            /// <para>The time when the scaling policy was last disabled, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641882854484</para>
            /// </summary>
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            /// <summary>
            /// <para>The configuration for metric-based scaling.</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyDataMetric : TeaModel {
                /// <summary>
                /// <para>The maximum number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                /// <summary>
                /// <para>The metrics that trigger scaling actions.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    /// <summary>
                    /// <para>The target value for the specified metric. The unit varies based on the metric type.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Target CPU utilization, in percentage.</para>
                    /// </description></item>
                    /// <item><description><para>Target memory usage, in percentage.</para>
                    /// </description></item>
                    /// <item><description><para>Target queries per second (QPS).</para>
                    /// </description></item>
                    /// <item><description><para>Target response time, in milliseconds.</para>
                    /// </description></item>
                    /// <item><description><para>The target number of active TCP connections.</para>
                    /// </description></item>
                    /// <item><description><para>Target QPS for the public-facing SLB instance.</para>
                    /// </description></item>
                    /// <item><description><para>Target response time of the public-facing SLB instance, in milliseconds.</para>
                    /// </description></item>
                    /// <item><description><para>Target QPS for the internal SLB instance.</para>
                    /// </description></item>
                    /// <item><description><para>Target response time of the internal SLB instance, in milliseconds.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    /// <summary>
                    /// <para>The metric that triggers the scaling policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>CPU</b>: CPU utilization.</para>
                    /// </description></item>
                    /// <item><description><para><b>MEMORY</b>: memory usage.</para>
                    /// </description></item>
                    /// <item><description><para><b>QPS</b>: The average queries per second (QPS) per instance over the last minute. This applies only to Java applications.</para>
                    /// </description></item>
                    /// <item><description><para><b>RT</b>: The average response time (RT) of all service interfaces in the application over the last minute. This applies only to Java applications.</para>
                    /// </description></item>
                    /// <item><description><para><b>tcpActiveConn</b>: The average number of active TCP connections per instance over the last 30 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>SLB_QPS</b>: The average QPS from the public-facing SLB, per instance, over the last 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>SLB_RT</b>: The average response time of a public-facing SLB instance over the last 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>INTRANET_SLB_QPS</b>: The average QPS from the internal SLB, per instance, over the last 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>INTRANET_SLB_RT</b>: The average response time of an internal SLB instance over the last 15 seconds.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CPU</para>
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    /// <summary>
                    /// <para>The SLB instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-xxx</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <para>The name of the Logstore for SLB access logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbLogstore")]
                    [Validation(Required=false)]
                    public string SlbLogstore { get; set; }

                    /// <summary>
                    /// <para>The name of the Log Service Project for SLB access logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbProject")]
                    [Validation(Required=false)]
                    public string SlbProject { get; set; }

                    /// <summary>
                    /// <para>The SLB port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Vport")]
                    [Validation(Required=false)]
                    public string Vport { get; set; }

                }

                /// <summary>
                /// <para>The minimum number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the scaling policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }

            /// <summary>
            /// <para>The name of the scaling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            /// <summary>
            /// <para>The type of the scaling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>timing</b>: scheduled scaling</para>
            /// </description></item>
            /// <item><description><para><b>metric</b>: metric-based scaling</para>
            /// </description></item>
            /// <item><description><para><b>mix</b>: hybrid scaling</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>timing</para>
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// <para>The configuration for scheduled scaling.</para>
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// <para>The start date of the short-term scheduled scaling policy.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>BeginDate</b> and <b>EndDate</b> are both set to <b>null</b>, the policy is long-term by default.</para>
                /// </description></item>
                /// <item><description><para>If you specify a date range, for example, <b>BeginDate</b> is set to 2021-03-25 and <b>EndDate</b> is set to 2021-04-25, the policy is effective for one month.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-25</para>
                /// </summary>
                [NameInMap("BeginDate")]
                [Validation(Required=false)]
                public string BeginDate { get; set; }

                /// <summary>
                /// <para>The end date of the short-term scheduled scaling policy.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>BeginDate</b> and <b>EndDate</b> are both set to <b>null</b>, the policy is long-term by default.</para>
                /// </description></item>
                /// <item><description><para>If you specify a date range, for example, <b>BeginDate</b> is set to 2021-03-25 and <b>EndDate</b> is set to 2021-04-25, the policy is effective for one month.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-25</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>The recurrence schedule for the scaling policy.</para>
                /// <list type="bullet">
                /// <item><description><para><em><em>\</em> \</em> \***: The policy runs at a specified time every day.</para>
                /// </description></item>
                /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The policy runs at a specified time on specific days of a week. You can select multiple days. The time is in the GMT+8 time zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Sun</b>: Sunday</para>
                /// </description></item>
                /// <item><description><para><b>Mon</b>: Monday</para>
                /// </description></item>
                /// <item><description><para><b>Tue</b>: Tuesday</para>
                /// </description></item>
                /// <item><description><para><b>Wed</b>: Wednesday</para>
                /// </description></item>
                /// <item><description><para><b>Thu</b>: Thursday</para>
                /// </description></item>
                /// <item><description><para><b>Fri</b>: Friday</para>
                /// </description></item>
                /// <item><description><para><b>Sat</b>: Saturday</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The policy runs at a specified time on specific days of a month. You can select multiple days. If a month does not have a specific day, such as the 31st, the policy skips that day.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para>The schedules for the scaling policy.</para>
                /// </summary>
                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    /// <summary>
                    /// <para>The time at which the scaling action is triggered. Format: <b>HH:mm</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>08:00</para>
                    /// </summary>
                    [NameInMap("AtTime")]
                    [Validation(Required=false)]
                    public string AtTime { get; set; }

                    /// <summary>
                    /// <para>The maximum number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    /// <summary>
                    /// <para>The minimum number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                    /// <summary>
                    /// <para>The target number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TargetReplicas")]
                    [Validation(Required=false)]
                    public int? TargetReplicas { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the scaling policy was updated, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616642248938</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if the request fails.</para>
        /// </description></item>
        /// <item><description><para>For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b> is returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>An error message is returned if the request fails.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used to query call details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
