// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyNodeSpecRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: true. Valid values:
        /// 
        /// *   **true**: enables automatic payment. Make sure that you have sufficient balance within your account.
        /// *   **false**: disables automatic payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The business information. This is an additional parameter.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
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
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The time when the changed configurations take effect. Default value: Immediately. Valid values:
        /// 
        /// *   **Immediately**: The new configurations immediately take effect.
        /// *   **MaintainTime**: The new configurations take effect during the maintenance window of the instance.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The source of the request. Valid values:
        /// 
        /// *   **OpenApi**: the ApsaraDB for MongoDB API
        /// *   **mongo_buy**: the ApsaraDB for MongoDB console
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// The specifications of the shard or mongos node. For more information, see [Instance types](~~57141~~).
        /// </summary>
        [NameInMap("NodeClass")]
        [Validation(Required=false)]
        public string NodeClass { get; set; }

        /// <summary>
        /// The ID of the shard or mongos node in the sharded cluster instance. You can call the [DescribeDBInstanceAttribute](~~62010~~) operation to query the node ID.
        /// 
        /// > If you set this parameter to the ID of the shard node, you must also specify the **NodeStorage** parameter.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The storage capacity of the shard node. Unit: GB.
        /// 
        /// *   Valid values are **10** to **2000** if the instance uses local SSDs.
        /// *   Valid values are **20** to **16000** if the instance uses enhanced SSDs (ESSDs) at PL1.
        /// 
        /// > The value must be a multiple of 10.
        /// </summary>
        [NameInMap("NodeStorage")]
        [Validation(Required=false)]
        public int? NodeStorage { get; set; }

        /// <summary>
        /// The order type. Valid values:
        /// 
        /// *   **UPGRADE**
        /// *   **DOWNGRADE**
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
        /// The number of read-only nodes in the shard node.
        /// 
        /// Valid values: **0** to **5**. The value must be an integer. Default value: **0**.
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public int? ReadonlyReplicas { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The execution time. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

    }

}
