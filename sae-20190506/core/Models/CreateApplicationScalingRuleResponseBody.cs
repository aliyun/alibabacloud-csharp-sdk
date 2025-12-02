// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or the error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: The request was redirected.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
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
        public CreateApplicationScalingRuleResponseBodyData Data { get; set; }
        public class CreateApplicationScalingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>null null</para>
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
            /// <para>null</para>
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
            public CreateApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class CreateApplicationScalingRuleResponseBodyDataMetric : TeaModel {
                /// <summary>
                /// <para>The maximum number of Elastic Compute Service (ECS) instances supported by the node pool.</para>
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
                public List<CreateApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class CreateApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    /// <summary>
                    /// <para>The limit on the metric.</para>
                    /// <list type="bullet">
                    /// <item><description>The limit on the CPU utilization. Unit: percentage.</description></item>
                    /// <item><description>The limit on the memory usage. Unit: percentage.</description></item>
                    /// <item><description>The limit on the queries per second (QPS). Unit: seconds.</description></item>
                    /// <item><description>The limit on the response time. Unit: milliseconds.</description></item>
                    /// <item><description>The limit on the average number of active TCP connections per second.</description></item>
                    /// <item><description>The limit on the QPS of the Internet-facing SLB instance.</description></item>
                    /// <item><description>The limit on the response time of the Internet-facing SLB instance. Unit: milliseconds.</description></item>
                    /// <item><description>The limit on the QPS of the internal-facing SLB instance.</description></item>
                    /// <item><description>The limit on the response time of the internal-facing SLB instance. Unit: milliseconds.</description></item>
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
                    /// <item><description><b>QPS</b>: the average QPS within 1 minute per Java application instance.</description></item>
                    /// <item><description><b>RT</b>: the average response time of all API operations within 1 minute in the Java application.</description></item>
                    /// <item><description><b>tcpActiveConn</b>: the average number of active TCP connections within 30 seconds per instance.</description></item>
                    /// <item><description><b>SLB_QPS</b>: the average QPS of the Internet-facing SLB instance within 15 seconds per instance.</description></item>
                    /// <item><description><b>SLB_RT</b>: the average response time of the Internet-facing SLB instance within 15 seconds.</description></item>
                    /// <item><description><b>INTRANET_SLB_QPS</b>: the average QPS of the internal-facing SLB instance within 15 seconds per instance.</description></item>
                    /// <item><description><b>INTRANET_SLB_RT</b>: the average response time of the internal-facing SLB instance within 15 seconds.</description></item>
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
                    /// <para>The Logstore that stores the SLB access logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbLogstore")]
                    [Validation(Required=false)]
                    public string SlbLogstore { get; set; }

                    /// <summary>
                    /// <para>The project that stores the SLB access logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbProject")]
                    [Validation(Required=false)]
                    public string SlbProject { get; set; }

                    /// <summary>
                    /// <para>The port number of the SLB instance.</para>
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
            /// <para>null null</para>
            /// <list type="bullet">
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>null</b></description></item>
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
            /// <para>null null</para>
            /// <list type="bullet">
            /// <item><description><b>null</b></description></item>
            /// <item><description><b>metric</b>: a metric-based auto scaling policy.</description></item>
            /// <item><description><b>mix</b>: a hybrid auto scaling policy.</description></item>
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
            public CreateApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class CreateApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// <para>The start date of the validity period of the scheduled auto scaling policy.</para>
                /// <list type="bullet">
                /// <item><description><b>null</b> (default): If you set <b>BeginDate</b> and <b>EndDate</b> to null, the scheduled auto scaling policy can always be triggered.</description></item>
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
                /// <para>The end date of the validity period of the scheduled auto scaling policy.</para>
                /// <list type="bullet">
                /// <item><description><b>null</b> (default): If you set <b>BeginDate</b> and <b>EndDate</b> to null, the scheduled auto scaling policy can always be triggered.</description></item>
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
                /// <para>The days on which the scheduled auto scaling policy takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><em><em>\</em> \</em> \***: The scheduled auto scaling policy is executed at a specified point in time every day.</para>
                /// </description></item>
                /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The scheduled auto scaling policy is executed at a specified point in time on one or more days every week. The time must be in GMT+8. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Sun</b>: Sunday</description></item>
                /// <item><description><b>Mon</b>: Monday</description></item>
                /// <item><description><b>Tue</b>: Tuesday</description></item>
                /// <item><description><b>Wed</b>: Wednesday</description></item>
                /// <item><description><b>Thu</b>: Thursday</description></item>
                /// <item><description><b>Fri</b>: Friday</description></item>
                /// <item><description><b>Sat</b>: Saturday</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The scheduled auto scaling policy is executed at a specified point in time on one or more dates of each month. Valid values: 1 to 31. If a month does not have the 31st day, the auto scaling policy is executed on the specified days other than the 31st day.</para>
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
                public List<CreateApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class CreateApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    /// <summary>
                    /// <para>The point in time. Format: <b>Hour:Minute</b>.</para>
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
            /// <para>null null</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616642248938</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The status code. Value values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, <b>ErrorCode</b> is returned. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned. The following limits are imposed on the ID:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>success</b> is returned.</description></item>
        /// <item><description>An error code is returned when a request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application instances were restarted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The application instances were restarted.</description></item>
        /// <item><description><b>false</b>: The application instances failed to be restarted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. The ID is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
