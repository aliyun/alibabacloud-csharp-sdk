// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200619.Models
{
    public class DescribeSSLCertificateMatchDomainListResponseBody : TeaModel {
        [NameInMap("CertMetaList")]
        [Validation(Required=false)]
        public List<DescribeSSLCertificateMatchDomainListResponseBodyCertMetaList> CertMetaList { get; set; }
        public class DescribeSSLCertificateMatchDomainListResponseBodyCertMetaList : TeaModel {
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            [NameInMap("DomainMatchCert")]
            [Validation(Required=false)]
            public bool? DomainMatchCert { get; set; }

            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
