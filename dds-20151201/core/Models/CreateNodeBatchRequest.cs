// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateNodeBatchRequest : TeaModel {
        /// <summary>
        /// The username of the account. The username must meet the following requirements:
        /// - The username starts with a lowercase letter. 
        /// - The username contains lowercase letters, digits, and underscores (_). 
        /// - The username is 4 to 16 characters in length. 
        /// 
        /// > - Keywords cannot be used as account usernames. 
        /// > - The permissions of this account are fixed at read-only. 
        /// > - The username and password are required to be set only when you apply for an endpoint for the shard node for the first time.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the account. The password must meet the following requirements:
        /// - The password contains at least three of the following character types: uppercase letters, lowercase letters, digits, and specific special characters. 
        /// - These special characters include ! @ # $ % ^ & * ( ) _ + - = 
        /// - The password is 8 to 32 characters in length. 
        /// > The account password of the shard node cannot be reset.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: true. Valid values:
        /// - **true**: enables automatic payment. Make sure that you have sufficient balance within your account. 
        /// - **false**: disables automatic payment. In this case, you must manually pay for the instance. You can perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose **Expenses** > **Orders**. On the Orders page, find the order and complete the payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The business information.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to use coupons. Default value: null. Valid values:
        /// 
        /// *   **default** or **null**: uses coupons.
        /// *   **youhuiquan_promotion_option_id_for_blank**: does not use coupons.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The ID of the instance for which you want to add nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The source of the request. Valid values:
        /// - **OpenApi**: ApsaraDB for MongoDB API 
        /// - **mongo_buy**: ApsaraDB for MongoDB console
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// The specifications of the mongos or shard node that you want to add. For more information, see [Instance types](https://help.aliyun.com/document_detail/57141.html). 
        /// 
        /// > Up to 32 mongos or shard nodes are supported for each sharded cluster instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodesInfo")]
        [Validation(Required=false)]
        public string NodesInfo { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to apply for an endpoint for the shard node. Default value: false. Valid values:
        /// - **true**: applies for an endpoint for the shard node. 
        /// - **false**: does not apply for an endpoint for the shard node.
        /// </summary>
        [NameInMap("ShardDirect")]
        [Validation(Required=false)]
        public bool? ShardDirect { get; set; }

    }

}
