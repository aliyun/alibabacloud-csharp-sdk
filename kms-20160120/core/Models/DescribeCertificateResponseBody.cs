// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeCertificateResponseBody : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the certificate.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The ID of the certificate. The ID must be globally unique in Certificates Manager.
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// The time when the certificate was created.
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Indicates whether the private key of the certificate can be exported for use. Valid values:
        /// 
        /// *   true: The private key of the certificate can be exported for use. This is the default value.
        /// *   false: The private key of the certificate cannot be exported for use.
        /// </summary>
        [NameInMap("ExportablePrivateKey")]
        [Validation(Required=false)]
        public bool? ExportablePrivateKey { get; set; }

        /// <summary>
        /// The certificate issuer in the distinguished name (DN) format.
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The type of the key.
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// The end of the validity period of the certificate.
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// The beginning of the validity period of the certificate.
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The serial number of the certificate.
        /// </summary>
        [NameInMap("Serial")]
        [Validation(Required=false)]
        public string Serial { get; set; }

        /// <summary>
        /// The signature algorithm of the certificate. Valid values:
        /// 
        /// *   RSA2048-SHA256
        /// *   ECDSA-SHA256
        /// *   SM2-SM3
        /// </summary>
        [NameInMap("SignatureAlgorithm")]
        [Validation(Required=false)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// The status of the certificate. Valid values:
        /// 
        /// *   PENDING: The certificate is to be imported.
        /// *   ACTIVE: The certificate is enabled.
        /// *   INACTIVE: The certificate is disabled.
        /// *   REVOKED: The certificate is revoked.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The subject of the certificate, which is in the DN format.
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// The alias of the certificate subject.
        /// 
        /// A domain name list is supported. A maximum of 10 domain names are supported.
        /// </summary>
        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public List<string> SubjectAlternativeNames { get; set; }

        /// <summary>
        /// The public key identifier of the certificate subject.
        /// </summary>
        [NameInMap("SubjectKeyIdentifier")]
        [Validation(Required=false)]
        public string SubjectKeyIdentifier { get; set; }

        /// <summary>
        /// The public key of the certificate.
        /// </summary>
        [NameInMap("SubjectPublicKey")]
        [Validation(Required=false)]
        public string SubjectPublicKey { get; set; }

        /// <summary>
        /// The tag of the certificate.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// The time when the certificate was updated.
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
