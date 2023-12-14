// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeCertificatesResponseBody : TeaModel {
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<DescribeCertificatesResponseBodyCertificates> Certificates { get; set; }
        public class DescribeCertificatesResponseBodyCertificates : TeaModel {
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public long? CertificateId { get; set; }

            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }

            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("IsUsing")]
            [Validation(Required=false)]
            public bool? IsUsing { get; set; }

            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
