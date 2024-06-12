// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForSmsRequest : TeaModel {
        /// <summary>
        /// The authorization code.
        /// 
        /// >  On the **My Applications** page in the [Cell Phone Number Service console](https://dytns.console.aliyun.com/analysis/apply), you can obtain the authorization code (also known as authorization ID).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The phone number to be queried.
        /// 
        /// *   If the value of Mask is NORMAL, specify an 11-digit phone number in plaintext.
        /// *   If the value of Mask is MD5, specify a 32-bit string that is encrypted by using MD5.
        /// *   If the value of Mask is SHA256, specify a 64-bit string that is encrypted by using SHA256.
        /// 
        /// >  Letters in the encrypted strings are not case-sensitive.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// The encryption method of the phone number. Valid values:
        /// 
        /// *   **NORMAL**: plaintext
        /// *   **MD5**
        /// *   **SHA256**
        /// 
        /// This parameter is required.
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
