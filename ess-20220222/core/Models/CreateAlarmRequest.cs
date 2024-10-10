// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The list of unique identifiers of the scaling rules that are associated with the event-triggered task.</para>
        /// </summary>
        [NameInMap("AlarmActions")]
        [Validation(Required=false)]
        public List<string> AlarmActions { get; set; }

        /// <summary>
        /// <para>The operator that is used to compare the metric value and the threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the metric value is greater than or equal to the threshold, set the value to: &gt;=.</description></item>
        /// <item><description>If the metric value is less than or equal to the threshold, set the value to: &lt;=.</description></item>
        /// <item><description>If the metric value is greater than the threshold, set the value to: &gt;.</description></item>
        /// <item><description>If the metric value is less than the threshold, set the value to: &lt;.</description></item>
        /// </list>
        /// <para>Default value: &gt;=.</para>
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
        public List<CreateAlarmRequestDimensions> Dimensions { get; set; }
        public class CreateAlarmRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The dimension key of the metric. The valid values vary based on the metric type.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set MetricType to custom, you can specify this parameter based on your business requirements.</para>
            /// </description></item>
            /// <item><description><para>If you set MetricType to system, this parameter has the following valid values:</para>
            /// <list type="bullet">
            /// <item><description>user_id: the ID of your Alibaba Cloud account.</description></item>
            /// <item><description>scaling_group: the scaling group that you want to monitor by using the event-triggered task.</description></item>
            /// <item><description>device: the NIC type.</description></item>
            /// <item><description>state: the status of the TCP connection.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>device</para>
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// <para>The dimension value of the metric. The valid values of this parameter vary based on the value of Dimensions.DimensionKey.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set MetricType to custom, you can specify this parameter based on your business requirements.</para>
            /// </description></item>
            /// <item><description><para>If you set MetricType to system, this parameter has the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>user_id: The system specifies the value.</para>
            /// </description></item>
            /// <item><description><para>scaling_group: The system specifies the value.</para>
            /// </description></item>
            /// <item><description><para>device: You can set this parameter to eth0 or eth1.</para>
            /// <list type="bullet">
            /// <item><description>For instances of the classic network type, eth0 specifies the internal NIC. Only one eth0 NIC exists on each instance that resides in VPCs.</description></item>
            /// <item><description>For instances of the classic network type, eth1 specifies the public NIC.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>state: You can set this parameter to TCP_TOTAL or ESTABLISHED.</para>
            /// <list type="bullet">
            /// <item><description>TCP_TOTAL specifies the total number of TCP connections.</description></item>
            /// <item><description>ESTABLISHED specifies the number of TCP connections that are established.</description></item>
            /// </list>
            /// </description></item>
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
        /// <para>The effective period of the event-triggered task. By default, the event-triggered task is in effect all the time.</para>
        /// <para>This parameter follows the cron expression format. The default format is <c>X X X X X ?</c>. In the format:</para>
        /// <list type="bullet">
        /// <item><description>X: a placeholder for a field, which represents seconds, minutes, hours, days, and months in sequence. X can be a definite value or a special character that has logical meaning. For information about the valid values of X, see <a href="https://help.aliyun.com/document_detail/25907.html">Cron expression</a>.</description></item>
        /// <item><description>?: No value is specified.</description></item>
        /// </list>
        /// <remarks>
        /// <para>By default, this parameter value is specified in <b>UTC+8</b>. You can specify the time zone in the <c>TZ=+yy</c> format before a cron expression. y indicates the time zone. For example, <c>TZ=+00 * * 1-2 * * ?</c> specifies that the event-triggered task is in effect between 01:00 and 02:59 (UTC+0) every day.</para>
        /// </remarks>
        /// <para>Sample values:</para>
        /// <list type="bullet">
        /// <item><description><c>* * * * * ? </c>: The event-triggered task is in effect all the time.</description></item>
        /// <item><description><c>* * 17-18 * * ? </c>: The event-triggered task is in effect between 17:00 and 18:59 (UTC+8) every day.</description></item>
        /// <item><description><c>TZ=+00 * * 1-2 * * ?</c>: The event-triggered task is in effect between 01:00 and 02:59 (UTC+0) every day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TZ=+00 * * 1-2 * * ?</para>
        /// </summary>
        [NameInMap("Effective")]
        [Validation(Required=false)]
        public string Effective { get; set; }

        /// <summary>
        /// <para>The number of times that the threshold must be reached before a scaling rule can be executed. For example, if you set this parameter to 3, the average CPU utilization must reach or exceed 80% three times in a row before a scaling rule is triggered.</para>
        /// <para>Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The information about the multi-metric alert rules.</para>
        /// </summary>
        [NameInMap("Expressions")]
        [Validation(Required=false)]
        public List<CreateAlarmRequestExpressions> Expressions { get; set; }
        public class CreateAlarmRequestExpressions : TeaModel {
            /// <summary>
            /// <para>The operator that you want to use to compare the metric value and the threshold in the multi-metric alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the metric value is greater than or equal to the threshold, set the value to &gt;=.</description></item>
            /// <item><description>If the metric value is less than or equal to the metric threshold, set the value to &lt;=.</description></item>
            /// <item><description>If the metric value is greater than the metric threshold, set the value to &gt;.</description></item>
            /// <item><description>If the metric value is less than the metric threshold, set the value to &lt;.</description></item>
            /// </list>
            /// <para>Default value: &gt;=.</para>
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
            /// <para>The names of the metrics in the multi-metric alert rule. The valid values of this parameter vary based on the metric type.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set MetricType to custom, the valid values are the metrics that you have.</para>
            /// </description></item>
            /// <item><description><para>If you set MetricType to system, this parameter has the following valid values:</para>
            /// <list type="bullet">
            /// <item><description>CpuUtilization: the CPU utilization. Unit: %.</description></item>
            /// <item><description>ConcurrentConnections: the number of concurrent connections.</description></item>
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
            /// </description></item>
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
            /// <para> You can set this parameter to 15 seconds only for scaling groups of the ECS type.</para>
            /// </remarks>
            /// <para>Default value: 300.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The method that you want to use to aggregate the metric data in the multi-metric alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Average: the average value.</description></item>
            /// <item><description>Minimum: the minimum value</description></item>
            /// <item><description>Maximum: the maximum value</description></item>
            /// </list>
            /// <para>Default value: Average.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The threshold of the metric value in the multi-metric alert rule. If the threshold is reached the specified number of times within the statistical period, a scaling rule is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40.0</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <para>The relationship between the trigger conditions in the multi-metric alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>&amp;&amp;</c>: An alert is triggered only if all metrics in the multi-metric alert rule meet the trigger conditions. In this case, an alert is triggered only if the results of all trigger conditions that are specified in the multi-metric alert rule are <c>true</c>.</description></item>
        /// <item><description><c>||</c>: An alert is triggered if one of the metrics in the multi-metric alert rule meets the trigger conditions.</description></item>
        /// </list>
        /// <para>Default value: <c>&amp;&amp;</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&amp;&amp;</para>
        /// </summary>
        [NameInMap("ExpressionsLogicOperator")]
        [Validation(Required=false)]
        public string ExpressionsLogicOperator { get; set; }

        /// <summary>
        /// <para>The ID of the application group to which the custom metric belongs. If you set the MetricType parameter to custom, you must specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4055401</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// <para>The metric name. The valid values of this parameter vary based on the metric type.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set MetricType to custom, the valid values are the metrics that you have.</para>
        /// </description></item>
        /// <item><description><para>If you set MetricType to system, this parameter has the following valid values:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilization: the CPU utilization. Unit: %.</description></item>
        /// <item><description>ConcurrentConnections: the number of concurrent connections.</description></item>
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
        /// <item><description>PackagesNetOut: the number of packets sent by the internal network interface controller (NIC). Unit: counts/s.</description></item>
        /// <item><description>PackagesNetIn: the number of packets received by the internal NIC. Unit: counts/s.</description></item>
        /// <item><description>PackagesNetOut: the number of packets sent by the public NIC. Unit: counts/s.</description></item>
        /// <item><description>PackagesNetIn: the number of packets received by the public NIC. Unit: counts/s.</description></item>
        /// <item><description>EciPodCpuUtilization: the CPU utilization. Unit: %.</description></item>
        /// <item><description>EciPodMemoryUtilization: the memory usage. Unit: %.</description></item>
        /// <item><description>LoadBalancerRealServerAverageQps: the queries per second (QPS) of an instance.</description></item>
        /// </list>
        /// </description></item>
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
        /// <item><description>custom: custom metrics that are reported to CloudMonitor</description></item>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// <para> You can set this parameter to 15 seconds only for scaling groups of the ECS type.</para>
        /// </remarks>
        /// <para>Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The scaling group ID of the event-triggered task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The method that is used to aggregate statistics for the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Average</description></item>
        /// <item><description>Minimum</description></item>
        /// <item><description>Maximum</description></item>
        /// </list>
        /// <para>Default value: Average.</para>
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
        /// <para>80.0</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
