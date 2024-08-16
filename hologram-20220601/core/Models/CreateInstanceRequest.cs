// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-payment. Default value: true. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// > The default value is true. If the balance of your account is insufficient, you can set this parameter to false. In this case, an unpaid order is generated. You can log on to the User Center to pay for the order.
        /// </summary>
        [NameInMap("autoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable monthly auto-renewal. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PrePaid: subscription
        /// *   PostPaid: pay-as-you-go
        /// 
        /// > This parameter is invalid for shared instances. Shared instances have fixed specifications and are pay-as-you-go instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The infrequent access (IA) storage space of the instance. Unit: GB.
        /// 
        /// > This parameter is invalid for pay-as-you-go instances.
        /// </summary>
        [NameInMap("coldStorageSize")]
        [Validation(Required=false)]
        public long? ColdStorageSize { get; set; }

        /// <summary>
        /// The instance specifications. Valid values:
        /// 
        /// *   8-core 32 GB (number of compute nodes: 1)
        /// *   16-core 64 GB (number of compute nodes: 1)
        /// *   32-core 128 GB (number of compute nodes: 2)
        /// *   64-core 256 GB (number of compute nodes: 4)
        /// *   96-core 384 GB (number of compute nodes: 6)
        /// *   128-core 512 GB (number of compute nodes: 8)
        /// *   Others
        /// 
        /// > 
        /// 
        /// *   Set this parameter to the number of cores.
        /// 
        /// *   If you want to set this parameter to specifications with more than 1,024 compute units (CUs), you must submit a ticket.
        /// 
        /// *   If you want to purchase a shared instance, you do not need to configure this parameter.
        /// 
        /// *   The specifications of 8-core 32 GB (number of compute nodes: 1) are for trial use only and cannot be used for production.
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// The validity period of the instance that you want to purchase. For example, you can specify a validity period of two months.
        /// 
        /// > You do not need to configure this parameter for pay-as-you-go instances.
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("enableServerlessComputing")]
        [Validation(Required=false)]
        public bool? EnableServerlessComputing { get; set; }

        /// <summary>
        /// The number of gateways. Valid values: 2 to 50.
        /// 
        /// > This parameter is required only for virtual warehouse instances.
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        [NameInMap("initialDatabases")]
        [Validation(Required=false)]
        public string InitialDatabases { get; set; }

        /// <summary>
        /// The name of the Hologres instance that you want to purchase. The name must be 2 to 64 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The type of the instance. Valid values:
        /// 
        /// *   Standard: general-purpose instance
        /// *   Follower: read-only secondary instance
        /// *   Warehouse: virtual warehouse instance
        /// *   Shared: shared instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The ID of the primary instance. This parameter is required for read-only secondary instances.
        /// 
        /// > The primary instance and secondary instances must meet the following requirements:
        /// 
        /// *   The primary instance is in the Running state.
        /// 
        /// *   The primary instance and secondary instances are deployed in the same region.
        /// 
        /// *   The primary instance and secondary instances are deployed in the same zone.
        /// 
        /// *   Less than 10 secondary instances are associated with the primary instance.
        /// 
        /// *   The primary and secondary instances belong to the same Alibaba Cloud account.
        /// </summary>
        [NameInMap("leaderInstanceId")]
        [Validation(Required=false)]
        public string LeaderInstanceId { get; set; }

        /// <summary>
        /// The billing cycle. Valid values:
        /// 
        /// *   Month
        /// *   Hour
        /// 
        /// > 
        /// 
        /// *   This parameter can only be set to Month for subscription instances.
        /// 
        /// *   This parameter can only be set to Hour for pay-as-you-go instances.
        /// 
        /// *   By default, this parameter is set to Hour for shared instances.
        /// </summary>
        [NameInMap("pricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the region. You can go to the [OpenAPI Explorer](https://api.aliyun.com/product/Hologram) or the Usage notes section to view the ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group. If you do not specify this parameter, the default resource group of the account is used.
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The standard storage space of the instance. Unit: GB.
        /// 
        /// > This parameter is invalid for pay-as-you-go instances.
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// The ID of the vSwitch. The zone in which the vSwitch resides must be the same as the zone in which the instance resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC). The region in which the VPC resides must be the same as the region in which the Hologres instance resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the zone. For more information about how to obtain the ID of the zone, see the Usage notes section.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
