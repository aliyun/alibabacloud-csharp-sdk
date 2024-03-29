// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateSubscriptionInstanceRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public CreateSubscriptionInstanceRequestSourceEndpoint SourceEndpoint { get; set; }
        public class CreateSubscriptionInstanceRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// The type of the source instance. Valid values: **MySQL**, **PolarDB**, **DRDS**, and **Oracle**.
            /// 
            /// >  Default value: **MySQL**.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The **ClientToken** parameter can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The billing method of the change tracking instance.
        /// 
        /// *   **Postpaid**: pay-as-you-go
        /// *   **Prepaid**: subscription
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The billing cycle of the subscription instance. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// 
        /// >  You must specify this parameter only if you set the PayType parameter to **Prepaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The region ID of the change tracking instance. The region ID is the same as that of the source instance. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The subscription length.
        /// 
        /// *   If the billing cycle is **Year**, the value range is **1 to 5**.
        /// *   If the billing cycle is **Month**, the value range is **1 to 60**.
        /// 
        /// >  You must specify this parameter only if you set the PayType parameter to **Prepaid**.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
