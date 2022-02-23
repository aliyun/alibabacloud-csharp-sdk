// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeServerCertificatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerCertificates")]
        [Validation(Required=false)]
        public DescribeServerCertificatesResponseBodyServerCertificates ServerCertificates { get; set; }
        public class DescribeServerCertificatesResponseBodyServerCertificates : TeaModel {
            [NameInMap("ServerCertificate")]
            [Validation(Required=false)]
            public List<DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate> ServerCertificate { get; set; }
            public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate : TeaModel {
                public string AliCloudCertificateId { get; set; }
                public string AliCloudCertificateName { get; set; }
                public string CommonName { get; set; }
                public string CreateTime { get; set; }
                public long? CreateTimeStamp { get; set; }
                public string ExpireTime { get; set; }
                public long? ExpireTimeStamp { get; set; }
                public string Fingerprint { get; set; }
                public int? IsAliCloudCertificate { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string ServerCertificateId { get; set; }
                public string ServerCertificateName { get; set; }
                public DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames SubjectAlternativeNames { get; set; }
                public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames : TeaModel {
                    [NameInMap("SubjectAlternativeName")]
                    [Validation(Required=false)]
                    public List<string> SubjectAlternativeName { get; set; }

                }
            }
        };

    }

}
