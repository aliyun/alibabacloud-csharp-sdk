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
        /// <para>The details of the VPC firewalls.</para>
        /// </summary>
        [NameInMap("VpcFirewalls")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallCenListResponseBodyVpcFirewalls> VpcFirewalls { get; set; }
        public class DescribeVpcFirewallCenListResponseBodyVpcFirewalls : TeaModel {
            /// <summary>
            /// <para>The access control list (ACL) engine mode.</para>
            /// </summary>
            [NameInMap("AclConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsAclConfig AclConfig { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsAclConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether the strict mode is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: enabled</para>
                /// </description></item>
                /// <item><description><para>0: disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StrictMode")]
                [Validation(Required=false)]
                public int? StrictMode { get; set; }

            }

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
            /// <para>cen-test</para>
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
            /// <item><description><para><b>opened</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>closed</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>notconfigured</b>: not configured.</para>
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
            /// <para>The intrusion prevention system (IPS) configuration.</para>
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether basic protection is enabled. Valid values:</para>
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
                /// <para>Indicates whether virtual patching is enabled. Valid values:</para>
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
                /// <para>The type of the IPS rule group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: loose.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: medium.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: strict.</para>
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
                /// <para>The mode of the IPS. Valid values:</para>
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
            /// <para>The details of the VPC.</para>
            /// </summary>
            [NameInMap("LocalVpc")]
            [Validation(Required=false)]
            public DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc LocalVpc { get; set; }
            public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpc : TeaModel {
                /// <summary>
                /// <para>The authorization status of the VPC. The value is fixed as <b>authorized</b>. This value indicates that the VPC is authorized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>authorized</para>
                /// </summary>
                [NameInMap("AuthorizationStatus")]
                [Validation(Required=false)]
                public string AuthorizationStatus { get; set; }

                /// <summary>
                /// <para>The CIDR blocks that are protected by the VPC firewall.</para>
                /// </summary>
                [NameInMap("DefendCidrList")]
                [Validation(Required=false)]
                public List<string> DefendCidrList { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch that is specified for the manual routing mode.</para>
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
                /// <para>network-instance-test</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <para>The type of the network instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>VPC</b>: Virtual Private Cloud.</para>
                /// </description></item>
                /// <item><description><para><b>VBR</b>: Virtual Border Router.</para>
                /// </description></item>
                /// <item><description><para><b>CCN</b>: Cloud Connect Network.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkInstanceType")]
                [Validation(Required=false)]
                public string NetworkInstanceType { get; set; }

                /// <summary>
                /// <para>The UID of the Alibaba Cloud account to which the VPC belongs.</para>
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
                /// <para>The routing mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>auto</b>: automatic.</para>
                /// </description></item>
                /// <item><description><para><b>manual</b>: manual.</para>
                /// </description></item>
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
                /// <item><description><para><b>1</b>: yes.</para>
                /// </description></item>
                /// <item><description><para><b>0</b>: no.</para>
                /// </description></item>
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
                /// <item><description><para><b>Basic</b>: Basic Edition.</para>
                /// </description></item>
                /// <item><description><para><b>Enterprise</b>: Enterprise Edition.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Basic</para>
                /// </summary>
                [NameInMap("TransitRouterType")]
                [Validation(Required=false)]
                public string TransitRouterType { get; set; }

                /// <summary>
                /// <para>The CIDR blocks of the VPC.</para>
                /// </summary>
                [NameInMap("VpcCidrTableList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
                public class DescribeVpcFirewallCenListResponseBodyVpcFirewallsLocalVpcVpcCidrTableList : TeaModel {
                    /// <summary>
                    /// <para>The routes of the VPC.</para>
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
                        /// <para>The ID of the next hop instance in the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vrt-m5eb5me6c3l5sezae****</para>
                        /// </summary>
                        [NameInMap("NextHopInstanceId")]
                        [Validation(Required=false)]
                        public string NextHopInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the route table for the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vtb-1234</para>
                    /// </summary>
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public string RouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The instance ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbwbo90rq0anm6t****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The instance name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-instance</para>
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
            /// <para>Indicates whether the firewall can be automatically created. Cloud Firewall automatically creates a firewall and protects VPC traffic based on route learning. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>passed</b>: The firewall can be automatically created.</para>
            /// </description></item>
            /// <item><description><para><b>failed</b>: The firewall cannot be automatically created.</para>
            /// </description></item>
            /// <item><description><para><b>unknown</b>: The status is unknown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>failed</para>
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            /// <summary>
            /// <para>The status of the region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: VPC firewalls can be configured in the region.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: VPC firewalls cannot be configured in the region.</para>
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
            /// <para>The result code of the operation to create the VPC firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Unauthorized</b>: The VPC firewall cannot be created because a network instance is not authorized.</para>
            /// </description></item>
            /// <item><description><para><b>RegionDisable</b>: The VPC firewall cannot be created because the region of the network instance is not supported.</para>
            /// </description></item>
            /// <item><description><para><b>OpsDisable</b>: The VPC firewall cannot be created.</para>
            /// </description></item>
            /// <item><description><para><b>VbrNotSupport</b>: The VPC firewall cannot be created because the VBR in the CEN instance is not supported.</para>
            /// </description></item>
            /// <item><description><para>An empty string indicates that the VPC firewall can be created for the network instance.</para>
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
            /// <para>vpc-firewall-test</para>
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
