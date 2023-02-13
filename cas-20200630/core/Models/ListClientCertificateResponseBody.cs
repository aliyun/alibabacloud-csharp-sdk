// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListClientCertificateResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about all client certificates and server certificates.
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<ListClientCertificateResponseBodyCertificateList> CertificateList { get; set; }
        public class ListClientCertificateResponseBodyCertificateList : TeaModel {
            /// <summary>
            /// The expiration date of the certificate. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// The type of the encryption algorithm of the certificate. Valid values:
            /// 
            /// *   **RSA**: the Rivest-Shamir-Adleman (RSA) algorithm.
            /// *   **ECC**: the elliptic curve cryptography (ECC) algorithm.
            /// *   **SM2**: the SM2 algorithm, which is developed and approved by the State Cryptography Administration of China.
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// The issuance date of the certificate. This value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// The type of the certificate. Valid values:
            /// 
            /// *   **CLIENT**: client certificate
            /// *   **SERVER**: server certificate
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// The common name of the certificate.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// The code of the country in which the organization is located. The organization is associated with the intermediate certificate from which the certificate is issued.
            /// 
            /// For more information about country codes, see the **"Country codes"** section of the [Manage company profiles](~~198289~~) topic.
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// The validity period of the certificate. Unit: days.
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public int? Days { get; set; }

            /// <summary>
            /// The unique identifier of the certificate.
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// The key length of the certificate.
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// The name of the city in which the organization is located. The organization is associated with the intermediate certificate from which the certificate is issued.
            /// </summary>
            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            /// <summary>
            /// The MD5 fingerprint of the certificate.
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// The name of the organization. The organization is associated with the intermediate certificate from which the certificate is issued.
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// The name of the department in the organization. The organization is associated with the intermediate certificate authority (CA) certificate from which the certificate is issued.
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// The unique identifier of the intermediate certificate from which the client certificate is issued.
            /// </summary>
            [NameInMap("ParentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// The subject alternative name (SAN) extension of the certificate. The value indicates additional information, including the additional domain names or IP addresses that are associated with the certificate.
            /// 
            /// The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that corresponds to a SAN extension. A SAN extension struct contains the following parameters:
            /// 
            /// *   **Type**: the type of the extension. Data type: integer. Valid values:
            /// 
            ///     *   **1**: an email address
            ///     *   **2**: a domain name
            ///     *   **6**: a Uniform Resource Identifier (URI)
            ///     *   **7**: an IP address
            /// 
            /// *   **Value**: the value of the extension. Data type: string.
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// The serial number of the certificate.
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// The SHA-256 fingerprint of the certificate.
            /// </summary>
            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            /// <summary>
            /// The signature algorithm of the certificate.
            /// </summary>
            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            /// <summary>
            /// The name of the province, municipality, or autonomous region in which the organization is located. The organization is associated with the intermediate certificate from which the certificate is issued.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The status of the certificate. Valid values:
            /// 
            /// *   **ISSUE**: issued
            /// *   **REVOKE**: revoked
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The distinguished name (DN) extension of the certificate, which indicates the user of the certificate. The DN extension includes the following information:
            /// 
            /// *   **C**: the country
            /// *   **O**: the organization
            /// *   **OU**: the department
            /// *   **L**: the city
            /// *   **ST**: the province, municipality, or autonomous region
            /// *   **CN**: the common name
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

            /// <summary>
            /// The content of the certificate.
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

        }

        /// <summary>
        /// The page number of the current page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of certificates that are returned per page.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// The number of client certificates and server certificates that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
