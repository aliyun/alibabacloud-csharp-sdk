// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The connectivity type of the virtual private cloud (VPC) firewall. Valid values: <b>cen</b>, which indicates Cloud Enterprise Network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen</para>
        /// </summary>
        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        /// <summary>
        /// <para>The switch status of the virtual private cloud (VPC) firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>opened</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: Shutdown.</para>
        /// </description></item>
        /// <item><description><para><b>notconfigured</b>: Not configured.</para>
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
        /// <para>The VPC used by the firewall.</para>
        /// </summary>
        [NameInMap("FirewallVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallCenDetailResponseBodyFirewallVpc FirewallVpc { get; set; }
        public class DescribeVpcFirewallCenDetailResponseBodyFirewallVpc : TeaModel {
            /// <summary>
            /// <para>Indicates whether the firewall VPC CIDR block is allowed to be configured when you create a VPC firewall for CEN Basic Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Allowed.</description></item>
            /// <item><description><b>0</b>: Not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AllowConfiguration")]
            [Validation(Required=false)]
            public int? AllowConfiguration { get; set; }

            /// <summary>
            /// <para>The deployment mode of the VPC firewall service. Valid values: <b>PrimaryStandby</b> (active/standby mode) and <b>MultiPrimary</b> (active-active mode).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrimaryStandby</para>
            /// </summary>
            [NameInMap("FirewallServiceMode")]
            [Validation(Required=false)]
            public string FirewallServiceMode { get; set; }

            /// <summary>
            /// <para>The zone IDs used by the VPC firewall service.</para>
            /// </summary>
            [NameInMap("FirewallServiceZones")]
            [Validation(Required=false)]
            public List<string> FirewallServiceZones { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The secondary zone ID of the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("StandbyZoneId")]
            [Validation(Required=false)]
            [Obsolete]
            public string StandbyZoneId { get; set; }

            /// <summary>
            /// <para>The CIDR block of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("VpcCidr")]
            [Validation(Required=false)]
            public string VpcCidr { get; set; }

            /// <summary>
            /// <para>The VPC instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1245k5oagy2bp74****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The CIDR block of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.1/24</para>
            /// </summary>
            [NameInMap("VswitchCidr")]
            [Validation(Required=false)]
            public string VswitchCidr { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1sqg9wms9wxcs1****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The zone ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("VswitchZoneId")]
            [Validation(Required=false)]
            public string VswitchZoneId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The primary zone ID of the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            [Obsolete]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The VPC details.</para>
        /// </summary>
        [NameInMap("LocalVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallCenDetailResponseBodyLocalVpc LocalVpc { get; set; }
        public class DescribeVpcFirewallCenDetailResponseBodyLocalVpc : TeaModel {
            /// <summary>
            /// <para>The connection ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-sxig7bye51fid5****</para>
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>The connection name of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local-test</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>The CIDR blocks protected by the virtual private cloud (VPC) firewall.</para>
            /// </summary>
            [NameInMap("DefendCidrList")]
            [Validation(Required=false)]
            public List<string> DefendCidrList { get; set; }

            /// <summary>
            /// <para>The network interface controller (NIC) list.</para>
            /// </summary>
            [NameInMap("EniList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList> EniList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList : TeaModel {
                /// <summary>
                /// <para>The instance ID of the elastic network interface (ENI) that serves as the network interface controller (NIC) in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-8vbhfosfqv2rff42****</para>
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// <para>The private IP of the elastic network interface (ENI) that serves as the network interface controller (NIC) in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("EniPrivateIpAddress")]
                [Validation(Required=false)]
                public string EniPrivateIpAddress { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the elastic network interface (ENI) that serves as the network interface controller (NIC) in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-wz9viido7j436b0n1****</para>
                /// </summary>
                [NameInMap("EniVSwitchId")]
                [Validation(Required=false)]
                public string EniVSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID where the elastic network interface (ENI) that serves as the network interface controller (NIC) is active.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("EniZoneId")]
                [Validation(Required=false)]
                public string EniZoneId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the vSwitch specified when the routing mode is manual.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-zeq4o875u****</para>
            /// </summary>
            [NameInMap("ManualVSwitchId")]
            [Validation(Required=false)]
            public string ManualVSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC instance ID used to create a VPC firewall.</para>
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
            /// <para>test-vpc</para>
            /// </summary>
            [NameInMap("NetworkInstanceName")]
            [Validation(Required=false)]
            public string NetworkInstanceName { get; set; }

            /// <summary>
            /// <para>The type of the network instance. Valid values: <b>VPC</b>.</para>
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
            public string OwnerId { get; set; }

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
            /// <item><description><para>auto: automatic mode.</para>
            /// </description></item>
            /// <item><description><para>manual: manual mode.</para>
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
            /// <para>Indicates whether the routing mode supports manual mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Supported.</description></item>
            /// <item><description><b>0</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SupportManualMode")]
            [Validation(Required=false)]
            public string SupportManualMode { get; set; }

            /// <summary>
            /// <para>The instance ID of the CEN-TR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-2zetwxskej633l3u1****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The version of the CEN transit router (CEN-TR). Valid values:</para>
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
            /// <para>The CIDR block list of the VPC.</para>
            /// </summary>
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList : TeaModel {
                /// <summary>
                /// <para>The route entry list of the VPC.</para>
                /// </summary>
                [NameInMap("RouteEntryList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
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
                    /// <para>The next hop instance ID in the VPC.</para>
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
            /// <para>vpc-firewall-test</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090125g4d2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The instance ID of the virtual private cloud (VPC) firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-m5e7dbc4y****</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        /// <summary>
        /// <para>The instance name of the virtual private cloud (VPC) firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-firewall-test</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
