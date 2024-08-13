// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class SignRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the certificate. You can call the [ListCert](https://help.aliyun.com/document_detail/455806.html) operation to obtain the identifier.
        /// 
        /// *   If the certificate is an SSL certificate, the value of this parameter must be in the {Certificate ID}-cn-hangzhou format.
        /// *   If the certificate is a private certificate, the value of this parameter must be the value of the Identifier field for the private certificate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// The data to sign. The value must be encoded in Base64.\\
        /// For example, if the hexadecimal data that you want to sign is [0x31, 0x32, 0x33, 0x34], set the parameter to the Base64-encoded value MTIzNA==. If you set MessageType to RAW, the size of the data must be less than 4 KB. If the size of the data is greater than 4 KB, you can set MessageType to DIGEST and set Message to the digest of the data. The digest is a hash value. You can compute the digest of the data on an on-premises machine. The certificate application repository uses the digest that you compute in your own certificate application system. The message digest algorithm that you use must match the specified signature algorithm. The following items describe the details:
        /// 
        /// *   If the signature algorithm is SHA256withRSA, SHA256withRSA/PSS, or SHA256withECDSA, the message digest algorithm must be SHA-256.
        /// *   If the signature algorithm is SM3withSM2, the message digest algorithm must be SM3.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The value type of the Message parameter. Valid values:
        /// 
        /// *   RAW: the raw data. This is the default value.
        /// *   DIGEST: the message digest (hash value) of the raw data.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// The signature algorithm. Valid values:
        /// 
        /// *   SHA256withRSA
        /// *   SHA256withRSA/PSS
        /// *   SHA256withECDSA
        /// *   SM3withSM2
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SigningAlgorithm")]
        [Validation(Required=false)]
        public string SigningAlgorithm { get; set; }

    }

}
