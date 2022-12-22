// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDetailResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth of the Express Connect circuit. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The connection type of the VPC firewall. The value is fixed as **expressconnect**, which indicates Express Connect circuits.
        /// </summary>
        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        /// <summary>
        /// The status of the VPC firewall. Valid values:
        /// 
        /// *   **opened**: The VPC firewall is enabled.
        /// *   **closed**: The VPC firewall is disabled.
        /// *   **notconfigured**: The VPC firewall is not configured.
        /// *   **configured**: The VPC firewall is configured.
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// The details about the local VPC.
        /// </summary>
        [NameInMap("LocalVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallDetailResponseBodyLocalVpc LocalVpc { get; set; }
        public class DescribeVpcFirewallDetailResponseBodyLocalVpc : TeaModel {
            /// <summary>
            /// The ID of the ENI for the local VPC.
            /// </summary>
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            /// <summary>
            /// The private IP address of the elastic network interface (ENI) for the local VPC.
            /// </summary>
            [NameInMap("EniPrivateIpAddress")]
            [Validation(Required=false)]
            public string EniPrivateIpAddress { get; set; }

            /// <summary>
            /// The region ID of the local VPC.
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// The router interface ID of the local VPC.
            /// </summary>
            [NameInMap("RouterInterfaceId")]
            [Validation(Required=false)]
            public string RouterInterfaceId { get; set; }

            /// <summary>
            /// The CIDR blocks of the local VPC.
            /// </summary>
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableList : TeaModel {
                /// <summary>
                /// The route entries of the local VPC.
                /// </summary>
                [NameInMap("RouteEntryList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
                    /// <summary>
                    /// The destination CIDR block of the local VPC.
                    /// </summary>
                    [NameInMap("DestinationCidr")]
                    [Validation(Required=false)]
                    public string DestinationCidr { get; set; }

                    /// <summary>
                    /// The instance ID of the next hop for the local VPC.
                    /// </summary>
                    [NameInMap("NextHopInstanceId")]
                    [Validation(Required=false)]
                    public string NextHopInstanceId { get; set; }

                }

                /// <summary>
                /// The ID of the route table for the local VPC.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

            }

            /// <summary>
            /// The ID of the local VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The name of the local VPC.
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// The UID of the member that is managed by your Alibaba Cloud account.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The details about the peer VPC.
        /// </summary>
        [NameInMap("PeerVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallDetailResponseBodyPeerVpc PeerVpc { get; set; }
        public class DescribeVpcFirewallDetailResponseBodyPeerVpc : TeaModel {
            /// <summary>
            /// The ID of the ENI for the peer VPC.
            /// </summary>
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            /// <summary>
            /// The private IP address of the ENI for the peer VPC.
            /// </summary>
            [NameInMap("EniPrivateIpAddress")]
            [Validation(Required=false)]
            public string EniPrivateIpAddress { get; set; }

            /// <summary>
            /// The region ID of the peer VPC.
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// The router interface ID of the peer VPC.
            /// </summary>
            [NameInMap("RouterInterfaceId")]
            [Validation(Required=false)]
            public string RouterInterfaceId { get; set; }

            /// <summary>
            /// The CIDR blocks of the peer VPC.
            /// </summary>
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableList : TeaModel {
                /// <summary>
                /// The route entries of the peer VPC.
                /// </summary>
                [NameInMap("RouteEntryList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableListRouteEntryList : TeaModel {
                    /// <summary>
                    /// The destination CIDR block of the peer VPC.
                    /// </summary>
                    [NameInMap("DestinationCidr")]
                    [Validation(Required=false)]
                    public string DestinationCidr { get; set; }

                    /// <summary>
                    /// The instance ID of the next hop for the peer VPC.
                    /// </summary>
                    [NameInMap("NextHopInstanceId")]
                    [Validation(Required=false)]
                    public string NextHopInstanceId { get; set; }

                }

                /// <summary>
                /// The ID of the route table for the peer VPC.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

            }

            /// <summary>
            /// The ID of the peer VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The name of the peer VPC.
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        /// <summary>
        /// The instance name of the VPC firewall.
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
