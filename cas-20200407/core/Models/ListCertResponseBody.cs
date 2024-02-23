// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertResponseBody : TeaModel {
        /// <summary>
        /// The certificates.
        /// </summary>
        [NameInMap("CertList")]
        [Validation(Required=false)]
        public List<ListCertResponseBodyCertList> CertList { get; set; }
        public class ListCertResponseBodyCertList : TeaModel {
            /// <summary>
            /// The expiration time of the certificate. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// The issuance time of the certificate. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// The type of the certificate.
            /// 
            /// *   **CA**: the CA certificate.
            /// *   **CERT**: a issued certificate.
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// Indicates whether the certificate contains a private key. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ExistPrivateKey")]
            [Validation(Required=false)]
            public bool? ExistPrivateKey { get; set; }

            /// <summary>
            /// The unique identifier of the certificate.
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// The issuer of the certificate.
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// All domain names that are bound to the certificate. Multiple domain names are separated by commas (,).
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// The source of the certificate. Valid values:
            /// 
            /// *   **upload**: uploaded certificate
            /// *   **aliyun**: Alibaba Cloud certificate
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

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
            /// The ID of the certificate application repository.
            /// </summary>
            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

            /// <summary>
            /// The instance ID of the certificate application repository.
            /// </summary>
            [NameInMap("WhInstanceId")]
            [Validation(Required=false)]
            public string WhInstanceId { get; set; }

        }

        /// <summary>
        /// The page number of the returned page. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: 50.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
