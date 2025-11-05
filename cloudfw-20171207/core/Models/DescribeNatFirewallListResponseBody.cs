// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallListResponseBody : TeaModel {
        /// <summary>
        /// <para>The NAT firewalls.</para>
        /// </summary>
        [NameInMap("NatFirewallList")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallListResponseBodyNatFirewallList> NatFirewallList { get; set; }
        public class DescribeNatFirewallListResponseBodyNatFirewallList : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// <remarks>
            /// <para> The value of this parameter indicates the management account to which the member is added.</para>
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
            /// <para>Create Failed.</para>
            /// </summary>
            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            /// <summary>
            /// <para>The UID of the member in Cloud Firewall.</para>
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
            /// <para>nat-******</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <para>The default route entries of the NAT gateway.</para>
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
                /// <para>The next hop of the original NAT gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-2ze0s284r9atg5******</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>The network type of the next hop. The value is fixed as NatGateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NatGateway</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The route table to which the default route of the NAT gateway belongs.</para>
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
            /// <para>proxy-******</para>
            /// </summary>
            [NameInMap("ProxyName")]
            [Validation(Required=false)]
            public string ProxyName { get; set; }

            [NameInMap("ProxyNetworkInterfaceId")]
            [Validation(Required=false)]
            public string ProxyNetworkInterfaceId { get; set; }

            [NameInMap("ProxyRouteTableId")]
            [Validation(Required=false)]
            public string ProxyRouteTableId { get; set; }

            /// <summary>
            /// <para>The status of the NAT firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>configuring</description></item>
            /// <item><description>deleting</description></item>
            /// <item><description>normal</description></item>
            /// <item><description>abnormal</description></item>
            /// <item><description>opening</description></item>
            /// <item><description>closing</description></item>
            /// <item><description>closed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            [NameInMap("ProxyVSwitchId")]
            [Validation(Required=false)]
            public string ProxyVSwitchId { get; set; }

            /// <summary>
            /// <para>The region ID of your Cloud Firewall.</para>
            /// <remarks>
            /// <para> For more information about the supported regions of Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the strict mode is enabled. Valid values: 1, which specifies yes, and 0, which specifies no.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StrictMode")]
            [Validation(Required=false)]
            public int? StrictMode { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
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
            /// <para>vpc-******</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
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
