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
            /// The category of data disk N. Valid values:
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
            /// The performance level of data disk N when the disk is an ESSD. This parameter is valid only when the `DataDisk.N.Category` parameter is set to cloud_essd. Default value: PL1. Valid values:
            /// 
            /// *   PL0
            /// *   PL1
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
            /// *   Valid values if you set DataDisk.N.Category to cloud: 5 to 2000.
            /// 
            /// *   Valid values if you set DataDisk.N.Category to cloud_efficiency: 20 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_ssd: 20 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_essd: depend on the `DataDisk.N.PerformanceLevel` value.
            /// 
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL0: 40 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL1: 20 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL2: 461 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL3: 1261 to 32768.
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
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
            /// <summary>
            /// The category of the system disk. Valid values:
            /// 
            /// *   cloud: basic disk
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   ephemeral_ssd: local SSD
            /// *   cloud_essd: enhanced SSD (ESSD)
            /// 
            /// Description of the default values:
            /// 
            /// *   When the InstanceType parameter is set to a retired instance type and the `IoOptimized` parameter is set to `none`, the default value of this parameter is `cloud`.
            /// *   In other cases, the default value of this parameter is `cloud_efficiency`.
            /// 
            /// > When you query the prices of system disks, you must also specify the `ImageId` parameter.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The performance level of the system disk when the disk is an ESSD. This parameter is valid only when the `SystemDiskCategory` parameter is set to cloud_essd. Default value: PL1. Valid values:
            /// 
            /// PL0 PL1 PL2 PL3
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
        /// The total number of times that the elasticity assurance can be applied. Set the value to Unlimited. This value indicates that the elasticity assurance can be applied an unlimited number of times within its effective duration.
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
        /// The dedicated host type. You can call the [DescribeDedicatedHostTypes](~~134240~~) operation to query the most recent list of dedicated host types.
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// The ID of the image. Images contain the runtime environment to load when instances start. You can call the [DescribeImages](~~25534~~) operation to query the available images. If you do not specify this parameter, the system queries the prices of Linux images.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The total number of instances for which to reserve the capacity of an instance type.
        /// 
        /// Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// The total number of vCPUs supported by the elasticity assurance. When you call this API operation, the system calculates the number of instances that an elasticity assurance must support based on your specified InstanceType value and rounds the calculated value up.
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
        /// The instance type of the instance. When the `ResourceType` parameter is set to `instance`, you must specify the InstanceType parameter. For more information, see [Instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent instance type list.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The instance type. You can select only a single instance type when you configure an elasticity assurance in unlimited mode.
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
        /// Default value: PayByTraffic.
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
        /// If the instance type specified by the InstanceType parameter belongs to [Generation I instance families](~~55263~~), the default value of IoOptimized is none.
        /// 
        /// If the instance type specified by the InstanceType parameter does not belong to [Generation I instance families](~~55263~~), the default value of IoOptimized is optimized.
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
        /// The billing duration of the ECS instance. Valid values:
        /// 
        /// *   Valid values when PriceUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, and 9.
        /// *   Valid values when PriceUnit is set to Year: 1, 2, 3, 4, and 5.
        /// *   Valid value when PriceUnit is set to Hour: 1.
        /// *   Valid values when PriceUnit is set to Week: 1, 2, 3, and 4.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The operating system of the image used by the instance. Valid values:
        /// 
        /// *   Windows: Windows Server operating systems
        /// *   Linux: Linux and UNIX-like operating systems
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The pricing unit of the ECS resource. Default value: Hour. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// *   Hour
        /// *   Week
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The type of the resource. Valid values:
        /// 
        /// *   instance: queries the most recent prices of ECS instances. When this parameter is set to `instance`, you must specify the `InstanceType` parameter.
        /// *   disk: queries the most recent prices of cloud disks. When this parameter is set to `disk`, you must specify both the `DataDisk.1.Category` and `DataDisk.1.Size` parameters.
        /// *   bandwidth: queries the most recent prices for network usage.
        /// *   ddh: queries the most recent prices of dedicated hosts.
        /// *   ElasticityAssurance: queries the most recent prices of elasticity assurances. When this parameter is set to `ElasticityAssurance`, you must specify the `InstanceType` parameter.
        /// *   CapacityReservation: queries the most recent prices of capacity reservations. When this parameter is set to `CapacityReservation`, you must specify the `InstanceType` parameter.
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
        /// The protection period of the preemptible instance. Unit: hours. Valid values: 0, 1, 2, 3, 4, 5, and 6
        /// 
        /// *   The following protection periods are unavailable: 2, 3, 4, 5, and 6 hours. If you want to set this parameter to one of these values, [submit a ticket](https://smartservice.console.aliyun.com/service/create-ticket) and enter the following information: - The specifications and number of the resources. Example: ecs.g6.8xlarge 1000. - The region where the resources reside. Example: China (Beijing). - The period of time during which the resources are used every day. Example: 1:00 to 4: 00 every day.
        /// *   If this parameter is set to 0, no protection period is configured for the preemptible instance.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// The preemption policy for the pay-as-you-go instance. Valid values:
        /// 
        /// *   NoSpot: The instance is a regular pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bidding price. The market price can be up to the pay-as-you-go price.
        /// 
        /// Default value: NoSpot.
        /// 
        /// > This parameter is valid only when the `PriceUnit` parameter is set to Hour and the `Period` parameter is set to 1. The default value of the `PriceUnit` parameter is `Hour` and the default value of the `Period` parameter is `1`. Therefore, you do not need to set the `PriceUnit` and `Period` parameters when you set the SpotStrategy parameter.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The ID of the zone.
        /// 
        /// > Prices of preemptible instances vary based on zones. When you query the price of a preemptible instance, specify the ZoneId parameter.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
