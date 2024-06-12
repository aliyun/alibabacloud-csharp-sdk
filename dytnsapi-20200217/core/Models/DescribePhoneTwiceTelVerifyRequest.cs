// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneTwiceTelVerifyRequest : TeaModel {
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
        /// *   **NORMAL**: The phone number is not encrypted.
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

        /// <summary>
        /// The registration time. Specify the time in the yyyy-MM-dd HH:mm:ss format. This time is the service registration time of the mobile phone user. If the service registration time is later than the time when the phone number is assigned by a carrier, it indicates that the phone number is not a reassigned number. Otherwise, the phone number is a reassigned number.
        /// 
        /// > 
        /// 
        /// *   If a carrier allocates a single number multiple times, the system will determine whether the phone number is a reassigned number based on the time when the carrier last allocated the phone number.
        /// 
        /// *   The service registration time must be later than 00:00:00 on January 1, 1970.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
