// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyRequest : TeaModel {
        /// <summary>
        /// The type of the CMK. Valid values:
        /// 
        /// *   Aliyun_AES\_256
        /// *   Aliyun_AES\_128
        /// *   Aliyun_AES\_192
        /// *   Aliyun_SM4
        /// *   RSA\_2048
        /// *   RSA\_3072
        /// *   EC_P256
        /// *   EC_P256K
        /// *   EC_SM2
        /// 
        /// > * The default type of the CMK is Aliyun\_AES\_256.
        /// > * Only Dedicated KMS supports Aliyun\_AES\_128 and Aliyun\_AES\_192.
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **CreateKey**.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The protection level of the CMK. Valid values:
        /// 
        /// *   SOFTWARE
        /// *   HSM
        /// 
        /// Default value: SOFTWARE.
        /// 
        /// > * The value of this parameter is case-sensitive.
        /// > * Assume that you set this parameter to HSM. If you set the Origin parameter to Aliyun_KMS, the CMK is created in a managed HSM. If you set the Origin parameter to EXTERNAL, you can import an external key into the managed HSM.
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        /// <summary>
        /// The period of automatic key rotation. Specify the value in the integer\[unit] format. Unit: d (day), h (hour), m (minute), or s (second). For example, you can use either 7d or 604800s to specify a seven-day period. The period can range from 7 days to 730 days.
        /// 
        /// >  If you set the EnableAutomaticRotation parameter to true, you must also specify this parameter. If you set the EnableAutomaticRotation parameter to false, you can leave this parameter unspecified.
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// The description of the CMK.
        /// 
        /// The description can be 0 to 8,192 characters in length.
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// The usage of the CMK. Valid values:
        /// 
        /// *   ENCRYPT/DECRYPT: encrypts or decrypts data.
        /// *   SIGN/VERIFY: generates or verifies a digital signature.
        /// 
        /// If the CMK supports signature verification, the default value is SIGN/VERIFY. If the CMK does not support signature verification, the default value is ENCRYPT/DECRYPT.
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// The source of key material. Valid values:
        /// 
        /// *   Aliyun_KMS (default value)
        /// *   EXTERNAL
        /// 
        /// > * The value of this parameter is case-sensitive.
        /// > * If you set the KeySpec parameter to an asymmetric CMK type, you are not allowed to set the Origin parameter to EXTERNAL.
        /// > * If you set the Origin parameter to EXTERNAL, you must import key material. For more information, see [Import key material](~~68523~~).
        /// </summary>
        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public string ProtectionLevel { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic key rotation. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// 
        /// >  If the Origin parameter is set to EXTERNAL or the KeySpec parameter is set to an asymmetric CMK type, automatic key rotation is not supported.
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
