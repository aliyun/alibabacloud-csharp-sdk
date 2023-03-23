// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCACertificateListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about the CA certificate.
        /// </summary>
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<DescribeCACertificateListResponseBodyCertificateList> CertificateList { get; set; }
        public class DescribeCACertificateListResponseBodyCertificateList : TeaModel {
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
            /// The Distinguished Name (DN) attribute of the CA certificate, which indicates the user information of the certificate. The DN attribute contains the following information:
            /// 
            /// *   **C**: the country code in which the organization is located
            /// *   **O**: the name of the organization
            /// *   **OU**: the name of the department or branch in the organization
            /// *   **L**: the name of the city in which the organization is located
            /// 
            /// <props="china">- **ST**: the name of the province, municipality, or autonomous region in which the organization is located</props> <props="intl">- **ST**: the name of the province or state in which the organization is located</props>
            /// 
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

            /// <summary>
            /// The validity period of the CA certificate. Unit: years.
            /// </summary>
            [NameInMap("Years")]
            [Validation(Required=false)]
            public int? Years { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of returned pages.
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
        /// The number of CA certificates returned per page.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// The total number of root CA certificates and intermediate CA certificates that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
