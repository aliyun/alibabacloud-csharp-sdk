// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
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
        public DescribeApplicationScalingRuleResponseBodyData Data { get; set; }
        public class DescribeApplicationScalingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a0d2e04c-159d-40a8-b240-d2f2c263****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the auto scaling policy was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624329843790</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            public DescribeApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class DescribeApplicationScalingRuleResponseBodyDataMetric : TeaModel {
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
                /// <para>The list of metrics that are used to trigger the auto scaling policy.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
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
                    /// <item><description><b>tcpActiveConn</b>: the average number of active TCP connections for an instance in 30 seconds.</description></item>
                    /// <item><description><b>SLB_QPS</b>: the average QPS of the Internet-facing SLB instance associated with an application instance in 15 seconds.</description></item>
                    /// <item><description><b>SLB_RT</b>: the average response time of the Internet-facing SLB instance in 15 seconds.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CPU</para>
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>lb-xxx</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbLogstore")]
                    [Validation(Required=false)]
                    public string SlbLogstore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbProject")]
                    [Validation(Required=false)]
                    public string SlbProject { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Vport")]
                    [Validation(Required=false)]
                    public string Vport { get; set; }

                }

                /// <summary>
                /// <para>The execution status of the metric-based auto scaling policy.</para>
                /// </summary>
                [NameInMap("MetricsStatus")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus MetricsStatus { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus : TeaModel {
                    /// <summary>
                    /// <para>The metrics that is used to trigger the current auto scaling policy.</para>
                    /// </summary>
                    [NameInMap("CurrentMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics> CurrentMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics : TeaModel {
                        /// <summary>
                        /// <para>The current value of the metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("CurrentValue")]
                        [Validation(Required=false)]
                        public long? CurrentValue { get; set; }

                        /// <summary>
                        /// <para>The name of the metric.</para>
                        /// <list type="bullet">
                        /// <item><description><b>cpu</b>: the CPU utilization.</description></item>
                        /// <item><description><b>memory</b>: the memory usage.</description></item>
                        /// <item><description><b>tcpActiveConn</b>: the number of active TCP connections.</description></item>
                        /// <item><description><b>slb_incall_qps</b>: the QPS of the Internet-facing SLB instance.</description></item>
                        /// <item><description><b>slb_incall_rt</b>: the response time of the Internet-facing SLB instance.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cpu</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The type of the data. This parameter corresponds to the metric.</para>
                        /// <list type="bullet">
                        /// <item><description><b>Resource</b>: used when the metric is the <b>CPU utilization</b> or <b>memory usage</b>.</description></item>
                        /// <item><description><b>Pods</b>: used when the metric is the <b>number of active TCP connections</b>.</description></item>
                        /// <item><description><b>External</b>: used when the metric is about the <b>SLB</b> instance or from <b>Application Real-Time Monitoring Service (ARMS)</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Resource</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The current number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("CurrentReplicas")]
                    [Validation(Required=false)]
                    public long? CurrentReplicas { get; set; }

                    /// <summary>
                    /// <para>The expected number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("DesiredReplicas")]
                    [Validation(Required=false)]
                    public long? DesiredReplicas { get; set; }

                    /// <summary>
                    /// <para>The time when the auto scaling policy was last triggered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-01-11T08:14:32Z</para>
                    /// </summary>
                    [NameInMap("LastScaleTime")]
                    [Validation(Required=false)]
                    public string LastScaleTime { get; set; }

                    /// <summary>
                    /// <para>The metrics that are used to trigger the auto scaling policy next time.</para>
                    /// </summary>
                    [NameInMap("NextScaleMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics> NextScaleMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics : TeaModel {
                        /// <summary>
                        /// <para>The name of the metric.</para>
                        /// <list type="bullet">
                        /// <item><description><b>cpu</b>: the CPU utilization.</description></item>
                        /// <item><description><b>memory</b>: the memory usage.</description></item>
                        /// <item><description><b>tcpActiveConn</b>: the number of active TCP connections.</description></item>
                        /// <item><description><b>slb_incall_qps</b>: the QPS of the Internet-facing SLB instance.</description></item>
                        /// <item><description><b>slb_incall_rt</b>: the response time of the Internet-facing SLB instance.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cpu</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The metric value as a percentage that triggers the application scale-in next time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("NextScaleInAverageUtilization")]
                        [Validation(Required=false)]
                        public int? NextScaleInAverageUtilization { get; set; }

                        /// <summary>
                        /// <para>The metric value as a percentage that triggers the application scale-out next time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21</para>
                        /// </summary>
                        [NameInMap("NextScaleOutAverageUtilization")]
                        [Validation(Required=false)]
                        public int? NextScaleOutAverageUtilization { get; set; }

                    }

                    /// <summary>
                    /// <para>The duration for which the metric-based auto scaling policy takes effect next time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("NextScaleTimePeriod")]
                    [Validation(Required=false)]
                    public int? NextScaleTimePeriod { get; set; }

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

                /// <summary>
                /// <para>Rules that determine the application scale-in.</para>
                /// </summary>
                [NameInMap("ScaleDownRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules ScaleDownRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the application scale-in is disabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: disabled.</description></item>
                    /// <item><description><b>false</b>: enabled.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> When this parameter is set to true, the application instances are never reduced. This prevents risks to your business in peak hours. By default, this parameter is set to false.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// <para>The cooldown time of the scale-in. Valid values: 0 to 3600. Unit: seconds. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }

                    /// <summary>
                    /// <para>The step size for the scale-in. The maximum number of instances that can be reduced within a specific period of time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

                /// <summary>
                /// <para>Rules that determine the application scale-out.</para>
                /// </summary>
                [NameInMap("ScaleUpRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules ScaleUpRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the application scale-in is disabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The application scale-in is disabled.</description></item>
                    /// <item><description><b>false</b>: The application scale-in is enabled.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> When this parameter is set to true, the application instances are never reduced. This prevents risks to your business in peak hours. By default, this parameter is set to false.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// <para>The cooldown time of the scale-out. Valid values: 0 to 3600. Unit: seconds. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }

                    /// <summary>
                    /// <para>The step size for the scale-out. The maximum number of instances that can be added within a specific period of time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MinReadyInstanceRatio")]
            [Validation(Required=false)]
            public int? MinReadyInstanceRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }

            /// <summary>
            /// <para>Indicates whether the auto scaling policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: disabled</description></item>
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
            /// <item><description><b>timing</b>: the scheduled auto scaling policy.</description></item>
            /// <item><description><b>metric</b>: the metric-based auto scaling policy.</description></item>
            /// <item><description><b>mix</b>: the hybrid auto scaling policy.</description></item>
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
            public DescribeApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class DescribeApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// <para>The start date of the validity period of the scheduled auto scaling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If both the <b>BeginDate</b> and <b>EndDate</b> parameters are set to <b>null</b>, the auto scaling policy can always be triggered. The default value for these parameters is null.</description></item>
                /// <item><description>If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if <b>BeginDate</b> is <b>2021-03-25</b> and <b>EndDate</b> is <b>2021-04-25</b>, the auto scaling policy is valid for one month.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-25</para>
                /// </summary>
                [NameInMap("BeginDate")]
                [Validation(Required=false)]
                public string BeginDate { get; set; }

                /// <summary>
                /// <para>The end date of the validity period of the scheduled auto scaling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If both the <b>BeginDate</b> and <b>EndDate</b> parameters are set to <b>null</b>, the auto scaling policy can always be triggered. The default value for these parameters is null.</description></item>
                /// <item><description>If the two parameters are set to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if <b>BeginDate</b> is <b>2021-03-25</b> and <b>EndDate</b> is <b>2021-04-25</b>, the auto scaling policy is valid for one month.</description></item>
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
                /// <item><description><para><em><em>\</em> \</em> \***: The scheduled auto scaling policy takes effect at a specified time every day.</para>
                /// </description></item>
                /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The scheduled auto scaling policy takes effect at a specified time on one or multiple days of a week. The specified time is in the GMT+8 time zone. Valid values:</para>
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
                /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The scheduled auto scaling policy takes effect at a specified time on one or multiple days of a month. Valid values: 1 to 31. If the month does not have a 31st day, the auto scaling policy takes effect on the specified days other than the 31st day.</para>
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
                /// <para>The points in time when the auto scaling policy is triggered within one day.</para>
                /// </summary>
                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
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
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                    /// <summary>
                    /// <para>The expected number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
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
            /// <para>1624330075827</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73404D3D-EE4F-4CB2-B197-5C46F6A1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
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
        /// <para>0b57ff7e16243300839193068e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
