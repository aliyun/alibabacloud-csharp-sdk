// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenListResponseBody : TeaModel {
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
        /// <para>An array that consists of the details about the VPC firewall.</para>
        /// </summary>
        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallCenListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallCenListResponseBodyVpcFirewalls : TeaModel {
            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-x5jayxou71ad73****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The name of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test CEN instance</para>
            /// </summary>
            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            /// <summary>
            /// <para>The connection type of the VPC firewall. The value is fixed as cen, which indicates a CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen</para>
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
            /// <para>The information about the intrusion prevention system (IPS) configuration.</para>
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig : TeaModel {
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
            /// <para>The details about the VPC.</para>
            /// </summary>
            [NameInMap("LocalVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                /// <summary>
                /// <para>Indicates whether the VPC is granted the required permissions. The value is fixed as <b>authorized</b>, which indicates that the VPC is granted the required permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>authorized</para>
                /// </summary>
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }

                /// <summary>
                /// <para>An array consisting of the CIDR blocks that are protected by the VPC firewall.</para>
                /// </summary>
                [NameInMap("DefendCidrList")]
                [Validation(Required=false)]
                public List<string> DefendCidrList { get; set; }

                /// <summary>
                /// <para>The ID of the specified vSwitch when the routing mode is manual.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-zeq4o875u****</para>
                /// </summary>
                [NameInMap("ManualVSwitchId")]
                [Validation(Required=false)]
                public string ManualVSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zefk9fbn8j7v585g****</para>
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test VPC</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <para>The type of the network instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b></description></item>
                /// <item><description><b>VBR</b></description></item>
                /// <item><description><b>CCN</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkInstanceType")]
                [Validation(Required=false)]
                public string NetworkInstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>158039427902****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The region ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The routing mode of the VPC firewall. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>auto</b>: automatic mode</description></item>
                /// <item><description><b>manual</b>: manual mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("RouteMode")]
                [Validation(Required=false)]
                public string RouteMode { get; set; }

                /// <summary>
                /// <para>Indicates whether the manual routing mode is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SupportManualMode")]
                [Validation(Required=false)]
                public string SupportManualMode { get; set; }

                /// <summary>
                /// <para>The edition of the CEN transit router. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: Basic Edition transit router</description></item>
                /// <item><description><b>Enterprise</b>: Enterprise Edition transit router</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Basic</para>
                /// </summary>
                [NameInMap("TransitRouterType")]
                [Validation(Required=false)]
                public string TransitRouterType { get; set; }

                /// <summary>
                /// <para>An array that consists of the CIDR blocks of the VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>An array that consists of the route entries for the VPC.</para>
                    /// </summary>
                    [NameInMap("RouteEntryList")]
                    [Validation(Required=false)]
                    public List<DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                    public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
                        /// <summary>
                        /// <para>The destination CIDR block of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.XX.XX/24</para>
                        /// </summary>
                        [NameInMap("DestinationCidr")]
                        [Validation(Required=false)]
                        public string DestinationCidr { get; set; }

                        /// <summary>
                        /// <para>The instance ID of the next hop for the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vrt-m5eb5me6c3l5sezae****</para>
                        /// </summary>
                        [NameInMap("NextHopInstanceId")]
                        [Validation(Required=false)]
                        public string NextHopInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The route table ID of the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vtb-1234</para>
                    /// </summary>
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbwbo90rq0anm6t****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test instance</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The UID of the member that is manged by your Alibaba Cloud account. The member is also an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>Indicates whether the VPC firewall can be automatically enabled to protect VPC traffic based on route learning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>passed</b>: The VPC firewall can be automatically enabled.</description></item>
            /// <item><description><b>failed</b>: The VPC firewall cannot be automatically enabled.</description></item>
            /// <item><description><b>unknown</b>: The VPC firewall is in an unknown state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>failed</para>
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

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
            /// <item><description><b>Unauthorized</b>: Cloud Firewall is not authorized to access the VPC for which the VPC firewall is created, and the VPC firewall cannot be created.</description></item>
            /// <item><description><b>RegionDisable</b>: VPC Firewall is not supported in the region of the VPC for which the VPC firewall is created, and the VPC firewall cannot be created.</description></item>
            /// <item><description><b>OpsDisable</b>: You are not allowed to create the VPC firewall.</description></item>
            /// <item><description><b>VbrNotSupport</b>: The VPC firewall cannot be created for a VBR that is attached to the CEN instance.</description></item>
            /// <item><description>Empty string: You can create a VPC firewall for the network instance.</description></item>
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
