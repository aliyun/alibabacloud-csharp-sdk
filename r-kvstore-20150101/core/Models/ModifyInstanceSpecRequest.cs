// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. Default value: true. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false**: disables auto-renewal. If you set this parameter to **false**, the instance must be manually renewed before it expires. For more information, see [Renew an instance](~~26352~~).
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The ID of the promotional event or business information.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The coupon code. Default value: `youhuiquan_promotion_option_id_for_blank`.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The time when to change the configurations. Default value: Immediately. Valid values:
        /// 
        /// *   **Immediately**: The configurations are immediately changed.
        /// *   **MaintainTime**: The configurations are changed within the maintenance window. You can call the [ModifyInstanceMaintainTime](~~61000~~) operation to change the maintenance window.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("ForceTrans")]
        [Validation(Required=false)]
        public bool? ForceTrans { get; set; }

        /// <summary>
        /// Specifies whether to forcefully change the configurations of the instance. Default value: true. Valid values:
        /// 
        /// *   **false**: The system does not forcefully change the configurations.
        /// *   **true**: The system forcefully changes the configurations.
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// The new instance type. You can call the [DescribeAvailableResource](~~120580~~) operation to query the instance types available for configuration change within the zone to which the instance belongs.
        /// 
        /// >  For more information about the instance types, see [Overview](~~26350~~).
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~60933~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The major version to which you want to upgrade. When you change the configurations of an instance, you can upgrade the major version of the instance by setting this parameter. Valid values: **4.0** and **5.0**.
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// The change type. This parameter is required when you change the configurations of a subscription instance. Default value: UPGRADE. Valid values:
        /// 
        /// *   **UPGRADE**: upgrades the configurations of a subscription instance.
        /// *   **DOWNGRADE**: downgrades the configurations of a subscription instance.
        /// 
        /// > *   To downgrade a subscription instance, you must set this parameter to **DOWNGRADE**.
        /// > *   If the price of an instance increases after its configurations are changed, the instance is upgraded. If the price decreases, the instance is downgraded. For example, the price of an 8 GB read/write splitting instance with five read replicas is higher than that of a 16 GB cluster instance. If you want to change a 16 GB cluster instance to an 8 GB read/write splitting instance with five read replicas, you must upgrade the instance.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of read-only nodes. This parameter is available only for read/write splitting instances that use cloud disks. Valid values: 1 to 5.
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61012~~) operation to query the most recent region list.
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The number of shards. This parameter is available only for cluster instances that use cloud disks.
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// The source of the operation. This parameter is used only for internal maintenance. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

    }

}
