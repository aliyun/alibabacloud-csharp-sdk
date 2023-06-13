// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenDetailResponseBody : TeaModel {
        /// <summary>
        /// The connection type of the VPC firewall. The value is fixed as **cen**, which indicates CEN instances.
        /// </summary>
        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        /// <summary>
        /// The status of the VPC firewall. Valid values:
        /// 
        /// *   **opened**: enabled
        /// *   **closed**: disabled
        /// *   **notconfigured**: not configured
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        [NameInMap("FirewallVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallCenDetailResponseBodyFirewallVpc FirewallVpc { get; set; }
        public class DescribeVpcFirewallCenDetailResponseBodyFirewallVpc : TeaModel {
            [NameInMap("AllowConfiguration")]
            [Validation(Required=false)]
            public int? AllowConfiguration { get; set; }

            [NameInMap("VpcCidr")]
            [Validation(Required=false)]
            public string VpcCidr { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchCidr")]
            [Validation(Required=false)]
            public string VswitchCidr { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The details about the VPC.
        /// </summary>
        [NameInMap("LocalVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallCenDetailResponseBodyLocalVpc LocalVpc { get; set; }
        public class DescribeVpcFirewallCenDetailResponseBodyLocalVpc : TeaModel {
            /// <summary>
            /// The ID of the connection between two network instances.
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// The name of the connection between two network instances.
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// An array consisting of the CIDR blocks that are protected by the VPC firewall.
            /// </summary>
            [NameInMap("DefendCidrList")]
            [Validation(Required=false)]
            public List<string> DefendCidrList { get; set; }

            /// <summary>
            /// An array that consists of the elastic network interfaces (ENIs).
            /// </summary>
            [NameInMap("EniList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList> EniList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList : TeaModel {
                /// <summary>
                /// The ID of the ENI that belongs to the VPC.
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// The private IP address of the ENI that belongs to the VPC.
                /// </summary>
                [NameInMap("EniPrivateIpAddress")]
                [Validation(Required=false)]
                public string EniPrivateIpAddress { get; set; }

                [NameInMap("EniVSwitchId")]
                [Validation(Required=false)]
                public string EniVSwitchId { get; set; }

            }

            /// <summary>
            /// The ID of the specified vSwitch when the routing mode is manual.
            /// </summary>
            [NameInMap("ManualVSwitchId")]
            [Validation(Required=false)]
            public string ManualVSwitchId { get; set; }

            /// <summary>
            /// The ID of the VPC for which the VPC firewall is created.
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
            /// The type of the network instance. The value is fixed as **VPC**.
            /// </summary>
            [NameInMap("NetworkInstanceType")]
            [Validation(Required=false)]
            public string NetworkInstanceType { get; set; }

            /// <summary>
            /// The UID of the Alibaba Cloud account to which the VPC belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The ID of the region in which the VPC resides.
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// The routing mode. Valid values:
            /// 
            /// *   auto: automatic mode
            /// *   manual: manual mode
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
            /// The instance ID of the CEN transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// The edition of the CEN transit router. Valid values:
            /// 
            /// *   **Basic**: Basic Edition
            /// *   **Enterprise**: Enterprise Edition
            /// </summary>
            [NameInMap("TransitRouterType")]
            [Validation(Required=false)]
            public string TransitRouterType { get; set; }

            /// <summary>
            /// An array that consists of the CIDR blocks of the VPC.
            /// </summary>
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList : TeaModel {
                /// <summary>
                /// An array that consists of the route entries for the VPC.
                /// </summary>
                [NameInMap("RouteEntryList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
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
