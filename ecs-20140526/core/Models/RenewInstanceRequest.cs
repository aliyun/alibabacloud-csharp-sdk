// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. **The token can only contain ASCII characters and cannot exceed 64 characters in length.** For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The synchronized expiration date. Set the value to a synchronized expiration date that you specified. Otherwise, the call fails. If you specify this parameter, your instance is renewed to the synchronized expiration date. Valid values: 1 to 28.
        /// 
        /// For information about how to synchronize the expiration dates of instances, see [Synchronize the expiration dates of subscription instances](~~108486~~).
        /// 
        /// >  The renewal period-related parameter pair (`Period` and `PeriodUnit`) and the `ExpectedRenewDay` parameter are mutually exclusive.
        /// </summary>
        [NameInMap("ExpectedRenewDay")]
        [Validation(Required=false)]
        public int? ExpectedRenewDay { get; set; }

        /// <summary>
        /// The ID of the instance.
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
        /// The renewal period of the subscription instance. If you specify the `DedicatedHostId` parameter, the value of the Period parameter must not exceed the subscription period of the specified dedicated host.
        /// 
        /// Valid values if you set the PeriodUnit parameter to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, and 12.
        /// 
        /// >  The renewal period-related parameter pair (`Period` and `PeriodUnit`) and the `ExpectedRenewDay` parameter are mutually exclusive.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal period. Valid value:
        /// 
        /// Month.
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
