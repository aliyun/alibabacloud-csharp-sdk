// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateApplicationScalingRuleResponseBodyData Data { get; set; }
        public class CreateApplicationScalingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the policy was created, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616642248938</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether idle mode is enabled.</para>
            /// </summary>
            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            /// <summary>
            /// <para>The time when the auto scaling policy was last disabled, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641882854484</para>
            /// </summary>
            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            /// <summary>
            /// <para>The configurations for the metric-based auto scaling policy.</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public CreateApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class CreateApplicationScalingRuleResponseBodyDataMetric : TeaModel {
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
                /// <para>An array of objects that define the metrics for the metric-based auto scaling policy.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<CreateApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class CreateApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    /// <summary>
                    /// <para>The target value for the metric.</para>
                    /// <list type="bullet">
                    /// <item><description><para>The target CPU utilization, in percentage.</para>
                    /// </description></item>
                    /// <item><description><para>The target memory utilization, in percentage.</para>
                    /// </description></item>
                    /// <item><description><para>The target QPS.</para>
                    /// </description></item>
                    /// <item><description><para>The target response time, in milliseconds.</para>
                    /// </description></item>
                    /// <item><description><para>The target average number of active TCP connections per second.</para>
                    /// </description></item>
                    /// <item><description><para>The target QPS for a public-facing SLB instance.</para>
                    /// </description></item>
                    /// <item><description><para>The target response time for a public-facing SLB instance, in milliseconds.</para>
                    /// </description></item>
                    /// <item><description><para>The target QPS for an internal-facing SLB instance.</para>
                    /// </description></item>
                    /// <item><description><para>The target response time for an internal-facing SLB instance, in milliseconds.</para>
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
                    /// <para>The type of the metric that triggers the auto scaling policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>CPU</b>: CPU utilization.</para>
                    /// </description></item>
                    /// <item><description><para><b>MEMORY</b>: memory utilization.</para>
                    /// </description></item>
                    /// <item><description><para><b>QPS</b>: The average QPS per instance over 1 minute for a Java application.</para>
                    /// </description></item>
                    /// <item><description><para><b>RT</b>: The average response time across all service endpoints over 1 minute for a Java application.</para>
                    /// </description></item>
                    /// <item><description><para><b>tcpActiveConn</b>: The average number of TCP active connections per instance over 30 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>SLB_QPS</b>: The average QPS per instance for a public SLB instance, measured over 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>SLB_RT</b>: The average response time for a public SLB instance, measured over 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>INTRANET_SLB_QPS</b>: The average QPS per instance for an internal-facing SLB instance, measured over 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>INTRANET_SLB_RT</b>: The average response time for an internal-facing SLB instance, measured over 15 seconds.</para>
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
                    /// <para>The ID of the SLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-xxx</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <para>The Log Service Logstore for SLB access logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbLogstore")]
                    [Validation(Required=false)]
                    public string SlbLogstore { get; set; }

                    /// <summary>
                    /// <para>The Log Service project for SLB access logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbProject")]
                    [Validation(Required=false)]
                    public string SlbProject { get; set; }

                    /// <summary>
                    /// <para>The port of the SLB instance.</para>
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
            /// <para>Indicates whether the auto scaling policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The policy is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The policy is disabled.</para>
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
            /// <item><description><para><b>timing</b>: scheduled auto scaling.</para>
            /// </description></item>
            /// <item><description><para><b>metric</b>: metric-based auto scaling.</para>
            /// </description></item>
            /// <item><description><para><b>mix</b>: mixed auto scaling.</para>
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
            /// <para>The configurations for the scheduled auto scaling policy.</para>
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public CreateApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class CreateApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// <para>The start date of the scheduled auto scaling policy.</para>
                /// <list type="bullet">
                /// <item><description><para>If both <b>BeginDate</b> and <b>EndDate</b> are <b>null</b>, the policy is a long-term policy. This is the default.</para>
                /// </description></item>
                /// <item><description><para>For example, if you set <b>BeginDate</b> to 2021-03-25 and <b>EndDate</b> to 2021-04-25, the policy is active for one month.</para>
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
                /// <para>The end date of the scheduled auto scaling policy.</para>
                /// <list type="bullet">
                /// <item><description><para>If both <b>BeginDate</b> and <b>EndDate</b> are <b>null</b>, the policy is a long-term policy. This is the default.</para>
                /// </description></item>
                /// <item><description><para>For example, if you set <b>BeginDate</b> to 2021-03-25 and <b>EndDate</b> to 2021-04-25, the policy is active for one month.</para>
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
                /// <para>The recurrence pattern for the scheduled auto scaling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><em><em>\</em> \</em> \***: The policy is executed at a specified time every day.</para>
                /// </description></item>
                /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The policy is executed at a specified time on specific days of the week. You can select multiple days. The time is in the GMT+8 time zone. Valid values:</para>
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
                /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The policy is executed at a specified time on specific days of a month. You can select multiple days. The value can be from 1 to 31. If a specified day does not exist in a given month (for example, the 31st), the policy is not executed on that day.</para>
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
                /// <para>The trigger points for the scheduled auto scaling policy.</para>
                /// </summary>
                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<CreateApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class CreateApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    /// <summary>
                    /// <para>The trigger time. The format is <b>HH:mm</b>.</para>
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
                    /// <para>5</para>
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
            /// <para>The time when the policy was last updated, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616642248938</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>An error code is returned if the request fails. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Returns <b>success</b> if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>Returns an error message if the request fails.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The API call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The API call failed.</para>
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
        /// <para>The trace ID. You can use this ID to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
