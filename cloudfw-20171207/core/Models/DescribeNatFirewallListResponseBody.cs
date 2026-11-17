// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of NAT firewalls.</para>
        /// </summary>
        [NameInMap("NatFirewallList")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallListResponseBodyNatFirewallList> NatFirewallList { get; set; }
        public class DescribeNatFirewallListResponseBodyNatFirewallList : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// <remarks>
            /// <para>The Alibaba Cloud account to which the Cloud Firewall member account belongs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>19106481******</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The cause of the error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Firewall creation failed</para>
            /// </summary>
            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            /// <summary>
            /// <para>The deployment mode of the NAT firewall service. Valid values: <b>PrimaryStandby</b> (primary/secondary mode) and <b>MultiPrimary</b> (active-active mode).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrimaryStandby</para>
            /// </summary>
            [NameInMap("FirewallServiceMode")]
            [Validation(Required=false)]
            public string FirewallServiceMode { get; set; }

            /// <summary>
            /// <para>The list of zone IDs used by the NAT firewall service.</para>
            /// </summary>
            [NameInMap("FirewallServiceZones")]
            [Validation(Required=false)]
            public List<string> FirewallServiceZones { get; set; }

            /// <summary>
            /// <para>The UID of the member account of Cloud Firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19106481******</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <para>The ID of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-uf6tnblxip4qcxg******</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The name of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-gateway-test</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <para>The default route entry list for routing of the NAT gateway.</para>
            /// </summary>
            [NameInMap("NatRouteEntryList")]
            [Validation(Required=false)]
            public List<DescribeNatFirewallListResponseBodyNatFirewallListNatRouteEntryList> NatRouteEntryList { get; set; }
            public class DescribeNatFirewallListResponseBodyNatFirewallListNatRouteEntryList : TeaModel {
                /// <summary>
                /// <para>The destination CIDR block of the default route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("DestinationCidr")]
                [Validation(Required=false)]
                public string DestinationCidr { get; set; }

                /// <summary>
                /// <para>The next hop ID of the original NAT gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-2ze0s284r9atg5******</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>The network type of the next hop. Valid values: NatGateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NatGateway</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The ID of the route table to which the default route of the NAT gateway belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vtb-bp18o0gb******</para>
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proxy-nat30******</para>
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public string ProxyId { get; set; }

            /// <summary>
            /// <para>The name of the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-firewall-test</para>
            /// </summary>
            [NameInMap("ProxyName")]
            [Validation(Required=false)]
            public string ProxyName { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI) used by the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp127llmo4v5qju******</para>
            /// </summary>
            [NameInMap("ProxyNetworkInterfaceId")]
            [Validation(Required=false)]
            public string ProxyNetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The ID of the route table used by the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1pmyga7p4j10a******</para>
            /// </summary>
            [NameInMap("ProxyRouteTableId")]
            [Validation(Required=false)]
            public string ProxyRouteTableId { get; set; }

            /// <summary>
            /// <para>The status of the NAT firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>configuring: Creating.</description></item>
            /// <item><description>deleting: Deleting.</description></item>
            /// <item><description>normal: Normal. </description></item>
            /// <item><description>abnormal: Abnormal.</description></item>
            /// <item><description>opening: Enabling.</description></item>
            /// <item><description>closing: Disabling.</description></item>
            /// <item><description>closed: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch used by the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1amn3t1ktjjy8******</para>
            /// </summary>
            [NameInMap("ProxyVSwitchId")]
            [Validation(Required=false)]
            public string ProxyVSwitchId { get; set; }

            /// <summary>
            /// <para>The region ID of the NAT firewall.</para>
            /// <remarks>
            /// <para>For more information about the regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Specifies whether strict mode is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Strict mode is enabled. </description></item>
            /// <item><description>0: Strict mode is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StrictMode")]
            [Validation(Required=false)]
            public int? StrictMode { get; set; }

            /// <summary>
            /// <para>The VPC-connected instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze26ya******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-test-instance</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of NAT firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
