// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateNodeRequest : TeaModel {
        /// <summary>
        /// The username of the account. The username must meet the following requirements:
        /// 
        /// * The username starts with a lowercase letter.
        /// * The username contains lowercase letters, digits, and underscores (\_).
        /// * The username is 4 to 16 characters in length.
        /// 
        /// > * Keywords cannot be used as account usernames.
        /// > * The permissions of this account are fixed at read-only.
        /// > * The username and password are required to be set only when you apply for an endpoint for the shard node for the first time.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the account. The password must meet the following requirements:
        /// 
        /// * The password contains at least three of the following character types: uppercase letters, lowercase letters, digits, and specific special characters.
        /// * These special characters include ! @ # $ % ^ & \* ( ) \_ + - =
        /// * The password is 8 to 32 characters in length.
        /// 
        /// >  The account password of the shard node cannot be reset.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: true. Valid values:
        /// 
        /// *   **true**: enables automatic payment. Make sure that you have sufficient balance within your account.
        /// *   **false**: disables automatic payment. You can perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose **Expenses** > **Orders**. On the **Orders** page, find the order and complete the payment.********
        /// 
        /// >  This parameter is required when the billing method of the instance is subscription.
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
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The coupon code. Default value: **youhuiquan\_promotion\_option\_id\_for\_blank**.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The ID of the sharded cluster instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The specifications of the shard or mongos node. For more information, see [Instance types](~~57141~~).
        /// </summary>
        [NameInMap("NodeClass")]
        [Validation(Required=false)]
        public string NodeClass { get; set; }

        /// <summary>
        /// The disk capacity of the node. Unit: GB.
        /// 
        /// Valid values: **10** to **2000**. The value must be a multiple of 10. Unit: GB.
        /// 
        /// >  This parameter is required if the NodeType parameter is set to **shard**.
        /// </summary>
        [NameInMap("NodeStorage")]
        [Validation(Required=false)]
        public int? NodeStorage { get; set; }

        /// <summary>
        /// The type of the node. Valid values:
        /// 
        /// *   **shard**: shard node
        /// *   **mongos**: mongos node
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

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
        /// 
        /// >  This parameter is available only for ApsaraDB for MongoDB instances that are purchased on the China site (aliyun.com).
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Specifies whether to apply for an endpoint for the shard node. Default value: false. Valid values:
        /// 
        /// *   **true**: applies for an endpoint for the shard node.
        /// *   **false** : does not apply for an endpoint for the shard node.
        /// </summary>
        [NameInMap("ShardDirect")]
        [Validation(Required=false)]
        public bool? ShardDirect { get; set; }

    }

}
