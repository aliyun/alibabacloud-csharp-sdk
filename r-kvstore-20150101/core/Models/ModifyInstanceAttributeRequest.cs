// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// The new password for the default account. The default account is named after the instance ID. Default account example: r-bp10noxlhcoim2****.
        /// 
        /// >  The password must be 8 to 32 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include `! @ # $ % ^ & * ( ) _ + - =`
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The release protection state of the instance. Valid values:
        /// 
        /// *   **true**: The release protection is enabled.
        /// *   **false**: The release protection is disabled.
        /// 
        /// >  This parameter is available only for pay-as-you-go instances.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ModifyInstanceAttribute**.
        /// </summary>
        [NameInMap("InstanceReleaseProtection")]
        [Validation(Required=false)]
        public bool? InstanceReleaseProtection { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

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
