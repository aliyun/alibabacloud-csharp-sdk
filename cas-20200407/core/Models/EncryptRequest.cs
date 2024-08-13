// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class EncryptRequest : TeaModel {
        /// <summary>
        /// The encryption algorithm. Valid values:
        /// 
        /// *   **RSAES_OAEP_SHA_1**
        /// *   **RSAES_OAEP_SHA_256**
        /// *   **SM2PKE**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

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
        /// The value type of the Message parameter. Valid values:
        /// 
        /// *   RAW: The value of the Plaintext parameter is directly encrypted. This is the default value.
        /// *   Base64: The value of the Plaintext parameter is Base64-encoded data. The data is decoded and then encrypted.
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// The data that you want to encrypt. The value of this parameter can be raw data or Base64-encoded data. For more information, see the description of the MessageType parameter. For example, if the hexadecimal data that you want to encrypt is `[0x31, 0x32, 0x33, 0x34]`, the Base64-encoded data is MTIzNA==. The size of data that can be encrypted varies based on the encryption algorithm that you use. The following list describes the relationship between the encryption algorithms and data sizes:
        /// 
        /// *   **RSAES_OAEP_SHA_1**: 214 bytes
        /// *   **RSAES_OAEP_SHA_256**: 190 bytes
        /// *   **SM2PKE**: 6,047 bytes
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
