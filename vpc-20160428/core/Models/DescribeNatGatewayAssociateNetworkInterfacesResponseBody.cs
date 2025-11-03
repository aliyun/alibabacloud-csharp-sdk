// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewayAssociateNetworkInterfacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ENIs associated with the VPC NAT gateway.</para>
        /// </summary>
        [NameInMap("AssociateNetworkInterfaces")]
        [Validation(Required=false)]
        public DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfaces AssociateNetworkInterfaces { get; set; }
        public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfaces : TeaModel {
            [NameInMap("AssociateNetworkInterface")]
            [Validation(Required=false)]
            public List<DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterface> AssociateNetworkInterface { get; set; }
            public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterface : TeaModel {
                /// <summary>
                /// <para>The IPv4 addresses of the ENIs.</para>
                /// </summary>
                [NameInMap("IPv4Sets")]
                [Validation(Required=false)]
                public DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4Sets IPv4Sets { get; set; }
                public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4Sets : TeaModel {
                    [NameInMap("IPv4Set")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4SetsIPv4Set> IPv4Set { get; set; }
                    public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4SetsIPv4Set : TeaModel {
                        /// <summary>
                        /// <para>The primary private IP address of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><c>172.17.**.**</c></para>
                        /// </summary>
                        [NameInMap("IPv4Address")]
                        [Validation(Required=false)]
                        public string IPv4Address { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the IP address is the primary private IP address. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: Primary private IP address</description></item>
                        /// <item><description>false: Secondary private IP addresses</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Primary")]
                        [Validation(Required=false)]
                        public bool? Primary { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-gw8g131ef2dnbu3k****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The ID of the service resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-8psre8c8936596cd****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The UID of the account to which the service resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>138859086900****</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public string ResourceOwnerId { get; set; }

                /// <summary>
                /// <para>The type of the service resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateLink</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("ResourceVpcId")]
                [Validation(Required=false)]
                public string ResourceVpcId { get; set; }

                /// <summary>
                /// <para>The ID of the tunnel index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41a5489ea2a0****</para>
                /// </summary>
                [NameInMap("TunnelIndex")]
                [Validation(Required=false)]
                public string TunnelIndex { get; set; }

            }

        }

        /// <summary>
        /// <para>Number of associated ENIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the VPC NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>Indicates whether the token for the next query exists. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, there is no next page.</description></item>
        /// <item><description>If the value returned of <b>NextToken</b> is not empty, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2315DEB7-5E92-423A-91F7-4C1EC9AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
