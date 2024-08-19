// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallListResponseBody : TeaModel {
        /// <summary>
        /// The NAT firewalls.
        /// </summary>
        [NameInMap("NatFirewallList")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallListResponseBodyNatFirewallList> NatFirewallList { get; set; }
        public class DescribeNatFirewallListResponseBodyNatFirewallList : TeaModel {
            /// <summary>
            /// The UID of the Alibaba Cloud account.
            /// 
            /// >  The value of this parameter indicates the management account to which the member is added.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The cause of the error.
            /// </summary>
            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            /// <summary>
            /// The UID of the member in Cloud Firewall.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// The ID of the NAT gateway.
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// The name of the NAT gateway.
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// The default route entries of the NAT gateway.
            /// </summary>
            [NameInMap("NatRouteEntryList")]
            [Validation(Required=false)]
            public List<DescribeNatFirewallListResponseBodyNatFirewallListNatRouteEntryList> NatRouteEntryList { get; set; }
            public class DescribeNatFirewallListResponseBodyNatFirewallListNatRouteEntryList : TeaModel {
                /// <summary>
                /// The destination CIDR block of the default route.
                /// </summary>
                [NameInMap("DestinationCidr")]
                [Validation(Required=false)]
                public string DestinationCidr { get; set; }

                /// <summary>
                /// The next hop of the original NAT gateway.
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// The network type of the next hop. The value is fixed as NatGateway.
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// The route table to which the default route of the NAT gateway belongs.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

            }

            /// <summary>
            /// The ID of the NAT firewall.
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public string ProxyId { get; set; }

            /// <summary>
            /// The name of the NAT firewall.
            /// </summary>
            [NameInMap("ProxyName")]
            [Validation(Required=false)]
            public string ProxyName { get; set; }

            /// <summary>
            /// The status of the NAT firewall. Valid values:
            /// 
            /// *   configuring
            /// *   deleting
            /// *   normal
            /// *   abnormal
            /// *   opening
            /// *   closing
            /// *   closed
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// The region ID of your Cloud Firewall.
            /// 
            /// >  For more information about the supported regions of Cloud Firewall, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether the strict mode is enabled. Valid values: 1, which specifies yes, and 0, which specifies no.
            /// </summary>
            [NameInMap("StrictMode")]
            [Validation(Required=false)]
            public int? StrictMode { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The name of the VPC.
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of NAT firewalls.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
