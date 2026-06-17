// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSecurityProxyResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E8D50E-9F45-5662-B116-A1D0807F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<DescribeSecurityProxyResourcesResponseBodyResourceList> ResourceList { get; set; }
        public class DescribeSecurityProxyResourcesResponseBodyResourceList : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The list of VPCs.</para>
            /// </summary>
            [NameInMap("VpcList")]
            [Validation(Required=false)]
            public List<DescribeSecurityProxyResourcesResponseBodyResourceListVpcList> VpcList { get; set; }
            public class DescribeSecurityProxyResourcesResponseBodyResourceListVpcList : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The UID of the member account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>157862808111****</para>
                /// </summary>
                [NameInMap("MemberUid")]
                [Validation(Required=false)]
                public string MemberUid { get; set; }

                /// <summary>
                /// <para>The list of NAT gateways.</para>
                /// </summary>
                [NameInMap("NatGateways")]
                [Validation(Required=false)]
                public List<DescribeSecurityProxyResourcesResponseBodyResourceListVpcListNatGateways> NatGateways { get; set; }
                public class DescribeSecurityProxyResourcesResponseBodyResourceListVpcListNatGateways : TeaModel {
                    /// <summary>
                    /// <para>The status of the NAT Gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                    /// <summary>
                    /// <para>The ID of the NAT Gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ngw-bp1bm0k2t8i6ooxu****</para>
                    /// </summary>
                    [NameInMap("NatGatewayId")]
                    [Validation(Required=false)]
                    public string NatGatewayId { get; set; }

                    /// <summary>
                    /// <para>The name of the NAT Gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ngw-test</para>
                    /// </summary>
                    [NameInMap("NatGatewayName")]
                    [Validation(Required=false)]
                    public string NatGatewayName { get; set; }

                    /// <summary>
                    /// <para>The list of NAT route tables.</para>
                    /// </summary>
                    [NameInMap("NatRouteEntryList")]
                    [Validation(Required=false)]
                    public List<DescribeSecurityProxyResourcesResponseBodyResourceListVpcListNatGatewaysNatRouteEntryList> NatRouteEntryList { get; set; }
                    public class DescribeSecurityProxyResourcesResponseBodyResourceListVpcListNatGatewaysNatRouteEntryList : TeaModel {
                        /// <summary>
                        /// <para>The destination CIDR block.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.0.70.XX/24</para>
                        /// </summary>
                        [NameInMap("DestinationCidr")]
                        [Validation(Required=false)]
                        public string DestinationCidr { get; set; }

                        /// <summary>
                        /// <para>The ID of the next hop.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ngw-2zey0w2u02u1x584m****</para>
                        /// </summary>
                        [NameInMap("NextHopId")]
                        [Validation(Required=false)]
                        public string NextHopId { get; set; }

                        /// <summary>
                        /// <para>The network type of the next hop.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NatGateway</para>
                        /// </summary>
                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        /// <summary>
                        /// <para>The ID of the route table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vtb-2ze409pp09d994a****</para>
                        /// </summary>
                        [NameInMap("RouteTableId")]
                        [Validation(Required=false)]
                        public string RouteTableId { get; set; }

                    }

                    /// <summary>
                    /// <para>The status of the NAT Gateway.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbuzirdl3w1r7exw****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-wz94a4q37rgl7g****</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
