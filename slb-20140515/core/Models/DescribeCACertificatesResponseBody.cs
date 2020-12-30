// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeCACertificatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CACertificates")]
        [Validation(Required=false)]
        public DescribeCACertificatesResponseBodyCACertificates CACertificates { get; set; }
        public class DescribeCACertificatesResponseBodyCACertificates : TeaModel {
            [NameInMap("CACertificate")]
            [Validation(Required=false)]
            public List<DescribeCACertificatesResponseBodyCACertificatesCACertificate> CACertificate { get; set; }
            public class DescribeCACertificatesResponseBodyCACertificatesCACertificate : TeaModel {
                public long? CreateTimeStamp { get; set; }
                public string ExpireTime { get; set; }
                public string CreateTime { get; set; }
                public long? ExpireTimeStamp { get; set; }
                public string CACertificateId { get; set; }
                public string RegionId { get; set; }
                public string Fingerprint { get; set; }
                public string ResourceGroupId { get; set; }
                public string CommonName { get; set; }
                public string CACertificateName { get; set; }
            }
        };

    }

}
