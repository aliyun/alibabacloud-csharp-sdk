// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The list of unique identifiers of the scaling rules that are associated with the event-triggered task.</para>
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
        /// <para>The operator that is used to compare the metric value and the threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the metric value is greater than or equal to the threshold, set the value to <c>&gt;=</c>.</description></item>
        /// <item><description>If the metric value is less than or equal to the threshold, set the value to <c>&lt;=</c>.</description></item>
        /// <item><description>If the metric value is greater than the threshold, set the value to <c>&gt;</c>.</description></item>
        /// <item><description>If the metric value is less than the threshold, set the value to <c>&lt;</c>.</description></item>
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
        /// <para>Details of the dimensions.</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ModifyAlarmRequestDimensions> Dimensions { get; set; }
        public class ModifyAlarmRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension. The valid values vary based on the metric type.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set the MetricType parameter to custom, you can specify this parameter based on your business requirements.</para>
            /// </description></item>
            /// <item><description><para>If you set the MetricType parameter to system, this parameter has the following valid values:</para>
            /// <list type="bullet">
            /// <item><description>user_id: the ID of your Alibaba Cloud account</description></item>
            /// <item><description>scaling_group: the scaling group that you want to monitor</description></item>
            /// <item><description>device: the type of the NIC</description></item>
            /// <item><description>state: the status of the TCP connection</description></item>
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
            /// <para>The value of the dimension. The valid values vary based on the value of the DimensionKey parameter.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set the MetricType parameter to custom, you can specify this parameter based on your business requirements.</para>
            /// </description></item>
            /// <item><description><para>If you set the MetricType parameter to system, this parameter has the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you set the DimensionKey parameter to user_id, the system specifies the value</para>
            /// </description></item>
            /// <item><description><para>scaling_group: The system specifies the value of the DimensionValue parameter.</para>
            /// </description></item>
            /// <item><description><para>If you set the DimensionKey parameter to device, you can set the DimensionValue parameter to eth0 or eth1.</para>
            /// <list type="bullet">
            /// <item><description>For instances that reside in the classic network type, eth0 specifies the internal NIC. Only one eth0 NIC exists on each instance that resides in a VPC.</description></item>
            /// <item><description>For instances that reside in the classic network, eth1 specifies the public NIC.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If you set the DimensionKey parameter to state, you can set the DimensionValue parameter to TCP_TOTAL or ESTABLISHED.</para>
            /// <list type="bullet">
            /// <item><description>TCP_TOTAL specifies the total number of TCP connections.</description></item>
            /// <item><description>ESTABLISHED specifies the number of established TCP connections.</description></item>
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
        /// <para>The effective period of the event-triggered task.</para>
        /// <para>This parameter follows the cron expression format. The default format is <c>X X X X X ?</c>, in which:</para>
        /// <list type="bullet">
        /// <item><description>X: a placeholder for a field, which represents seconds, minutes, hours, days, and months in sequence. X can be a definite value or a special character that has logical meaning. For information about the valid values of X, see <a href="https://help.aliyun.com/document_detail/25907.html">Cron expression</a>.</description></item>
        /// <item><description>?: No value is specified.</description></item>
        /// </list>
        /// <remarks>
        /// <para>By default, the value of this parameter is specified in <b>UTC+8</b>. You can specify the time zone in the <c>TZ=+yy</c> format before a cron expression. y indicates the time zone. For example, <c>TZ=+00 * * 1-2 * * ?</c> specifies that the event-triggered task is in effect between 01:00 and 02:59 (UTC+0) every day.</para>
        /// </remarks>
        /// <para>Examples:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The expressions that are specified in the multi-metric alert rule.</para>
        /// </summary>
        [NameInMap("Expressions")]
        [Validation(Required=false)]
        public List<ModifyAlarmRequestExpressions> Expressions { get; set; }
        public class ModifyAlarmRequestExpressions : TeaModel {
            /// <summary>
            /// <para>The operator that is used to compare the metric value and the threshold. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the metric value is greater than or equal to the threshold, set the value to <c>&gt;=</c>.</description></item>
            /// <item><description>If the metric value is less than or equal to the threshold, set the value to <c>&lt;=</c>.</description></item>
            /// <item><description>If the metric value is greater than the threshold, set the value to <c>&gt;</c>.</description></item>
            /// <item><description>If the metric value is less than the threshold, set the value to <c>&lt;</c>.</description></item>
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
            /// <para>The name of the metric that is specified in the multi-metric alert rule. The valid values vary based on the metric type.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set the MetricType parameter to custom, the valid values are your custom metrics.</para>
            /// </description></item>
            /// <item><description><para>If you set the MetricType parameter to system, the MetricName parameter has the following valid values:</para>
            /// <list type="bullet">
            /// <item><description>CpuUtilization: the CPU utilization of an ECS instance. Unit: %.</description></item>
            /// <item><description>IntranetTx: the outbound traffic over the internal network from an ECS instance. Unit: KB/min.</description></item>
            /// <item><description>IntranetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.</description></item>
            /// <item><description>VpcInternetTx: the outbound traffic over the Internet from an ECS instance that resides in a VPC. Unit: KB/min.</description></item>
            /// <item><description>VpcInternetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.</description></item>
            /// <item><description>SystemDiskReadBps: the number of bytes read from the system disk used by an ECS instance per second.</description></item>
            /// <item><description>SystemDiskWriteBps: the number of bytes written to the system disk used by an ECS instance per second.</description></item>
            /// <item><description>SystemDiskReadOps: the number of read operations on the system disk used by an ECS instance per second.</description></item>
            /// <item><description>SystemDiskWriteOps: the number of write operations on the system disk used by an ECS instance per second.</description></item>
            /// <item><description>CpuUtilizationAgent: the CPU utilization of an agent. Unit: %.</description></item>
            /// <item><description>GpuUtilizationAgent: the GPU utilization of an agent. Unit: %.</description></item>
            /// <item><description>GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory of an agent.</description></item>
            /// <item><description>GpuMemoryUtilizationAgent: the GPU memory usage of an agent. Unit: %.</description></item>
            /// <item><description>MemoryUtilization: the memory usage of an agent. Unit: %.</description></item>
            /// <item><description>LoadAverage: the average system load of an agent.</description></item>
            /// <item><description>TcpConnection: the total number of TCP connections of an agent.</description></item>
            /// <item><description>TcpConnection: the number of established TCP connections of an agent.</description></item>
            /// <item><description>PackagesNetOut: the number of packets that are sent by the internal NIC used by an agent.</description></item>
            /// <item><description>PackagesNetIn: the number of packets that are received by the internal NIC used by an agent.</description></item>
            /// <item><description>EciPodCpuUtilization: the CPU utilization of an elastic container instance. Unit: %.</description></item>
            /// <item><description>EciPodMemoryUtilization: the memory usage of an elastic container instance. Unit: %.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered task for system monitoring</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CpuUtilization</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The period of time during which statistics about the metrics in the multi-metric alert rule is collected. Unit: seconds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>15</description></item>
            /// <item><description>60</description></item>
            /// <item><description>120</description></item>
            /// <item><description>300</description></item>
            /// <item><description>900</description></item>
            /// </list>
            /// <remarks>
            /// <para>If your scaling group is of the ECS type and the event-triggered task associated with your scaling group monitors CloudMonitor metrics, you can set the Period parameter to 15. In other cases, you can set the Period parameter to 60, 120, 300, or 900. In most cases, the name of a CloudMonitor metric contains Agent.</para>
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
            /// <para>The method that is used to aggregate statistics about the metrics that are specified in the multi-metric alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Average</description></item>
            /// <item><description>Minimum</description></item>
            /// <item><description>Maximum</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The thresholds of the metric values in the multi-metric alert rule. If the thresholds are reached the specified number of times within the specified period, a scaling rule is executed.</para>
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
        /// <item><description><c>||</c>: An alert is triggered if one of the metrics in the multi-metric alert rule meets the trigger condition.</description></item>
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
        /// <para>The name of the metric. The valid values vary based on the metric type.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the MetricType parameter to custom, the valid values are your custom metrics.</para>
        /// </description></item>
        /// <item><description><para>If you set the MetricType parameter to system, the MetricName parameter has the following valid values:</para>
        /// <list type="bullet">
        /// <item><description>CpuUtilization: the CPU utilization of an ECS instance. Unit: %.</description></item>
        /// <item><description>IntranetTx: the outbound traffic over the internal network from an ECS instance. Unit: KB/min.</description></item>
        /// <item><description>IntranetRx: the inbound traffic over the Internet to an ECS instance that resides in a virtual private cloud (VPC). Unit: KB/min.</description></item>
        /// <item><description>VpcInternetTx: the outbound traffic over the Internet from an ECS instance that resides in a VPC. Unit: KB/min.</description></item>
        /// <item><description>VpcInternetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.</description></item>
        /// <item><description>SystemDiskReadBps: the number of bytes read from the system disk used by an ECS instance per second.</description></item>
        /// <item><description>SystemDiskWriteBps: the number of bytes written to the system disk used by an ECS instance per second.</description></item>
        /// <item><description>SystemDiskReadOps: the number of read operations on the system disk used by an ECS instance per second.</description></item>
        /// <item><description>SystemDiskWriteOps: the number of write operations on the system disk used by an ECS instance per second.</description></item>
        /// <item><description>CpuUtilizationAgent: the CPU utilization of an agent. Unit: %.</description></item>
        /// <item><description>GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory of an agent.</description></item>
        /// <item><description>GpuMemoryUtilizationAgent: the GPU memory usage of an agent. Unit: %.</description></item>
        /// <item><description>MemoryUtilization: the memory usage of an agent. Unit: %.</description></item>
        /// <item><description>LoadAverage: the average system load of an agent.</description></item>
        /// <item><description>TcpConnection: the total number of TCP connections of an agent.</description></item>
        /// <item><description>TcpConnection: the number of established TCP connections of an agent.</description></item>
        /// <item><description>PackagesNetOut: the number of packets that are sent by the internal network interface controller (NIC) used by an agent.</description></item>
        /// <item><description>PackagesNetIn: the number of packets that are received by the internal NIC used by an agent.</description></item>
        /// <item><description>EciPodCpuUtilization: the CPU utilization of an elastic container instance. Unit: %.</description></item>
        /// <item><description>EciPodMemoryUtilization: the memory usage of an elastic container instance. Unit: %.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/74854.html">Event-triggered task for system monitoring</a>.</para>
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
        /// <para>alarmtask****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The period of time during which statistics about the metric is collected. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>15</description></item>
        /// <item><description>60</description></item>
        /// <item><description>120</description></item>
        /// <item><description>300</description></item>
        /// <item><description>900</description></item>
        /// </list>
        /// <remarks>
        /// <para>If your scaling group is of the ECS type and uses CloudMonitor metrics, you can set the Period parameter to 15. In other cases, you can set the Period parameter to 60, 120, 300, or 900. In most cases, the name of a CloudMonitor metric contains Agent.</para>
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
        /// <para>The method that is used to aggregate statistics for the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Average</description></item>
        /// <item><description>Minimum</description></item>
        /// <item><description>Maximum</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Average</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The thresholds of the metric values in the multi-metric alert rule. If the thresholds are reached the specified number of times within the specified period, a scaling rule is executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
