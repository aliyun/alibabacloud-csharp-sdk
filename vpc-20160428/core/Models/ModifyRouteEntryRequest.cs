// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The description of the route entry.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EntryDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block of the route entry. IPv4 and IPv6 CIDR blocks are supported.</para>
        /// <remarks>
        /// <para>If the <b>RouteEntryId</b> parameter is not specified, the <b>DestinationCidrBlock</b> and <b>RouteTableId</b> parameters are required.
        /// To change the IPv4 CIDR block of a route to a <b>prefix list</b>, specify the <b>RouteEntryId</b> parameter. The <b>DestinationCidrBlock</b> parameter does not support prefix list CIDR blocks or prefix list instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <para><b>true</b>: sends the request without modifying the route. The system checks whether the AccessKey pair is valid, the authorization of the Resource Access Management (RAM) user, and whether the required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</para>
        /// <para><b>false</b> (default): sends a Normal request. After the request passes the check, a 2xx HTTP status code is returned and the route is modified.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The new next hop instance ID of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp17y37ytsenqyim****</para>
        /// </summary>
        [NameInMap("NewNextHopId")]
        [Validation(Required=false)]
        public string NewNextHopId { get; set; }

        /// <summary>
        /// <para>The new next hop type of the route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b>: ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: high-availability virtual IP address.  </para>
        /// </description></item>
        /// <item><description><para><b>RouterInterface</b>: vRouter interface.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: elastic network interface (ENI).</para>
        /// </description></item>
        /// <item><description><para><b>VpnGateway</b>: VPN gateway.</para>
        /// </description></item>
        /// <item><description><para><b>IPv6Gateway</b>: IPv6 gateway.</para>
        /// </description></item>
        /// <item><description><para><b>NatGateway</b>: NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>Attachment</b>: transit router.</para>
        /// </description></item>
        /// <item><description><para><b>VpcPeer</b>: VPC peering connection.</para>
        /// </description></item>
        /// <item><description><para><b>Ipv4Gateway</b>: IPv4 gateway.</para>
        /// </description></item>
        /// <item><description><para><b>GatewayEndpoint</b>: gateway endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>Ecr</b>: Express Connect Router (ECR).</para>
        /// </description></item>
        /// <item><description><para><b>GatewayLoadBalancerEndpoint</b>: Gateway Load Balancer endpoint (GWLBe).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NetworkInterface</para>
        /// </summary>
        [NameInMap("NewNextHopType")]
        [Validation(Required=false)]
        public string NewNextHopType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the route entry.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The ID of the custom route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rte-acfvgfsghfdd****</para>
        /// </summary>
        [NameInMap("RouteEntryId")]
        [Validation(Required=false)]
        public string RouteEntryId { get; set; }

        /// <summary>
        /// <para>The name of the route entry.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EntryName</para>
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// <para>The route table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1nk7zk65du3pni8z9td</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
