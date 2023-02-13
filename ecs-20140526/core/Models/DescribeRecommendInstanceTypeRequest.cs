// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeRequest : TeaModel {
        /// <summary>
        /// The number of vCPUs of the instance.
        /// 
        /// >  If the `Cores` and `Memory` parameters are both specified, all instance types that offer the vCPUs and memory size specified by the parameters are matched.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The billing method of the instances of the instance type. For more information, see [Billing overview](~~25398~~). Valid values:
        /// 
        /// * PrePaid: subscription
        /// * PostPaid: pay-as-you-go
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The level of the instance family. Valid values:
        /// 
        /// * EntryLevel
        /// * EnterpriseLevel.
        /// * CreditEntryLevel. For more information, see [Burstable instance families](~~59977~~).
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// The specified instance type. For more information, see [Instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent instance type list.
        /// 
        /// >  If the `InstanceType` parameter is specified, none of the `Cores` and `Memory` parameters can be specified.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Instance families to be filtered out. You can specify up to 10 instance families.
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamily { get; set; }

        /// <summary>
        /// Specifies whether to match I/O optimized instances. The IoOptimized parameter cannot be specified when the instance is not I/O optimized. Valid values:
        /// 
        /// * optimized: matches I/O optimized instances.
        /// * none: matches non-I/O optimized instances.
        /// 
        /// Default value: optimized.
        /// 
        /// If you query alternative instance types for retired instance types, this parameter is set to none by default. Default value: none.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The maximum hourly price for pay-as-you-go instances or preemptible instances.
        /// 
        /// >  If this parameter is specified, the `SpotStrategy` parameter must be set to `SpotWithPriceLimit`.
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// The memory size of the instance. Unit: GiB.
        /// 
        /// >  If the `Cores` and `Memory` parameters are both specified, all instance types that offer the vCPUs and memory size specified by the parameters are matched.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The network type of the ECS instance. Valid values:
        /// 
        /// *   classic: classic network
        /// *   vpc: VPC
        /// 
        /// Default value: vpc.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The policy for recommending instance types. Valid values:
        /// 
        /// * InventoryFirst: Instance types are recommended in descending order based on resource availability.
        /// * PriceFirst: Instance types are recommended in ascending order based on hourly price per vCPU.
        /// * NewProductFirst: The latest instance types are recommended first.
        /// 
        /// Default value: InventoryFirst.
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        /// <summary>
        /// The region ID of the alternative instance types. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// Specifies the scenario in which the instance type is recommended. Valid values:
        /// 
        /// * UPGRADE: instance type upgrade or downgrade
        /// * CREATE: instance creation
        /// 
        /// Default value: CREATE.
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// The bidding policy of preemptible instances. Valid values:
        /// 
        /// * NoSpot: applies to regular pay-as-you-go instances.
        /// * SpotWithPriceLimit: applies to preemptible instances that have user-defined maximum hourly prices.
        /// * SpotAsPriceGo: applies to preemptible instances that are of the market price at the time of purchase.
        /// 
        /// > If the `SpotStrategy` parameter is specified, the `InstanceChargeType` parameter must be set to `PostPaid`.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The category of the system disk. Valid values:
        /// 
        /// * cloud_efficiency: ultra disk
        /// * cloud_ssd: standard SSD
        /// * cloud_essd: enhanced SSD (ESSD)
        /// * cloud: basic disk
        /// 
        /// For non-I/O optimized instances, the default value is cloud.
        /// 
        /// For I/O optimized instances, the default value is cloud_efficiency.
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// The zone ID of the alternative instance types. You can call the [DescribeZones](~~25610~~) operation to query the most recent zone list.
        /// 
        /// When you specify this parameter, we recommend that you set ZoneMatchMode to the default value Include. This value indicates that instance types in the zone specified by ZoneId are preferentially recommended, and instance types in other zones in the same region are also listed.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Specifies which alternative instance types are recommended. Valid values:
        /// 
        /// * Strict: recommends only alternative instance types in the zone specified by ZoneId.
        /// * Include: recommends all instance types in all the zones in the same region as the specified instance type.
        /// 
        /// When `ZoneId` is specified, the default value of this parameter is Strict. This value indicates that only alternative instance types in the zone specified by ZoneId are recommended.
        /// </summary>
        [NameInMap("ZoneMatchMode")]
        [Validation(Required=false)]
        public string ZoneMatchMode { get; set; }

    }

}
