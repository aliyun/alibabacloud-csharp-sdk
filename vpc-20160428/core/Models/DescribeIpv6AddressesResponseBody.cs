// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6AddressesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Ipv6Addresses")]
        [Validation(Required=false)]
        public DescribeIpv6AddressesResponseBodyIpv6Addresses Ipv6Addresses { get; set; }
        public class DescribeIpv6AddressesResponseBodyIpv6Addresses : TeaModel {
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address> Ipv6Address { get; set; }
            public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address : TeaModel {
                public string Status { get; set; }
                public string VpcId { get; set; }
                public string Ipv6AddressId { get; set; }
                public string AllocationTime { get; set; }
                public string AssociatedInstanceType { get; set; }
                public string Ipv6AddressName { get; set; }
                public string AssociatedInstanceId { get; set; }
                public string NetworkType { get; set; }
                public string Ipv6Address { get; set; }
                public string VSwitchId { get; set; }
                public DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth Ipv6InternetBandwidth { get; set; }
                public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth : TeaModel {
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    [NameInMap("BusinessStatus")]
                    [Validation(Required=false)]
                    public string BusinessStatus { get; set; }

                    [NameInMap("Ipv6InternetBandwidthId")]
                    [Validation(Required=false)]
                    public string Ipv6InternetBandwidthId { get; set; }

                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                }
                public string Ipv6GatewayId { get; set; }
                public int? RealBandwidth { get; set; }
            }
        };

    }

}
