// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ReEncryptShrinkRequest : TeaModel {
        /// <summary>
        /// The ciphertext that you want to re-encrypt.
        /// 
        /// You can set this parameter to the ciphertext that is returned after a symmetric or asymmetric encryption operation.
        /// 
        /// *   Symmetric encryption: the ciphertext returned after you call the [Encrypt](~~28949~~), [GenerateDataKey](~~28948~~), [GenerateDataKeyWithoutPlaintext](~~134043~~), or [GenerateAndExportDataKey](~~176804~~) operation
        /// *   Asymmetric encryption: the public key-encrypted ciphertext returned after you call the [GenerateAndExportDataKey](~~176804~~) operation, or the ciphertext encrypted by using the public key of an asymmetric key pair outside KMS
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// A JSON string that consists of key-value pairs. This parameter specifies the EncryptionContext that is used to re-encrypt the decrypted data or data key.
        /// </summary>
        [NameInMap("DestinationEncryptionContext")]
        [Validation(Required=false)]
        public string DestinationEncryptionContextShrink { get; set; }

        /// <summary>
        /// The ID of the symmetric CMK that is used to re-encrypt the ciphertext after the ciphertext is decrypted.
        /// </summary>
        [NameInMap("DestinationKeyId")]
        [Validation(Required=false)]
        public string DestinationKeyId { get; set; }

        /// <summary>
        /// The encryption algorithm based on which the public key is used to encrypt the ciphertext specified by CiphertextBlob. For more information about encryption algorithms, see [AsymmetricDecrypt](~~148130~~).
        /// 
        /// Valid values:
        /// 
        /// *   RSAES_OAEP_SHA\_256
        /// *   RSAES_OAEP_SHA\_1
        /// *   SM2PKE
        /// 
        /// >  If you set CiphertextBlob to the public key-encrypted ciphertext that is returned after an asymmetric encryption operation, specify this parameter.
        /// </summary>
        [NameInMap("SourceEncryptionAlgorithm")]
        [Validation(Required=false)]
        public string SourceEncryptionAlgorithm { get; set; }

        /// <summary>
        /// A JSON string that consists of key-value pairs. If you specify EncryptionContext when you call the [Encrypt](~~28949~~), [GenerateDataKey](~~28948~~), [GenerateDataKeyWithoutPlaintext](~~134043~~), or [GenerateAndExportDataKey](~~176804~~) operation to encrypt the data or data key, an equivalent value is required here. For more information, see [EncryptionContext](~~42975~~).
        /// 
        /// >  If you set CiphertextBlob to the ciphertext that is returned after a symmetric encryption operation, specify this parameter.
        /// </summary>
        [NameInMap("SourceEncryptionContext")]
        [Validation(Required=false)]
        public string SourceEncryptionContextShrink { get; set; }

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
