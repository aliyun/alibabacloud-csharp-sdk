// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForRealRequest : TeaModel {
        /// <summary>
        /// The authorization code.
        /// 
        /// >  On the **My Applications** page in the [Cell Phone Number Service console](https://dytns.console.aliyun.com/analysis/apply), you can obtain the authorization ID.
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The phone number to be queried.
        /// 
        /// *   If the value of Mask is NORMAL, the value of this field is an 11-digit phone number.
        /// *   If the value of Mask is MD5, the value of this field is a 32-bit encrypted string.
        /// *   If the value of Mask is SHA256, the value of this field is a 64-bit encrypted string.
        /// 
        /// >  Letters in the encrypted strings are not case-sensitive.
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// The encryption method of the phone number. Valid values:
        /// 
        /// *   **NORMAL**: The phone number is not encrypted.
        /// *   **MD5**
        /// *   **SHA256**
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
