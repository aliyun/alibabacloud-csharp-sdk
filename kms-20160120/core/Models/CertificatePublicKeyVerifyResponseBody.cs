// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePublicKeyVerifyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the certificate.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The verification result. Valid values:
        /// 
        /// *   true: The signature is valid.
        /// *   false: The signature is invalid.
        /// </summary>
        [NameInMap("SignatureValid")]
        [Validation(Required=false)]
        public bool? SignatureValid { get; set; }

    }

}
