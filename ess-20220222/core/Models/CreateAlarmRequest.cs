// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The list of unique identifiers of the scaling rules associated with the event-triggered task.</para>
        /// </summary>
        [NameInMap("AlarmActions")]
        [Validation(Required=false)]
        public List<string> AlarmActions { get; set; }

        /// <summary>
        /// <para>The comparison operator used to compare the aggregated metric value with the threshold. This operator specifies the condition under which the threshold is met. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><remarks>
        /// <para>=: The aggregated metric value is greater than or equal to the threshold.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>&lt;=: The aggregated metric value is less than or equal to the threshold.</description></item>
        /// <item><description><remarks>
        /// <para>: The aggregated metric value is greater than the threshold.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>&lt;: The aggregated metric value is less than the threshold.</description></item>
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
        /// <para>The dimension information associated with the metric.</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateAlarmRequestDimensions> Dimensions { get; set; }
        public class CreateAlarmRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension information associated with the metric. Valid values vary based on the monitoring type of the event-triggered task:</para>
            /// <list type="bullet">
            /// <item><description><para>If the event-triggered task is of the custom monitoring type (MetricType=custom), the valid values are not limited and can be specified by you.</para>
            /// </description></item>
            /// <item><description><para>If the event-triggered task is of the system monitoring type (MetricType=system), valid values:</para>
            /// <list type="bullet">
            /// <item><description>user_id: the ID of your account.</description></item>
            /// <item><description>scaling_group: the monitored scaling group.</description></item>
            /// <item><description>device: the type of the network interface controller (NIC) device.</description></item>
            /// <item><description>state: the state of the TCP connection.</description></item>
            /// <item><description>rulePool: the ALB server group specified for the QPS monitoring metrics.</description></item>
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
            /// <para>The value of the dimension information associated with the metric. Valid values vary based on Dimensions.DimensionKey:</para>
            /// <list type="bullet">
            /// <item><description><para>If Dimensions.DimensionKey is custom, which means the event-triggered task is of the custom monitoring type (MetricType=custom), the valid values are not limited and can be specified by you.</para>
            /// </description></item>
            /// <item><description><para>If Dimensions.DimensionKey is within the system-specified range, which means the event-triggered task is of the system monitoring type (MetricType=system), valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>user_id: automatically populated by the system.</para>
            /// </description></item>
            /// <item><description><para>scaling_group: automatically populated by the system.</para>
            /// </description></item>
            /// <item><description><para>device:</para>
            /// <list type="bullet">
            /// <item><description><para>eth0: For classic network instances, eth0 represents the internal NIC. For VPC-connected instances, only the eth0 NIC exists.</para>
            /// </description></item>
            /// <item><description><para>eth1: For classic network instances, eth1 represents the public NIC.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>state:</para>
            /// <list type="bullet">
            /// <item><description><para>TCP_TOTAL: the total number of TCP connections.</para>
            /// </description></item>
            /// <item><description><para>ESTABLISHED: the number of established TCP connections.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>rulePool: the ID of the ALB server group. Example: sgp-xxxxx.</para>
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
        /// <para>Specifies the effective period of the event-triggered task. By default, the task takes effect at all times.</para>
        /// <para>This parameter follows the cron expression format. The default format is <c>X X X X X ?</c>, which is described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>X: a placeholder for a field, representing seconds, minutes, hours, day of month, and month in sequence. X can be a specific value or a special character with logical meaning. For more information about the valid values of X, see <a href="https://help.aliyun.com/document_detail/25907.html">Cron expressions</a>.</para>
        /// </description></item>
        /// <item><description><para>?: indicates that no value is specified.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The specified value of this parameter <b>defaults to the UTC+8 time zone</b>. You can add the time zone information <c>TZ=+yy</c> before the cron expression to specify a time zone, where y represents the time zone offset. For example, <c>TZ=+00 * * 1-2 * * ?</c> indicates that the event-triggered task takes effect between 01:00 and 02:59 every day in the UTC+0 time zone.</para>
        /// </remarks>
        /// <para>Examples and their meanings:</para>
        /// <list type="bullet">
        /// <item><description><para><c>* * * * * ?</c>: takes effect at all times.</para>
        /// </description></item>
        /// <item><description><para><c>* * 17-18 * * ?</c>: takes effect between 17:00 and 18:59 every day in the UTC+8 time zone.</para>
        /// </description></item>
        /// <item><description><para><c>TZ=+00 * * 1-2 * * ?</c>: takes effect between 01:00 and 02:59 every day in the UTC+0 time zone.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TZ=+00 * * 1-2 * * ?</para>
        /// </summary>
        [NameInMap("Effective")]
        [Validation(Required=false)]
        public string Effective { get; set; }

        /// <summary>
        /// <para>The number of times that the threshold expression must be met to trigger a scaling rule. For example, if this parameter is set to 3, the scaling rule is triggered when the average CPU utilization is greater than or equal to 80% for three consecutive times.</para>
        /// <para>Default value: 3.</para>
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
        public List<CreateAlarmRequestExpressions> Expressions { get; set; }
        public class CreateAlarmRequestExpressions : TeaModel {
            /// <summary>
            /// <para>The comparison operator used to compare the aggregated metric value with the threshold for the multi-metric alert rule. This operator specifies the condition under which the threshold is met. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><remarks>
            /// <para>=: The aggregated metric value is greater than or equal to the threshold.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>&lt;=: The aggregated metric value is less than or equal to the threshold.</description></item>
            /// <item><description><remarks>
            /// <para>: The aggregated metric value is greater than the threshold.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>&lt;: The aggregated metric value is less than the threshold.</description></item>
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
            /// <para>The name of the monitoring metrics for the multi-metric alert rule. Valid values vary based on the monitoring type of the event-triggered task:</para>
            /// <list type="bullet">
            /// <item><description><para>If the event-triggered task is of the custom monitoring type (MetricType=custom), the valid values are your custom metrics.</para>
            /// </description></item>
            /// <item><description><para>If the event-triggered task is of the system monitoring type (MetricType=system), valid values: </para>
            /// <list type="bullet">
            /// <item><description><para>CpuUtilization: the CPU utilization of an ECS instance (%).</para>
            /// </description></item>
            /// <item><description><para>ConcurrentConnections: the number of concurrent connections to an ECS instance.</para>
            /// </description></item>
            /// <item><description><para>IntranetTx: the outbound internal network traffic of an ECS instance (Kb/min).</para>
            /// </description></item>
            /// <item><description><para>IntranetRx: the inbound internal network traffic of an ECS instance (Kb/min).</para>
            /// </description></item>
            /// <item><description><para>VpcInternetTx: the outbound Internet traffic of an ECS instance (Kb/min).</para>
            /// </description></item>
            /// <item><description><para>VpcInternetRx: the inbound Internet traffic of an ECS instance (Kb/min).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskReadBps: the read BPS of the system cloud disk (Byte/s).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskWriteBps: the write BPS of the system cloud disk (Byte/s).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskReadOps: the read IOPS of the system cloud disk (operations/s).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskWriteOps: the write IOPS of the system cloud disk (operations/s).</para>
            /// </description></item>
            /// <item><description><para>CpuUtilizationAgent: the CPU utilization monitored by the agent (%).</para>
            /// </description></item>
            /// <item><description><para>GpuUtilizationAgent: the GPU utilization monitored by the agent (%).</para>
            /// </description></item>
            /// <item><description><para>GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory monitored by the agent (%).</para>
            /// </description></item>
            /// <item><description><para>GpuMemoryUtilizationAgent: the GPU memory utilization monitored by the agent (%).</para>
            /// </description></item>
            /// <item><description><para>MemoryUtilization: the memory utilization monitored by the agent (%).</para>
            /// </description></item>
            /// <item><description><para>LoadAverage: the average system load monitored by the agent.</para>
            /// </description></item>
            /// <item><description><para>TcpConnection: the total number of TCP connections monitored by the agent.</para>
            /// </description></item>
            /// <item><description><para>TcpConnection: the number of established TCP connections monitored by the agent.</para>
            /// </description></item>
            /// <item><description><para>PackagesNetOut: the number of packets sent by the internal network interface controller (NIC) per second monitored by the agent (packets/s).</para>
            /// </description></item>
            /// <item><description><para>PackagesNetIn: the number of packets received by the internal network interface controller (NIC) per second monitored by the agent (packets/s).</para>
            /// </description></item>
            /// <item><description><para>PackagesNetOut: the number of packets sent by the public network interface controller (NIC) per second monitored by the agent (packets/s).</para>
            /// </description></item>
            /// <item><description><para>PackagesNetIn: the number of packets received by the public network interface controller (NIC) per second monitored by the agent (packets/s).</para>
            /// </description></item>
            /// <item><description><para>EciPodCpuUtilization: the CPU utilization (%).</para>
            /// </description></item>
            /// <item><description><para>EciPodMemoryUtilization: the memory utilization (%).</para>
            /// </description></item>
            /// <item><description><para>LoadBalancerRealServerAverageQps: the average QPS per backend server in an ALB server group (queries/s).</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">System monitoring event-triggered tasks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CpuUtilization</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The epoch for aggregating monitoring metric data in the multi-metric alert rule. Unit: seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>15</description></item>
            /// <item><description>60</description></item>
            /// <item><description>120</description></item>
            /// <item><description>300</description></item>
            /// <item><description>900</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only scaling groups of the ECS instance type support a 15-second statistical period.</para>
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
            /// <para>The method for aggregating metric data in the multi-metric alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Average: the average value.</description></item>
            /// <item><description>Minimum: the minimum value.</description></item>
            /// <item><description>Maximum: the maximum value.</description></item>
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
            /// <para>The threshold of the monitoring metrics in the multi-metric alert rule. When the monitoring threshold expression is met for a specified number of times, it triggers the execution of a scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40.0</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <para>The logical operator between multiple metric alert conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>&amp;&amp;</c>: An alert is triggered only when all monitoring metrics meet the alert conditions. That is, an alert is triggered only when all expressions in the multi-metric alert rule evaluate to <c>true</c>.</description></item>
        /// <item><description><c>||</c>: An alert is triggered if any one of the metrics meets the alert condition.</description></item>
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
        /// <para>The ID of the CloudMonitor application group to which the custom metric belongs. This parameter is required only when the metric type is custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4055401</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// <para>The name of the metric. The valid values vary based on the monitoring type of the event-triggered task:</para>
        /// <list type="bullet">
        /// <item><description><para>If the event-triggered task is of the custom monitoring type (MetricType=custom), the valid values are your custom metrics.</para>
        /// </description></item>
        /// <item><description><para>If the event-triggered task is of the system monitoring type (MetricType=system), valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>CpuUtilization: the CPU utilization of an ECS instance (%).</para>
        /// </description></item>
        /// <item><description><para>ConcurrentConnections: the number of concurrent connections to an ECS instance.</para>
        /// </description></item>
        /// <item><description><para>IntranetTx: the outbound internal network traffic of an ECS instance (Kb/min).</para>
        /// </description></item>
        /// <item><description><para>IntranetRx: the inbound internal network traffic of an ECS instance (Kb/min).</para>
        /// </description></item>
        /// <item><description><para>VpcInternetTx: the outbound Internet traffic of an ECS instance (Kb/min).</para>
        /// </description></item>
        /// <item><description><para>VpcInternetRx: the inbound Internet traffic of an ECS instance (Kb/min).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskReadBps: the read BPS of the system cloud disk (Byte/s).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskWriteBps: the write BPS of the system cloud disk (Byte/s).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskReadOps: the read IOPS of the system cloud disk (operations/s).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskWriteOps: the write IOPS of the system cloud disk (operations/s).</para>
        /// </description></item>
        /// <item><description><para>CpuUtilizationAgent: the CPU utilization monitored by the agent (%).</para>
        /// </description></item>
        /// <item><description><para>GpuUtilizationAgent: the GPU utilization monitored by the agent (%).</para>
        /// </description></item>
        /// <item><description><para>GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory monitored by the agent (%).</para>
        /// </description></item>
        /// <item><description><para>GpuMemoryUtilizationAgent: the GPU memory utilization monitored by the agent (%).</para>
        /// </description></item>
        /// <item><description><para>MemoryUtilization: the memory utilization monitored by the agent (%).</para>
        /// </description></item>
        /// <item><description><para>LoadAverage: the average system load monitored by the agent.</para>
        /// </description></item>
        /// <item><description><para>TcpConnection: the total number of TCP connections monitored by the agent.</para>
        /// </description></item>
        /// <item><description><para>TcpConnection: the number of established TCP connections monitored by the agent.</para>
        /// </description></item>
        /// <item><description><para>PackagesNetOut: the number of packets sent by the internal NIC per second monitored by the agent (packets/s).</para>
        /// </description></item>
        /// <item><description><para>PackagesNetIn: the number of packets received by the internal NIC per second monitored by the agent (packets/s).</para>
        /// </description></item>
        /// <item><description><para>PackagesNetOut: the number of packets sent by the public NIC per second monitored by the agent (packets/s).</para>
        /// </description></item>
        /// <item><description><para>PackagesNetIn: the number of packets received by the public NIC per second monitored by the agent (packets/s).</para>
        /// </description></item>
        /// <item><description><para>EciPodCpuUtilization: the CPU utilization (%).</para>
        /// </description></item>
        /// <item><description><para>EciPodMemoryUtilization: the memory utilization (%).</para>
        /// </description></item>
        /// <item><description><para>LoadBalancerRealServerAverageQps: the average QPS per backend server in an ALB server group (queries/s).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">System monitoring event-triggered tasks</a>.</para>
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
        /// <item><description>system: uses system metrics of CloudMonitor.</description></item>
        /// <item><description>custom: uses custom metrics reported to CloudMonitor.</description></item>
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
        /// <para>The epoch for aggregating monitoring metric data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>15</description></item>
        /// <item><description>60</description></item>
        /// <item><description>120</description></item>
        /// <item><description>300</description></item>
        /// <item><description>900</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only scaling groups of the ECS instance type support a 15-second statistical period.</para>
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
        /// <para>The ID of the scaling group associated with the event-triggered task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The method for aggregating metric data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Average: the average value.</description></item>
        /// <item><description>Minimum: the minimum value.</description></item>
        /// <item><description>Maximum: the maximum value.</description></item>
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
        /// <para>The threshold of the monitoring metrics. When the monitoring threshold expression is met for a specified number of times, it triggers the execution of a scaling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80.0</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
