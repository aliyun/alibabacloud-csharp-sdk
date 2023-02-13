// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCACertificateResponseBody : TeaModel {
        /// <summary>
        /// The details about the CA certificate.
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public DescribeCACertificateResponseBodyCertificate Certificate { get; set; }
        public class DescribeCACertificateResponseBodyCertificate : TeaModel {
            /// <summary>
            /// The expiration date of the CA certificate. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// The encryption algorithm of the CA certificate. Valid values:
            /// 
            /// *   **RSA**: the Rivest-Shamir-Adleman (RSA) algorithm.
            /// *   **ECC**: the elliptic curve cryptography (ECC) algorithm.
            /// *   **SM2**: the SM2 algorithm, which is developed and approved by the State Cryptography Administration of China.
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// The issuance date of the CA certificate. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// The type of the CA certificate. Valid values:
            /// 
            /// *   **ROOT**: root CA certificate
            /// *   **SUB_ROOT**: intermediate CA certificate
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// The common name or abbreviation of the organization that is associated with the CA certificate.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// The code of the country in which the organization is located.
            /// 
            /// For more information about country codes, see the **"Country codes"** section of the [Manage company profiles](~~198289~~) topic.
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// The status of the certificate revocation list (CRL) feature.
            /// </summary>
            [NameInMap("CrlStatus")]
            [Validation(Required=false)]
            public string CrlStatus { get; set; }

            /// <summary>
            /// The address of the CRL.
            /// </summary>
            [NameInMap("CrlUrl")]
            [Validation(Required=false)]
            public string CrlUrl { get; set; }

            /// <summary>
            /// The unique identifier of the CA certificate.
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// The key length of the CA certificate.
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// The name of the city in which the organization is located.
            /// </summary>
            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            /// <summary>
            /// The MD5 fingerprint of the CA certificate.
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// The name of the organization that is associated with the CA certificate.
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// The name of the department or branch in the organization that is associated with the CA certificate.
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// The unique identifier of the root CA certificate from which the CA certificate is issued.
            /// 
            /// >  This parameter is returned only if the value of the **CertificateType** parameter is **SUB_ROOT**. The value SUB_ROOT indicates an intermediate CA certificate.
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// The serial number of the CA certificate.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// The SHA-256 fingerprint of the CA certificate.
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// The signature algorithm of the CA certificate.
            /// </summary>
            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            /// <summary>
            /// The name of the province, municipality, or autonomous region in which the organization is located.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The status of the CA certificate. Valid values:
            /// 
            /// *   **ISSUE**: The CA certificate is issued.
            /// *   **REVOKE**: The CA certificate is revoked.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The user attribute of the CA certificate, which contains the following information:
            /// 
            /// *   **C**: the country code in which the organization is located
            /// *   **O**: the name of the organization
            /// *   **OU**: the name of the department or branch in the organization
            /// *   **L**: the name of the city in which the organization is located
            /// *   **ST**: the name of the province, municipality, or autonomous region in which the organization is located
            /// *   **CN**: the common name or abbreviation of the organization
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

            /// <summary>
            /// The content of the CA certificate.
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The validity period of the CA certificate. Unit: years.
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}
