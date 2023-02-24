// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ExportDataKeyShrinkRequest : TeaModel {
        /// <summary>
        /// The ciphertext of the data key encrypted by using a CMK.
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// A JSON string that consists of key-value pairs. If you specify this parameter when you use a CMK to encrypt the data key, an equivalent value is required here. For more information, see [EncryptionContext](~~42975~~).
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public string EncryptionContextShrink { get; set; }

        /// <summary>
        /// A Base64-encoded public key.
        /// </summary>
        [NameInMap("PublicKeyBlob")]
        [Validation(Required=false)]
        public string PublicKeyBlob { get; set; }

        /// <summary>
        /// The encryption algorithm based on which you want to use the public key specified by PublicKeyBlob to encrypt the data key. For more information about encryption algorithms, see [AsymmetricDecrypt](~~148130~~).
        /// 
        /// Valid values:
        /// 
        /// *   RSAES_OAEP_SHA\_256
        /// *   RSAES_OAEP_SHA\_1
        /// *   SM2PKE
        /// </summary>
        [NameInMap("WrappingAlgorithm")]
        [Validation(Required=false)]
        public string WrappingAlgorithm { get; set; }

        /// <summary>
        /// The key type of the public key specified by PublicKeyBlob. For more information about key types, see [Introduction to asymmetric keys](~~148147~~).
        /// 
        /// Valid values:
        /// 
        /// *   RSA\_2048
        /// *   EC_SM2
        /// </summary>
        [NameInMap("WrappingKeySpec")]
        [Validation(Required=false)]
        public string WrappingKeySpec { get; set; }

    }

}
