// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateInstancesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **true** (default).
        /// *   **false**. If automatic payment is disabled, you must perform the following steps to complete the payment in the ApsaraDB for Redis console: In the top navigation bar, choose **Expenses** > **Renewal Management**. In the left-side navigation pane, click **Orders**. On the **Orders** page, find the order and complete the payment.
        /// 
        /// >  This parameter is valid only if the value of the **ChargeType** field in the **Instances** parameter is set to **PrePaid**.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. Default value: false. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// >  This parameter is available only if **ChargeType** in the **Instances** parameter is set to **PrePaid**.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The additional business information about the instance.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The coupon code. Default value: `youhuiquan_promotion_option_id_for_blank`.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The database engine version of the instance. Valid values: **4.0** and **5.0**.
        /// 
        /// >  The default value is **5.0**.
        /// 
        /// Valid values:
        /// 
        /// *   2.8
        /// *   4.0
        /// *   5.0
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The JSON-formatted configurations of the instance. For more information, see the "Description of the Instances parameter" section of this topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to restore the source instance from the recycle bin. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// >  This parameter is valid only if the **SrcDBInstanceId** field in the **Instances** parameter is specified.
        /// </summary>
        [NameInMap("RebuildInstance")]
        [Validation(Required=false)]
        public bool? RebuildInstance { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the instance.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token is case-sensitive. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
