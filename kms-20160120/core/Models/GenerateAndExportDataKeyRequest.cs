// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateAndExportDataKeyRequest : TeaModel {
        /// <summary>
        /// A JSON string of key-value pairs. If you specify this parameter here, an equivalent value is required when you decrypt or re-encrypt the data key. For more information, see [EncryptionContext](https://help.aliyun.com/document_detail/42975.html).
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> EncryptionContext { get; set; }

        /// <summary>
        /// The globally unique ID of the CMK. You can also set this parameter to an alias that is bound to the CMK. For more information, see [Use aliases](https://help.aliyun.com/document_detail/68522.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The length of the data key that you want to generate. Valid values:
        /// 
        /// *   AES_256: a 256-bit symmetric key
        /// *   AES_128: a 128-bit symmetric key
        /// 
        /// >  We recommend that you use the KeySpec or NumberOfBytes parameter to specify the length of a data key. If both parameters are not specified, KMS generates a 256-bit data key. If both parameters are specified, KMS ignores the KeySpec parameter.
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// The length of the data key that you want to generate.
        /// 
        /// Valid values: 1 to 1024.
        /// 
        /// Unit: bytes.
        /// </summary>
        [NameInMap("NumberOfBytes")]
        [Validation(Required=false)]
        public int? NumberOfBytes { get; set; }

        /// <summary>
        /// A Base64-encoded public key.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PublicKeyBlob")]
        [Validation(Required=false)]
        public string PublicKeyBlob { get; set; }

        /// <summary>
        /// The encryption algorithm based on which you want to use the public key specified by PublicKeyBlob to encrypt the data key. For more information about encryption algorithms, see [AsymmetricDecrypt](https://help.aliyun.com/document_detail/148130.html).
        /// 
        /// Valid values:
        /// 
        /// *   RSAES_OAEP_SHA_256
        /// *   RSAES_OAEP_SHA_1
        /// *   SM2PKE
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WrappingAlgorithm")]
        [Validation(Required=false)]
        public string WrappingAlgorithm { get; set; }

        /// <summary>
        /// The key type of the public key specified by PublicKeyBlob. For more information about key types, see [Introduction to asymmetric keys](https://help.aliyun.com/document_detail/148147.html).
        /// 
        /// Valid values:
        /// 
        /// *   RSA_2048
        /// *   EC_SM2
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WrappingKeySpec")]
        [Validation(Required=false)]
        public string WrappingKeySpec { get; set; }

    }

}
