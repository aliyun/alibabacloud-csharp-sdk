// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class ThreeElementsVerificationRequest : TeaModel {
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
        /// The ID card number to be verified.
        /// 
        /// *   If the value of Mask is NORMAL, specify a value in plaintext for this field.
        /// *   If the value of Mask is MD5, specify a MD5-encrypted value for this field.
        /// *   If the value of Mask is SHA256, specify a SHA256-encrypted value for this field.
        /// 
        /// >  Letters in the encrypted strings are not case-sensitive.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertCode")]
        [Validation(Required=false)]
        public string CertCode { get; set; }

        /// <summary>
        /// The phone number to be verified.
        /// 
        /// *   If the value of Mask is NORMAL, specify a value in plaintext for this field.
        /// *   If the value of Mask is MD5, specify a MD5-encrypted value for this field.
        /// *   If the value of Mask is SHA256, specify a SHA256-encrypted value for this field.
        /// 
        /// >  Letters in the encrypted strings are not case-sensitive.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// The encryption method. Valid values:
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

        /// <summary>
        /// The name to be verified.
        /// 
        /// *   If the value of Mask is NORMAL, specify a value in plaintext for this field.
        /// *   If the value of Mask is MD5, specify a MD5-encrypted value for this field.
        /// *   If the value of Mask is SHA256, specify a SHA256-encrypted value for this field.
        /// 
        /// >  Letters in the encrypted strings are not case-sensitive.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
