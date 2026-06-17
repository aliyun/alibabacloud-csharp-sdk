// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090125k8g2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of VPC firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The details of the VPC firewalls.</para>
        /// </summary>
        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallListResponseBodyVpcFirewalls : TeaModel {
            /// <summary>
            /// <para>The mode of the access control list (ACL) engine.</para>
            /// </summary>
            [NameInMap("AclConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsAclConfig AclConfig { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsAclConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether to enable strict mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: enabled</para>
                /// </description></item>
                /// <item><description><para>0: disabled</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StrictMode")]
                [Validation(Required=false)]
                public int? StrictMode { get; set; }

            }

            /// <summary>
            /// <para>The bandwidth of the Express Connect circuit. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The subtype of the connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>vpc2vpc</b>: Express Connect.</para>
            /// </description></item>
            /// <item><description><para><b>vpcpeer</b>: peering connection.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpcpeer</para>
            /// </summary>
            [NameInMap("ConnectSubType")]
            [Validation(Required=false)]
            public string ConnectSubType { get; set; }

            /// <summary>
            /// <para>The type of connection for the VPC firewall. The value is fixed as <b>expressconnect</b>, which indicates an Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>expressconnect</para>
            /// </summary>
            [NameInMap("ConnectType")]
            [Validation(Required=false)]
            public string ConnectType { get; set; }

            /// <summary>
            /// <para>The status of the VPC firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>opened</b>: The firewall is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>closed</b>: The firewall is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>notconfigured</b>: The firewall is not configured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opened</para>
            /// </summary>
            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            /// <summary>
            /// <para>The configuration of the intrusion prevention system (IPS).</para>
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// <para>The status of the basic policies. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: enabled.</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                /// <summary>
                /// <para>The status of virtual patching. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: enabled.</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                /// <summary>
                /// <para>The IPS rule group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Loose.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Medium.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Strict.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleClass")]
                [Validation(Required=false)]
                public int? RuleClass { get; set; }

                /// <summary>
                /// <para>The IPS mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Block Mode.</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: Monitor mode.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RunMode")]
                [Validation(Required=false)]
                public int? RunMode { get; set; }

            }

            /// <summary>
            /// <para>The details of the local VPC.</para>
            /// </summary>
            [NameInMap("LocalVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                /// <summary>
                /// <para>The authorization status of the local VPC. The value is fixed as authorized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>authorized</para>
                /// </summary>
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }

                /// <summary>
                /// <para>The UID of the Alibaba Cloud account to which the local VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>158039427902****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The region ID of the local VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The CIDR blocks of the local VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>The route entries of the local VPC.</para>
                    /// </summary>
                    [NameInMap("RouteEntryList")]
                    [Validation(Required=false)]
                    public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
                        /// <summary>
                        /// <para>The destination CIDR block of the local VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.XX.XX/24</para>
                        /// </summary>
                        [NameInMap("DestinationCidr")]
                        [Validation(Required=false)]
                        public string DestinationCidr { get; set; }

                        /// <summary>
                        /// <para>The ID of the next hop instance for the local VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vrt-m5eb5me6c3l5sezae****</para>
                        /// </summary>
                        [NameInMap("NextHopInstanceId")]
                        [Validation(Required=false)]
                        public string NextHopInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the route table for the local VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vtb-1234</para>
                    /// </summary>
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The instance ID of the local VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbwbo90rq0anm6t****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The instance name of the local VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-vpc1</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The details of the peer VPC.</para>
            /// </summary>
            [NameInMap("PeerVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc PeerVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc : TeaModel {
                /// <summary>
                /// <para>The authorization status of the peer VPC. The value is fixed as <b>authorized</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>authorized</para>
                /// </summary>
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }

                /// <summary>
                /// <para>The UID of the Alibaba Cloud account to which the peer VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>158039427902****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The region ID of the peer VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The CIDR blocks of the peer VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>The route entries of the peer VPC.</para>
                    /// </summary>
                    [NameInMap("RouteEntryList")]
                    [Validation(Required=false)]
                    public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableListRouteEntryList : TeaModel {
                        /// <summary>
                        /// <para>The destination CIDR block of the peer VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.XX.XX/24</para>
                        /// </summary>
                        [NameInMap("DestinationCidr")]
                        [Validation(Required=false)]
                        public string DestinationCidr { get; set; }

                        /// <summary>
                        /// <para>The ID of the next hop instance for the peer VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vrt-m5eb5me6c3l5sezae****</para>
                        /// </summary>
                        [NameInMap("NextHopInstanceId")]
                        [Validation(Required=false)]
                        public string NextHopInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the route table for the peer VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vtb-1256</para>
                    /// </summary>
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The instance ID of the peer VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbwbo90rq0anm6t****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The instance name of the peer VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-vpc2</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The status of the region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: The region is available. You can create a VPC firewall in this region.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: The region is unavailable. You cannot create a VPC firewall in this region.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The result code of the VPC firewall creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Unauthorized</b>: An unauthorized VPC exists. You cannot create a VPC firewall.</para>
            /// </description></item>
            /// <item><description><para><b>RegionDisable</b>: The VPC is in a region where VPC firewalls are not supported. You cannot create a VPC firewall.</para>
            /// </description></item>
            /// <item><description><para><b>An empty string</b>: You can create a VPC firewall for the network instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unauthorized</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vfw-m5e7dbc4y****</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// <para>The instance name of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-firewall</para>
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
