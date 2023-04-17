// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeRequest : TeaModel {
        /// <summary>
        /// The number of vCPUs for the instance.
        /// 
        /// > If the `Cores` and `Memory` parameters are both specified, all instance types with the vCPUs and memory size specified by the parameters are queried.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The billing method of the instance. For more information, see [Billing overview](~~25398~~). Valid values:
        /// 
        /// *   PrePaid: subscription
        /// *   PostPaid: pay-as-you-go
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The level of the instance family. Valid values:
        /// 
        /// *   EntryLevel.
        /// *   EnterpriseLevel.
        /// *   CreditEntryLevel: credit-based entry level. For more information, see [Burstable instance families](~~59977~~).
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// The specified instance type. For more information, see [Instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent list of instance types.
        /// 
        /// > If the `InstanceType` parameter is specified, the `Cores` and `Memory` are ignored.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies the instance families from which the alternative instance types are selected. You can specify up to 10 instance types.
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamily { get; set; }

        /// <summary>
        /// Indicates whether the instance is an I/O optimized instance. The IoOptimized parameter cannot be specified when the instance is not I/O optimized. Valid values:
        /// 
        /// *   optimized
        /// *   none
        /// 
        /// Default value: optimized.
        /// 
        /// If you query alternative instance types for retired instance types, this parameter is set to none by default.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The maximum hourly price for pay-as-you-go instances or preemptible instances.
        /// 
        /// >  This parameter takes effect only when `SpotStrategy` is set to `SpotWithPriceLimit`.
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// The memory size of the instance. Unit: GiB.
        /// 
        /// > If the `Cores` and `Memory` parameters are both specified, all instance types with the vCPUs and memory size specified by the parameters are queried.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   classic
        /// *   vpc
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
        /// The policy based on which the system recommends the instance type. Valid values:
        /// 
        /// *   InventoryFirst: Instance types are recommended in descending order based on resource availability.
        /// *   PriceFirst: Instance types are recommended in ascending order based on hourly price per vCPU.
        /// *   NewProductFirst: The latest instance types are recommended first.
        /// 
        /// Default value: InventoryFirst.
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

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
        /// Specifies the scenarios in which the instance type is recommended. Valid values:
        /// 
        /// *   UPGRADE: instance type upgrade or downgrade
        /// *   CREATE: instance creation
        /// 
        /// Default value: CREATE.
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// The bidding policy of preemptible instances. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bid price. The market price can be as high as the pay-as-you-go price.
        /// 
        /// > The `SpotStrategy` parameter takes effect only when `InstanceChargeType` is set to `PostPaid`.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The type of the system disk. Valid values:
        /// 
        /// *   cloud_efficiency: ultra disk
        /// *   cloud_ssd: SSD
        /// *   cloud_essd: enhanced SSD (ESSD)
        /// *   cloud: basic disk
        /// 
        /// For non-I/O optimized instances, the default value is cloud.
        /// 
        /// For I/O optimized instances, the default value is cloud_efficiency.
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// The ID of the zone for which to query resources. You can call the [DescribeZones](~~25610~~) operation to query the most recent zone list.
        /// 
        /// We recommend that you set the value of ZoneMatchMode to Include, which is the default value. As a result, instance types within zones specified by ZoneId are recommended with priority. Instance types in other zones within the same region are also listed.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Specifies whether to recommend only instance types in the zone specified by ZoneId. Valid values:
        /// 
        /// *   Strict: only instance types within zones specified by the ZoneId parameter are recommended.
        /// *   Include: instance types in other zones within the same region are also recommended.
        /// 
        /// If `ZoneId` is specified, the default value of this parameter is Strict. This value indicates that only alternative instance types in the zone specified by ZoneId are recommended.
        /// </summary>
        [NameInMap("ZoneMatchMode")]
        [Validation(Required=false)]
        public string ZoneMatchMode { get; set; }

    }

}
