// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>A unique, case-sensitive identifier to ensure request idempotency. The token must be 1 to 64 ASCII characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The destination CIDR block. The value must be a valid CIDR block. Set the value to <c>0.0.0.0/0</c> to create a default route.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the next hop.</para>
        /// <para><b>Note</b> Specify either <c>NextHopId</c> or <c>NextHopList</c>, but not both.</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The list of next hops for an ECMP route.</para>
        /// <para><b>Note</b> Specify either <c>NextHopId</c> or <c>NextHopList</c>, but not both.</para>
        /// </summary>
        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<CreateRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class CreateRouteEntryRequestNextHopList : TeaModel {
            /// <summary>
            /// <para>The ID of the next hop in the ECMP route.</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The type of the next hop in the ECMP route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Instance</b>: an ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>HaVip</b>: a high-availability virtual IP address.</para>
            /// </description></item>
            /// <item><description><para><b>RouterInterface</b>: a router interface.</para>
            /// </description></item>
            /// <item><description><para><b>NetworkInterface</b>: an elastic network interface.</para>
            /// </description></item>
            /// <item><description><para><b>VpnGateway</b>: a VPN gateway.</para>
            /// </description></item>
            /// <item><description><para><b>Ipv6Gateway</b>: an IPv6 gateway.</para>
            /// </description></item>
            /// <item><description><para><b>NatGateway</b>: a NAT gateway.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

        }

        /// <summary>
        /// <para>The type of the next hop. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b>: an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: a high-availability virtual IP address.</para>
        /// </description></item>
        /// <item><description><para><b>RouterInterface</b>: a router interface.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: an elastic network interface.</para>
        /// </description></item>
        /// <item><description><para><b>VpnGateway</b>: a VPN gateway.</para>
        /// </description></item>
        /// <item><description><para><b>Ipv6Gateway</b>: an IPv6 gateway.</para>
        /// </description></item>
        /// <item><description><para><b>NatGateway</b>: a NAT gateway.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Note</b> This parameter is required if you specify <c>NextHopId</c>.</para>
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
        /// <para>The ID of the region. You can call the <a href="~~docid:36063~~">DescribeRegions</a> operation to get the latest list of regions.</para>
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
        /// <para>The ID of the route table.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
