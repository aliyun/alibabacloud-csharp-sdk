// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyAlarmRequest : TeaModel {
        /// <summary>
        /// The list of unique identifiers of the scaling rules that are associated with the event-triggered task.
        /// </summary>
        [NameInMap("AlarmActions")]
        [Validation(Required=false)]
        public List<string> AlarmActions { get; set; }

        /// <summary>
        /// The ID of the event-triggered task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlarmTaskId")]
        [Validation(Required=false)]
        public string AlarmTaskId { get; set; }

        /// <summary>
        /// The operator that is used to compare the metric value and the threshold. Valid values:
        /// 
        /// *   If the metric value is greater than or equal to the threshold, set the value to `>=`.
        /// *   If the metric value is less than or equal to the threshold, set the value to `<=`.
        /// *   If the metric value is greater than the threshold, set the value to `>`.
        /// *   If the metric value is less than the threshold, set the value to `<`.
        /// </summary>
        [NameInMap("ComparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// The description of the event-triggered task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Details of the dimensions.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ModifyAlarmRequestDimensions> Dimensions { get; set; }
        public class ModifyAlarmRequestDimensions : TeaModel {
            /// <summary>
            /// The key of the dimension. The valid values vary based on the metric type.
            /// 
            /// *   If you set the MetricType parameter to custom, you can specify this parameter based on your business requirements.
            /// 
            /// *   If you set the MetricType parameter to system, this parameter has the following valid values:
            /// 
            ///     *   user_id: the ID of your Alibaba Cloud account
            ///     *   scaling_group: the scaling group that you want to monitor
            ///     *   device: the type of the NIC
            ///     *   state: the status of the TCP connection
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// The value of the dimension. The valid values vary based on the value of the DimensionKey parameter.
            /// 
            /// *   If you set the MetricType parameter to custom, you can specify this parameter based on your business requirements.
            /// 
            /// *   If you set the MetricType parameter to system, this parameter has the following valid values:
            /// 
            ///     *   If you set the DimensionKey parameter to user_id, the system specifies the value
            /// 
            ///     *   scaling_group: The system specifies the value of the DimensionValue parameter.
            /// 
            ///     *   If you set the DimensionKey parameter to device, you can set the DimensionValue parameter to eth0 or eth1.
            /// 
            ///         *   For instances that reside in the classic network type, eth0 specifies the internal NIC. Only one eth0 NIC exists on each instance that resides in a VPC.
            ///         *   For instances that reside in the classic network, eth1 specifies the public NIC.
            /// 
            ///     *   If you set the DimensionKey parameter to state, you can set the DimensionValue parameter to TCP_TOTAL or ESTABLISHED.
            /// 
            ///         *   TCP_TOTAL specifies the total number of TCP connections.
            ///         *   ESTABLISHED specifies the number of established TCP connections.
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

        }

        /// <summary>
        /// The effective period of the event-triggered task.
        /// 
        /// This parameter follows the cron expression format. The default format is `X X X X X ?`, in which:
        /// 
        /// *   X: a placeholder for a field, which represents seconds, minutes, hours, days, and months in sequence. X can be a definite value or a special character that has logical meaning. For information about the valid values of X, see [Cron expression](https://help.aliyun.com/document_detail/25907.html).
        /// *   ?: No value is specified.
        /// 
        /// > By default, the value of this parameter is specified in **UTC+8**. You can specify the time zone in the `TZ=+yy` format before a cron expression. y indicates the time zone. For example, `TZ=+00 * * 1-2 * * ?` specifies that the event-triggered task is in effect between 01:00 and 02:59 (UTC+0) every day.
        /// 
        /// Examples:
        /// 
        /// *   ` * * * * * ?  `: The event-triggered task is in effect all the time.
        /// *   ` * * 17-18 * * ?  `: The event-triggered task is in effect between 17:00 and 18:59 (UTC+8) every day.
        /// *   `TZ=+00 * * 1-2 * * ?`: The event-triggered task is in effect between 01:00 and 02:59 (UTC+0) every day.
        /// </summary>
        [NameInMap("Effective")]
        [Validation(Required=false)]
        public string Effective { get; set; }

        /// <summary>
        /// The number of times that the threshold must be reached before a scaling rule can be executed. For example, if you set this parameter to 3, the average CPU utilization must reach or exceed 80% three times in a row before a scaling rule is triggered.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The expressions that are specified in the multi-metric alert rule.
        /// </summary>
        [NameInMap("Expressions")]
        [Validation(Required=false)]
        public List<ModifyAlarmRequestExpressions> Expressions { get; set; }
        public class ModifyAlarmRequestExpressions : TeaModel {
            /// <summary>
            /// The operator that is used to compare the metric value and the threshold. Valid values:
            /// 
            /// *   If the metric value is greater than or equal to the threshold, set the value to `>=`.
            /// *   If the metric value is less than or equal to the threshold, set the value to `<=`.
            /// *   If the metric value is greater than the threshold, set the value to `>`.
            /// *   If the metric value is less than the threshold, set the value to `<`.
            /// 
            /// Default value: >=.
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// The name of the metric that is specified in the multi-metric alert rule. The valid values vary based on the metric type.
            /// 
            /// *   If you set the MetricType parameter to custom, the valid values are your custom metrics.
            /// 
            /// *   If you set the MetricType parameter to system, the MetricName parameter has the following valid values:
            /// 
            ///     *   CpuUtilization: the CPU utilization of an ECS instance. Unit: %.
            ///     *   IntranetTx: the outbound traffic over the internal network from an ECS instance. Unit: KB/min.
            ///     *   IntranetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.
            ///     *   VpcInternetTx: the outbound traffic over the Internet from an ECS instance that resides in a VPC. Unit: KB/min.
            ///     *   VpcInternetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.
            ///     *   SystemDiskReadBps: the number of bytes read from the system disk used by an ECS instance per second.
            ///     *   SystemDiskWriteBps: the number of bytes written to the system disk used by an ECS instance per second.
            ///     *   SystemDiskReadOps: the number of read operations on the system disk used by an ECS instance per second.
            ///     *   SystemDiskWriteOps: the number of write operations on the system disk used by an ECS instance per second.
            ///     *   CpuUtilizationAgent: the CPU utilization of an agent. Unit: %.
            ///     *   GpuUtilizationAgent: the GPU utilization of an agent. Unit: %.
            ///     *   GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory of an agent.
            ///     *   GpuMemoryUtilizationAgent: the GPU memory usage of an agent. Unit: %.
            ///     *   MemoryUtilization: the memory usage of an agent. Unit: %.
            ///     *   LoadAverage: the average system load of an agent.
            ///     *   TcpConnection: the total number of TCP connections of an agent.
            ///     *   TcpConnection: the number of established TCP connections of an agent.
            ///     *   PackagesNetOut: the number of packets that are sent by the internal NIC used by an agent.
            ///     *   PackagesNetIn: the number of packets that are received by the internal NIC used by an agent.
            ///     *   EciPodCpuUtilization: the CPU utilization of an elastic container instance. Unit: %.
            ///     *   EciPodMemoryUtilization: the memory usage of an elastic container instance. Unit: %.
            /// 
            /// For more information, see [Event-triggered task for system monitoring](https://help.aliyun.com/document_detail/74854.html).
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The period of time during which statistics about the metrics in the multi-metric alert rule is collected. Unit: seconds. Valid values:
            /// 
            /// *   15
            /// *   60
            /// *   120
            /// *   300
            /// *   900
            /// 
            /// > If your scaling group is of the ECS type and the event-triggered task associated with your scaling group monitors CloudMonitor metrics, you can set the Period parameter to 15. In other cases, you can set the Period parameter to 60, 120, 300, or 900. In most cases, the name of a CloudMonitor metric contains Agent.
            /// 
            /// Default value: 300.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The method that is used to aggregate statistics about the metrics that are specified in the multi-metric alert rule. Valid values:
            /// 
            /// *   Average
            /// *   Minimum
            /// *   Maximum
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// The thresholds of the metric values in the multi-metric alert rule. If the thresholds are reached the specified number of times within the specified period, a scaling rule is executed.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// The relationship between the trigger conditions in the multi-metric alert rule. Valid values:
        /// 
        /// *   `&&`: An alert is triggered only if all metrics in the multi-metric alert rule meet the trigger conditions. In this case, an alert is triggered only if the results of all trigger conditions that are specified in the multi-metric alert rule are `true`.
        /// *   `||`: An alert is triggered if one of the metrics in the multi-metric alert rule meets the trigger condition.
        /// 
        /// Default value: `&&`.
        /// </summary>
        [NameInMap("ExpressionsLogicOperator")]
        [Validation(Required=false)]
        public string ExpressionsLogicOperator { get; set; }

        /// <summary>
        /// The ID of the application group to which the custom metric belongs. If you set the MetricType parameter to custom, you must specify this parameter.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// The name of the metric. The valid values vary based on the metric type.
        /// 
        /// *   If you set the MetricType parameter to custom, the valid values are your custom metrics.
        /// 
        /// *   If you set the MetricType parameter to system, the MetricName parameter has the following valid values:
        /// 
        ///     *   CpuUtilization: the CPU utilization of an ECS instance. Unit: %.
        ///     *   IntranetTx: the outbound traffic over the internal network from an ECS instance. Unit: KB/min.
        ///     *   IntranetRx: the inbound traffic over the Internet to an ECS instance that resides in a virtual private cloud (VPC). Unit: KB/min.
        ///     *   VpcInternetTx: the outbound traffic over the Internet from an ECS instance that resides in a VPC. Unit: KB/min.
        ///     *   VpcInternetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.
        ///     *   SystemDiskReadBps: the number of bytes read from the system disk used by an ECS instance per second.
        ///     *   SystemDiskWriteBps: the number of bytes written to the system disk used by an ECS instance per second.
        ///     *   SystemDiskReadOps: the number of read operations on the system disk used by an ECS instance per second.
        ///     *   SystemDiskWriteOps: the number of write operations on the system disk used by an ECS instance per second.
        ///     *   CpuUtilizationAgent: the CPU utilization of an agent. Unit: %.
        ///     *   GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory of an agent.
        ///     *   GpuMemoryUtilizationAgent: the GPU memory usage of an agent. Unit: %.
        ///     *   MemoryUtilization: the memory usage of an agent. Unit: %.
        ///     *   LoadAverage: the average system load of an agent.
        ///     *   TcpConnection: the total number of TCP connections of an agent.
        ///     *   TcpConnection: the number of established TCP connections of an agent.
        ///     *   PackagesNetOut: the number of packets that are sent by the internal network interface controller (NIC) used by an agent.
        ///     *   PackagesNetIn: the number of packets that are received by the internal NIC used by an agent.
        ///     *   EciPodCpuUtilization: the CPU utilization of an elastic container instance. Unit: %.
        ///     *   EciPodMemoryUtilization: the memory usage of an elastic container instance. Unit: %.
        /// 
        /// For more information, see [Event-triggered task for system monitoring](https://help.aliyun.com/document_detail/74854.html).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The type of the metric. Valid values:
        /// 
        /// *   system: system metrics of CloudMonitor
        /// *   custom: custom metrics that are reported to CloudMonitor
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// The name of the event-triggered task.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The period of time during which statistics about the metric is collected. Unit: seconds. Valid values:
        /// 
        /// *   15
        /// *   60
        /// *   120
        /// *   300
        /// *   900
        /// 
        /// > If your scaling group is of the ECS type and uses CloudMonitor metrics, you can set the Period parameter to 15. In other cases, you can set the Period parameter to 60, 120, 300, or 900. In most cases, the name of a CloudMonitor metric contains Agent.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The region ID of the event-triggered task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The method that is used to aggregate statistics for the metric. Valid values:
        /// 
        /// *   Average
        /// *   Minimum
        /// *   Maximum
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// The thresholds of the metric values in the multi-metric alert rule. If the thresholds are reached the specified number of times within the specified period, a scaling rule is executed.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
