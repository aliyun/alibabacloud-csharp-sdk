// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceInstanceCertsResponseBody : TeaModel {
        [NameInMap("Certs")]
        [Validation(Required=false)]
        public List<DescribeResourceInstanceCertsResponseBodyCerts> Certs { get; set; }
        public class DescribeResourceInstanceCertsResponseBodyCerts : TeaModel {
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

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

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("IsChainCompleted")]
            [Validation(Required=false)]
            public bool? IsChainCompleted { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
