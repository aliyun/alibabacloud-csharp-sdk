// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class TransformDBInstancePayTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the auto-renewal feature for the instance. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > 
        /// 
        /// *   This parameter is valid only when you change the billing method from pay-as-you-go to subscription.
        /// 
        /// *   All strings except **true** are considered **false**.
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
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go
        /// *   **Prepaid**: subscription
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The renewal cycle of the instance. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// 
        /// > This parameter must be specified if you set **PayType** to **Prepaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The subscription duration of the instance. Valid values:
        /// 
        /// *   If you set **Period** to **Year**, the value of UsedTime ranges from **1 to 5**.
        /// *   If you set **Period** to **Month**, the value of UsedTime ranges from **1 to 11**.
        /// 
        /// > This parameter must be specified when **PayType** is set to **Prepaid**.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
