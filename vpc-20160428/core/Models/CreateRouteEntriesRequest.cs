// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <para><b>true</b>: Sends a request to check whether the request is valid. The system checks whether your AccessKey is valid, whether the RAM user is authorized, and whether the required parameters are specified. If the request fails the check, an error message is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</para>
        /// <para><b>false</b> (default): Sends a normal request. After the request passes the check, a 2xx HTTP status code is returned and the routes are created.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the route table is located.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The list of route information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class CreateRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// <para>The description of the custom route. You can specify up to 50 descriptions.</para>
            /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the custom route. Both IPv4 and IPv6 CIDR blocks are supported. You can specify up to 50 destination CIDR blocks. The destination CIDR blocks must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>The destination CIDR block cannot point to 100.64.0.0/10 or be a subset of 100.64.0.0/10.</para>
            /// </description></item>
            /// <item><description><para>The destination CIDR blocks of different routes in the same route table cannot be the same.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/24</para>
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// <para>The IP protocol version. You can specify up to 50 IP protocol versions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>4</b>: IPv4.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: IPv6.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The name of the custom route that you want to add. You can specify up to 50 names.</para>
            /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the next hop instance for the custom route. You can specify up to 50 instance IDs.</para>
            /// <remarks>
            /// <para>If you set NextHopType to Ecr, call the <a href="https://help.aliyun.com/document_detail/2712069.html">DescribeExpressConnectRouterAssociation</a> operation to obtain the AssociationId and use it as the next hop ID.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6c2fp57q8rr4jlu****</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// <para>The type of the next hop for the custom route. You can specify up to 50 next hop types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Instance</b> (default): an ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>HaVip</b>: a high-availability virtual IP address (HAVIP).</para>
            /// </description></item>
            /// <item><description><para><b>RouterInterface</b>: a router interface.</para>
            /// </description></item>
            /// <item><description><para><b>NetworkInterface</b>: an elastic network interface (ENI).</para>
            /// </description></item>
            /// <item><description><para><b>VpnGateway</b>: a VPN Gateway.</para>
            /// </description></item>
            /// <item><description><para><b>IPv6Gateway</b>: an IPv6 Gateway.</para>
            /// </description></item>
            /// <item><description><para><b>NatGateway</b>: a NAT Gateway.</para>
            /// </description></item>
            /// <item><description><para><b>Attachment</b>: a transit router.</para>
            /// </description></item>
            /// <item><description><para><b>VpcPeer</b>: a VPC peering connection.</para>
            /// </description></item>
            /// <item><description><para><b>Ipv4Gateway</b>: an IPv4 gateway.</para>
            /// </description></item>
            /// <item><description><para><b>GatewayEndpoint</b>: a gateway endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>CenBasic</b>: CEN does not support transit routers.</para>
            /// </description></item>
            /// <item><description><para><b>Ecr</b>: an Express Connect Router (ECR).</para>
            /// </description></item>
            /// <item><description><para><b>GatewayLoadBalancerEndpoint</b>: a Gateway Load Balancer endpoint (GWLBe).</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RouterInterface</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The ID of the route table to which you want to add custom routes. You can specify up to 50 route table IDs.</para>
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

}
