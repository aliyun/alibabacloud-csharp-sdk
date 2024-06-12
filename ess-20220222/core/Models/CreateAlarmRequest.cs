// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateAlarmRequest : TeaModel {
        /// <summary>
        /// The list of unique identifiers of the scaling rules that are associated with the event-triggered task.
        /// </summary>
        [NameInMap("AlarmActions")]
        [Validation(Required=false)]
        public List<string> AlarmActions { get; set; }

        /// <summary>
        /// The operator that is used to compare the metric value and the threshold. Valid values:
        /// 
        /// *   If the metric value is greater than or equal to the threshold, set the value to: >=.
        /// *   If the metric value is less than or equal to the threshold, set the value to: <=.
        /// *   If the metric value is greater than the threshold, set the value to: >.
        /// *   If the metric value is less than the threshold, set the value to: <.
        /// 
        /// Default value: >=.
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
        /// The metric dimensions.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateAlarmRequestDimensions> Dimensions { get; set; }
        public class CreateAlarmRequestDimensions : TeaModel {
            /// <summary>
            /// The dimension key of the metric. The valid values vary based on the metric type.
            /// 
            /// *   If you set MetricType to custom, you can specify this parameter based on your business requirements.
            /// 
            /// *   If you set MetricType to system, this parameter has the following valid values:
            /// 
            ///     *   user_id: the ID of your Alibaba Cloud account.
            ///     *   scaling_group: the scaling group that you want to monitor by using the event-triggered task.
            ///     *   device: the NIC type.
            ///     *   state: the status of the TCP connection.
            /// </summary>
            [NameInMap("DimensionKey")]
            [Validation(Required=false)]
            public string DimensionKey { get; set; }

            /// <summary>
            /// The dimension value of the metric. The valid values of this parameter vary based on the value of Dimensions.DimensionKey.
            /// 
            /// *   If you set MetricType to custom, you can specify this parameter based on your business requirements.
            /// 
            /// *   If you set MetricType to system, this parameter has the following valid values:
            /// 
            ///     *   user_id: The system specifies the value.
            /// 
            ///     *   scaling_group: The system specifies the value.
            /// 
            ///     *   device: You can set this parameter to eth0 or eth1.
            /// 
            ///         *   For instances of the classic network type, eth0 specifies the internal NIC. Only one eth0 NIC exists on each instance that resides in VPCs.
            ///         *   For instances of the classic network type, eth1 specifies the public NIC.
            /// 
            ///     *   state: You can set this parameter to TCP_TOTAL or ESTABLISHED.
            /// 
            ///         *   TCP_TOTAL specifies the total number of TCP connections.
            ///         *   ESTABLISHED specifies the number of TCP connections that are established.
            /// </summary>
            [NameInMap("DimensionValue")]
            [Validation(Required=false)]
            public string DimensionValue { get; set; }

        }

        /// <summary>
        /// The effective period of the event-triggered task. By default, the event-triggered task is in effect all the time.
        /// 
        /// This parameter follows the cron expression format. The default format is `X X X X X ?`. In the format:
        /// 
        /// *   X: a placeholder for a field, which represents seconds, minutes, hours, days, and months in sequence. X can be a definite value or a special character that has logical meaning. For information about the valid values of X, see [Cron expression](https://help.aliyun.com/document_detail/25907.html).
        /// *   ?: No value is specified.
        /// 
        /// > By default, this parameter value is specified in **UTC+8**. You can specify the time zone in the `TZ=+yy` format before a cron expression. y indicates the time zone. For example, `TZ=+00 * * 1-2 * * ?` specifies that the event-triggered task is in effect between 01:00 and 02:59 (UTC+0) every day.
        /// 
        /// Sample values:
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
        /// 
        /// Default value: 3.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The information about the multi-metric alert rules.
        /// </summary>
        [NameInMap("Expressions")]
        [Validation(Required=false)]
        public List<CreateAlarmRequestExpressions> Expressions { get; set; }
        public class CreateAlarmRequestExpressions : TeaModel {
            /// <summary>
            /// The operator that you want to use to compare the metric value and the threshold in the multi-metric alert rule. Valid values:
            /// 
            /// *   If the metric value is greater than or equal to the threshold, set the value to >=.
            /// *   If the metric value is less than or equal to the metric threshold, set the value to <=.
            /// *   If the metric value is greater than the metric threshold, set the value to >.
            /// *   If the metric value is less than the metric threshold, set the value to <.
            /// 
            /// Default value: >=.
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// The names of the metrics in the multi-metric alert rule. The valid values of this parameter vary based on the metric type.
            /// 
            /// *   If you set MetricType to custom, the valid values are the metrics that you have.
            /// 
            /// *   If you set MetricType to system, this parameter has the following valid values:
            /// 
            ///     *   CpuUtilization: the CPU utilization. Unit: %.
            ///     *   ConcurrentConnections: the number of concurrent connections.
            ///     *   IntranetTx: the outbound traffic over an internal network. Unit: KB/min.
            ///     *   IntranetRx: the inbound traffic over an internal network. Unit: KB/min.
            ///     *   VpcInternetTx: the outbound traffic over a VPC. Unit: KB/min.
            ///     *   VpcInternetRx: the inbound traffic over a VPC. Unit: KB/min.
            ///     *   SystemDiskReadBps: the number of bytes read from the system disk per second.
            ///     *   SystemDiskWriteBps: the number of bytes written to the system disk per second.
            ///     *   SystemDiskReadOps: the read IOPS of the system disk. Unit: counts/s.
            ///     *   SystemDiskWriteOps: the write IOPS of the system disk. Unit: counts/s.
            ///     *   CpuUtilizationAgent: the CPU utilization. Unit: %.
            ///     *   GpuUtilizationAgent: the GPU utilization. Unit: %.
            ///     *   GpuMemoryFreeUtilizationAgent: the idle GPU memory usage. Unit: %.
            ///     *   GpuMemoryUtilizationAgent: the GPU memory usage. Unit: %.
            ///     *   MemoryUtilization: the memory usage. Unit: %.
            ///     *   LoadAverage: the average system load.
            ///     *   TcpConnection: the total number of TCP connections.
            ///     *   TcpConnection: the number of established TCP connections.
            ///     *   PackagesNetOut: the number of packets sent by the internal NIC. Unit: counts/s.
            ///     *   PackagesNetIn: the number of packets received by the internal NIC. Unit: counts/s.
            ///     *   PackagesNetOut: the number of packets sent by the public NIC. Unit: counts/s.
            ///     *   PackagesNetIn: the number of packets received by the public NIC. Unit: counts/s.
            ///     *   EciPodCpuUtilization: the CPU utilization. Unit: %.
            ///     *   EciPodMemoryUtilization: the memory usage. Unit: %.
            ///     *   LoadBalancerRealServerAverageQps: the QPS of an instance.
            /// 
            /// For more information, see [Event-triggered tasks of the system monitoring type](https://help.aliyun.com/document_detail/74854.html).
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The statistical period of the metric data in the multi-metric alert rule. Unit: seconds. Valid values:
            /// 
            /// *   15
            /// *   60
            /// *   120
            /// *   300
            /// *   900
            /// 
            /// >  You can set this parameter to 15 seconds only for scaling groups of the ECS type.
            /// 
            /// Default value: 300.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The method that you want to use to aggregate the metric data in the multi-metric alert rule. Valid values:
            /// 
            /// *   Average: the average value.
            /// *   Minimum: the minimum value
            /// *   Maximum: the maximum value
            /// 
            /// Default value: Average.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// The threshold of the metric value in the multi-metric alert rule. If the threshold is reached the specified number of times within the statistical period, a scaling rule is executed.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// The relationship between the trigger conditions in the multi-metric alert rule. Valid values:
        /// 
        /// *   `&&`: An alert is triggered only if all metrics in the multi-metric alert rule meet the trigger conditions. In this case, an alert is triggered only if the results of all trigger conditions that are specified in the multi-metric alert rule are `true`.
        /// *   `||`: An alert is triggered if one of the metrics in the multi-metric alert rule meets the trigger conditions.
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
        /// The metric name. The valid values of this parameter vary based on the metric type.
        /// 
        /// *   If you set MetricType to custom, the valid values are the metrics that you have.
        /// 
        /// *   If you set MetricType to system, this parameter has the following valid values:
        /// 
        ///     *   CpuUtilization: the CPU utilization. Unit: %.
        ///     *   ConcurrentConnections: the number of concurrent connections.
        ///     *   IntranetTx: the outbound traffic over an internal network. Unit: KB/min.
        ///     *   IntranetRx: the inbound traffic over an internal network. Unit: KB/min.
        ///     *   VpcInternetTx: the outbound traffic over a virtual private cloud (VPC). Unit: KB/min.
        ///     *   VpcInternetRx: the inbound traffic over a VPC. Unit: KB/min.
        ///     *   SystemDiskReadBps: the number of bytes read from the system disk per second.
        ///     *   SystemDiskWriteBps: the number of bytes written to the system disk per second.
        ///     *   SystemDiskReadOps: the read IOPS of the system disk. Unit: counts/s.
        ///     *   SystemDiskWriteOps: the write IOPS of the system disk. Unit: counts/s.
        ///     *   CpuUtilizationAgent: the CPU utilization. Unit: %.
        ///     *   GpuUtilizationAgent: the GPU utilization. Unit: %.
        ///     *   GpuMemoryFreeUtilizationAgent: the idle GPU memory usage. Unit: %.
        ///     *   GpuMemoryUtilizationAgent: the GPU memory usage. Unit: %.
        ///     *   MemoryUtilization: the memory usage. Unit: %.
        ///     *   LoadAverage: the average system load.
        ///     *   TcpConnection: the total number of TCP connections.
        ///     *   TcpConnection: the number of established TCP connections.
        ///     *   PackagesNetOut: the number of packets sent by the internal network interface controller (NIC). Unit: counts/s.
        ///     *   PackagesNetIn: the number of packets received by the internal NIC. Unit: counts/s.
        ///     *   PackagesNetOut: the number of packets sent by the public NIC. Unit: counts/s.
        ///     *   PackagesNetIn: the number of packets received by the public NIC. Unit: counts/s.
        ///     *   EciPodCpuUtilization: the CPU utilization. Unit: %.
        ///     *   EciPodMemoryUtilization: the memory usage. Unit: %.
        ///     *   LoadBalancerRealServerAverageQps: the queries per second (QPS) of an instance.
        /// 
        /// For more information, see [Event-triggered tasks of the system monitoring type](https://help.aliyun.com/document_detail/74854.html).
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
        /// The statistical period of the metric data. Unit: seconds. Valid values:
        /// 
        /// *   15
        /// *   60
        /// *   120
        /// *   300
        /// *   900
        /// 
        /// >  You can set this parameter to 15 seconds only for scaling groups of the ECS type.
        /// 
        /// Default value: 300.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
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
        /// The scaling group ID of the event-triggered task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The method that is used to aggregate statistics for the metric. Valid values:
        /// 
        /// *   Average
        /// *   Minimum
        /// *   Maximum
        /// 
        /// Default value: Average.
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// The threshold of the metric value. If the threshold is reached the specified number of times within the specified period, a scaling rule is executed.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
