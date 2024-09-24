// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of VPC firewalls.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the VPC firewalls.
        /// </summary>
        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallListResponseBodyVpcFirewalls : TeaModel {
            /// <summary>
            /// The bandwidth of the Express Connect circuit. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The sub-type of the connection. Valid values:
            /// 
            /// *   **vpc2vpc**: Express Connect connection
            /// *   **vpcpeer**: peer connection
            /// </summary>
            [NameInMap("ConnectSubType")]
            [Validation(Required=false)]
            public string ConnectSubType { get; set; }

            /// <summary>
            /// The connection type of the VPC firewall. The value is fixed as **expressconnect**, which indicates an Express Connect connection.
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
            /// </summary>
            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            /// <summary>
            /// The intrusion prevention system (IPS) configurations.
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// Indicates whether basic protection is enabled. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                /// <summary>
                /// Indicates whether virtual patching is enabled. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                /// <summary>
                /// The level of the rule group for the IPS. Valid values:
                /// 
                /// *   **1**: loose
                /// *   **2**: medium
                /// *   **3**: strict
                /// </summary>
                [NameInMap("RuleClass")]
                [Validation(Required=false)]
                public int? RuleClass { get; set; }

                /// <summary>
                /// The mode of the IPS. Valid values:
                /// 
                /// *   **1**: block mode
                /// *   **0**: monitor mode
                /// </summary>
                [NameInMap("RunMode")]
                [Validation(Required=false)]
                public int? RunMode { get; set; }

            }

            /// <summary>
            /// The details about the local VPC.
            /// </summary>
            [NameInMap("LocalVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                /// <summary>
                /// Indicates whether Cloud Firewall is authorized to access the local VPC. The value is fixed as authorized, which indicates that Cloud Firewall is authorized to access the local VPC.
                /// </summary>
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }

                /// <summary>
                /// The UID of the Alibaba Cloud account to which the local VPC belongs.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The region ID of the local VPC.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// An array that consists of the CIDR blocks of the local VPC.
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// An array that consists of the route entries of the local VPC.
                    /// </summary>
                    [NameInMap("RouteEntryList")]
                    [Validation(Required=false)]
                    public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
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
            public DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc PeerVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc : TeaModel {
                /// <summary>
                /// Indicates whether Cloud Firewall is authorized to access the peer VPC. The value is fixed as **authorized**, which indicates that Cloud Firewall is authorized to access the peer VPC.
                /// </summary>
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }

                /// <summary>
                /// The UID of the Alibaba Cloud account to which the peer VPC belongs.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The region ID of the peer VPC.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// An array that consists of the CIDR blocks of the peer VPC.
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// An array that consists of the route entries of the peer VPC.
                    /// </summary>
                    [NameInMap("RouteEntryList")]
                    [Validation(Required=false)]
                    public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableListRouteEntryList : TeaModel {
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
            /// Indicates whether you can create a VPC firewall in a specified region. Valid values:
            /// 
            /// *   **enable**: yes
            /// *   **disable**: no
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// The result code of the operation that creates the VPC firewall. Valid values:
            /// 
            /// *   **Unauthorized**: Cloud Firewall is not authorized to access a VPC for which the VPC firewall is created, and the VPC firewall cannot be created.
            /// *   **RegionDisable**: VPC Firewall is not supported in the region of a VPC for which the VPC firewall is created, and the VPC firewall cannot be created.
            /// *   **Empty string**: You can create a VPC firewall for the network instance.
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

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

}
