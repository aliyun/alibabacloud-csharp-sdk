// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCsrResponseBody : TeaModel {
        /// <summary>
        /// The CSRs.
        /// </summary>
        [NameInMap("CsrList")]
        [Validation(Required=false)]
        public List<ListCsrResponseBodyCsrList> CsrList { get; set; }
        public class ListCsrResponseBodyCsrList : TeaModel {
            /// <summary>
            /// The algorithm. Valid values: RSA, SM2, and ECC.
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// The primary domain name, which is a common name.
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// The name of the company.
            /// </summary>
            [NameInMap("CorpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// The code of the country or region in which the organization is located. For example, you can use CN to indicate China and use US to indicate the United States. The default value is the code of the country or region in which the organization is located. The organization is associated with the intermediate CA certificate from which the certificate is issued. For more information about country codes, see the "Country codes" section of the [Manage company profiles](https://help.aliyun.com/document_detail/198289.html) topic.
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// The ID of the CSR.
            /// </summary>
            [NameInMap("CsrId")]
            [Validation(Required=false)]
            public long? CsrId { get; set; }

            /// <summary>
            /// The department that uses the certificate.
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// Indicates whether the certificate contains a private key.
            /// </summary>
            [NameInMap("HasPrivateKey")]
            [Validation(Required=false)]
            public bool? HasPrivateKey { get; set; }

            /// <summary>
            /// The public key that is calculated by using the SHA256 algorithm.
            /// </summary>
            [NameInMap("KeySha2")]
            [Validation(Required=false)]
            public string KeySha2 { get; set; }

            /// <summary>
            /// The key length that is used by the algorithm. The key length for RSA algorithms can be 2,048, 3,072, and 4,096 bits. The key length for ECC and SM2 algorithms can be 256 bits.
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// The city where the company is located.
            /// </summary>
            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            /// <summary>
            /// The name of the CSR.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The province or location.
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// The secondary domain names. Separate multiple domain names with commas (,).
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 50.
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
