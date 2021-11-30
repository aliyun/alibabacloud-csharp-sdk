// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateForSerialNumberResponseBody : TeaModel {
        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<DescribeClientCertificateForSerialNumberResponseBodyCertificateList> CertificateList { get; set; }
        public class DescribeClientCertificateForSerialNumberResponseBodyCertificateList : TeaModel {
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public string AfterDate { get; set; }

            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public string BeforeDate { get; set; }

            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("Sha2")]
            [Validation(Required=false)]
            public string Sha2 { get; set; }

            [NameInMap("SignAlgorithm")]
            [Validation(Required=false)]
            public string SignAlgorithm { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

            [NameInMap("Years")]
            [Validation(Required=false)]
            public int? Years { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
