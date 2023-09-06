// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetAutoScaleConfigRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to enable hyper-threading for the ECS instance that is used as the compute node.
        /// 
        /// >  You can only disable hyper-threading for some instance types. The hyper-threading is enabled for ECS instances by default. For more information, see [Specify and view CPU options](~~145895~~).
        /// </summary>
        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public string DnsConfig { get; set; }

        /// <summary>
        /// Specifies whether to enable auto scale-out. Valid values:
        /// 
        /// *   true: enables auto scale-out.
        /// *   false: disables auto scale-out.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        /// <summary>
        /// Specifies whether to enable auto scale-in. Valid values:
        /// 
        /// *   true: enables auto scale-in.
        /// *   false: disables auto scale-in.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("EnableAutoShrink")]
        [Validation(Required=false)]
        public bool? EnableAutoShrink { get; set; }

        /// <summary>
        /// The compute nodes that are excluded from auto scaling tasks. Separate multiple compute nodes with commas (,).
        /// 
        /// If you want to retain a compute node, you can specify the node as an additional node to retain the node when it is idle.
        /// </summary>
        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public string ExcludeNodes { get; set; }

        /// <summary>
        /// The percentage of extra compute nodes. Valid values: 0 to 100.
        /// 
        /// Default value: 0.
        /// 
        /// If you need to add 100 compute nodes and the value of the ExtraNodesGrowRatio parameter is 2, 102 compute nodes are added.
        /// </summary>
        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        /// <summary>
        /// The interval between two consecutive rounds of scale-out. Unit: minutes.
        /// 
        /// Valid values: 2 to 10.
        /// 
        /// Default value: 2.
        /// 
        /// > An interval may exist during multiple rounds of a scale-out task or between two consecutive scale-out tasks.
        /// </summary>
        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        /// <summary>
        /// The percentage of each round of a scale-out task. Valid values: 1 to 100.
        /// 
        /// Default value: 100.
        /// 
        /// If you set GrowRatio to 50, the scale-out has two rounds. Each round completes half of the scale-out.
        /// </summary>
        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        /// <summary>
        /// The scale-out timeout period. Unit: minutes.
        /// 
        /// Valid values: 10 to 60.
        /// 
        /// Default value: 20.
        /// 
        /// If the scale-out timeout period has been reached but the scale-out nodes still do not reach the Running state, the system releases them.
        /// </summary>
        [NameInMap("GrowTimeoutInMinutes")]
        [Validation(Required=false)]
        public int? GrowTimeoutInMinutes { get; set; }

        /// <summary>
        /// The IDs of the images.
        /// 
        /// > 
        /// 
        /// *   If both `Queues.N.QueueImageId` and `ImageId` are specified, `Queues.N.QueueImageId` prevails.
        /// 
        /// *   If you set `Queues.N.QueueImageId` or `ImageId`, the parameter that you set takes effect.
        /// *   If you leave both `Queues.N.QueueImageId` and `ImageId` empty, the image that was specified when you created the cluster or the last time you scaled out the cluster is used by default.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The maximum number of compute nodes that can be added to the cluster. Valid values: 0 to 500.
        /// 
        /// Default value: 100.
        /// </summary>
        [NameInMap("MaxNodesInCluster")]
        [Validation(Required=false)]
        public int? MaxNodesInCluster { get; set; }

        /// <summary>
        /// The information about the queue.
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<SetAutoScaleConfigRequestQueues> Queues { get; set; }
        public class SetAutoScaleConfigRequestQueues : TeaModel {
            [NameInMap("AutoMinNodesPerCycle")]
            [Validation(Required=false)]
            public bool? AutoMinNodesPerCycle { get; set; }

            /// <summary>
            /// The list of data disks.
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<SetAutoScaleConfigRequestQueuesDataDisks> DataDisks { get; set; }
            public class SetAutoScaleConfigRequestQueuesDataDisks : TeaModel {
                /// <summary>
                /// The type of the data disk. Valid values:
                /// 
                /// *   cloud_efficiency: ultra disk
                /// *   cloud_ssd: standard SSD
                /// *   cloud_essd: ESSD
                /// *   cloud: basic disk
                /// 
                /// Default value: cloud_efficiency.
                /// 
                /// Valid values of N: 0 to 16.
                /// </summary>
                [NameInMap("DataDiskCategory")]
                [Validation(Required=false)]
                public string DataDiskCategory { get; set; }

                /// <summary>
                /// Specifies whether the data disk is released when the node is released. Valid value:
                /// 
                /// *   true: yes
                /// *   false: no
                /// 
                /// Default value: true.
                /// 
                /// Valid values of N: 0 to 16.
                /// </summary>
                [NameInMap("DataDiskDeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DataDiskDeleteWithInstance { get; set; }

                /// <summary>
                /// Specifies whether to encrypt the data disk. Valid values:
                /// 
                /// *   true: encrypts the data disk.
                /// *   false: does not encrypt the data disk.
                /// 
                /// Default value: false.
                /// 
                /// Valid values of N: 0 to 16.
                /// </summary>
                [NameInMap("DataDiskEncrypted")]
                [Validation(Required=false)]
                public bool? DataDiskEncrypted { get; set; }

                /// <summary>
                /// The Key Management Service (KMS) key ID of the data disk.
                /// 
                /// Valid values of N: 0 to 16.
                /// </summary>
                [NameInMap("DataDiskKMSKeyId")]
                [Validation(Required=false)]
                public string DataDiskKMSKeyId { get; set; }

                /// <summary>
                /// The performance level of the ESSD used as the data disk. The parameter takes effect only when the Queues.N.DataDisks.N.DataDiskCategory parameter is set to cloud_essd. Valid values:
                /// 
                /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
                /// *   PL1: A single ESSD can deliver up to 50,000 IOPS of random read/write.
                /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
                /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
                /// 
                /// Default value: PL1.
                /// 
                /// Valid values of N: 0 to 16.
                /// </summary>
                [NameInMap("DataDiskPerformanceLevel")]
                [Validation(Required=false)]
                public string DataDiskPerformanceLevel { get; set; }

                /// <summary>
                /// The size of the data disk. Unit: GB.
                /// 
                /// Valid values: 40 to 500.
                /// 
                /// Default value: 40.
                /// 
                /// Valid values of N: 0 to 16.
                /// </summary>
                [NameInMap("DataDiskSize")]
                [Validation(Required=false)]
                public int? DataDiskSize { get; set; }

            }

            /// <summary>
            /// Specifies whether the queue enables auto scale-out. Valid value:
            /// 
            /// *   true: enables auto scale-out.
            /// *   false: disables auto scale-out.
            /// 
            /// Valid values of N: 1 to 8.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("EnableAutoGrow")]
            [Validation(Required=false)]
            public bool? EnableAutoGrow { get; set; }

            /// <summary>
            /// Specifies whether the queue enables auto scale-in. Valid value:
            /// 
            /// *   true: enables auto scale-in.
            /// *   false: disables auto scale-in.
            /// 
            /// Valid values of N: 1 to 8.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("EnableAutoShrink")]
            [Validation(Required=false)]
            public bool? EnableAutoShrink { get; set; }

            /// <summary>
            /// The hostname prefix of the host that is used to perform scale-out for the queue. You can manage compute nodes that have a specified hostname prefix.
            /// 
            /// Valid values of N: 1 to 8.
            /// </summary>
            [NameInMap("HostNamePrefix")]
            [Validation(Required=false)]
            public string HostNamePrefix { get; set; }

            /// <summary>
            /// The hostname suffix of the host that is used to perform scale-out for the queue. You can manage nodes that have a specified hostname suffix.
            /// 
            /// Valid values of N: 1 to 8.
            /// </summary>
            [NameInMap("HostNameSuffix")]
            [Validation(Required=false)]
            public string HostNameSuffix { get; set; }

            /// <summary>
            /// The instance type of the compute nodes that are automatically added in the queues. Valid values of N: 1 to 8.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The instance types of the nodes in the queue.
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<SetAutoScaleConfigRequestQueuesInstanceTypes> InstanceTypes { get; set; }
            public class SetAutoScaleConfigRequestQueuesInstanceTypes : TeaModel {
                /// <summary>
                /// The instance type of the compute nodes that are automatically added to the queue.
                /// 
                /// The maximum hourly prices of the compute nodes that are automatically added to N queues can be set the same time. Valid values of N: 1 to 8.
                /// 
                /// The instance types of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The protection period of the preemptible instance. Unit: hours. Valid values: 0 to 1. A value of 0 means that no protection period is specified. Default value: 1.
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
                /// The maximum hourly price of the compute nodes that are automatically added to the queue. The value can be accurate to three decimal places. The parameter takes effect only when `Queues.N.InstanceTypes.N.SpotStrategy` is set to `SpotWithPriceLimit`.
                /// 
                /// The maximum hourly prices of the compute nodes that are automatically added to N queues can be set the same time. Valid values of N: 1 to 8.
                /// 
                /// The maximum hourly prices of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// The preemption policy for the compute node that is automatically added to the queues. Valid value:
                /// 
                /// *   NoSpot: The compute node is created as a pay-as-you-go instance.
                /// *   SpotWithPriceLimit: The compute node is created as a preemptible instance that has a user-defined maximum hourly price.
                /// *   SpotAsPriceGo: The compute node is created as a preemptible instance for which the market price at the time of purchase is used as the bid price.
                /// 
                /// Default value: NoSpot.
                /// 
                /// The maximum hourly prices of the compute nodes that are automatically added to N queues can be set at the same time. Valid values of N: 1 to 8.
                /// 
                /// The bidding methods of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The vSwitch ID of the compute nodes that are automatically added to the queue.
                /// 
                /// The names of N queues can be set at the same time. Valid values of N: 1 to 8.
                /// 
                /// The vSwitch IDs of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The zone ID of the compute nodes that are automatically added to the queue belongs.
                /// 
                /// The maximum hourly prices of the compute nodes that are automatically added to N queues can be set the same time. Valid values of N: 1 to 8.
                /// 
                /// The zone IDs of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// The maximum number of compute nodes that can be added to the queue. Valid values: 0 to 500.
            /// 
            /// Valid values of N: 1 to 8.
            /// 
            /// Default value: 100.
            /// </summary>
            [NameInMap("MaxNodesInQueue")]
            [Validation(Required=false)]
            public int? MaxNodesInQueue { get; set; }

            /// <summary>
            /// The maximum number of compute nodes that can be added in each round of scale-out. Valid values: 0 to 99.
            /// 
            /// Default value: 0.
            /// </summary>
            [NameInMap("MaxNodesPerCycle")]
            [Validation(Required=false)]
            public long? MaxNodesPerCycle { get; set; }

            /// <summary>
            /// The minimum number of compute nodes that can be removed in the queue. Valid values: 0 to 50.
            /// 
            /// Valid values of N: 1 to 8.
            /// 
            /// Default value: 0.
            /// </summary>
            [NameInMap("MinNodesInQueue")]
            [Validation(Required=false)]
            public int? MinNodesInQueue { get; set; }

            /// <summary>
            /// The minimum number of compute nodes that can be added in each round of scale-out. Valid values: 1 to 99.
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
            /// The image ID of the queue where the scale-out is performed. Valid values of N: 1 to 8.
            /// 
            /// > 
            /// 
            /// *   If you set both `Queues.N.QueueImageId` and `ImageId`, `Queues.N.QueueImageId` prevails.
            /// 
            /// *   If you set `Queues.N.QueueImageId` or `ImageId`, the parameter that you set takes effect.
            /// *   If you leave both `Queues.N.QueueImageId` and `ImageId` empty, the image that was specified when you created the cluster or the last time when you scaled out the cluster is used by default.
            /// </summary>
            [NameInMap("QueueImageId")]
            [Validation(Required=false)]
            public string QueueImageId { get; set; }

            /// <summary>
            /// The name of the queue. The names of N queues can be set at the same time. Valid values of N: 1 to 8.
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// Whether the instances are unordered. Valid values:
            /// 
            /// *   true: yes
            /// *   false: no
            /// 
            /// >  If you set this parameter to true, the system selects instance types in descending order of the number of instances in stock during auto scaling.
            /// </summary>
            [NameInMap("SortedByInventory")]
            [Validation(Required=false)]
            public bool? SortedByInventory { get; set; }

            /// <summary>
            /// The maximum hourly price of the compute nodes that are automatically added to the queue. The value can be accurate to three decimal places. The parameter takes effect only when `Queues.N.SpotStrategy` is set to `SpotWithPriceLimit`.
            /// 
            /// Valid values of N: 1 to 8.
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// The preemption policy of the compute node that is automatically added to the queue. Valid values of N: 1 to 8.
            /// 
            /// Valid values:
            /// 
            /// *   NoSpot: The compute nodes is created as a pay-as-you-go instance.
            /// *   SpotWithPriceLimit: The compute node is created as a preemptible instance that has a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The compute node is created as a preemptible instance for which the market price at the time of purchase is used as the bid price.
            /// 
            /// Default value: NoSpot.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The type of the system disk specified for the compute nodes that are added in the queue. Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   cloud_essd: enhanced SSD (ESSD)
            /// *   cloud: basic disk. Disks of this type are retired.
            /// 
            /// Valid values of N: 1 to 8.
            /// 
            /// Default value: cloud_efficiency.
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The performance level of the system disk specified for the compute nodes that are added to the queue. Valid values:
            /// 
            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 IOPS of random read/write.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// Valid values of N: 1 to 8.
            /// 
            /// Default value: PL1.
            /// </summary>
            [NameInMap("SystemDiskLevel")]
            [Validation(Required=false)]
            public string SystemDiskLevel { get; set; }

            /// <summary>
            /// The size of the system disk specified for the compute nodes that are added in the queue. Unit: GB.
            /// 
            /// Valid values: 40 to 500.
            /// 
            /// Valid values of N: 1 to 8.
            /// 
            /// Default value: 40.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// The number of consecutive times that a compute node is idle during the resource scale-in check.
        /// 
        /// Valid values: 2 to 5.
        /// 
        /// Default value: 3.
        /// 
        /// If the parameter is set to 3, a compute node is idle more than three consecutive times. In this case, the node is released. If a compute node is idle for longer than 6 minutes continuously, it is released by default. This is because the default value of the ShrinkIntervalInMinutes parameter is 2.
        /// </summary>
        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        /// <summary>
        /// The interval between two consecutive rounds of scale-in. Unit: minutes.
        /// 
        /// Valid values: 2 to 10.
        /// 
        /// Default value: 2.
        /// </summary>
        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        /// <summary>
        /// The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter takes effect only when `SpotStrategy` is set to `SpotWithPriceLimit`.
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
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
