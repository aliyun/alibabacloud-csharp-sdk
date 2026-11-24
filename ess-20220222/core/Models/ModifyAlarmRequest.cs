// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The list of unique identifiers of the scaling rules associated with the event-triggered task.</para>
        /// </summary>
        [NameInMap("AlarmActions")]
        [Validation(Required=false)]
        public List<string> AlarmActions { get; set; }

        /// <summary>
        /// <para>The ID of the event-triggered task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1hvbnmkl10vll5****_f95ce797-dc2e-4bad-9618-14fee7d1****</para>
        /// </summary>
        [NameInMap("AlarmTaskId")]
        [Validation(Required=false)]
        public string AlarmTaskId { get; set; }

        /// <summary>
        /// <para>The comparison operator between the statistical value and the threshold of the metric. The comparison operator indicates the relationship in which the statistical value and the threshold can satisfy the condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The statistical value is greater than or equal to the threshold. Value: <c>&gt;=</c>.</description></item>
        /// <item><description>The statistical value is less than or equal to the threshold. Value: <c>&lt;=</c>.</description></item>
        /// <item><description>The statistical value is greater than the threshold. Value: <c>&gt;</c>.</description></item>
        /// <item><description>The statistical value is less than the threshold. Value: <c>&lt;</c>.</description></item>
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
        public List<ModifyAlarmRequestDimensions> Dimensions { get; set; }
        public class ModifyAlarmRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension information associated with the metric. Valid values vary based on the monitoring type of the event-triggered node:</para>
            /// <list type="bullet">
            /// <item><description><para>If the event-triggered task is of the custom monitoring type (MetricType=custom), valid values are not restricted. You can specify custom values.</para>
            /// </description></item>
            /// <item><description><para>If the event-triggered task is of the system monitoring type (MetricType=system), valid values:</para>
            /// <list type="bullet">
            /// <item><description>user_id: your account ID.</description></item>
            /// <item><description>scaling_group: the scaling group to be monitored.</description></item>
            /// <item><description>device: the type of the network interface controller (NIC) device.</description></item>
            /// <item><description>state: the state of the TCP connection.</description></item>
            /// <item><description>rulePool: the server group specified for the ALB QPS monitoring metrics.</description></item>
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
            /// <para>The value of the dimension information associated with the metric. Valid values are determined by Dimension.N.DimensionKey:</para>
            /// <list type="bullet">
            /// <item><description><para>If Dimension.N.DimensionKey is set to a custom value, which means the event-triggered task is of the custom monitoring type (MetricType=custom), valid values are not restricted. You can specify custom values.</para>
            /// </description></item>
            /// <item><description><para>If Dimension.N.DimensionKey is set to a system-specified value, which means the event-triggered task is of the system monitoring type (MetricType=system), valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>user_id: automatically populated by the system.</para>
            /// </description></item>
            /// <item><description><para>scaling_group: automatically populated by the system.</para>
            /// </description></item>
            /// <item><description><para>device:</para>
            /// <list type="bullet">
            /// <item><description>eth0: for classic network instances, eth0 represents the internal NIC. For VPC-connected instances, only the eth0 NIC exists.</description></item>
            /// <item><description>eth1: for classic network instances, eth1 represents the public NIC.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>state:</para>
            /// <list type="bullet">
            /// <item><description>TCP_TOTAL: the total number of TCP connections.</description></item>
            /// <item><description>ESTABLISHED: the number of established TCP connections.</description></item>
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
        /// <para>Specifies the effective period of the event-triggered task.</para>
        /// <para>This parameter follows cron expressions. The default format is <c>X X X X X ?</c>, where:</para>
        /// <list type="bullet">
        /// <item><description><para>X: a placeholder for a field, which sequentially represents seconds, minutes, hours, day, and month. X can be a specific value or a special character with logical meaning. For more information about the valid values of X, see <a href="https://help.aliyun.com/document_detail/25907.html">Cron expression</a>.</para>
        /// </description></item>
        /// <item><description><para>?: specifies no value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The value of this parameter is <b>in the UTC+8 time zone by default</b>. You can add time zone information <c>TZ=+yy</c> before the cron expression to specify a time zone, where y represents the numeric value of the time zone. For example, <c>TZ=+00 * * 1-2 * * ?</c> indicates that the event-triggered task takes effect between 01:00 and 02:59 every day in the UTC+0 time zone.</para>
        /// </remarks>
        /// <para>Examples and descriptions:</para>
        /// <list type="bullet">
        /// <item><description><para><c>* * * * * ?  </c>: takes effect at all times.</para>
        /// </description></item>
        /// <item><description><para><c>* * 17-18 * * ? </c>: takes effect between 17:00 and 18:59 every day in the UTC+8 time zone.</para>
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
        /// <para>The number of times that the threshold expression must be met before the scaling rule is triggered. For example, the average CPU utilization must be greater than or equal to 80% in three consecutive statistical results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The monitoring metrics of the multi-metric event-triggered task.</para>
        /// </summary>
        [NameInMap("Expressions")]
        [Validation(Required=false)]
        public List<ModifyAlarmRequestExpressions> Expressions { get; set; }
        public class ModifyAlarmRequestExpressions : TeaModel {
            /// <summary>
            /// <para>The comparison operator between the statistical value and the threshold of the metric. The comparison operator indicates the relationship in which the statistical value and the threshold can satisfy the condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>The statistical value is greater than or equal to the threshold. Value: <c>&gt;=</c>.</description></item>
            /// <item><description>The statistical value is less than or equal to the threshold. Value: <c>&lt;=</c>.</description></item>
            /// <item><description>The statistical value is greater than the threshold. Value: <c>&gt;</c>.</description></item>
            /// <item><description>The statistical value is less than the threshold. Value: <c>&lt;</c>.</description></item>
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
            /// <para>The name of the monitoring metric in the multi-metric event-triggered node. Valid values vary based on the monitoring type of the event-triggered task: </para>
            /// <list type="bullet">
            /// <item><description><para>If the event-triggered task is of the custom monitoring type (MetricType=custom), valid values are your custom monitoring metrics.</para>
            /// </description></item>
            /// <item><description><para>If the event-triggered task is of the system monitoring type (MetricType=system), valid values: </para>
            /// <list type="bullet">
            /// <item><description><para>CpuUtilization: (ECS) CPU utilization (%).</para>
            /// </description></item>
            /// <item><description><para>IntranetTx: (ECS) outbound traffic over the internal network (KByte/min).</para>
            /// </description></item>
            /// <item><description><para>IntranetRx: (ECS) inbound traffic over the internal network (KByte/min).</para>
            /// </description></item>
            /// <item><description><para>VpcInternetTx: (ECS) outbound traffic over the Internet (KByte/min).</para>
            /// </description></item>
            /// <item><description><para>VpcInternetRx: (ECS) inbound traffic over the Internet (KByte/min).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskReadBps: (ECS) system cloud disk read BPS (Byte/s).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskWriteBps: (ECS) system cloud disk write BPS (Byte/s).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskReadOps: (ECS) system cloud disk read IOPS (count/s).</para>
            /// </description></item>
            /// <item><description><para>SystemDiskWriteOps: (ECS) system cloud disk write IOPS (count/s).</para>
            /// </description></item>
            /// <item><description><para>CpuUtilizationAgent: (Agent) CPU utilization (%).</para>
            /// </description></item>
            /// <item><description><para>GpuUtilizationAgent: (Agent) GPU utilization (%).</para>
            /// </description></item>
            /// <item><description><para>GpuMemoryFreeUtilizationAgent: (Agent) GPU memory idle rate (%).</para>
            /// </description></item>
            /// <item><description><para>GpuMemoryUtilizationAgent: (Agent) GPU memory utilization (%).</para>
            /// </description></item>
            /// <item><description><para>MemoryUtilization: (Agent) memory utilization (%).</para>
            /// </description></item>
            /// <item><description><para>LoadAverage: (Agent) average system load.</para>
            /// </description></item>
            /// <item><description><para>TcpConnection: (Agent) total number of TCP connections.</para>
            /// </description></item>
            /// <item><description><para>TcpConnection: (Agent) number of established TCP connections.</para>
            /// </description></item>
            /// <item><description><para>PackagesNetOut: (Agent) number of packets sent by the network interface controller (NIC).</para>
            /// </description></item>
            /// <item><description><para>PackagesNetIn: (Agent) number of packets received by the network interface controller (NIC).</para>
            /// </description></item>
            /// <item><description><para>EciPodCpuUtilization: CPU utilization (%).</para>
            /// </description></item>
            /// <item><description><para>EciPodMemoryUtilization: memory utilization (%).</para>
            /// </description></item>
            /// </list>
            /// </description></item>
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
            /// <para>The statistical period for the metric data in the multi-metric event-triggered task, in seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><ol start="15">
            /// <item><description></description></item>
            /// </ol>
            /// </description></item>
            /// <item><description><ol start="60">
            /// <item><description></description></item>
            /// </ol>
            /// </description></item>
            /// <item><description><ol start="120">
            /// <item><description></description></item>
            /// </ol>
            /// </description></item>
            /// <item><description><ol start="300">
            /// <item><description></description></item>
            /// </ol>
            /// </description></item>
            /// <item><description><ol start="900">
            /// <item><description></description></item>
            /// </ol>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>A statistical period of 15 seconds is applicable only to metrics collected by the CloudMonitor agent (metrics that start with Agent) when monitoring ECS-type scaling groups. For all other metrics, the statistical period can be set to 60, 120, 300, or 900 seconds.</para>
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
            /// <para>The method used to aggregate the metric data in the multi-metric event-triggered task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Average: average value.</description></item>
            /// <item><description>Minimum: minimum value.</description></item>
            /// <item><description>Maximum: maximum value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The threshold of the monitoring metrics in a multi-metric event-triggered task. The scaling rule is executed when the threshold expression is met the specified number of times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40.0</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <para>The relationship between multiple monitoring metrics conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>&amp;&amp;</c>: An alert is triggered only when all monitoring metrics meet the alert conditions. An alert is triggered only when all expressions in the multi-metric event-triggered task evaluate to <c>true</c>.</description></item>
        /// <item><description><c>||</c>: An alert is triggered when any monitoring metric meets the alert condition.</description></item>
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
        /// <para>The ID of the CloudMonitor application group to which the custom metric belongs. This parameter is required only when MetricType is set to custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4055401</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid values vary based on the monitoring type of the event-triggered task: </para>
        /// <list type="bullet">
        /// <item><description><para>If the event-triggered task is of the custom monitoring type (MetricType=custom), valid values are your custom metrics.</para>
        /// </description></item>
        /// <item><description><para>If the event-triggered task is of the system monitoring type (MetricType=system), valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>CpuUtilization: (ECS) CPU utilization (%).</para>
        /// </description></item>
        /// <item><description><para>IntranetTx: (ECS) outbound traffic over the internal network (KByte/min).</para>
        /// </description></item>
        /// <item><description><para>IntranetRx: (ECS) inbound traffic over the internal network (KByte/min).</para>
        /// </description></item>
        /// <item><description><para>VpcInternetTx: (ECS) outbound traffic over the Internet (KByte/min).</para>
        /// </description></item>
        /// <item><description><para>VpcInternetRx: (ECS) inbound traffic over the Internet (KByte/min).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskReadBps: (ECS) system cloud disk read BPS (Byte/s).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskWriteBps: (ECS) system cloud disk write BPS (Byte/s).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskReadOps: (ECS) system cloud disk read IOPS (count/s).</para>
        /// </description></item>
        /// <item><description><para>SystemDiskWriteOps: (ECS) system cloud disk write IOPS (count/s).</para>
        /// </description></item>
        /// <item><description><para>CpuUtilizationAgent: (Agent) CPU utilization (%).</para>
        /// </description></item>
        /// <item><description><para>GpuMemoryFreeUtilizationAgent: (Agent) GPU memory idle rate (%).</para>
        /// </description></item>
        /// <item><description><para>GpuMemoryUtilizationAgent: (Agent) GPU memory utilization (%).</para>
        /// </description></item>
        /// <item><description><para>MemoryUtilization: (Agent) memory utilization (%).</para>
        /// </description></item>
        /// <item><description><para>LoadAverage: (Agent) average system load.</para>
        /// </description></item>
        /// <item><description><para>TcpConnection: (Agent) total number of TCP connections.</para>
        /// </description></item>
        /// <item><description><para>TcpConnection: (Agent) number of established TCP connections.</para>
        /// </description></item>
        /// <item><description><para>PackagesNetOut: (Agent) number of packets sent by the NIC.</para>
        /// </description></item>
        /// <item><description><para>PackagesNetIn: (Agent) number of packets received by the NIC.</para>
        /// </description></item>
        /// <item><description><para>EciPodCpuUtilization: CPU utilization (%).</para>
        /// </description></item>
        /// <item><description><para>EciPodMemoryUtilization: memory utilization (%).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered tasks for system monitoring</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MemoryUtilization</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The type of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: uses CloudMonitor system metrics.</description></item>
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
        /// <para>alarmtask****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The statistical period for the metric data, in seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><ol start="15">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="60">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="120">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="300">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="900">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>A statistical period of 15 seconds is applicable only to metrics collected by the CloudMonitor agent (metrics that start with Agent) when monitoring ECS-type scaling groups. For all other metrics, the statistical period can be set to 60, 120, 300, or 900 seconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID of the event-triggered task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The method used to aggregate the metric data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Average: average value.</description></item>
        /// <item><description>Minimum: minimum value.</description></item>
        /// <item><description>Maximum: maximum value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Average</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The threshold of the monitoring metrics in a multi-metric event-triggered task. The scaling rule is executed when the threshold expression is met the specified number of times.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
