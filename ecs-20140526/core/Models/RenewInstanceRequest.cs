// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The synchronized expiration date. Set the value to a synchronized expiration date that you specified. Otherwise, the call fails. If you configure this parameter, your instance will be renewed to the specified synchronized expiration date. Valid values: 1 to 28.
        /// 
        /// For information about how to synchronize the expiration dates of instances, see [Synchronize the expiration dates of subscription instances](https://help.aliyun.com/document_detail/108486.html).
        /// 
        /// > The renewal period-related parameter pair (`Period` and `PeriodUnit`) and `ExpectedRenewDay` are mutually exclusive.
        /// </summary>
        [NameInMap("ExpectedRenewDay")]
        [Validation(Required=false)]
        public int? ExpectedRenewDay { get; set; }

        /// <summary>
        /// The ID of the instance that you want to renew.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The renewal period of the subscription instance. If `DedicatedHostId` is specified, the value of Period cannot exceed the subscription period of the specified dedicated host.
        /// 
        /// Valid values when PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, and 12.
        /// 
        /// > The renewal period-related parameter pair (`Period` and `PeriodUnit`) and `ExpectedRenewDay` are mutually exclusive.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal period. Valid values:
        /// 
        /// Month
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
