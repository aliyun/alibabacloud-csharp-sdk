// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyRequest : TeaModel {
        /// <summary>
        /// The ID of the KMS instance.
        /// 
        /// > You must specify this parameter if you need to create a key for a KMS instance. If you need to create a default key of the CMK type, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// The description of the key.
        /// 
        /// The description can be 0 to 8,192 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic key rotation. Valid values:
        /// 
        /// - true
        /// - false (default)
        /// 
        /// This parameter is valid only when the key belongs to an instance type that supports automatic rotation. For more information, see [Key rotation](~~2358146~~).
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        /// <summary>
        /// The key specification. The valid values vary based on the KMS instance type. For more information, see [Overview](~~480159~~).
        /// 
        /// > If you do not specify a value for this parameter, the default key specification is Aliyun_AES_256.
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// The usage of the key. Valid values:
        /// 
        /// - ENCRYPT/DECRYPT
        /// - SIGN/VERIFY
        /// 
        /// If the key supports signing and verification, the default value is SIGN/VERIFY. If the key does not support signing and verification, the default value is ENCRYPT/DECRYPT.
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// The key material origin. Valid values:
        /// 
        /// - Aliyun_KMS (default): KMS generates key material.
        /// - EXTERNAL: You import key material.
        /// 
        /// 
        /// > - The value of this parameter is case-sensitive.
        /// > - Default keys of the customer master key (CMK) type support Aliyun_KMS and EXTERNAL. Keys in instances of the software key management type support only Aliyun_KMS. Keys in instances of the hardware key management type support Aliyun_KMS and EXTERNAL.
        /// > - If you set Origin to EXTERNAL, you must import key material. For more information, see [Import key material into a symmetric key](~~607841~~) or [Import key material into an asymmetric key](~~608827~~).
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// You do not need to specify this parameter. KMS sets a protection level for your key.
        /// 
        /// The protection level of the key. Valid values:
        /// 
        /// - SOFTWARE
        /// - HSM
        /// 
        /// 
        /// > - If DKMSInstanceId is specified, this parameter does not take effect. If your instance is an instance of the software key management type, set the value to SOFTWARE. If your instance is an instance of the hardware key management type, set the value to HSM.
        /// > - If you do not specify DKMSInstanceId, we recommend that you do not specify this parameter. KMS sets a protection level for your key. If managed hardware security modules (HSMs) exist in the region of your KMS instance, set the value to HSM. If managed HSMs do not exist in the region of your KMS instance, set the value to SOFTWARE. For more information, see Managed HSM overview.
        /// </summary>
        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public string ProtectionLevel { get; set; }

        /// <summary>
        /// The period of automatic key rotation. Format: integer[unit]. Unit: d (day), h (hour), m (minute), or s (second). For example, both 7d and 604800s represent a seven-day interval.
        /// 
        /// - For a default key, set the value to 365 days.
        /// - For a software-protected key, set a value that ranges from 7 to 365 days.
        /// - A hardware-protected key does not support automatic rotation.
        /// 
        /// > If EnableAutomaticRotation is set to true, this parameter is required.
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// The tag that is added to the key. A tag consists of a key-value pair.
        /// 
        /// You can enter up to 20 tags. Enter multiple tags in the [{"TagKey":"key1","TagValue":"value1"},{"TagKey":"key2","TagValue":"value2"},..] format.
        /// 
        /// Each tag key or tag value can be up to 128 characters in length and can contain letters, digits, forward slashes (/), backslashes (\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).
        /// 
        /// > The tag key cannot start with aliyun or acs:.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
