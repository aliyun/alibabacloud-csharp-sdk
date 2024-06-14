// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePublicKeyEncryptRequest : TeaModel {
        /// <summary>
        /// The encryption algorithm. Valid values:
        /// 
        /// *   RSAES_OAEP_SHA_1
        /// 
        /// *   RSAES_OAEP_SHA_256
        /// 
        /// *   SM2PKE
        /// 
        /// >The SM2PKE encryption algorithm is supported only in regions in mainland China. In these regions, managed hardware security modules (HSMs) are used. For more information, see [Managed HSM overview](https://help.aliyun.com/document_detail/125803.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The ID of the certificate. The ID must be globally unique in Certificates Manager.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The data that you want to encrypt.
        /// 
        /// The value is encoded in Base64. For example, if the hexadecimal data that you want to encrypt is `[0x31, 0x32, 0x33, 0x34]`, the Base64-encoded data is `MTIzNA==`.
        /// 
        /// The size of data that can be encrypted varies based on the encryption algorithm that you use:
        /// 
        /// *   RSAES_OAEP_SHA_1: 214 bytes
        /// *   RSAES_OAEP_SHA_256: 190 bytes
        /// *   SM2PKE: 6,047 bytes
        /// 
        /// If the size of data that you want to encrypt exceeds the preceding limits, you can call the [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html) operation to generate a data key to encrypt the data. Then, call the CertificatePublicKeyEncrypt operation to encrypt the data key.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
