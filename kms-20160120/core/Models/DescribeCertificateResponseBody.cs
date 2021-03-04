// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeCertificateResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public string ProtectionLevel { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public List<string> SubjectAlternativeNames { get; set; }

        [NameInMap("SignatureAlgorithm")]
        [Validation(Required=false)]
        public string SignatureAlgorithm { get; set; }

        [NameInMap("SubjectKeyIdentifier")]
        [Validation(Required=false)]
        public string SubjectKeyIdentifier { get; set; }

        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("Serial")]
        [Validation(Required=false)]
        public string Serial { get; set; }

        [NameInMap("SubjectPublicKey")]
        [Validation(Required=false)]
        public string SubjectPublicKey { get; set; }

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
