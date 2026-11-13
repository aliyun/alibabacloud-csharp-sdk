// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090125k8g2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of virtual private cloud (VPC) border firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The details of the virtual private cloud (VPC) border firewalls.</para>
        /// </summary>
        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallListResponseBodyVpcFirewalls : TeaModel {
            /// <summary>
            /// <para>The ACL engine mode.</para>
            /// </summary>
            [NameInMap("AclConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsAclConfig AclConfig { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsAclConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether strict mode is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Enabled. </description></item>
                /// <item><description><b>0</b>: Disabled.</description></item>
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
            /// <para>The bandwidth of the Express Connect circuit. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The connection subtype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>vpc2vpc</b>: Express Connect.</description></item>
            /// <item><description><b>vpcpeer</b>: VPC peering connection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpcpeer</para>
            /// </summary>
            [NameInMap("ConnectSubType")]
            [Validation(Required=false)]
            public string ConnectSubType { get; set; }

            /// <summary>
            /// <para>The interconnection type of the virtual private cloud (VPC) border firewall. Valid values: <b>expressconnect</b>, which indicates Express Connect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>expressconnect</para>
            /// </summary>
            [NameInMap("ConnectType")]
            [Validation(Required=false)]
            public string ConnectType { get; set; }

            /// <summary>
            /// <para>The switch status of the virtual private cloud (VPC) border firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>opened</b>: Enabled.</description></item>
            /// <item><description><b>closed</b>: Disabled.</description></item>
            /// <item><description><b>notconfigured</b>: The virtual private cloud (VPC) border firewall is not configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opened</para>
            /// </summary>
            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            /// <summary>
            /// <para>The IPS configuration.</para>
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// <para>The switch for Basic Policies. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Enabled.</description></item>
                /// <item><description><b>0</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                /// <summary>
                /// <para>The switch for virtual patches. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Enabled.</description></item>
                /// <item><description><b>0</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                /// <summary>
                /// <para>The IPS rules group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: Loose rule group.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Medium rule group.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Strict rule group.</para>
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
                /// <para>The IPS defense mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Block mode.</description></item>
                /// <item><description><b>0</b>: Monitor mode.</description></item>
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
                /// <para>The authorization status of the local VPC. Valid values: <b>authorized</b>, which indicates that the VPC is authorized.</para>
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
                /// <para>The CIDR block list of the local VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>The routing entry list of the local VPC.</para>
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
                        /// <para>The next hop instance ID of the local VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vrt-m5eb5me6c3l5sezae****</para>
                        /// </summary>
                        [NameInMap("NextHopInstanceId")]
                        [Validation(Required=false)]
                        public string NextHopInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the route table of the local VPC.</para>
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
                /// <para>The name of the local VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-vpc1</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The UID of the member accounts.</para>
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
                /// <para>The authorization status of the peer VPC. Valid values: <b>authorized</b>, which indicates that the VPC is authorized.</para>
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
                /// <para>The CIDR block list of the peer VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>The routing entry list of the peer VPC.</para>
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
                        /// <para>The next hop instance ID of the peer VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vrt-m5eb5me6c3l5sezae****</para>
                        /// </summary>
                        [NameInMap("NextHopInstanceId")]
                        [Validation(Required=false)]
                        public string NextHopInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the route table of the peer VPC.</para>
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
                /// <para>The name of the peer VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-vpc2</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The availability status of the region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: Available. The region supports virtual private cloud (VPC) border firewalls.</description></item>
            /// <item><description><b>disable</b>: Unavailable. The region does not support virtual private cloud (VPC) border firewalls.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The operation result code when you create a VPC border firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unauthorized</b>: Indicates that a VPC without authorization exists, and you are not allowed to create a VPC border firewall.</description></item>
            /// <item><description><b>RegionDisable</b>: Indicates that the region where the VPC resides does not support VPC border firewalls, and you are not allowed to create a VPC border firewall.</description></item>
            /// <item><description><b>Empty string</b>: Indicates that you can normally create a VPC border firewall for this network instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unauthorized</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// <para>The instance ID of the virtual private cloud (VPC) border firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vfw-m5e7dbc4y****</para>
            /// </summary>
            [NameInMap("VpcFirewallId")]
            [Validation(Required=false)]
            public string VpcFirewallId { get; set; }

            /// <summary>
            /// <para>The instance name of the virtual private cloud (VPC) border firewall.</para>
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
