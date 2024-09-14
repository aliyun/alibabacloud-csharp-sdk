// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeAlarmsResponseBody : TeaModel {
        /// <summary>
        /// The event-triggered tasks.
        /// </summary>
        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public List<DescribeAlarmsResponseBodyAlarmList> AlarmList { get; set; }
        public class DescribeAlarmsResponseBodyAlarmList : TeaModel {
            /// <summary>
            /// The unique identifiers of the scaling rules that are associated with the event-triggered task.
            /// </summary>
            [NameInMap("AlarmActions")]
            [Validation(Required=false)]
            public List<string> AlarmActions { get; set; }

            /// <summary>
            /// The ID of the event-triggered task.
            /// </summary>
            [NameInMap("AlarmTaskId")]
            [Validation(Required=false)]
            public string AlarmTaskId { get; set; }

            /// <summary>
            /// The operator that is used to compare the metric value and the metric threshold.
            /// 
            /// *   Valid value if the metric value is greater than or equal to the threshold: >=.
            /// *   Valid value if the metric value is less than or equal to the threshold: <=.
            /// *   Valid value if the metric value is greater than the threshold: >.
            /// *   Valid value if the metric value is less than the threshold: <.
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
            public List<DescribeAlarmsResponseBodyAlarmListDimensions> Dimensions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListDimensions : TeaModel {
                /// <summary>
                /// The dimension key of the metric. Valid values:
                /// 
                /// *   user_id: the ID of your Alibaba Cloud account.
                /// *   scaling_group: the scaling group that is monitored by the event-triggered task.
                /// *   device: the NIC type.
                /// *   state: the status of the TCP connection.
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// The dimension value of the metric. The value of DimensionValue varies based on the value of DimensionKey.
                /// 
                /// *   If you set DimensionKey to `user_id`, the system specifies the value of DimensionValue.
                /// 
                /// *   If you set DimensionKey to `scaling_group`, the system specifies the value of DimensionValue.
                /// 
                /// *   If you set DimensionKey to `device`, you can set DimensionValue to eth0 or eth1.
                /// 
                ///     *   For instances of the classic network type, eth0 indicates the internal NIC. Only one eth0 NIC exists on each instance that resides in VPCs.
                ///     *   For instances of the classic network type, eth1 indicates the public NIC.
                /// 
                /// *   If you set DimensionKey to `state`, you can set DimensionValue to TCP_TOTAL or ESTABLISHED.
                /// 
                ///     *   TCP_TOTAL indicates the total number of TCP connections.
                ///     *   ESTABLISHED indicates the number of TCP connections that are established.
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            /// <summary>
            /// The effective period of the event-triggered task.
            /// </summary>
            [NameInMap("Effective")]
            [Validation(Required=false)]
            public string Effective { get; set; }

            /// <summary>
            /// Indicates whether the event-triggered task feature is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The number of consecutive times that the threshold must be reached before a scaling rule is executed. For example, if you set this parameter to 3, the average CPU utilization must reach or exceed 80% three times in a row before a scaling rule is executed.
            /// </summary>
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            /// <summary>
            /// The alert conditions of the multi-metric alert rule.
            /// </summary>
            [NameInMap("Expressions")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListExpressions> Expressions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListExpressions : TeaModel {
                /// <summary>
                /// The operator that is used to compare the metric value and the threshold.
                /// 
                /// *   Valid value if the metric value is greater than or equal to the threshold: >=.
                /// *   Valid value if the metric value is less than or equal to the threshold: <=.
                /// *   Valid value if the metric value is greater than the threshold: >.
                /// *   Valid value if the metric value is less than the threshold: <.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The name of the metric that is specified in the multi-metric alert rule. Valid values:
                /// 
                /// *   CpuUtilization: the CPU utilization of an ECS instance. Unit: %.
                /// *   ConcurrentConnections: the number of current connections to an ECS instance.
                /// *   IntranetTx: the outbound traffic over an internal network. Unit: KB/min.
                /// *   IntranetRx: the inbound traffic over an internal network. Unit: KB/min.
                /// *   VpcInternetTx: the outbound traffic over a VPC. Unit: KB/min.
                /// *   VpcInternetRx: the inbound traffic over a VPC. Unit: KB/min.
                /// *   SystemDiskReadBps: the number of bytes read from the system disk per second.
                /// *   SystemDiskWriteBps: the number of bytes written to the system disk per second.
                /// *   SystemDiskReadOps: the read IOPS of the system disk. Unit: counts/s.
                /// *   SystemDiskWriteOps: the write IOPS of the system disk. Unit: counts/s.
                /// *   CpuUtilizationAgent: the CPU utilization. Unit: %.
                /// *   GpuUtilizationAgent: the GPU utilization. Unit: %.
                /// *   GpuMemoryFreeUtilizationAgent: the idle GPU memory usage. Unit: %.
                /// *   GpuMemoryUtilizationAgent: the GPU memory usage. Unit: %.
                /// *   MemoryUtilization: the memory usage. Unit: %.
                /// *   LoadAverage: the average system load.
                /// *   TcpConnection: the total number of TCP connections.
                /// *   TcpConnection: the number of established TCP connections.
                /// *   PackagesNetOut: the number of packets sent by the internal NIC. Unit: counts/s.
                /// *   PackagesNetIn: the number of packets received by the internal NIC. Unit: counts/s.
                /// *   PackagesNetOut: the number of packets sent by the public NIC. Unit: counts/s.
                /// *   PackagesNetIn: the number of packets received by the public NIC. Unit: counts/s.
                /// *   EciPodCpuUtilization: the CPU utilization. Unit: %.
                /// *   EciPodMemoryUtilization: the memory usage. Unit: %.
                /// *   LoadBalancerRealServerAverageQps: the QPS of an instance.
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
                /// >  If your scaling group is of the ECS type and the event-triggered task that is associated with your scaling group monitors CloudMonitor metrics, you can set Period to 15. In most cases, the name of a CloudMonitor metric contains Agent.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// The method that is used to aggregate statistics about the metrics in the multi-metric alert rule. Valid values:
                /// 
                /// *   Average: the average value
                /// *   Minimum: the minimum value
                /// *   Maximum: the maximum value
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

            /// <summary>
            /// The relationship between the trigger conditions that are specified in the multi-metric alert rule. Valid values:
            /// 
            /// *   `&&`: An alert is triggered only if all metrics in the multi-metric alert rule meet their trigger conditions. In this case, an alert is triggered only if the results of all trigger conditions that are specified in the multi-metric alert rule are `true`.
            /// *   `||`: An alert is triggered only if one of the metrics in the multi-metric alert rule meets its trigger condition.
            /// </summary>
            [NameInMap("ExpressionsLogicOperator")]
            [Validation(Required=false)]
            public string ExpressionsLogicOperator { get; set; }

            [NameInMap("HybridMetrics")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListHybridMetrics> HybridMetrics { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListHybridMetrics : TeaModel {
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<DescribeAlarmsResponseBodyAlarmListHybridMetricsDimensions> Dimensions { get; set; }
                public class DescribeAlarmsResponseBodyAlarmListHybridMetricsDimensions : TeaModel {
                    [NameInMap("DimensionKey")]
                    [Validation(Required=false)]
                    public string DimensionKey { get; set; }

                    [NameInMap("DimensionValue")]
                    [Validation(Required=false)]
                    public string DimensionValue { get; set; }

                }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Statistic")]
                [Validation(Required=false)]
                public string Statistic { get; set; }

            }

            [NameInMap("HybridMonitorNamespace")]
            [Validation(Required=false)]
            public string HybridMonitorNamespace { get; set; }

            /// <summary>
            /// The metric name. Valid values:
            /// 
            /// *   CpuUtilization: the CPU utilization of an Elastic Compute Service (ECS) instance. Unit: %.
            /// *   ConcurrentConnections: the number of current connections to an ECS instance.
            /// *   IntranetTx: the outbound traffic over an internal network. Unit: KB/min.
            /// *   IntranetRx: the inbound traffic over an internal network. Unit: KB/min.
            /// *   VpcInternetTx: the outbound traffic over a virtual private cloud (VPC). Unit: KB/min.
            /// *   VpcInternetRx: the inbound traffic over a VPC. Unit: KB/min.
            /// *   SystemDiskReadBps: the number of bytes read from the system disk per second.
            /// *   SystemDiskWriteBps: the number of bytes written to the system disk per second.
            /// *   SystemDiskReadOps: the read IOPS of the system disk. Unit: counts/s.
            /// *   SystemDiskWriteOps: the write IOPS of the system disk. Unit: counts/s.
            /// *   CpuUtilizationAgent: the CPU utilization. Unit: %.
            /// *   GpuUtilizationAgent: the GPU utilization. Unit: %.
            /// *   GpuMemoryFreeUtilizationAgent: the idle GPU memory usage. Unit: %.
            /// *   GpuMemoryUtilizationAgent: the GPU memory usage. Unit: %.
            /// *   MemoryUtilization: the memory usage. Unit: %.
            /// *   LoadAverage: the average system load.
            /// *   TcpConnection: the total number of TCP connections.
            /// *   TcpConnection: the number of established TCP connections.
            /// *   PackagesNetOut: the number of packets sent by the internal NIC. Unit: counts/s.
            /// *   PackagesNetIn: the number of packets received by the internal NIC. Unit: counts/s.
            /// *   PackagesNetOut: the number of packets sent by the public NIC. Unit: counts/s.
            /// *   PackagesNetIn: the number of packets received by the public NIC. Unit: counts/s.
            /// *   EciPodCpuUtilization: the CPU utilization. Unit: %.
            /// *   EciPodMemoryUtilization: the memory usage. Unit: %.
            /// *   LoadBalancerRealServerAverageQps: the queries per second (QPS) of an instance.
            /// 
            /// For more information, see [Event-triggered tasks of the system monitoring type](https://help.aliyun.com/document_detail/74854.html).
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The metric type. Valid values:
            /// 
            /// *   system: system metrics of CloudMonitor
            /// *   custom: custom metrics that are reported to CloudMonitor.
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

            /// <summary>
            /// The statistical period of the metric data. Unit: seconds. Valid values:
            /// 
            /// *   15
            /// *   60
            /// *   120
            /// *   300
            /// *   900
            /// 
            /// >  You can set the value of this parameter to 15 Seconds only for scaling groups of the ECS type.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("PromQL")]
            [Validation(Required=false)]
            public string PromQL { get; set; }

            /// <summary>
            /// The ID of the scaling group to which the event-triggered task is associated.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The status of the event-triggered task. Valid values:
            /// 
            /// *   ALARM: The alert condition is met and an alert is triggered.
            /// *   OK: The alert condition is not met.
            /// *   INSUFFICIENT_DATA: Auto Scaling cannot determine whether the alert condition is met due to insufficient data.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The method that is used to aggregate the metric data. Valid values:
            /// 
            /// *   Average: the average value
            /// *   Minimum: the minimum value
            /// *   Maximum: the maximum value
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// The threshold of the metric. If the threshold is reached the specified number of times within the statistical period, a scaling rule is executed.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of event-triggered tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
