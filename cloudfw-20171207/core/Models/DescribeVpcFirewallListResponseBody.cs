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
        /// <para>The total number of VPC firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the VPC firewalls.</para>
        /// </summary>
        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallListResponseBodyVpcFirewalls : TeaModel {
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
            /// <para>The sub-type of the connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>vpc2vpc</b>: Express Connect connection</description></item>
            /// <item><description><b>vpcpeer</b>: peer connection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpcpeer</para>
            /// </summary>
            [NameInMap("ConnectSubType")]
            [Validation(Required=false)]
            public string ConnectSubType { get; set; }

            /// <summary>
            /// <para>The connection type of the VPC firewall. The value is fixed as <b>expressconnect</b>, which indicates an Express Connect connection.</para>
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
            /// <item><description><b>opened</b>: The VPC firewall is enabled.</description></item>
            /// <item><description><b>closed</b>: The VPC firewall is disabled.</description></item>
            /// <item><description><b>notconfigured</b>: The VPC firewall is not configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>opened</para>
            /// </summary>
            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            /// <summary>
            /// <para>The intrusion prevention system (IPS) configurations.</para>
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether basic protection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                /// <summary>
                /// <para>Indicates whether virtual patching is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                /// <summary>
                /// <para>The level of the rule group for the IPS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: loose</description></item>
                /// <item><description><b>2</b>: medium</description></item>
                /// <item><description><b>3</b>: strict</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleClass")]
                [Validation(Required=false)]
                public int? RuleClass { get; set; }

                /// <summary>
                /// <para>The mode of the IPS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: block mode</description></item>
                /// <item><description><b>0</b>: monitor mode</description></item>
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
            /// <para>The details about the local VPC.</para>
            /// </summary>
            [NameInMap("LocalVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                /// <summary>
                /// <para>Indicates whether Cloud Firewall is authorized to access the local VPC. The value is fixed as authorized, which indicates that Cloud Firewall is authorized to access the local VPC.</para>
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
                /// <para>An array that consists of the CIDR blocks of the local VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>An array that consists of the route entries of the local VPC.</para>
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
                        /// <para>The instance ID of the next hop for the local VPC.</para>
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
                /// <para>The ID of the local VPC.</para>
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
                /// <para>Test instance</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The UID of the member that is managed by your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The details about the peer VPC.</para>
            /// </summary>
            [NameInMap("PeerVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc PeerVpc { get; set; }
            public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpc : TeaModel {
                /// <summary>
                /// <para>Indicates whether Cloud Firewall is authorized to access the peer VPC. The value is fixed as <b>authorized</b>, which indicates that Cloud Firewall is authorized to access the peer VPC.</para>
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
                /// <para>An array that consists of the CIDR blocks of the peer VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallListResponseBodyVpcFirewallsPeerVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>An array that consists of the route entries of the peer VPC.</para>
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
                        /// <para>The instance ID of the next hop for the peer VPC.</para>
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
                /// <para>The ID of the peer VPC.</para>
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
                /// <para>Test VPC 2</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether you can create a VPC firewall in a specified region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: yes</description></item>
            /// <item><description><b>disable</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The result code of the operation that creates the VPC firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unauthorized</b>: Cloud Firewall is not authorized to access a VPC for which the VPC firewall is created, and the VPC firewall cannot be created.</description></item>
            /// <item><description><b>RegionDisable</b>: VPC Firewall is not supported in the region of a VPC for which the VPC firewall is created, and the VPC firewall cannot be created.</description></item>
            /// <item><description><b>Empty string</b>: You can create a VPC firewall for the network instance.</description></item>
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
            /// <para>Test firewall</para>
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
