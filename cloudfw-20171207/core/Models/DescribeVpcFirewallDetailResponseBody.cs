// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDetailResponseBody : TeaModel {
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
        /// <para>The connection type of the VPC firewall. The value is fixed as <b>expressconnect</b>, which indicates Express Connect circuits.</para>
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
        /// <item><description><b>configured</b>: The VPC firewall is configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>opened</para>
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// <para>The details about the local VPC.</para>
        /// </summary>
        [NameInMap("LocalVpc")]
        [Validation(Required=false)]
        public DescribeVpcFirewallDetailResponseBodyLocalVpc LocalVpc { get; set; }
        public class DescribeVpcFirewallDetailResponseBodyLocalVpc : TeaModel {
            /// <summary>
            /// <para>The ID of the ENI for the local VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-8vbhfosfqv2rff42****</para>
            /// </summary>
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            /// <summary>
            /// <para>The private IP address of the elastic network interface (ENI) for the local VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("EniPrivateIpAddress")]
            [Validation(Required=false)]
            public string EniPrivateIpAddress { get; set; }

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
            /// <para>The router interface ID of the local VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vrt-m5eb5me6c3l5sezae****</para>
            /// </summary>
            [NameInMap("RouterInterfaceId")]
            [Validation(Required=false)]
            public string RouterInterfaceId { get; set; }

            /// <summary>
            /// <para>The CIDR blocks of the local VPC.</para>
            /// </summary>
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableList : TeaModel {
                /// <summary>
                /// <para>The route entries of the local VPC.</para>
                /// </summary>
                [NameInMap("RouteEntryList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallDetailResponseBodyLocalVpcVpcCidrTableListRouteEntryList : TeaModel {
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
            /// <para>Vitasoy</para>
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
        public DescribeVpcFirewallDetailResponseBodyPeerVpc PeerVpc { get; set; }
        public class DescribeVpcFirewallDetailResponseBodyPeerVpc : TeaModel {
            /// <summary>
            /// <para>The ID of the ENI for the peer VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-8vbhfosfqv2rff42****</para>
            /// </summary>
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            /// <summary>
            /// <para>The private IP address of the ENI for the peer VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("EniPrivateIpAddress")]
            [Validation(Required=false)]
            public string EniPrivateIpAddress { get; set; }

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
            /// <para>The router interface ID of the peer VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vrt-m5eb5me6c3l5sezae****</para>
            /// </summary>
            [NameInMap("RouterInterfaceId")]
            [Validation(Required=false)]
            public string RouterInterfaceId { get; set; }

            /// <summary>
            /// <para>The CIDR blocks of the peer VPC.</para>
            /// </summary>
            [NameInMap("VpcCidrTableList")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableList> VpcCidrTableList { get; set; }
            public class DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableList : TeaModel {
                /// <summary>
                /// <para>The route entries of the peer VPC.</para>
                /// </summary>
                [NameInMap("RouteEntryList")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableListRouteEntryList> RouteEntryList { get; set; }
                public class DescribeVpcFirewallDetailResponseBodyPeerVpcVpcCidrTableListRouteEntryList : TeaModel {
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
            /// <para>vpc-90rq0anm6t8vbwbo****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the peer VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zcy_prod</para>
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
        /// <para>tf-test</para>
        /// </summary>
        [NameInMap("VpcFirewallName")]
        [Validation(Required=false)]
        public string VpcFirewallName { get; set; }

    }

}
