// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeDomainAdvanceConfigsResponseBody : TeaModel {
        [NameInMap("DomainConfigs")]
        [Validation(Required=false)]
        public List<DescribeDomainAdvanceConfigsResponseBodyDomainConfigs> DomainConfigs { get; set; }
        public class DescribeDomainAdvanceConfigsResponseBodyDomainConfigs : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Profile")]
            [Validation(Required=false)]
            public DescribeDomainAdvanceConfigsResponseBodyDomainConfigsProfile Profile { get; set; }
            public class DescribeDomainAdvanceConfigsResponseBodyDomainConfigsProfile : TeaModel {
                [NameInMap("CertStatus")]
                [Validation(Required=false)]
                public int? CertStatus { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public int? ClusterType { get; set; }

                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("ExclusiveVipStatus")]
                [Validation(Required=false)]
                public int? ExclusiveVipStatus { get; set; }

                [NameInMap("GSLBStatus")]
                [Validation(Required=false)]
                public string GSLBStatus { get; set; }

                [NameInMap("Http2Port")]
                [Validation(Required=false)]
                public List<int?> Http2Port { get; set; }

                [NameInMap("HttpPort")]
                [Validation(Required=false)]
                public List<int?> HttpPort { get; set; }

                [NameInMap("HttpsPort")]
                [Validation(Required=false)]
                public List<int?> HttpsPort { get; set; }

                [NameInMap("Ipv6Status")]
                [Validation(Required=false)]
                public int? Ipv6Status { get; set; }

                [NameInMap("ResolvedType")]
                [Validation(Required=false)]
                public int? ResolvedType { get; set; }

                [NameInMap("Rs")]
                [Validation(Required=false)]
                public List<string> Rs { get; set; }

                [NameInMap("VipServiceStatus")]
                [Validation(Required=false)]
                public int? VipServiceStatus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
