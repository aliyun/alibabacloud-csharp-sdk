// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeAlarmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The event-triggered tasks.</para>
        /// </summary>
        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public List<DescribeAlarmsResponseBodyAlarmList> AlarmList { get; set; }
        public class DescribeAlarmsResponseBodyAlarmList : TeaModel {
            /// <summary>
            /// <para>The unique identifiers of the scaling rules that are associated with the event-triggered task.</para>
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
            /// <para>The operator that is used to compare the metric value and the metric threshold.</para>
            /// <list type="bullet">
            /// <item><description>Valid value if the metric value is greater than or equal to the threshold: &gt;=.</description></item>
            /// <item><description>Valid value if the metric value is less than or equal to the threshold: &lt;=.</description></item>
            /// <item><description>Valid value if the metric value is greater than the threshold: &gt;.</description></item>
            /// <item><description>Valid value if the metric value is less than the threshold: &lt;.</description></item>
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
            /// <para>The metric dimensions.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListDimensions> Dimensions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListDimensions : TeaModel {
                /// <summary>
                /// <para>The dimension key of the metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>user_id: the ID of your Alibaba Cloud account.</description></item>
                /// <item><description>scaling_group: the scaling group that is monitored by the event-triggered task.</description></item>
                /// <item><description>device: the NIC type.</description></item>
                /// <item><description>state: the status of the TCP connection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>device</para>
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// <para>The dimension value of the metric. The value of DimensionValue varies based on the value of DimensionKey.</para>
                /// <list type="bullet">
                /// <item><description><para>If you set DimensionKey to <c>user_id</c>, the system specifies the value of DimensionValue.</para>
                /// </description></item>
                /// <item><description><para>If you set DimensionKey to <c>scaling_group</c>, the system specifies the value of DimensionValue.</para>
                /// </description></item>
                /// <item><description><para>If you set DimensionKey to <c>device</c>, you can set DimensionValue to eth0 or eth1.</para>
                /// <list type="bullet">
                /// <item><description>For instances of the classic network type, eth0 indicates the internal NIC. Only one eth0 NIC exists on each instance that resides in VPCs.</description></item>
                /// <item><description>For instances of the classic network type, eth1 indicates the public NIC.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If you set DimensionKey to <c>state</c>, you can set DimensionValue to TCP_TOTAL or ESTABLISHED.</para>
                /// <list type="bullet">
                /// <item><description>TCP_TOTAL indicates the total number of TCP connections.</description></item>
                /// <item><description>ESTABLISHED indicates the number of TCP connections that are established.</description></item>
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
            /// <para>The effective period of the event-triggered task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Effective")]
            [Validation(Required=false)]
            public string Effective { get; set; }

            /// <summary>
            /// <para>Indicates whether the event-triggered task feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The number of consecutive times that the threshold must be reached before a scaling rule is executed. For example, if you set this parameter to 3, the average CPU utilization must reach or exceed 80% three times in a row before a scaling rule is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            /// <summary>
            /// <para>The alert conditions of the multi-metric alert rule.</para>
            /// </summary>
            [NameInMap("Expressions")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListExpressions> Expressions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListExpressions : TeaModel {
                /// <summary>
                /// <para>The operator that is used to compare the metric value and the threshold.</para>
                /// <list type="bullet">
                /// <item><description>Valid value if the metric value is greater than or equal to the threshold: &gt;=.</description></item>
                /// <item><description>Valid value if the metric value is less than or equal to the threshold: &lt;=.</description></item>
                /// <item><description>Valid value if the metric value is greater than the threshold: &gt;.</description></item>
                /// <item><description>Valid value if the metric value is less than the threshold: &lt;.</description></item>
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
                /// <para>The name of the metric that is specified in the multi-metric alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CpuUtilization: the CPU utilization of an ECS instance. Unit: %.</description></item>
                /// <item><description>ConcurrentConnections: the number of current connections to an ECS instance.</description></item>
                /// <item><description>IntranetTx: the outbound traffic over an internal network. Unit: KB/min.</description></item>
                /// <item><description>IntranetRx: the inbound traffic over an internal network. Unit: KB/min.</description></item>
                /// <item><description>VpcInternetTx: the outbound traffic over a VPC. Unit: KB/min.</description></item>
                /// <item><description>VpcInternetRx: the inbound traffic over a VPC. Unit: KB/min.</description></item>
                /// <item><description>SystemDiskReadBps: the number of bytes read from the system disk per second.</description></item>
                /// <item><description>SystemDiskWriteBps: the number of bytes written to the system disk per second.</description></item>
                /// <item><description>SystemDiskReadOps: the read IOPS of the system disk. Unit: counts/s.</description></item>
                /// <item><description>SystemDiskWriteOps: the write IOPS of the system disk. Unit: counts/s.</description></item>
                /// <item><description>CpuUtilizationAgent: the CPU utilization. Unit: %.</description></item>
                /// <item><description>GpuUtilizationAgent: the GPU utilization. Unit: %.</description></item>
                /// <item><description>GpuMemoryFreeUtilizationAgent: the idle GPU memory usage. Unit: %.</description></item>
                /// <item><description>GpuMemoryUtilizationAgent: the GPU memory usage. Unit: %.</description></item>
                /// <item><description>MemoryUtilization: the memory usage. Unit: %.</description></item>
                /// <item><description>LoadAverage: the average system load.</description></item>
                /// <item><description>TcpConnection: the total number of TCP connections.</description></item>
                /// <item><description>TcpConnection: the number of established TCP connections.</description></item>
                /// <item><description>PackagesNetOut: the number of packets sent by the internal NIC. Unit: counts/s.</description></item>
                /// <item><description>PackagesNetIn: the number of packets received by the internal NIC. Unit: counts/s.</description></item>
                /// <item><description>PackagesNetOut: the number of packets sent by the public NIC. Unit: counts/s.</description></item>
                /// <item><description>PackagesNetIn: the number of packets received by the public NIC. Unit: counts/s.</description></item>
                /// <item><description>EciPodCpuUtilization: the CPU utilization. Unit: %.</description></item>
                /// <item><description>EciPodMemoryUtilization: the memory usage. Unit: %.</description></item>
                /// <item><description>LoadBalancerRealServerAverageQps: the QPS of an instance.</description></item>
                /// </list>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered tasks of the system monitoring type</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CpuUtilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The statistical period of the metric data in the multi-metric alert rule. Unit: seconds. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>15</description></item>
                /// <item><description>60</description></item>
                /// <item><description>120</description></item>
                /// <item><description>300</description></item>
                /// <item><description>900</description></item>
                /// </list>
                /// <remarks>
                /// <para> If your scaling group is of the ECS type and the event-triggered task that is associated with your scaling group monitors CloudMonitor metrics, you can set Period to 15. In most cases, the name of a CloudMonitor metric contains Agent.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// <para>The method that is used to aggregate statistics about the metrics in the multi-metric alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average: the average value</description></item>
                /// <item><description>Minimum: the minimum value</description></item>
                /// <item><description>Maximum: the maximum value</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Average</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The threshold of the metric value. If the threshold is reached the specified number of times within the specified period, a scaling rule is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40.0</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The relationship between the trigger conditions that are specified in the multi-metric alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>&amp;&amp;</c>: An alert is triggered only if all metrics in the multi-metric alert rule meet their trigger conditions. In this case, an alert is triggered only if the results of all trigger conditions that are specified in the multi-metric alert rule are <c>true</c>.</description></item>
            /// <item><description><c>||</c>: An alert is triggered only if one of the metrics in the multi-metric alert rule meets its trigger condition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&amp;&amp;</para>
            /// </summary>
            [NameInMap("ExpressionsLogicOperator")]
            [Validation(Required=false)]
            public string ExpressionsLogicOperator { get; set; }

            /// <summary>
            /// <para>The Hybrid Cloud Monitoring metrics.</para>
            /// </summary>
            [NameInMap("HybridMetrics")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListHybridMetrics> HybridMetrics { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListHybridMetrics : TeaModel {
                /// <summary>
                /// <para>The metric dimensions. This parameter is used to specify the monitored resources.</para>
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
                    /// <para>The key of the metric dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testQueue</para>
                    /// </summary>
                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                /// <summary>
                /// <para>The metric expression that consists of multiple Hybrid Cloud Monitoring metrics. It calculates a result used to trigger scaling events.</para>
                /// <para>The expression is written in Reverse Polish Notation (RPN) format and supports only the following operators: <c>+, -, *, /</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(a+b)/2</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The reference ID of the metric in the metric expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the Hybrid Cloud Monitoring metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunSmq_NumberOfMessagesVisible</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The statistical method of the metric value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Average: The average value of all metric values within a specified interval is calculated.</description></item>
                /// <item><description>Minimum: The minimum value of all metric values within a specified interval is calculated.</description></item>
                /// <item><description>Maximum: The maximum value of all metric values within a specified interval is calculated.</description></item>
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
            /// <para>The ID of the Hybrid Cloud Monitoring namespace.</para>
            /// <para>For information about how to manage Hybrid Cloud Monitoring namespaces, see <a href="https://help.aliyun.com/document_detail/217606.html">Manage namespaces</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("HybridMonitorNamespace")]
            [Validation(Required=false)]
            public string HybridMonitorNamespace { get; set; }

            /// <summary>
            /// <para>The metric name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CpuUtilization: the CPU utilization of an Elastic Compute Service (ECS) instance. Unit: %.</description></item>
            /// <item><description>ConcurrentConnections: the number of current connections to an ECS instance.</description></item>
            /// <item><description>IntranetTx: the outbound traffic over an internal network. Unit: KB/min.</description></item>
            /// <item><description>IntranetRx: the inbound traffic over an internal network. Unit: KB/min.</description></item>
            /// <item><description>VpcInternetTx: the outbound traffic over a virtual private cloud (VPC). Unit: KB/min.</description></item>
            /// <item><description>VpcInternetRx: the inbound traffic over a VPC. Unit: KB/min.</description></item>
            /// <item><description>SystemDiskReadBps: the number of bytes read from the system disk per second.</description></item>
            /// <item><description>SystemDiskWriteBps: the number of bytes written to the system disk per second.</description></item>
            /// <item><description>SystemDiskReadOps: the read IOPS of the system disk. Unit: counts/s.</description></item>
            /// <item><description>SystemDiskWriteOps: the write IOPS of the system disk. Unit: counts/s.</description></item>
            /// <item><description>CpuUtilizationAgent: the CPU utilization. Unit: %.</description></item>
            /// <item><description>GpuUtilizationAgent: the GPU utilization. Unit: %.</description></item>
            /// <item><description>GpuMemoryFreeUtilizationAgent: the idle GPU memory usage. Unit: %.</description></item>
            /// <item><description>GpuMemoryUtilizationAgent: the GPU memory usage. Unit: %.</description></item>
            /// <item><description>MemoryUtilization: the memory usage. Unit: %.</description></item>
            /// <item><description>LoadAverage: the average system load.</description></item>
            /// <item><description>TcpConnection: the total number of TCP connections.</description></item>
            /// <item><description>TcpConnection: the number of established TCP connections.</description></item>
            /// <item><description>PackagesNetOut: the number of packets sent by the internal NIC. Unit: counts/s.</description></item>
            /// <item><description>PackagesNetIn: the number of packets received by the internal NIC. Unit: counts/s.</description></item>
            /// <item><description>PackagesNetOut: the number of packets sent by the public NIC. Unit: counts/s.</description></item>
            /// <item><description>PackagesNetIn: the number of packets received by the public NIC. Unit: counts/s.</description></item>
            /// <item><description>EciPodCpuUtilization: the CPU utilization. Unit: %.</description></item>
            /// <item><description>EciPodMemoryUtilization: the memory usage. Unit: %.</description></item>
            /// <item><description>LoadBalancerRealServerAverageQps: the queries per second (QPS) of an instance.</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered tasks of the system monitoring type</a>.</para>
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
            /// <item><description>system: system metrics of CloudMonitor</description></item>
            /// <item><description>custom: custom metrics that are reported to CloudMonitor.</description></item>
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
            /// <para>The statistical period of the metric data. Unit: seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>15</description></item>
            /// <item><description>60</description></item>
            /// <item><description>120</description></item>
            /// <item><description>300</description></item>
            /// <item><description>900</description></item>
            /// </list>
            /// <remarks>
            /// <para> You can set the value of this parameter to 15 Seconds only for scaling groups of the ECS type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The PromQL statement of Hybrid Cloud Monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(avg(last_over_time(AliyunMnsnew_ActiveMessages{region=\&quot;cn-hangzhou\&quot;,userId=\&quot;123456****\&quot;,queue=\&quot;testQueue\&quot;}[900s])) by (userId))/(avg(last_over_time(AliyunEss_RunningInstanceCount{instanceId=\&quot;asg-bp1****\&quot;}[900s])) by (userId) != 0)</para>
            /// </summary>
            [NameInMap("PromQL")]
            [Validation(Required=false)]
            public string PromQL { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group to which the event-triggered task is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp18p2yfxow2dloq****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The status of the event-triggered task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALARM: The alert condition is met and an alert is triggered.</description></item>
            /// <item><description>OK: The alert condition is not met.</description></item>
            /// <item><description>INSUFFICIENT_DATA: Auto Scaling cannot determine whether the alert condition is met due to insufficient data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALARM</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The method that is used to aggregate the metric data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Average: the average value</description></item>
            /// <item><description>Minimum: the minimum value</description></item>
            /// <item><description>Maximum: the maximum value</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The threshold of the metric. If the threshold is reached the specified number of times within the statistical period, a scaling rule is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80.0</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
