// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
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
            /// <para>The time when the auto scaling policy was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616642248938</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            /// <summary>
            /// <para>The time when the auto scaling policy was last disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641882854484</para>
            /// </summary>
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            /// <summary>
            /// <para>The details of the metric-based auto scaling policy.</para>
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
                /// <para>The metrics that are used to trigger the auto scaling policy.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    /// <summary>
                    /// <para>The limit on the metric.</para>
                    /// <list type="bullet">
                    /// <item><description>The limit on the CPU utilization. Unit: percentage.</description></item>
                    /// <item><description>The limit on the memory usage. Unit: percentage.</description></item>
                    /// <item><description>The limit on the average number of active TCP connections per second.</description></item>
                    /// <item><description>The limit on the QPS of the Internet-facing SLB instance.</description></item>
                    /// <item><description>The limit on the response time of the Internet-facing SLB instance. Unit: milliseconds.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    /// <summary>
                    /// <para>The metric that is used to trigger the auto scaling policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>CPU</b>: the CPU utilization.</description></item>
                    /// <item><description><b>MEMORY</b>: the memory usage.</description></item>
                    /// <item><description><b>tcpActiveConn</b>: the average number of active TCP connections of an application instance within 30 seconds.</description></item>
                    /// <item><description><b>SLB_QPS</b>: the average QPS of the Internet-facing SLB instance associated with an application instance within 15 seconds.</description></item>
                    /// <item><description><b>SLB_RT</b>: the average response time of the Internet-facing SLB instance within 15 seconds.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CPU</para>
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
            /// <para>Specifies whether to enable the auto scaling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The auto scaling policy is enabled.</description></item>
            /// <item><description><b>false</b>: The auto scaling policy is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }

            /// <summary>
            /// <para>The name of the auto scaling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            /// <summary>
            /// <para>The type of the auto scaling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>timing</b>: a scheduled auto scaling policy</description></item>
            /// <item><description><b>metric</b>: a metric-based auto scaling policy</description></item>
            /// <item><description><b>mix</b>: a hybrid auto scaling policy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>timing</para>
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            /// <summary>
            /// <para>The details of the scheduled auto scaling policy.</para>
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public UpdateApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class UpdateApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// <para>The start date of the validity period of the scheduled auto scaling policy. Parameter description:</para>
                /// <list type="bullet">
                /// <item><description>If <b>BeginDate</b> and <b>EndDate</b> are set to <b>null</b>, the auto scaling policy is a long-term policy. Default values of the beginDate and endDate parameters: null.</description></item>
                /// <item><description>If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if <b>BeginDate</b> is set to 2021-03-25 and <b>EndDate</b> is set to 2021-04-25, the auto scaling policy is valid for one month.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-25</para>
                /// </summary>
                [NameInMap("BeginDate")]
                [Validation(Required=false)]
                public string BeginDate { get; set; }

                /// <summary>
                /// <para>The end date of the validity period of the scheduled auto scaling policy. Take note of the following rules:</para>
                /// <list type="bullet">
                /// <item><description>If <b>BeginDate</b> and <b>EndDate</b> are set to <b>null</b>, the auto scaling policy is a long-term policy. Default values of the beginDate and endDate parameters: null.</description></item>
                /// <item><description>If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if <b>BeginDate</b> is set to 2021-03-25 and <b>EndDate</b> is set to 2021-04-25, the auto scaling policy is valid for one month.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-25</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>The frequency at which the scheduled auto scaling policy is executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><em><em>\</em> \</em> \***: The scheduled auto scaling policy is executed at a specified point in time every day.</para>
                /// </description></item>
                /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The scheduled auto scaling policy is executed at a specified point in time on one or more days of each week. GMT+8 is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Sun</b></description></item>
                /// <item><description><b>Mon</b></description></item>
                /// <item><description><b>Tue</b></description></item>
                /// <item><description><b>Wed</b></description></item>
                /// <item><description><b>Thu</b></description></item>
                /// <item><description><b>Fri</b></description></item>
                /// <item><description><b>Sat</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The scheduled auto scaling policy is executed at a specified point in time on one or more days of each month. Valid values: 1 to 31. If the month does not have a 31st day, the auto scaling policy is executed on the specified days other than the 31st day.</para>
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
                /// <para>The points in time at which the auto scaling policy is triggered within one day.</para>
                /// </summary>
                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<UpdateApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class UpdateApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    /// <summary>
                    /// <para>The point in time. Format: <b>Hour:Minute</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>08:00</para>
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
                    /// <para>The expected number of instances.</para>
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
            /// <para>The time when the auto scaling policy was updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616642248938</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The error code returned. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the call fails, <b>ErrorCode</b> is returned. For more information, see the &quot;<b>Error codes</b>&quot; section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the call fails, an error code is returned.</description></item>
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
        /// <para>Specifies whether the instances are successfully restarted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
