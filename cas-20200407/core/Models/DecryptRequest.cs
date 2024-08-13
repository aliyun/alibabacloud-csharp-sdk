// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DecryptRequest : TeaModel {
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
        /// The unique identifier of the certificate. You can call the [ListCert](https://help.aliyun.com/document_detail/455806.html) operation to query the identifier.
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
        /// The data that you want to decrypt. The value is encoded in Base64.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// The value type of the Message parameter. Valid values:
        /// 
        /// *   RAW: The returned result is raw data encoded in UTF-8.
        /// *   Base64: The returned result is Base64-encoded data. This is the default value.
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

    }

}
