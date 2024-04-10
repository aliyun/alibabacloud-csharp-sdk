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
        /// > If you specify both `Cores` and `Memory`, the system returns all instance types that match the values of the parameters.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The billing method of the ECS instance. For more information, see [Billing overview](~~25398~~). Valid values:
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
        /// *   EntryLevel
        /// *   EnterpriseLevel
        /// *   CreditEntryLevel For more information, see [Burstable instance families](~~59977~~).
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// The instance type. For more information, see [Instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent instance type list.
        /// 
        /// > If you specify `InstanceType`, the `Cores` and `Memory` parameters are ignored.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies the instance families from which the alternative instance types are selected. You can specify up to 10 instance families.
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public List<string> InstanceTypeFamily { get; set; }

        /// <summary>
        /// Specifies whether the instance is I/O optimized. The IoOptimized parameter cannot be specified when the instance is not I/O optimized. Valid values:
        /// 
        /// *   optimized: The instance is I/O optimized.
        /// *   none: The instance is not I/O optimized.
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
        /// > If you specify both `Cores` and `Memory`, the system returns all instance types that match the values of the parameters.
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
        /// The policy that is used to recommend instance types. Valid values:
        /// 
        /// *   InventoryFirst: recommends instance types in descending order of resource availability.
        /// *   PriceFirst: recommends the most cost-effective instance type. Recommended instance types appear based on the hourly prices of vCPUs in ascending order.
        /// *   NewProductFirst: recommends the latest instance types first.
        /// 
        /// Default value: InventoryFirst.
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// *   NoSpot: The instance is a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance for which you can specify the maximum hourly price.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price. The market price can be up to the pay-as-you-go price.
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
        /// *   cloud_efficiency: ultra disk
        /// *   cloud_ssd: SSD
        /// *   cloud_essd: ESSD
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
        /// The zone ID. You can call the [DescribeZones](~~25610~~) operation to query the most recent zone list.
        /// 
        /// We recommend that you set the value of ZoneMatchMode to Include, which is the default value. This way, the system recommends instance types that are available in the zone specified by the ZoneId parameter based on priority. The system also recommends instance types that are available in other zones within the same region.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Specifies whether to recommend only instance types in the zone specified by ZoneId. Valid values:
        /// 
        /// *   Strict: recommends only instance types that are available in zones specified by the ZoneId parameter.
        /// *   Include: recommends instance types that are available in zones specified by the ZoneId parameter and other zones within the same region.
        /// 
        /// If `ZoneId` is specified, the default value of this parameter is Strict. This value indicates that only alternative instance types in the zone specified by ZoneId are recommended.
        /// </summary>
        [NameInMap("ZoneMatchMode")]
        [Validation(Required=false)]
        public string ZoneMatchMode { get; set; }

    }

}
