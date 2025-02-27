// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> for each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the custom route entry.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the custom route entry. Both IPv4 and IPv6 CIDR blocks are supported. Make sure that the destination CIDR block meets the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The destination CIDR block is not 100.64.0.0/10 or a subset of 100.64.0.0/10.</description></item>
        /// <item><description>The destination CIDR block of the custom route entry is different from the destination CIDR blocks of other route entries in the same route table.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the next hop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-j6c2fp57q8rr4jlu****</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The next hop list.</para>
        /// </summary>
        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<CreateRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class CreateRouteEntryRequestNextHopList : TeaModel {
            /// <summary>
            /// <para>The ID of the next hop of the ECMP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ri-2zeo3xzyf3cd8r4****</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The type of next hop of the ECMP route entry. Set the value to <b>RouterInterface</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RouterInterface</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The weight of the next hop of the ECMP route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The type of next hop of the custom route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: an Elastic Compute Service (ECS) instance. This is the default value.</description></item>
        /// <item><description><b>HaVip</b>: a high-availability virtual IP address (HAVIP).</description></item>
        /// <item><description><b>RouterInterface</b>: a router interface.</description></item>
        /// <item><description><b>NetworkInterface</b>: an elastic network interface (ENI).</description></item>
        /// <item><description><b>VpnGateway</b>: a VPN gateway.</description></item>
        /// <item><description><b>IPv6Gateway</b>: an IPv6 gateway.</description></item>
        /// <item><description><b>NatGateway</b>: a NAT gateway.</description></item>
        /// <item><description><b>Attachment</b>: a transit router.</description></item>
        /// <item><description><b>VpcPeer</b>: a VPC peering connection.</description></item>
        /// <item><description><b>Ipv4Gateway</b>: an IPv4 gateway.</description></item>
        /// <item><description><b>GatewayEndpoint</b>: a gateway endpoint.</description></item>
        /// <item><description><b>Ecr</b>: an Express Connect Router (ECR).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RouterInterface</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the route table.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the custom route entry that you want to add.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the route table to which you want to add a custom route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp145q7glnuzd****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
