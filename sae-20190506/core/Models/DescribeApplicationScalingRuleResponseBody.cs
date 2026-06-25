// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationScalingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or a POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The operation is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: A redirection is required.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A request error occurred.</para>
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
        public DescribeApplicationScalingRuleResponseBodyData Data { get; set; }
        public class DescribeApplicationScalingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
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
            /// <para>The metric-based scaling policy.</para>
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
                /// <para>The list of metric-based scaling policies.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    /// <summary>
                    /// <para>The target value of the metric.</para>
                    /// <list type="bullet">
                    /// <item><description><para>The target CPU utilization. Unit: percent.</para>
                    /// </description></item>
                    /// <item><description><para>The target memory usage. Unit: percent.</para>
                    /// </description></item>
                    /// <item><description><para>The number of queries per second (QPS).</para>
                    /// </description></item>
                    /// <item><description><para>The response time. Unit: milliseconds.</para>
                    /// </description></item>
                    /// <item><description><para>The average number of active TCP connections per second.</para>
                    /// </description></item>
                    /// <item><description><para>The QPS of a public-facing SLB instance.</para>
                    /// </description></item>
                    /// <item><description><para>The response time of a public-facing SLB instance. Unit: milliseconds.</para>
                    /// </description></item>
                    /// <item><description><para>The QPS of a private SLB instance.</para>
                    /// </description></item>
                    /// <item><description><para>The response time of a private SLB instance. Unit: milliseconds.</para>
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
                    /// <para>The metric that is used to trigger the auto scaling policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>CPU</b>: CPU utilization.</para>
                    /// </description></item>
                    /// <item><description><para><b>MEMORY</b>: memory usage.</para>
                    /// </description></item>
                    /// <item><description><para><b>QPS</b>: the average QPS of a single instance of a Java application in one minute.</para>
                    /// </description></item>
                    /// <item><description><para><b>RT</b>: the average response time (RT) of all service interfaces of a Java application in one minute.</para>
                    /// </description></item>
                    /// <item><description><para><b>tcpActiveConn</b>: the average number of active TCP connections of a single instance in 30 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>SLB_QPS</b>: the average QPS of a single instance for a public-facing SLB instance in 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>SLB_RT</b>: the average RT of a public-facing SLB instance in 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>INTRANET_SLB_QPS</b>: the average QPS of a single instance for a private SLB instance in 15 seconds.</para>
                    /// </description></item>
                    /// <item><description><para><b>INTRANET_SLB_RT</b>: the average RT of a private SLB instance in 15 seconds.</para>
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
                    /// <para>The SLB access log Logstore.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SlbLogstore")]
                    [Validation(Required=false)]
                    public string SlbLogstore { get; set; }

                    /// <summary>
                    /// <para>The SLB access log Project.</para>
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
                /// <para>The status of the metric-based scaling policy.</para>
                /// </summary>
                [NameInMap("MetricsStatus")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus MetricsStatus { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatus : TeaModel {
                    /// <summary>
                    /// <para>The data of the current metric-based scaling.</para>
                    /// </summary>
                    [NameInMap("CurrentMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics> CurrentMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusCurrentMetrics : TeaModel {
                        /// <summary>
                        /// <para>The current value.</para>
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
                        /// <item><description><para><b>cpu</b>: CPU utilization.</para>
                        /// </description></item>
                        /// <item><description><para><b>memory</b>: memory usage.</para>
                        /// </description></item>
                        /// <item><description><para><b>arms_incall_qps</b>: the average QPS of a single instance of a Java application in one minute.</para>
                        /// </description></item>
                        /// <item><description><para><b>arms_incall_rt</b>: the average RT of all service interfaces of a Java application in one minute.</para>
                        /// </description></item>
                        /// <item><description><para><b>tcpActiveConn</b>: the number of active TCP connections.</para>
                        /// </description></item>
                        /// <item><description><para><b>slb_incall_qps</b>: the QPS of a public-facing SLB instance.</para>
                        /// </description></item>
                        /// <item><description><para><b>slb_incall_rt</b>: the RT of a public-facing SLB instance.</para>
                        /// </description></item>
                        /// <item><description><para><b>intranet_slb_incall_qps</b>: the QPS of a private SLB instance.</para>
                        /// </description></item>
                        /// <item><description><para><b>intranet_slb_incall_rt</b>: the RT of a private SLB instance.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cpu</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The type of the metric. This parameter is associated with the monitoring metric.</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>Resource</b>: the metric value of <b>cpu</b> or <b>memory</b>.</para>
                        /// </description></item>
                        /// <item><description><para><b>Pods</b>: the metric value of <b>tcpActiveConn</b>.</para>
                        /// </description></item>
                        /// <item><description><para><b>External</b>: the metric value of <b>arms</b> or <b>slb</b>.</para>
                        /// </description></item>
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
                    /// <para>The target number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("DesiredReplicas")]
                    [Validation(Required=false)]
                    public long? DesiredReplicas { get; set; }

                    /// <summary>
                    /// <para>The time of the last scaling activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-01-11T08:14:32Z</para>
                    /// </summary>
                    [NameInMap("LastScaleTime")]
                    [Validation(Required=false)]
                    public string LastScaleTime { get; set; }

                    /// <summary>
                    /// <para>The list of metrics for the next scaling activity.</para>
                    /// </summary>
                    [NameInMap("NextScaleMetrics")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics> NextScaleMetrics { get; set; }
                    public class DescribeApplicationScalingRuleResponseBodyDataMetricMetricsStatusNextScaleMetrics : TeaModel {
                        /// <summary>
                        /// <para>The name of the metric.</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>cpu</b>: CPU utilization.</para>
                        /// </description></item>
                        /// <item><description><para><b>memory</b>: memory usage.</para>
                        /// </description></item>
                        /// <item><description><para><b>arms_incall_qps</b>: the average QPS of a single instance of a Java application in one minute.</para>
                        /// </description></item>
                        /// <item><description><para><b>arms_incall_rt</b>: the average RT of all service interfaces of a Java application in one minute.</para>
                        /// </description></item>
                        /// <item><description><para><b>tcpActiveConn</b>: the number of active TCP connections.</para>
                        /// </description></item>
                        /// <item><description><para><b>slb_incall_qps</b>: the QPS of a public-facing SLB instance.</para>
                        /// </description></item>
                        /// <item><description><para><b>slb_incall_rt</b>: the RT of a public-facing SLB instance.</para>
                        /// </description></item>
                        /// <item><description><para><b>intranet_slb_incall_qps</b>: the QPS of a private SLB instance.</para>
                        /// </description></item>
                        /// <item><description><para><b>intranet_slb_incall_rt</b>: the RT of a private SLB instance.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cpu</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The metric threshold for the next scale-in. The value is a percentage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("NextScaleInAverageUtilization")]
                        [Validation(Required=false)]
                        public int? NextScaleInAverageUtilization { get; set; }

                        /// <summary>
                        /// <para>The metric threshold for the next scale-out. The value is a percentage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21</para>
                        /// </summary>
                        [NameInMap("NextScaleOutAverageUtilization")]
                        [Validation(Required=false)]
                        public int? NextScaleOutAverageUtilization { get; set; }

                    }

                    /// <summary>
                    /// <para>The period of the next metric-based scaling.</para>
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
                /// <para>The scale-in rules.</para>
                /// </summary>
                [NameInMap("ScaleDownRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules ScaleDownRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleDownRules : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether scale-in is disabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>true</b>: enabled.</para>
                    /// </description></item>
                    /// <item><description><para><b>false</b>: disabled.</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If you enable this feature, the application is never scaled in. This prevents business risks that are caused by scale-ins during peak hours. By default, this feature is disabled.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// <para>The cooldown period for scale-ins. The value can be an integer from 0 to 3600. Unit: seconds. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }

                    /// <summary>
                    /// <para>The scaling step size for scale-ins. The maximum number of instances that can be removed at a time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

                /// <summary>
                /// <para>The scale-out rules.</para>
                /// </summary>
                [NameInMap("ScaleUpRules")]
                [Validation(Required=false)]
                public DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules ScaleUpRules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataMetricScaleUpRules : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether scale-in is disabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>true</b>: enabled.</para>
                    /// </description></item>
                    /// <item><description><para><b>false</b>: disabled.</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>If you enable this feature, the application is never scaled in. This prevents business risks that are caused by scale-ins during peak hours. By default, this feature is disabled.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// <para>The cooldown period for scale-outs. The value can be an integer from 0 to 3600. Unit: seconds. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("StabilizationWindowSeconds")]
                    [Validation(Required=false)]
                    public long? StabilizationWindowSeconds { get; set; }

                    /// <summary>
                    /// <para>The scaling step size for scale-outs. The maximum number of instances that can be added at a time.</para>
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
            /// <para>The percentage of the minimum number of ready instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>-1</b>: an initial value, which indicates that a percentage is not used.</para>
            /// </description></item>
            /// <item><description><para><b>0 to 100</b>: a percentage that is rounded up. For example, if you set this parameter to 50% and the current number of instances is 5, the minimum number of ready instances is 3.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify both MinReadyInstances and MinReadyInstanceRatio, and the value of <b>MinReadyInstanceRatio</b> is not <b>-1</b>, the value of <b>MinReadyInstanceRatio</b> prevails. For example, if <b>MinReadyInstances</b> is set to <b>5</b> and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the value <b>50</b> is used to calculate the minimum number of ready instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MinReadyInstanceRatio")]
            [Validation(Required=false)]
            public int? MinReadyInstanceRatio { get; set; }

            /// <summary>
            /// <para>The minimum number of ready instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you set this parameter to <b>0</b>, the application is interrupted during an upgrade.</para>
            /// </description></item>
            /// <item><description><para>If you set this parameter to -1, the system uses a recommended value for the minimum number of ready instances. The value is 25% of the current number of instances. For example, if the current number of instances is 5, the minimum number of ready instances is 2 after 5 × 25% = 1.25 is rounded up.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Set the minimum number of ready instances to a value greater than or equal to 1 for each rolling deployment to ensure business continuity.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinReadyInstances")]
            [Validation(Required=false)]
            public int? MinReadyInstances { get; set; }

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
            /// <item><description><para><b>timing</b>: scheduled scaling.</para>
            /// </description></item>
            /// <item><description><para><b>metric</b>: metric-based scaling.</para>
            /// </description></item>
            /// <item><description><para><b>mix</b>: hybrid scaling.</para>
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
            /// <para>The scheduled scaling policy.</para>
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public DescribeApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class DescribeApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                /// <summary>
                /// <para>The start date of a short-term scheduled scaling policy. The following list describes the valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>If you leave both <b>BeginDate</b> and <b>EndDate</b> empty, the policy is a long-term policy. This is the default value.</para>
                /// </description></item>
                /// <item><description><para>If you specify a date, for example, you set <b>BeginDate</b> to <b>2021-03-25</b> and <b>EndDate</b> to <b>2021-04-25</b>, the policy is effective for one month.</para>
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
                /// <para>The end date of a short-term scheduled scaling policy. The following list describes the valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>If you leave both <b>BeginDate</b> and <b>EndDate</b> empty, the policy is a long-term policy. This is the default value.</para>
                /// </description></item>
                /// <item><description><para>If you specify a date, for example, you set <b>BeginDate</b> to <b>2021-03-25</b> and <b>EndDate</b> to <b>2021-04-25</b>, the policy is effective for one month.</para>
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
                /// <para>The period in which the scheduled scaling policy is executed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><em><em>\</em> \</em> \***: The policy is executed at a specified time every day.</para>
                /// </description></item>
                /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The policy is executed at a specified time on one or more days of a week. You can select multiple days. The time is in GMT+8. Valid values:</para>
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
                /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The policy is executed at a specified time on one or more days of a month. You can select multiple days. The value can be an integer from 1 to 31. If a month does not have a 31st day, the policy is not executed on that day.</para>
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
                /// <para>The points in time when the auto scaling policy is triggered within a day.</para>
                /// </summary>
                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<DescribeApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class DescribeApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    /// <summary>
                    /// <para>The point in time. Format: <b>HH:mm</b>.</para>
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

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, the <b>ErrorCode</b> field is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the <b>ErrorCode</b> field is returned. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, a specific error code is returned.</para>
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
        /// <para>73404D3D-EE4F-4CB2-B197-5C46F6A1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application instance was successfully restarted.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The restart succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The restart failed.</para>
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
        /// <para>The trace ID. Use this ID to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b57ff7e16243300839193068e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
