// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeAlarmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of event-triggered tasks.</para>
        /// </summary>
        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public List<DescribeAlarmsResponseBodyAlarmList> AlarmList { get; set; }
        public class DescribeAlarmsResponseBodyAlarmList : TeaModel {
            /// <summary>
            /// <para>The list of unique identifiers of the scaling rules associated with the event-triggered task.</para>
            /// </summary>
            [NameInMap("AlarmActions")]
            [Validation(Required=false)]
            public List<string> AlarmActions { get; set; }

            /// <summary>
            /// <para>The ID of the event-triggered task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp1hvbnmkl10vll5****_f95ce797-dc2e-4bad-9618-14fee7d1****</para>
            /// </summary>
            [NameInMap("AlarmTaskId")]
            [Validation(Required=false)]
            public string AlarmTaskId { get; set; }

            /// <summary>
            /// <para>The comparison operator used to compare the metric value with the threshold. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><remarks>
            /// <para>=: The metric value is greater than or equal to the threshold.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>&lt;=: The metric value is less than or equal to the threshold.</description></item>
            /// <item><description><remarks>
            /// <para>: The metric value is greater than the threshold.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>&lt;: The metric value is less than the threshold.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <remarks>
            /// <para>=</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// <para>The description of the event-triggered task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test alarm task.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The dimension information associated with the metric.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListDimensions> Dimensions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListDimensions : TeaModel {
                /// <summary>
                /// <para>The key of the dimension associated with the metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>user_id: the ID of your account.</description></item>
                /// <item><description>scaling_group: the monitored scaling group.</description></item>
                /// <item><description>device: the type of the NIC device.</description></item>
                /// <item><description>state: the state of the TCP connection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>device</para>
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// <para>The value of the dimension associated with the metric. The valid values vary based on the dimension key.</para>
                /// <list type="bullet">
                /// <item><description><para><c>user_id</c>: automatically populated by the system.</para>
                /// </description></item>
                /// <item><description><para><c>scaling_group</c>: automatically populated by the system.</para>
                /// </description></item>
                /// <item><description><para>Valid values for <c>device</c>:</para>
                /// <list type="bullet">
                /// <item><description>eth0: For classic network instances, eth0 represents the internal NIC. For VPC-connected instances, only the eth0 NIC exists.</description></item>
                /// <item><description>eth1: For classic network instances, eth1 represents the public NIC.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Valid values for <c>state</c>:</para>
                /// <list type="bullet">
                /// <item><description>TCP_TOTAL: the total number of TCP connections.</description></item>
                /// <item><description>ESTABLISHED: the number of established TCP connections.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eth0</para>
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            /// <summary>
            /// <para>The effective period of the event-triggered node.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>?</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Effective")]
            [Validation(Required=false)]
            public string Effective { get; set; }

            /// <summary>
            /// <para>Indicates whether the event-triggered task is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The number of times that the threshold condition must be met before the scaling rule is triggered. For example, if this parameter is set to 3, the scaling rule is triggered only when the average CPU utilization is greater than or equal to 80% for three consecutive times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            /// <summary>
            /// <para>The information about the multi-metric alert rule.</para>
            /// </summary>
            [NameInMap("Expressions")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListExpressions> Expressions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListExpressions : TeaModel {
                /// <summary>
                /// <para>The comparison operator used to compare the metric value with the threshold in the multi-metric alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><remarks>
                /// <para>=: The metric value is greater than or equal to the threshold.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;=: The metric value is less than or equal to the threshold.</description></item>
                /// <item><description><remarks>
                /// <para>: The metric value is greater than the threshold.</para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;: The metric value is less than the threshold.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <remarks>
                /// <para>=</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The name of the monitoring metrics in the multi-metric alert rule. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>CpuUtilization: the CPU utilization of an ECS instance. Unit: %.</description></item>
                /// <item><description>ConcurrentConnections: the number of concurrent connections to an ECS instance.</description></item>
                /// <item><description>IntranetTx: the outbound internal network traffic of an ECS instance. Unit: Kbit/min.</description></item>
                /// <item><description>IntranetRx: the inbound internal network traffic of an ECS instance. Unit: Kbit/min.</description></item>
                /// <item><description>VpcInternetTx: the outbound Internet traffic of an ECS instance. Unit: Kbit/min.</description></item>
                /// <item><description>VpcInternetRx: the inbound Internet traffic of an ECS instance. Unit: Kbit/min.</description></item>
                /// <item><description>SystemDiskReadBps: the number of bytes read from the system cloud disk per second. Unit: Byte/s.</description></item>
                /// <item><description>SystemDiskWriteBps: the number of bytes written to the system cloud disk per second. Unit: Byte/s.</description></item>
                /// <item><description>SystemDiskReadOps: the number of read operations on the system cloud disk per second. Unit: IOPS.</description></item>
                /// <item><description>SystemDiskWriteOps: the number of write operations on the system cloud disk per second. Unit: IOPS.</description></item>
                /// <item><description>CpuUtilizationAgent: the CPU utilization collected by the CloudMonitor agent. Unit: %.</description></item>
                /// <item><description>GpuUtilizationAgent: the GPU utilization collected by the CloudMonitor agent. Unit: %.</description></item>
                /// <item><description>GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory collected by the CloudMonitor agent. Unit: %.</description></item>
                /// <item><description>GpuMemoryUtilizationAgent: the GPU memory utilization collected by the CloudMonitor agent. Unit: %.</description></item>
                /// <item><description>MemoryUtilization: the memory utilization collected by the CloudMonitor agent. Unit: %.</description></item>
                /// <item><description>LoadAverage: the average system load collected by the CloudMonitor agent.</description></item>
                /// <item><description>TcpConnection: the total number of TCP connections collected by the CloudMonitor agent.</description></item>
                /// <item><description>TcpConnection: the number of established TCP connections collected by the CloudMonitor agent.</description></item>
                /// <item><description>PackagesNetOut: the number of packets sent by the internal network interface controller (NIC) per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
                /// <item><description>PackagesNetIn: the number of packets received by the internal network interface controller (NIC) per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
                /// <item><description>PackagesNetOut: the number of packets sent by the public network interface controller (NIC) per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
                /// <item><description>PackagesNetIn: the number of packets received by the public network interface controller (NIC) per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
                /// <item><description>EciPodCpuUtilization: the CPU utilization. Unit: %.</description></item>
                /// <item><description>EciPodMemoryUtilization: the memory utilization. Unit: %.</description></item>
                /// <item><description>LoadBalancerRealServerAverageQps: the average QPS per backend server in an ALB server group. Unit: queries/s.</description></item>
                /// </list>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered nodes for system monitoring</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CpuUtilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The period at which metric data is collected in the multi-metric alert rule. Unit: seconds. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>15</description></item>
                /// <item><description>60</description></item>
                /// <item><description>120</description></item>
                /// <item><description>300</description></item>
                /// <item><description>900</description></item>
                /// </list>
                /// <remarks>
                /// <para>A statistical period of 15 seconds is supported only when you monitor a scaling group that contains ECS instances and use metrics collected by the CloudMonitor agent (metrics whose names start with Agent).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// <para>The statistical method used for metric data in the multi-metric alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average: the average value.</description></item>
                /// <item><description>Minimum: the minimum value.</description></item>
                /// <item><description>Maximum: the maximum value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold of the monitoring metrics in the multi-metric alert rule. The scaling rule is triggered when the threshold expression is met for the specified number of times.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40.0</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The logical operator that specifies the relationship among multiple monitoring alert conditions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>&amp;&amp;</c>: An alert is triggered only when all monitoring metrics meet the alert conditions. That is, an alert is triggered only when all expressions in the multi-metric alert rule evaluate to <c>true</c>.</description></item>
            /// <item><description><c>||</c>: An alert is triggered when any of the monitoring metrics meets the alert condition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&amp;&amp;</para>
            /// </summary>
            [NameInMap("ExpressionsLogicOperator")]
            [Validation(Required=false)]
            public string ExpressionsLogicOperator { get; set; }

            /// <summary>
            /// <para>The monitoring metrics settings of Hybrid Cloud Monitoring. For more information about how to configure the settings, see <a href="https://help.aliyun.com/document_detail/2852162.html">Use formulas to customize target tracking scaling rules</a>.</para>
            /// </summary>
            [NameInMap("HybridMetrics")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListHybridMetrics> HybridMetrics { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListHybridMetrics : TeaModel {
                /// <summary>
                /// <para>The dimensions of the metric. This is used to specify the resources monitored by the metric.</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<DescribeAlarmsResponseBodyAlarmListHybridMetricsDimensions> Dimensions { get; set; }
                public class DescribeAlarmsResponseBodyAlarmListHybridMetricsDimensions : TeaModel {
                    /// <summary>
                    /// <para>The key of the metric dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>queue</para>
                    /// </summary>
                    [NameInMap("DimensionKey")]
                    [Validation(Required=false)]
                    public string DimensionKey { get; set; }

                    /// <summary>
                    /// <para>The value of the metric dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testQueue</para>
                    /// </summary>
                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                /// <summary>
                /// <para>The metric calculation expression for multiple Hybrid Cloud Monitoring metrics. The calculation result of the expression is used to trigger scaling activities. The calculation expression must comply with the Reverse Polish Notation (RPN) specification, and only the <c>+</c>, <c>-</c>, <c>*</c>, and <c>/</c> operators are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(a+b)/2</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The reference ID of the metric in the metric calculation expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the monitoring metrics in the Hybrid Cloud Monitoring metrics repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunSmq_NumberOfMessagesVisible</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The statistical method of the metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average: the average value of all data points in the specified period.</description></item>
                /// <item><description>Minimum: the minimum value of all data points in the specified period.</description></item>
                /// <item><description>Maximum: the maximum value of all data points in the specified period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistic")]
                [Validation(Required=false)]
                public string Statistic { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Hybrid Cloud Monitoring metrics repository.</para>
            /// <para>For more information about how to manage metrics repositories, see <a href="https://help.aliyun.com/document_detail/217606.html">Manage metrics repositories</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("HybridMonitorNamespace")]
            [Validation(Required=false)]
            public string HybridMonitorNamespace { get; set; }

            /// <summary>
            /// <para>The name of the metric. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>CpuUtilization: the CPU utilization of an ECS instance. Unit: %.</description></item>
            /// <item><description>ConcurrentConnections: the number of concurrent connections to an ECS instance.</description></item>
            /// <item><description>IntranetTx: the outbound internal traffic of an ECS instance. Unit: Kbit/min.</description></item>
            /// <item><description>IntranetRx: the inbound internal traffic of an ECS instance. Unit: Kbit/min.</description></item>
            /// <item><description>VpcInternetTx: the outbound Internet traffic of an ECS instance. Unit: Kbit/min.</description></item>
            /// <item><description>VpcInternetRx: the inbound Internet traffic of an ECS instance. Unit: Kbit/min.</description></item>
            /// <item><description>SystemDiskReadBps: the number of bytes read from the system cloud disk per second. Unit: Byte/s.</description></item>
            /// <item><description>SystemDiskWriteBps: the number of bytes written to the system cloud disk per second. Unit: Byte/s.</description></item>
            /// <item><description>SystemDiskReadOps: the number of read operations on the system cloud disk per second. Unit: IOPS.</description></item>
            /// <item><description>SystemDiskWriteOps: the number of write operations on the system cloud disk per second. Unit: IOPS.</description></item>
            /// <item><description>CpuUtilizationAgent: the CPU utilization collected by the CloudMonitor agent. Unit: %.</description></item>
            /// <item><description>GpuUtilizationAgent: the GPU utilization collected by the CloudMonitor agent. Unit: %.</description></item>
            /// <item><description>GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory collected by the CloudMonitor agent. Unit: %.</description></item>
            /// <item><description>GpuMemoryUtilizationAgent: the GPU memory utilization collected by the CloudMonitor agent. Unit: %.</description></item>
            /// <item><description>MemoryUtilization: the memory utilization collected by the CloudMonitor agent. Unit: %.</description></item>
            /// <item><description>LoadAverage: the average system load collected by the CloudMonitor agent.</description></item>
            /// <item><description>TcpConnection: the total number of TCP connections collected by the CloudMonitor agent.</description></item>
            /// <item><description>TcpConnection: the number of established TCP connections collected by the CloudMonitor agent.</description></item>
            /// <item><description>PackagesNetOut: the number of packets sent by the internal NIC per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
            /// <item><description>PackagesNetIn: the number of packets received by the internal NIC per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
            /// <item><description>PackagesNetOut: the number of packets sent by the public NIC per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
            /// <item><description>PackagesNetIn: the number of packets received by the public NIC per second collected by the CloudMonitor agent. Unit: packets/s.</description></item>
            /// <item><description>EciPodCpuUtilization: the CPU utilization. Unit: %.</description></item>
            /// <item><description>EciPodMemoryUtilization: the memory utilization. Unit: %.</description></item>
            /// <item><description>LoadBalancerRealServerAverageQps: the average QPS per backend server in an ALB server group. Unit: queries/s.</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered tasks for system monitoring</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CpuUtilization</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The type of the metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system metrics of CloudMonitor.</description></item>
            /// <item><description>custom: custom metrics reported to CloudMonitor.</description></item>
            /// <item><description>hybrid: metrics of Hybrid Cloud Monitoring.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// <para>The name of the event-triggered task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestAlarmTask</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The period at which metric data is collected. Unit: seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>15</description></item>
            /// <item><description>60</description></item>
            /// <item><description>120</description></item>
            /// <item><description>300</description></item>
            /// <item><description>900</description></item>
            /// </list>
            /// <remarks>
            /// <para>A statistical period of 15 seconds is supported only for scaling groups that contain ECS instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The PromQL query statement for Hybrid Cloud Monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(avg(last_over_time(AliyunMnsnew_ActiveMessages{region=\&quot;cn-hangzhou\&quot;,userId=\&quot;123456****\&quot;,queue=\&quot;testQueue\&quot;}[900s])) by (userId))/(avg(last_over_time(AliyunEss_RunningInstanceCount{instanceId=\&quot;asg-bp1****\&quot;}[900s])) by (userId) != 0)</para>
            /// </summary>
            [NameInMap("PromQL")]
            [Validation(Required=false)]
            public string PromQL { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group with which the event-triggered task is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp18p2yfxow2dloq****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The state of the event-triggered task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALARM: Alerting. The alert condition is met.</description></item>
            /// <item><description>OK: Normal. The alert condition is not met.</description></item>
            /// <item><description>INSUFFICIENT_DATA: Insufficient data. The data is insufficient to determine whether the alert condition is met.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALARM</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The statistical method used for metric data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Average: the average value.</description></item>
            /// <item><description>Minimum: the minimum value.</description></item>
            /// <item><description>Maximum: the maximum value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The threshold of the monitoring metrics. The scaling rule is triggered when the threshold expression is met for the specified number of times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80.0</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>871C7C53-34A4-45AA-8C14-4B72FA6A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of event-triggered tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
