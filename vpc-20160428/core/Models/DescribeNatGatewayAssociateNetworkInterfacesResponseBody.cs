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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><c>172.17.**.**</c></para>
                        /// </summary>
                        [NameInMap("IPv4Address")]
                        [Validation(Required=false)]
                        public string IPv4Address { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Primary")]
                        [Validation(Required=false)]
                        public bool? Primary { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eni-gw8g131ef2dnbu3k****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ep-8psre8c8936596cd****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>138859086900****</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public string ResourceOwnerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PrivateLink</para>
                /// </summary>
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

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2315DEB7-5E92-423A-91F7-4C1EC9AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
