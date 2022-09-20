// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6AddressesResponseBody : TeaModel {
        [NameInMap("Ipv6Addresses")]
        [Validation(Required=false)]
        public DescribeIpv6AddressesResponseBodyIpv6Addresses Ipv6Addresses { get; set; }
        public class DescribeIpv6AddressesResponseBodyIpv6Addresses : TeaModel {
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address> Ipv6Address { get; set; }
            public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address : TeaModel {
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                [NameInMap("AssociatedInstanceId")]
                [Validation(Required=false)]
                public string AssociatedInstanceId { get; set; }

                [NameInMap("AssociatedInstanceType")]
                [Validation(Required=false)]
                public string AssociatedInstanceType { get; set; }

                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                [NameInMap("Ipv6AddressId")]
                [Validation(Required=false)]
                public string Ipv6AddressId { get; set; }

                [NameInMap("Ipv6AddressName")]
                [Validation(Required=false)]
                public string Ipv6AddressName { get; set; }

                [NameInMap("Ipv6GatewayId")]
                [Validation(Required=false)]
                public string Ipv6GatewayId { get; set; }

                [NameInMap("Ipv6InternetBandwidth")]
                [Validation(Required=false)]
                public DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth Ipv6InternetBandwidth { get; set; }
                public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth : TeaModel {
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    [NameInMap("BusinessStatus")]
                    [Validation(Required=false)]
                    public string BusinessStatus { get; set; }

                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    [NameInMap("Ipv6InternetBandwidthId")]
                    [Validation(Required=false)]
                    public string Ipv6InternetBandwidthId { get; set; }

                }

                [NameInMap("Ipv6Isp")]
                [Validation(Required=false)]
                public string Ipv6Isp { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("RealBandwidth")]
                [Validation(Required=false)]
                public int? RealBandwidth { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

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
