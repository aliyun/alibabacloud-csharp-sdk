// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The connection type of the VPC firewall. The value is fixed as <b>cen</b>, which indicates CEN.</para>
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
        /// <para>The VPC that is used by the firewall.</para>
        /// </summary>
        [NameInMap("FirewallVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallCenDetailResponseBodyFirewallVpc FirewallVpc { get; set; }
        public class DescribeVpcFirewallCenDetailResponseBodyFirewallVpc : TeaModel {
            /// <summary>
            /// <para>Indicates whether you can specify a CIDR block for the firewall VPC when you create a VPC firewall for a Basic Edition transit router. Valid values:</para>
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
            [NameInMap("AllowConfiguration")]
            [Validation(Required=false)]
            public int? AllowConfiguration { get; set; }

            /// <summary>
            /// <para>The ID of the secondary zone for the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("StandbyZoneId")]
            [Validation(Required=false)]
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
            /// <para>The CIDR block of the virtual switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.1/24</para>
            /// </summary>
            [NameInMap("VswitchCidr")]
            [Validation(Required=false)]
            public string VswitchCidr { get; set; }

            /// <summary>
            /// <para>The virtual switch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1sqg9wms9wxcs1****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The zone ID of the virtual switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("VswitchZoneId")]
            [Validation(Required=false)]
            public string VswitchZoneId { get; set; }

            /// <summary>
            /// <para>The ID of the primary zone for the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The details of the VPC.</para>
        /// </summary>
        [NameInMap("LocalVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallCenDetailResponseBodyLocalVpc LocalVpc { get; set; }
        public class DescribeVpcFirewallCenDetailResponseBodyLocalVpc : TeaModel {
            /// <summary>
            /// <para>The ID of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-sxig7bye51fid5****</para>
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>The name of the network instance connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local-test</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>The list of CIDR blocks that are protected by the VPC firewall.</para>
            /// </summary>
            [NameInMap("DefendCidrList")]
            [Validation(Required=false)]
            public List<string> DefendCidrList { get; set; }

            /// <summary>
            /// <para>The list of elastic network interfaces (ENIs).</para>
            /// </summary>
            [NameInMap("EniList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList> EniList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcEniList : TeaModel {
                /// <summary>
                /// <para>The instance ID of the ENI in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-8vbhfosfqv2rff42****</para>
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// <para>The private IP address of the ENI in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("EniPrivateIpAddress")]
                [Validation(Required=false)]
                public string EniPrivateIpAddress { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch for the ENI in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-wz9viido7j436b0n1****</para>
                /// </summary>
                [NameInMap("EniVSwitchId")]
                [Validation(Required=false)]
                public string EniVSwitchId { get; set; }

            }

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
            /// <para>The ID of the VPC instance for which the VPC firewall is created.</para>
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
            /// <para>The type of the network instance. The value is fixed as <b>VPC</b>.</para>
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
            /// <para>The instance ID of the CEN transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-2zetwxskej633l3u1****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

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
            /// <para>The list of CIDR blocks for the VPC.</para>
            /// </summary>
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallCenDetailResponseBodyLocalVpcVpcCidrTableList : TeaModel {
                /// <summary>
                /// <para>The list of route entries for the VPC.</para>
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
            /// <para>vpc-firewall-test</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090125g4d2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
