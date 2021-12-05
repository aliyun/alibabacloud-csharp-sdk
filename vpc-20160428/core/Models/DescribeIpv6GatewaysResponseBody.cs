// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6GatewaysResponseBody : TeaModel {
        [NameInMap("Ipv6Gateways")]
        [Validation(Required=false)]
        public DescribeIpv6GatewaysResponseBodyIpv6Gateways Ipv6Gateways { get; set; }
        public class DescribeIpv6GatewaysResponseBodyIpv6Gateways : TeaModel {
            [NameInMap("Ipv6Gateway")]
            [Validation(Required=false)]
            public List<DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6Gateway> Ipv6Gateway { get; set; }
            public class DescribeIpv6GatewaysResponseBodyIpv6GatewaysIpv6Gateway : TeaModel {
                public string BusinessStatus { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string ExpiredTime { get; set; }
                public string InstanceChargeType { get; set; }
                public string Ipv6GatewayId { get; set; }
                public string Name { get; set; }
                public string RegionId { get; set; }
                public string Spec { get; set; }
                public string Status { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
