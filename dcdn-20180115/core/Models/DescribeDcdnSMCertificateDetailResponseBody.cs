// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSMCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// The time when the certificate expires. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CertExpireTime")]
        [Validation(Required=false)]
        public string CertExpireTime { get; set; }

        /// <summary>
        /// The ID of the certificate.
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// The name of the certificate.
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// The certificate authority (CA) that issued the certificate.
        /// </summary>
        [NameInMap("CertOrg")]
        [Validation(Required=false)]
        public string CertOrg { get; set; }

        /// <summary>
        /// The top-level domain name.
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// The content of the encryption certificate.
        /// </summary>
        [NameInMap("EncryptCertificate")]
        [Validation(Required=false)]
        public string EncryptCertificate { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The domain name on the additional certificate.
        /// </summary>
        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        /// <summary>
        /// The content of the signature certificate.
        /// </summary>
        [NameInMap("SignCertificate")]
        [Validation(Required=false)]
        public string SignCertificate { get; set; }

    }

}
