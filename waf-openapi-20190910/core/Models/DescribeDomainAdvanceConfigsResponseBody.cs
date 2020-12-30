// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeDomainAdvanceConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeDomainAdvanceConfigsResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeDomainAdvanceConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public DescribeDomainAdvanceConfigsResponseBodyDomainConfigsProfile Profile { get; set; }
            public class DescribeDomainAdvanceConfigsResponseBodyDomainConfigsProfile : TeaModel {
                [NameInMap("Http2Port")]
                [Validation(Required=false)]
                public string Http2Port { get; set; }
                [NameInMap("Ipv6Status")]
                [Validation(Required=false)]
                public int? Ipv6Status { get; set; }
                [NameInMap("HttpPort")]
                [Validation(Required=false)]
                public string HttpPort { get; set; }
                [NameInMap("GSLBStatus")]
                [Validation(Required=false)]
                public string GSLBStatus { get; set; }
                [NameInMap("Rs")]
                [Validation(Required=false)]
                public string Rs { get; set; }
                [NameInMap("VipServiceStatus")]
                [Validation(Required=false)]
                public int? VipServiceStatus { get; set; }
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public int? ClusterType { get; set; }
                [NameInMap("ExclusiveVipStatus")]
                [Validation(Required=false)]
                public int? ExclusiveVipStatus { get; set; }
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }
                [NameInMap("CertStatus")]
                [Validation(Required=false)]
                public int? CertStatus { get; set; }
                [NameInMap("HttpsPort")]
                [Validation(Required=false)]
                public string HttpsPort { get; set; }
                [NameInMap("ResolvedType")]
                [Validation(Required=false)]
                public int? ResolvedType { get; set; }
            };

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

    }

}
