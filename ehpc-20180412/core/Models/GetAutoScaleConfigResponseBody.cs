// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAutoScaleConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The type of the scheduler. Valid values:
        /// 
        /// *   slurm
        /// *   pbs
        /// *   opengridscheduler
        /// *   deadline
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public string DnsConfig { get; set; }

        /// <summary>
        /// Indicates whether the cluster enabled auto scale-out. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        /// <summary>
        /// Indicates whether the cluster enabled auto scale-in. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnableAutoShrink")]
        [Validation(Required=false)]
        public bool? EnableAutoShrink { get; set; }

        /// <summary>
        /// The compute nodes that were excluded from the list of auto scaling nodes. Multiple compute nodes were separated with commas (,).
        /// </summary>
        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public string ExcludeNodes { get; set; }

        /// <summary>
        /// The percentage of extra compute nodes. Valid values: 0 to 100.
        /// 
        /// If you need to add 100 compute nodes and the value of the ExtraNodesGrowRatio parameter is 2, 102 compute nodes are added.
        /// </summary>
        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        /// <summary>
        /// The interval between two consecutive rounds of scale-in. Unit: minutes. Valid values: 2 to 10.
        /// 
        /// >  An interval may exist during multiple rounds of a scale-out task or between two consecutive scale-out tasks.
        /// </summary>
        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        /// <summary>
        /// The percentage of each round of scale-out. Valid values: 1 to 100.
        /// 
        /// If you set GrowRatio to 50, the scale-out has two rounds. Each round completes half of the scale-out.
        /// </summary>
        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        /// <summary>
        /// The timeout period before the scale-out nodes were started. Unit: minutes. Valid values: 10 to 60.
        /// 
        /// If the scale-out timeout period has been reached but the scale-out nodes still do not reach the Running state, the system resets them.
        /// </summary>
        [NameInMap("GrowTimeoutInMinutes")]
        [Validation(Required=false)]
        public int? GrowTimeoutInMinutes { get; set; }

        /// <summary>
        /// The image ID of the compute nodes in the queue.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The maximum number of compute nodes that can be added in the cluster. Valid values: 0 to 500.
        /// </summary>
        [NameInMap("MaxNodesInCluster")]
        [Validation(Required=false)]
        public int? MaxNodesInCluster { get; set; }

        /// <summary>
        /// The auto scaling configuration of the queue.
        /// 
        /// >  If auto scaling is enabled for the cluster and queue at the same time, the queue settings prevail.
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public GetAutoScaleConfigResponseBodyQueues Queues { get; set; }
        public class GetAutoScaleConfigResponseBodyQueues : TeaModel {
            [NameInMap("QueueInfo")]
            [Validation(Required=false)]
            public List<GetAutoScaleConfigResponseBodyQueuesQueueInfo> QueueInfo { get; set; }
            public class GetAutoScaleConfigResponseBodyQueuesQueueInfo : TeaModel {
                [NameInMap("AutoMinNodesPerCycle")]
                [Validation(Required=false)]
                public bool? AutoMinNodesPerCycle { get; set; }

                /// <summary>
                /// The list of data disks.
                /// </summary>
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisks DataDisks { get; set; }
                public class GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisks : TeaModel {
                    [NameInMap("DataDisksInfo")]
                    [Validation(Required=false)]
                    public List<GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisksDataDisksInfo> DataDisksInfo { get; set; }
                    public class GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisksDataDisksInfo : TeaModel {
                        /// <summary>
                        /// The type of the data disk. Valid values:
                        /// 
                        /// - cloud_efficiency: ultra disk
                        /// - cloud_ssd: SSD
                        /// - cloud_essd: ESSD
                        /// - cloud: basic disk
                        /// </summary>
                        [NameInMap("DataDiskCategory")]
                        [Validation(Required=false)]
                        public string DataDiskCategory { get; set; }

                        /// <summary>
                        /// Indicates whether the data disk is released when the node is released. Valid values:
                        /// 
                        /// - true
                        /// - false
                        /// </summary>
                        [NameInMap("DataDiskDeleteWithInstance")]
                        [Validation(Required=false)]
                        public bool? DataDiskDeleteWithInstance { get; set; }

                        /// <summary>
                        /// Indicates whether the data disk is encrypted. Valid values:
                        /// 
                        /// - true
                        /// - false
                        /// </summary>
                        [NameInMap("DataDiskEncrypted")]
                        [Validation(Required=false)]
                        public bool? DataDiskEncrypted { get; set; }

                        /// <summary>
                        /// The KMS key ID of the data disk.
                        /// </summary>
                        [NameInMap("DataDiskKMSKeyId")]
                        [Validation(Required=false)]
                        public string DataDiskKMSKeyId { get; set; }

                        /// <summary>
                        /// The performance level of the ESSD used as the data disk. The parameter takes effect only when the DataDisks.N.DataDiskCategory parameter is set to cloud_essd. Valid values:
                        /// 
                        /// - PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
                        /// - PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
                        /// - PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
                        /// - PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
                        /// </summary>
                        [NameInMap("DataDiskPerformanceLevel")]
                        [Validation(Required=false)]
                        public string DataDiskPerformanceLevel { get; set; }

                        /// <summary>
                        /// The capacity of the data disk. Unit: GB.
                        /// 
                        /// Valid values: 40 to 500.
                        /// </summary>
                        [NameInMap("DataDiskSize")]
                        [Validation(Required=false)]
                        public int? DataDiskSize { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the queue enabled auto scale-out. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("EnableAutoGrow")]
                [Validation(Required=false)]
                public bool? EnableAutoGrow { get; set; }

                /// <summary>
                /// Indicates whether the queue enabled auto scale-in. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("EnableAutoShrink")]
                [Validation(Required=false)]
                public bool? EnableAutoShrink { get; set; }

                /// <summary>
                /// The prefix of the queue name. You can query queues that have a specified prefix.
                /// </summary>
                [NameInMap("HostNamePrefix")]
                [Validation(Required=false)]
                public string HostNamePrefix { get; set; }

                /// <summary>
                /// The suffix of the queue name. You can query queues that have a specified suffix.
                /// </summary>
                [NameInMap("HostNameSuffix")]
                [Validation(Required=false)]
                public string HostNameSuffix { get; set; }

                /// <summary>
                /// The instance type of the compute nodes that were automatically added in the queue.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The specification information of the compute nodes.
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes InstanceTypes { get; set; }
                public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes : TeaModel {
                    [NameInMap("InstanceTypeInfo")]
                    [Validation(Required=false)]
                    public List<GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo> InstanceTypeInfo { get; set; }
                    public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo : TeaModel {
                        /// <summary>
                        /// The prefix of the hostname. You can query compute nodes that have a specified prefix.
                        /// </summary>
                        [NameInMap("HostNamePrefix")]
                        [Validation(Required=false)]
                        public string HostNamePrefix { get; set; }

                        /// <summary>
                        /// The instance type of the node.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The protection period of the preemptible instance. Unit: hours. Valid values: 0 to 1. Default value: 1. A value of 0 means no protection period is specified.
                        /// </summary>
                        [NameInMap("SpotDuration")]
                        [Validation(Required=false)]
                        public int? SpotDuration { get; set; }

                        /// <summary>
                        /// The interruption mode of the preemptible instance. Default value: Terminate. Set the value to Terminate, which indicates that the instance is released.
                        /// </summary>
                        [NameInMap("SpotInterruptionBehavior")]
                        [Validation(Required=false)]
                        public string SpotInterruptionBehavior { get; set; }

                        /// <summary>
                        /// The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.
                        /// </summary>
                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                        /// <summary>
                        /// The bidding method of the compute nodes. Valid values:
                        /// 
                        /// *   NoSpot: The compute nodes are pay-as-you-go instances.
                        /// *   SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.
                        /// *   SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.
                        /// </summary>
                        [NameInMap("SpotStrategy")]
                        [Validation(Required=false)]
                        public string SpotStrategy { get; set; }

                        /// <summary>
                        /// The ID of the vSwitch.
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// The ID of the zone.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// The maximum number of compute nodes that can be added in a queue. Valid values: 0 to 500.
                /// </summary>
                [NameInMap("MaxNodesInQueue")]
                [Validation(Required=false)]
                public int? MaxNodesInQueue { get; set; }

                /// <summary>
                /// The maximum number of compute nodes that can be added in each round of an auto scale-out task. Valid values: 0 to 99.
                /// 
                /// Default value: 0.
                /// </summary>
                [NameInMap("MaxNodesPerCycle")]
                [Validation(Required=false)]
                public long? MaxNodesPerCycle { get; set; }

                /// <summary>
                /// The minimum number of compute nodes that can be retained in a queue. Valid values: 0 to 50.
                /// </summary>
                [NameInMap("MinNodesInQueue")]
                [Validation(Required=false)]
                public int? MinNodesInQueue { get; set; }

                /// <summary>
                /// The minimum number of compute nodes that can be added in each round of an auto scale-out task. Valid values: 1 to 99.
                /// 
                /// Default value: 1.
                /// 
                /// If the number of compute nodes that you want to add in a round is less than the value of this property, the system automatically changes the value of this property to the number of compute nodes that you want to add in a round. This helps ensure that compute nodes can be added as expected.
                /// 
                /// > The configuration takes effect only for the minimum compute nodes that can be added in the current round.
                /// </summary>
                [NameInMap("MinNodesPerCycle")]
                [Validation(Required=false)]
                public long? MinNodesPerCycle { get; set; }

                /// <summary>
                /// The image ID of the compute nodes in the queue.
                /// </summary>
                [NameInMap("QueueImageId")]
                [Validation(Required=false)]
                public string QueueImageId { get; set; }

                /// <summary>
                /// The name of the queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// The ID of the resource group to which the compute nodes belong.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SortedByInventory")]
                [Validation(Required=false)]
                public bool? SortedByInventory { get; set; }

                /// <summary>
                /// The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// The preemption policy of the compute nodes. Valid values:
                /// 
                /// *   NoSpot: The compute nodes are pay-as-you-go instances.
                /// *   SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.
                /// *   SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The type of the system disk. Valid values:
                /// 
                /// *   cloud_efficiency: ultra disk
                /// *   cloud_ssd: SSD
                /// *   cloud_essd: ESSD
                /// *   cloud: basic disk
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// The performance level of the system disk. Valid values:
                /// 
                /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
                /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
                /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
                /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
                /// </summary>
                [NameInMap("SystemDiskLevel")]
                [Validation(Required=false)]
                public string SystemDiskLevel { get; set; }

                /// <summary>
                /// The size of the system disk. Unit: GB. Valid values: 40 to 500.
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of consecutive times that a compute node is idle during the resource scale-in check. Valid values: 2 to 5.
        /// 
        /// If the parameter is set to 3, a compute node is idle for more than three consecutive times. In this case, the node is released.
        /// </summary>
        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        /// <summary>
        /// The interval between two consecutive rounds of scale-out. Unit: minutes. Valid values: 2 to 10.
        /// </summary>
        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        /// <summary>
        /// The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// The preemption policy of the compute nodes. Valid values:
        /// 
        /// *   NoSpot: The compute nodes are pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
