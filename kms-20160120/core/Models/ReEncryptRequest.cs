// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ReEncryptRequest : TeaModel {
        /// <summary>
        /// The ciphertext that you want to re-encrypt.
        /// 
        /// You can set this parameter to the ciphertext that is returned after a symmetric or asymmetric encryption operation.
        /// 
        /// *   Symmetric encryption: the ciphertext returned after you call the [Encrypt](https://help.aliyun.com/document_detail/28949.html), [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html), [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html), or [GenerateAndExportDataKey](https://help.aliyun.com/document_detail/176804.html) operation
        /// *   Asymmetric encryption: the public key-encrypted ciphertext returned after you call the [GenerateAndExportDataKey](https://help.aliyun.com/document_detail/176804.html) operation, or the ciphertext encrypted by using the public key of an asymmetric key pair outside KMS
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// A JSON string that consists of key-value pairs. This parameter specifies the EncryptionContext that is used to re-encrypt the decrypted data or data key.
        /// </summary>
        [NameInMap("DestinationEncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> DestinationEncryptionContext { get; set; }

        /// <summary>
        /// The ID of the symmetric CMK that is used to re-encrypt the ciphertext after the ciphertext is decrypted.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationKeyId")]
        [Validation(Required=false)]
        public string DestinationKeyId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// The encryption algorithm based on which the public key is used to encrypt the ciphertext specified by CiphertextBlob. For more information about encryption algorithms, see [AsymmetricDecrypt](https://help.aliyun.com/document_detail/148130.html).
        /// 
        /// Valid values:
        /// 
        /// *   RSAES_OAEP_SHA_256
        /// *   RSAES_OAEP_SHA_1
        /// *   SM2PKE
        /// 
        /// >  If you set CiphertextBlob to the public key-encrypted ciphertext that is returned after an asymmetric encryption operation, specify this parameter.
        /// </summary>
        [NameInMap("SourceEncryptionAlgorithm")]
        [Validation(Required=false)]
        public string SourceEncryptionAlgorithm { get; set; }

        /// <summary>
        /// A JSON string that consists of key-value pairs. If you specify EncryptionContext when you call the [Encrypt](https://help.aliyun.com/document_detail/28949.html), [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html), [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html), or [GenerateAndExportDataKey](https://help.aliyun.com/document_detail/176804.html) operation to encrypt the data or data key, an equivalent value is required here. For more information, see [EncryptionContext](https://help.aliyun.com/document_detail/42975.html).
        /// 
        /// >  If you set CiphertextBlob to the ciphertext that is returned after a symmetric encryption operation, specify this parameter.
        /// </summary>
        [NameInMap("SourceEncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceEncryptionContext { get; set; }

        /// <summary>
        /// The ID of the CMK that is used to decrypt the ciphertext.
        /// 
        /// This parameter is the globally unique ID of the CMK.
        /// 
        /// >  If you set CiphertextBlob to the public key-encrypted ciphertext that is returned after an asymmetric encryption operation, specify this parameter.
        /// </summary>
        [NameInMap("SourceKeyId")]
        [Validation(Required=false)]
        public string SourceKeyId { get; set; }

        /// <summary>
        /// The ID of the CMK version that is used to decrypt the ciphertext.
        /// 
        /// >  If you set CiphertextBlob to the public key-encrypted ciphertext that is returned after an asymmetric encryption operation, specify this parameter.
        /// </summary>
        [NameInMap("SourceKeyVersionId")]
        [Validation(Required=false)]
        public string SourceKeyVersionId { get; set; }

    }

}
