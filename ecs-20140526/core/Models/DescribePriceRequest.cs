// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePriceRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceRequestDataDisk : TeaModel {
            /// <summary>
            /// The type of data disk N. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   ephemeral_ssd: local SSD
            /// *   cloud_essd: ESSD
            /// 
            /// Valid values of N: 1 to 16.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The performance level of data disk N when the disk is an ESSD. This parameter is valid only when `DataDisk.N.Category` is set to cloud_essd. Valid values:
            /// 
            /// *   PL0
            /// *   PL1 (default)
            /// *   PL2
            /// *   PL3
            /// 
            /// Valid values of N: 1 to 16.
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The size of data disk N. Unit: GiB. Valid values:
            /// 
            /// *   Valid values when Category is set to cloud: 5 to 2000.
            /// 
            /// *   Valid values when Category is set to cloud_efficiency: 20 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_ssd: 20 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_essd: depend on the value of `DataDisk.N.PerformanceLevel`.
            /// 
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL0: 40 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL1: 20 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL2: 461 to 32768.
            ///     *   Valid values when DataDisk.4.PerformanceLevel is set to PL3: 1261 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to ephemeral_ssd: 5 to 800.
            /// 
            /// Valid values of N: 1 to 16.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public DescribePriceRequestSchedulerOptions SchedulerOptions { get; set; }
        public class DescribePriceRequestSchedulerOptions : TeaModel {
            /// <summary>
            /// 专有宿主机ID。您可以通过[DescribeDedicatedHosts ](~~134242~~)查询专有宿主机ID列表。
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
            /// <summary>
            /// The type of the system disk. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   ephemeral_ssd: local SSD
            /// *   cloud_essd: enhanced SSD (ESSD)
            /// 
            /// Description of the default values:
            /// 
            /// *   When the InstanceType parameter is set to a retired instance type and `IoOptimized` is set to `none`, the default value of this parameter is `cloud`.
            /// *   In other cases, the default value of this parameter is `cloud_efficiency`.
            /// 
            /// > If you want to query the prices of system disks, you must also specify `ImageId`.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The performance level of the system disk when the disk is an ESSD. This parameter is valid only when `SystemDiskCategory` is set to cloud_essd. Valid values:
            /// 
            /// PL0, PL1 (default), PL2, PL3.
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB. Valid values: 20 to 500.
            /// 
            /// Default value: 20 or the image size, whichever is greater.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// The number of ECS instances. You can specify this parameter when you want to query the prices of multiple instances that have specific specifications. Valid values: 1 to 1000.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// The total number of times that the elasticity assurance can be applied. Set the value to Unlimited. This value indicates that the elasticity assurance can be applied an unlimited number of times within its effective period.
        /// 
        /// Default value: Unlimited.
        /// </summary>
        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        /// <summary>
        /// The storage capacity. Unit: GiB.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// The type of the dedicated host. You can call the [DescribeDedicatedHostTypes](~~134240~~) operation to query the most recent list of dedicated host types.
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// The image ID. An image contains the runtime environment to load when an instance is started. You can call the [DescribeImages](~~25534~~) operation to query the available images. If you do not specify this parameter, the system queries the prices of Linux images.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The total number of reserved instances for an instance type.
        /// 
        /// Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// The total number of vCPUs supported by the elasticity assurance. When you call this API operation, the system calculates the number of instances that an elasticity assurance must support based on the specified value of InstanceType. The calculated value is rounded up to the nearest integer.
        /// 
        /// > When you call this API operation to query the price of an elasticity assurance, you can only specify either InstanceCoreCpuCount or InstanceAmount.
        /// </summary>
        [NameInMap("InstanceCpuCoreCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCoreCount { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   classic: classic network
        /// *   vpc: Virtual Private Cloud (VPC)
        /// 
        /// Default value: vpc.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The instance type. When `ResourceType` is set to `instance`, you must specify this parameter. For more information, see [Instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent list of instance types.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The instance types. You can select only a single instance type when you configure an elasticity assurance in unlimited mode.
        /// </summary>
        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <summary>
        /// The billing method for network usage. Valid values:
        /// 
        /// *   PayByBandwidth: pay-by-bandwidth
        /// *   PayByTraffic: pay-by-traffic
        /// 
        /// Default value: PayByTraffic
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.
        /// 
        /// Default value: 0.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Specifies whether the instance is I/O optimized. Valid values:
        /// 
        /// *   none: The instance is not I/O optimized.
        /// *   optimized: The instance is I/O optimized.
        /// 
        /// When the instance type specified by the InstanceType parameter belongs to [Generation I instance families](~~55263~~), the default value of this parameter is none.
        /// 
        /// When the instance type specified by the InstanceType parameter does not belong to [Generation I instance families](~~55263~~), the default value of this parameter is optimized.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The Internet service provider (ISP). Valid values:
        /// 
        /// *   cmcc: China Mobile
        /// *   telecom: China Telecom
        /// *   unicom: China Unicom
        /// *   multiCarrier: multi-line ISP
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// The payment option of the reserved instance. Valid values:
        /// 
        /// *   No Upfront
        /// *   Partial Upfront
        /// *   All Upfront
        /// </summary>
        [NameInMap("OfferingType")]
        [Validation(Required=false)]
        public string OfferingType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing cycle of the ECS instance. Valid values:
        /// 
        /// *   Valid values when PriceUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, and 9.
        /// *   Valid values when PriceUnit is set to Year: 1, 2, 3, 4, and 5.
        /// *   Set the value to 1 when PriceUnit is set to Hour.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The operating system of the image that is used by the instance. Valid values:
        /// 
        /// *   Windows: Windows Server operating system
        /// *   Linux: Linux and UNIX-like operating system
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The pricing unit of the ECS resource. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// *   Hour (default)
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   instance: queries the most recent prices of ECS instances. When this parameter is set to `instance`, you must specify `InstanceType`.
        /// *   disk: queries the most recent prices of cloud disks. When this parameter is set to `disk`, you must specify `DataDisk.1.Category` and `DataDisk.1.Size`.
        /// *   bandwidth: queries the most recent prices of network usage.
        /// *   ddh: queries the most recent prices of dedicated hosts.
        /// *   ElasticityAssurance: queries the most recent prices of elasticity assurances. When this parameter is set to `ElasticityAssurance`, you must specify `InstanceType`.
        /// *   CapacityReservation: queries the most recent prices of capacity reservations. When this parameter is set to `CapacityReservation`, you must specify `InstanceType`.
        /// 
        /// Default value: instance.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The scope of the reserved instance. Valid values:
        /// 
        /// *   Region: regional
        /// *   Zone: zonal
        /// 
        /// Default value: Region.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The retention period of the preemptible instance. Unit: hours. Valid values: 0, 1, 2, 3, 4, 5, and 6
        /// 
        /// *   The following protection periods are unavailable: 2, 3, 4, 5, and 6 hours. If you want to set this parameter to one of these values, [submit a ticket](https://workorder-intl.console.aliyun.com/#/ticket/createIndex) and enter the following information: - The specifications and number of the resources. Example: ecs.g6.8xlarge 1000. - The region where the resources reside. Example: China (Beijing). - The period of time during which the resources are used every day. Example: 1:00 to 4: 00 every day.
        /// *   A value of 0 indicates that no protection period is specified for the preemptible instance.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// The preemption policy for the pay-as-you-go instance. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bid price. The market price can be up to the pay-as-you-go price.
        /// 
        /// Default value: NoSpot
        /// 
        /// > This parameter is valid only when `PriceUnit` is set to Hour and `Period` is set to 1. The default value of `PriceUnit` is `Hour` and the default value of `Period` is `1`. Therefore, you do not need to set `PriceUnit` and `Period` when you set SpotStrategy.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The zone ID.
        /// 
        /// > Prices of preemptible instances vary based on zones. When you query the price of a preemptible instance, specify ZoneId.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
