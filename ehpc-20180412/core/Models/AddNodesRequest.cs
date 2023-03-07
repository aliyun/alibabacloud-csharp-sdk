// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddNodesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allocate a public IP address to the compute nodes. Valid values:
        /// 
        /// *   true: A public IP address is allocated to the compute nodes.
        /// *   false: A public IP address is not allocated to the compute nodes.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public bool? AllocatePublicAddress { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal. The parameter takes effect only when EcsChargeType is set to PrePaid. Valid values:
        /// 
        /// *   true: enables auto-renewal
        /// *   false: disables auto-renewal
        /// 
        /// Default value: true
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period of the subscription compute nodes. The parameter takes effect when AutoRenew is set to true.
        /// 
        /// *   If PeriodUnit is set to Week, the valid values of the AutoRenewPeriod parameter are 1, 2, and 3.
        /// *   If PeriodUnit is set to Month, the valid values of the AutoRenewPeriod parameter are 1, 2, 3, 6, and 12.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure the idempotence of a request?](~~25693~~)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether the compute nodes support hyper-threading. Valid values:
        /// 
        /// *   true: Hyper-threading is supported.
        /// *   false: Hyper-threading is not supported.
        /// 
        /// Default value: true
        /// </summary>
        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        /// <summary>
        /// The protection period of the preemptible instance. Unit: hours. Valid values: 0 and 1. A value of 0 indicates that the preemptible instance has no protection period.
        /// </summary>
        [NameInMap("ComputeSpotDuration")]
        [Validation(Required=false)]
        public int? ComputeSpotDuration { get; set; }

        /// <summary>
        /// The interruption mode of the preemptible instance. Default value: Terminate. Set the value to Terminate, which indicates that the instance is released.
        /// </summary>
        [NameInMap("ComputeSpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string ComputeSpotInterruptionBehavior { get; set; }

        /// <summary>
        /// The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter only takes effect when SpotStrategy is set to SpotWithPriceLimit.
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public string ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// The preemption policy of the compute nodes. The parameter only takes effect when EcsChargeType is set to PostPaid. Valid values:
        /// 
        /// *   NoSpot: The compute nodes are pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.
        /// 
        /// Default value: NoSpot
        /// </summary>
        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        /// <summary>
        /// The number of compute nodes that you want to add. Valid values: 1 to 99. The value of this parameter is greater than that of the MinCount parameter.
        /// 
        /// *   If the number of available ECS instances is less than the value of the MinCount parameter, the compute nodes cannot be added.
        /// *   If the number of available ECS instances is greater than the value of the MinCount parameter and less than that of the Count parameter, the compute nodes are added based on the value of the MinCount parameter.
        /// *   If the number of available ECS instances is greater than the value of the Count parameter, the compute nodes are added based on the value of the Count parameter.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The mode in which the compute nodes are added. Valid values:
        /// 
        /// *   manual: The compute nodes are manually added.
        /// *   autoscale: The compute nodes are automatically added.
        /// 
        /// Default value: manual
        /// </summary>
        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public string CreateMode { get; set; }

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<AddNodesRequestDataDisks> DataDisks { get; set; }
        public class AddNodesRequestDataDisks : TeaModel {
            /// <summary>
            /// The type of the data disk. Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: SSD
            /// *   cloud_essd: ESSD
            /// *   cloud: basic disk
            /// 
            /// Default value: cloud_efficiency
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// Specifies whether the data disk is released when the node is released. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// Default value: true
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("DataDiskDeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DataDiskDeleteWithInstance { get; set; }

            /// <summary>
            /// Specifies whether to encrypt the data disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// Default value: false
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("DataDiskEncrypted")]
            [Validation(Required=false)]
            public bool? DataDiskEncrypted { get; set; }

            /// <summary>
            /// The KMS key ID of the data disk.
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("DataDiskKMSKeyId")]
            [Validation(Required=false)]
            public string DataDiskKMSKeyId { get; set; }

            /// <summary>
            /// The performance level of the ESSD used as the data disk. The parameter only takes effect only when the DataDisks.N.DataDiskCategory parameter is set to cloud_essd. Valid values:
            /// 
            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// Default value: PL1
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("DataDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string DataDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The size of the data disk. Unit: GB
            /// 
            /// Valid values: 40 to 500
            /// 
            /// Default value: 40
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

        }

        /// <summary>
        /// The billing method of the compute nodes. Valid values:
        /// 
        /// *   PostPaid: pay-as-you-go
        /// *   PrePaid: subscription
        /// 
        /// Default value: PostPaid
        /// 
        /// If the parameter is set to PrePaid, auto-renewal is enabled by default. After the E-HPC cluster is released, auto-renewal is disabled.
        /// </summary>
        [NameInMap("EcsChargeType")]
        [Validation(Required=false)]
        public string EcsChargeType { get; set; }

        /// <summary>
        /// The prefix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.
        /// </summary>
        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        /// <summary>
        /// The suffix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.
        /// </summary>
        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        /// <summary>
        /// The ID of the image that is specified for the compute nodes. The image must meet the following requirements:
        /// 
        /// *   The operating system that is specified by the image must be the same as that of the existing cluster nodes. For example, if the operating system of the cluster nodes is CentOS, you can select only a CentOS image.
        /// 
        /// > If you add nodes to a hybrid cloud cluster that supports multiple operating systems, you can select a Windows Server image or a CentOS image when the operating system of the cluster nodes is Windows.
        /// 
        /// *   The major version of the image specified for the compute nodes that you want to add is the same as that of the image of the cluster. For example, if the version of the cluster image is CentOS 7.x, the version of the image specified for the compute nodes must be CentOS 7.x.
        /// 
        /// You can call the [ListImages](~~87213~~) and [ListCustomImages](~~87215~~) operations to query the image ID.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the image. Valid values:
        /// 
        /// *   system: public image
        /// *   self: custom image
        /// *   others: shared image
        /// *   marketplace: Alibaba Cloud Marketplace image
        /// 
        /// Default value: system
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The instance type of the compute nodes. The default value is the instance type that was specified when you created the E-HPC cluster or the last time when you added compute nodes.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The billing method of the elastic IP address (EIP). Valid values:
        /// 
        /// *   PayByBandwidth: pay-by-bandwidth
        /// *   PayByTraffic: pay-by-traffic
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:
        /// 
        /// *   If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of the parameter are 1 to 10 and the default value is 10.
        /// *   If the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the amount of the outbound bandwidth that is purchased.
        /// </summary>
        [NameInMap("InternetMaxBandWidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthIn { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.
        /// 
        /// Default value: 0
        /// </summary>
        [NameInMap("InternetMaxBandWidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthOut { get; set; }

        /// <summary>
        /// The queue to which the compute nodes are added.
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// The minimum number of the compute nodes that you want to add. Valid values: 1 to 99. The value of the parameter is less than that of the Count parameter.
        /// 
        /// *   If the number of available ECS instances is less than the value of the MinCount parameter, the compute nodes cannot be added.
        /// *   If the number of available ECS instances is greater than the value of the MinCount parameter and less than that of the Count parameter, the compute nodes are added based on the value of the MinCount parameter.
        /// *   If the number of available ECS instances is greater than the value of the Count parameter, the compute nodes are added based on the value of the Count parameter.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("MinCount")]
        [Validation(Required=false)]
        public int? MinCount { get; set; }

        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// The duration of the subscription. The unit of the duration is specified by the PeriodUnit parameter. The parameter only takes effect when InstanceChargeType is set to PrePaid. Valid values:
        /// 
        /// *   If PeriodUnit is set to Week, the valid values of the Period parameter are 1, 2, 3, and 4.
        /// *   Valid values when PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription period. Valid values:
        /// 
        /// *   Week
        /// *   Month
        /// 
        /// Default value: Month
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// Specifies whether to set the API operation as a synchronous operation. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

        /// <summary>
        /// The performance level of the ESSD that is used as the system disk. Valid values:
        /// 
        /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1
        /// 
        /// For more information about ESSD performance parameters, see [ESSD](~~122389~~).
        /// </summary>
        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        /// <summary>
        /// The size of the system disk. Unit: GiB
        /// 
        /// Valid values: 40 to 500
        /// 
        /// Default value: 40
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The type of the system disk. Valid values:
        /// 
        /// *   cloud_efficiency: ultra disk.
        /// *   cloud_ssd: SSD.
        /// *   cloud_essd: ESSD.
        /// *   cloud: basic disk. Disks of this type are retired.
        /// 
        /// Default value: cloud_efficiency
        /// </summary>
        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

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
