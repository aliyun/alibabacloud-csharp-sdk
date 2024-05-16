// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeAlarmsResponseBody : TeaModel {
        /// <summary>
        /// The list of event-triggered tasks.
        /// </summary>
        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public List<DescribeAlarmsResponseBodyAlarmList> AlarmList { get; set; }
        public class DescribeAlarmsResponseBodyAlarmList : TeaModel {
            /// <summary>
            /// The list of unique identifiers of the scaling rules that are associated with the event-triggered task.
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
            /// The operator that is used to compare the metric value and the threshold.
            /// 
            /// *   Valid value if the metric value is greater than or equal to the threshold: >=
            /// *   Valid value if the metric value is less than or equal to the threshold: <=
            /// *   Valid value if the metric value is greater than the threshold: >
            /// *   Valid value if the metric value is less than the threshold: <
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
            public List<DescribeAlarmsResponseBodyAlarmListDimensions> Dimensions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListDimensions : TeaModel {
                /// <summary>
                /// The key of the dimension. Valid values:
                /// 
                /// *   user_id: the ID of your Alibaba Cloud account
                /// *   scaling_group: the scaling group that you want to monitor
                /// *   device: the type of the NIC
                /// *   state: the state of the TCP connection
                /// </summary>
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                /// <summary>
                /// The value of the dimension. The value of the DimensionValue parameter varies based on the value of the DimensionKey parameter.
                /// 
                /// *   If you set the DimensionKey parameter to `user_id`, the system specifies the value of the DimensionValue parameter.
                /// 
                /// *   If you set the DimensionKey parameter to `scaling_group`, the system specifies the value of the DimensionValue parameter.
                /// 
                /// *   If you set the DimensionKey parameter to `device`, you can set the DimensionValue parameter to eth0 or eth1.
                /// 
                ///     *   For instances that reside in the classic network type, eth0 specifies the internal NIC. Only one eth0 NIC exists on each instance that resides in a VPC.
                ///     *   For instances that reside in the classic network, eth1 specifies the public NIC.
                /// 
                /// *   If you set the DimensionKey parameter to `state`, you can set the DimensionValue parameter to TCP_TOTAL or ESTABLISHED.
                /// 
                ///     *   TCP_TOTAL specifies the total number of TCP connections.
                ///     *   ESTABLISHED specifies the number of established TCP connections.
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            /// <summary>
            /// > This parameter is in invitational preview and is unavailable.
            /// </summary>
            [NameInMap("Effective")]
            [Validation(Required=false)]
            public string Effective { get; set; }

            /// <summary>
            /// Indicates whether the event-triggered task is enabled. Valid values:
            /// 
            /// *   true: The event-triggered task is enabled.
            /// *   false: The event-triggered task is disabled.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

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
            public List<DescribeAlarmsResponseBodyAlarmListExpressions> Expressions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListExpressions : TeaModel {
                /// <summary>
                /// The operator that is used to compare the metric value and the threshold.
                /// 
                /// *   Valid value if the metric value is greater than or equal to the threshold: >=
                /// *   Valid value if the metric value is less than or equal to the threshold: <=
                /// *   Valid value if the metric value is greater than the threshold: >
                /// *   Valid value if the metric value is less than the threshold: <
                /// 
                /// Default value: >=.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The name of the metric that is specified in the multi-metric alert rule. Valid values:
                /// 
                /// *   CpuUtilization: the CPU utilization of an ECS instance. Unit: %.
                /// *   IntranetTx: the outbound traffic over the internal network from an ECS instance. Unit: KB/min.
                /// *   IntranetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.
                /// *   VpcInternetTx: the outbound traffic over the Internet from an ECS instance that resides in a VPC. Unit: KB/min.
                /// *   VpcInternetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.
                /// *   SystemDiskReadBps: the number of bytes read from the system disk used by an ECS instance per second.
                /// *   SystemDiskWriteBps: the number of bytes written to the system disk used by an ECS instance per second.
                /// *   SystemDiskReadOps: the number of read operations on the system disk used by an ECS instance per second.
                /// *   SystemDiskWriteOps: the number of write operations on the system disk used by an ECS instance per second.
                /// *   CpuUtilizationAgent: the CPU utilization of an agent. Unit: %.
                /// *   GpuUtilizationAgent: the GPU utilization of an agent. Unit: %.
                /// *   GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory of an agent.
                /// *   GpuMemoryUtilizationAgent: the GPU memory usage of an agent. Unit: %.
                /// *   MemoryUtilization: the memory usage of an agent. Unit: %.
                /// *   LoadAverage: the average system load of an agent.
                /// *   TcpConnection: the total number of TCP connections of an agent.
                /// *   TcpConnection: the number of established TCP connections of an agent.
                /// *   PackagesNetOut: the number of packets that are sent by the internal NIC used by an agent.
                /// *   PackagesNetIn: the number of packets that are received by the internal NIC used by an agent.
                /// *   EciPodCpuUtilization: the CPU utilization of an elastic container instance. Unit: %.
                /// *   EciPodMemoryUtilization: the memory usage of an elastic container instance. Unit: %.
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
                /// > If your scaling group is of the ECS type and the event-triggered task associated with your scaling group monitors CloudMonitor metrics, you can set the Period parameter to 15. In most cases, the name of a CloudMonitor metric contains Agent.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// The method that is used to aggregate statistics about the metrics in the multi-metric alert rule. Valid values:
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
            /// The relationship between the trigger conditions that are specified in the multi-metric alert rule. Valid values:
            /// 
            /// *   `&&`: An alert is triggered only if all metrics in the multi-metric alert rule meet the trigger conditions. In this case, an alert is triggered only if the results of all trigger conditions that are specified in the multi-metric alert rule are `true`.
            /// *   `||`: An alert is triggered if one of the metrics in the multi-metric alert rule meets the trigger conditions.
            /// </summary>
            [NameInMap("ExpressionsLogicOperator")]
            [Validation(Required=false)]
            public string ExpressionsLogicOperator { get; set; }

            /// <summary>
            /// The name of the metric. Valid values:
            /// 
            /// *   CpuUtilization: the CPU utilization of an ECS instance. Unit: %.
            /// *   IntranetTx: the outbound traffic over the internal network from an ECS instance. Unit: KB/min.
            /// *   IntranetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.
            /// *   VpcInternetTx: the outbound traffic over the Internet from an ECS instance that resides in a VPC. Unit: KB/min.
            /// *   VpcInternetRx: the inbound traffic over the Internet to an ECS instance that resides in a VPC. Unit: KB/min.
            /// *   SystemDiskReadBps: the number of bytes read from the system disk used by an ECS instance per second.
            /// *   SystemDiskWriteBps: the number of bytes written to the system disk used by an ECS instance per second.
            /// *   SystemDiskReadOps: the number of read operations on the system disk used by an ECS instance per second.
            /// *   SystemDiskWriteOps: the number of write operations on the system disk used by an ECS instance per second.
            /// *   CpuUtilizationAgent: the CPU utilization of an agent. Unit: %.
            /// *   GpuMemoryFreeUtilizationAgent: the percentage of idle GPU memory of an agent.
            /// *   GpuMemoryUtilizationAgent: the GPU memory usage of an agent. Unit: %.
            /// *   MemoryUtilization: the memory usage of an agent. Unit: %.
            /// *   LoadAverage: the average system load of an agent.
            /// *   TcpConnection: the total number of TCP connections of an agent.
            /// *   TcpConnection: the number of established TCP connections of an agent.
            /// *   PackagesNetOut: the number of packets that are sent by the internal NIC used by an agent.
            /// *   PackagesNetIn: the number of packets that are received by the internal NIC used by an agent.
            /// *   EciPodCpuUtilization: the CPU utilization of an elastic container instance. Unit: %.
            /// *   EciPodMemoryUtilization: the memory usage of an elastic container instance. Unit: %.
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

            /// <summary>
            /// The period of time during which statistics about the metric is collected. Unit: seconds. Valid values:
            /// 
            /// *   15
            /// *   60
            /// *   120
            /// *   300
            /// *   900
            /// 
            /// > If your scaling group is of the ECS type and the event-triggered task associated with your scaling group monitors CloudMonitor metrics, you can set the Period parameter to 15. In most cases, the name of a CloudMonitor metric contains Agent.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The scaling group ID of the event-triggered task.
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
            /// The threshold of the metric value. If the threshold is reached the specified times within the specified period, a scaling rule is executed.
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
