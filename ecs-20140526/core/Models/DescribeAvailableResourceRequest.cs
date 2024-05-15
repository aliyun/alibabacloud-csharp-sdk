// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// The number of vCPUs of the instance type. For more information, see [Instance families](https://help.aliyun.com/document_detail/25378.html).
        /// 
        /// The Cores parameter takes effect only when the DestinationResource parameter is set to InstanceType.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The type of the data disk. Valid values:
        /// 
        /// *   cloud: basic disk.
        /// *   cloud_efficiency: ultra disk.
        /// *   cloud_ssd: standard SSD.
        /// *   ephemeral_ssd: local SSD.
        /// *   cloud_essd: ESSD.
        /// </summary>
        [NameInMap("DataDiskCategory")]
        [Validation(Required=false)]
        public string DataDiskCategory { get; set; }

        /// <summary>
        /// The ID of the dedicated host.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The resource type to query. Valid values:
        /// 
        /// *   Zone: zone.
        /// *   IoOptimized: I/O optimized resource.
        /// *   InstanceType: instance type.
        /// *   SystemDisk: system disk.
        /// *   DataDisk: data disk.
        /// *   Network: network type.
        /// *   ddh: dedicated host.
        /// 
        /// For more information about how to configure the DestinationResource parameter, see the **Description** section of this topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public string DestinationResource { get; set; }

        /// <summary>
        /// The billing method of the resource. For more information, see [Billing overview](https://help.aliyun.com/document_detail/25398.html). Valid values:
        /// 
        /// *   PrePaid: subscription.
        /// *   PostPaid: pay-as-you-go.
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The instance types. For more information, see [Instance families](https://help.aliyun.com/document_detail/25378.html) or call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation to query the most recent instance type list.
        /// 
        /// For more information about how to configure the InstanceType parameter, see the **Description** section of this topic.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether the instance is an I/O optimized instance. Valid values:
        /// 
        /// *   none: The instance is a non-I/O optimized instance.
        /// *   optimized: The instance is an I/O optimized instance.
        /// 
        /// Default value: optimized.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The memory size of the instance type. Unit: GiB. For more information, see [Instance families](https://help.aliyun.com/document_detail/25378.html).
        /// 
        /// The Memory parameter takes effect only when the DestinationResource parameter is set to InstanceType.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The network type of the cluster. Valid values:
        /// 
        /// *   vpc
        /// *   classic
        /// </summary>
        [NameInMap("NetworkCategory")]
        [Validation(Required=false)]
        public string NetworkCategory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region for which to query resources. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// *   instance: ECS instance.
        /// *   disk: cloud disk.
        /// *   reservedinstance: reserved instance.
        /// *   ddh: dedicated host.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The scope of the reserved instance. Valid values:
        /// 
        /// *   Region: regional.
        /// *   Zone: zonal.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The protection period of the preemptible instance. Unit: hours. Default value: 1. Valid values:
        /// 
        /// - 1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bidding price with the market price and checks the resource inventory to determine whether to retain or release the instance.
        /// 
        /// - 0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the biding price with the market price and checks the resource inventory to determine whether to retain or release the instance.
        /// 
        /// Alibaba Cloud sends ECS system events to notify you 5 minutes before the instance is released. Preemptible instances are billed by the second. We recommend that you specify a protection period based on your business requirements.
        /// 
        /// >If you set SpotStrategy to SpotWithPriceLimit or SpotAsPriceGo, this parameter takes effect.
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// The bidding policy for pay-as-you-go instances. Valid values:
        /// 
        /// *   NoSpot: The instance is a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bid price. The market price can be up to the pay-as-you-go price.
        /// 
        /// Default value: NoSpot.
        /// 
        /// The SpotStrategy parameter takes effect only when the InstanceChargeType parameter is set to PostPaid.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The category of the system disk. Valid values:
        /// 
        /// *   cloud: basic disk.
        /// *   cloud_efficiency: ultra disk.
        /// *   cloud_ssd: standard SSD.
        /// *   ephemeral_ssd: local SSD.
        /// *   cloud_essd: enhanced SSD (ESSD).
        /// 
        /// Default value: cloud_efficiency.
        /// 
        /// > When the ResourceType parameter is set to instance and the DestinationResource parameter is set to DataDisk, you must set the SystemDiskCategory parameter. If you do not set this parameter, the default value takes effect.
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// The ID of the zone where the instance resides.
        /// 
        /// This parameter is empty by default. When this parameter is empty, the system returns resources that match the other criteria in all zones within the region specified by `RegionId`.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
