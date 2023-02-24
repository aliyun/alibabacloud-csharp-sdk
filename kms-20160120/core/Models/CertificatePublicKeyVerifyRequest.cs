// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePublicKeyVerifyRequest : TeaModel {
        /// <summary>
        /// The signature algorithm. Valid values:
        /// 
        /// *   RSA_PKCS1\_SHA\_256
        /// 
        /// *   RSA_PSS_SHA\_256
        /// 
        /// *   ECDSA_SHA\_256
        /// 
        /// *   SM2DSA
        /// 
        /// > The SM2DSA signature algorithm is supported only in regions where managed hardware security modules (HSMs) are used in the Chinese mainland. For more information, see [Managed HSM overview](~~125803~~).
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The ID of the certificate. The ID must be globally unique in Certificates Manager.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The raw data that is signed.
        /// 
        /// The value is encoded in Base64. For example, if the raw data in the hexadecimal format is `[0x31, 0x32, 0x33, 0x34]`, set this parameter to the Base64-encoded value `MTIzNA==`.
        /// 
        /// If the MessageType parameter is set to RAW, the size of the data must be less than or equal to 4 KB.
        /// 
        /// If the size of the data is greater than 4 KB, you can set the MessageType parameter to DIGEST and set the Message parameter to the digest of the data. The digest is also called hash value. You can compute the digest of the data on an on-premises device. Certificates Manager uses the digest that you compute in your own certificate application system. The message digest algorithm that you use must match the specified signature algorithm. Comply with the following mapping between signature algorithms and message digest algorithms:
        /// 
        /// *   If the signature algorithm is RSA_PKCS1\_SHA\_256, RSA_PSS_SHA\_256, or ECDSA_SHA\_256, the message digest algorithm must be SHA-256.
        /// *   If the signature algorithm is SM2DSA, the message digest algorithm must be SM3.
        /// 
        /// >  If the key type of the certificate is EC_SM2 and the MessageType parameter is set to DIGEST, the value of the Message parameter is `e` that is described in GB/T 32918.2-2016 6.1.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The type of the message. Valid values:
        /// 
        /// *   RAW: the raw data. This is the default value.
        /// *   DIGEST: the message digest (hash value) of the raw data.
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// The signature value.
        /// 
        /// The value is encoded in Base64.
        /// </summary>
        [NameInMap("SignatureValue")]
        [Validation(Required=false)]
        public string SignatureValue { get; set; }

    }

}
