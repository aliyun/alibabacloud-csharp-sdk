// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenListResponseBody : TeaModel {
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
        /// An array that consists of the details about the VPC firewall.
        /// </summary>
        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallCenListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallCenListResponseBodyVpcFirewalls : TeaModel {
            /// <summary>
            /// The ID of the CEN instance.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The name of the CEN instance.
            /// </summary>
            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            /// <summary>
            /// The connection type of the VPC firewall. The value is fixed as cen, which indicates a CEN instance.
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
            /// The information about the intrusion prevention system (IPS) configuration.
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig : TeaModel {
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
            /// The details about the VPC.
            /// </summary>
            [NameInMap("LocalVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                /// <summary>
                /// Indicates whether the VPC is granted the required permissions. The value is fixed as **authorized**, which indicates that the VPC is granted the required permissions.
                /// </summary>
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }

                /// <summary>
                /// An array consisting of the CIDR blocks that are protected by the VPC firewall.
                /// </summary>
                [NameInMap("DefendCidrList")]
                [Validation(Required=false)]
                public List<string> DefendCidrList { get; set; }

                /// <summary>
                /// The ID of the specified vSwitch when the routing mode is manual.
                /// </summary>
                [NameInMap("ManualVSwitchId")]
                [Validation(Required=false)]
                public string ManualVSwitchId { get; set; }

                /// <summary>
                /// The ID of the network instance.
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// The name of the network instance.
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// The type of the network instance. Valid values:
                /// 
                /// *   **VPC**
                /// *   **VBR**
                /// *   **CCN**
                /// </summary>
                [NameInMap("NetworkInstanceType")]
                [Validation(Required=false)]
                public string NetworkInstanceType { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the VPC belongs.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The region ID of the VPC.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// The routing mode of the VPC firewall. Valid values:
                /// 
                /// *   **auto**: automatic mode
                /// *   **manual**: manual mode
                /// </summary>
                [NameInMap("RouteMode")]
                [Validation(Required=false)]
                public string RouteMode { get; set; }

                /// <summary>
                /// Indicates whether the manual routing mode is supported. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("SupportManualMode")]
                [Validation(Required=false)]
                public string SupportManualMode { get; set; }

                /// <summary>
                /// The edition of the CEN transit router. Valid values:
                /// 
                /// *   **Basic**: Basic Edition transit router
                /// *   **Enterprise**: Enterprise Edition transit router
                /// </summary>
                [NameInMap("TransitRouterType")]
                [Validation(Required=false)]
                public string TransitRouterType { get; set; }

                /// <summary>
                /// An array that consists of the CIDR blocks of the VPC.
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// An array that consists of the route entries for the VPC.
                    /// </summary>
                    [NameInMap("RouteEntryList")]
                    [Validation(Required=false)]
                    public List<DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
                        /// <summary>
                        /// The destination CIDR block of the VPC.
                        /// </summary>
                        [NameInMap("DestinationCidr")]
                        [Validation(Required=false)]
                        public string DestinationCidr { get; set; }

                        /// <summary>
                        /// The instance ID of the next hop for the VPC.
                        /// </summary>
                        [NameInMap("NextHopInstanceId")]
                        [Validation(Required=false)]
                        public string NextHopInstanceId { get; set; }

                    }

                    /// <summary>
                    /// The route table ID of the VPC.
                    /// </summary>
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                }

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
            /// The UID of the member that is manged by your Alibaba Cloud account. The member is also an Alibaba Cloud account.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// Indicates whether the VPC firewall can be automatically enabled to protect VPC traffic based on route learning. Valid values:
            /// 
            /// *   **passed**: The VPC firewall can be automatically enabled.
            /// *   **failed**: The VPC firewall cannot be automatically enabled.
            /// *   **unknown**: The VPC firewall is in an unknown state.
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

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
            /// *   **Unauthorized**: Cloud Firewall is not authorized to access the VPC for which the VPC firewall is created, and the VPC firewall cannot be created.
            /// *   **RegionDisable**: VPC Firewall is not supported in the region of the VPC for which the VPC firewall is created, and the VPC firewall cannot be created.
            /// *   **OpsDisable**: You are not allowed to create the VPC firewall.
            /// *   **VbrNotSupport**: The VPC firewall cannot be created for a VBR that is attached to the CEN instance.
            /// *   Empty string: You can create a VPC firewall for the network instance.
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
