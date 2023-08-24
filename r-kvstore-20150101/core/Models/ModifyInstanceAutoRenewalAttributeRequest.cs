// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceAutoRenewalAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false**: disables auto-renewal.
        /// 
        /// > The default value is **false**.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The ID of the instance. Separate multiple instance IDs with commas (,).
        /// 
        /// > You can specify up to 30 instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The auto-renewal period. Valid values: **1** to **12**. Unit: months. When the instance is about to expire, the instance is automatically renewed based on the number of months specified by this parameter.
        /// 
        /// > This parameter is available and required only if the **AutoRenew** parameter is set to **true**.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
