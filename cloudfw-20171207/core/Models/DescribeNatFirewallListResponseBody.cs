// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Cloud Firewalls.</para>
        /// </summary>
        [NameInMap("NatFirewallList")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallListResponseBodyNatFirewallList> NatFirewallList { get; set; }
        public class DescribeNatFirewallListResponseBodyNatFirewallList : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// <remarks>
            /// <para>This is the primary account of the Cloud Firewall member account.</para>
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
            /// <para>The UID of the Cloud Firewall member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19106481******</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <para>The ID of the NAT Gateway to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-uf6tnblxip4qcxg******</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The name of the NAT Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-gateway-test</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <para>The list of default route entries for the NAT Gateway.</para>
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
                /// <para>The next hop of the original NAT Gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-2ze0s284r9atg5******</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>The network type of the next hop. The value is \<c>NatGateway\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NatGateway</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The route table that contains the default route of the NAT Gateway.</para>
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
            /// <para>The ID of the Elastic Network Interface (ENI) that the firewall uses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp127llmo4v5qju******</para>
            /// </summary>
            [NameInMap("ProxyNetworkInterfaceId")]
            [Validation(Required=false)]
            public string ProxyNetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The ID of the route table that the firewall uses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1pmyga7p4j10a******</para>
            /// </summary>
            [NameInMap("ProxyRouteTableId")]
            [Validation(Required=false)]
            public string ProxyRouteTableId { get; set; }

            /// <summary>
            /// <para>The status of the Cloud Firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>configuring: The firewall is being created.</para>
            /// </description></item>
            /// <item><description><para>deleting: The firewall is being deleted.</para>
            /// </description></item>
            /// <item><description><para>normal: The firewall is working as expected.</para>
            /// </description></item>
            /// <item><description><para>abnormal: The firewall is not working as expected.</para>
            /// </description></item>
            /// <item><description><para>opening: The firewall is being enabled.</para>
            /// </description></item>
            /// <item><description><para>closing: The firewall is being disabled.</para>
            /// </description></item>
            /// <item><description><para>closed: The firewall is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch that the firewall uses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1amn3t1ktjjy8******</para>
            /// </summary>
            [NameInMap("ProxyVSwitchId")]
            [Validation(Required=false)]
            public string ProxyVSwitchId { get; set; }

            /// <summary>
            /// <para>The region ID where the Cloud Firewall is located.</para>
            /// <remarks>
            /// <para>For more information about the regions where Cloud Firewall is available, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether strict mode is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para>1: Strict mode is enabled.</para>
            /// </description></item>
            /// <item><description><para>0: Strict mode is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StrictMode")]
            [Validation(Required=false)]
            public int? StrictMode { get; set; }

            /// <summary>
            /// <para>The ID of the VPC instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze26ya******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC instance.</para>
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
