// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewayAssociateNetworkInterfacesResponseBody : TeaModel {
        [NameInMap("AssociateNetworkInterfaces")]
        [Validation(Required=false)]
        public DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfaces AssociateNetworkInterfaces { get; set; }
        public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfaces : TeaModel {
            [NameInMap("AssociateNetworkInterface")]
            [Validation(Required=false)]
            public List<DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterface> AssociateNetworkInterface { get; set; }
            public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterface : TeaModel {
                [NameInMap("IPv4Sets")]
                [Validation(Required=false)]
                public DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4Sets IPv4Sets { get; set; }
                public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4Sets : TeaModel {
                    [NameInMap("IPv4Set")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4SetsIPv4Set> IPv4Set { get; set; }
                    public class DescribeNatGatewayAssociateNetworkInterfacesResponseBodyAssociateNetworkInterfacesAssociateNetworkInterfaceIPv4SetsIPv4Set : TeaModel {
                        [NameInMap("IPv4Address")]
                        [Validation(Required=false)]
                        public string IPv4Address { get; set; }

                        [NameInMap("Primary")]
                        [Validation(Required=false)]
                        public bool? Primary { get; set; }

                    }

                }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public string ResourceOwnerId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("ResourceVpcId")]
                [Validation(Required=false)]
                public string ResourceVpcId { get; set; }

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
