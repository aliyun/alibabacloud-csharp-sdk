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
        /// <para><b>true</b>: performs a dry run without creating routes. The system checks the AccessKey pair, the authorization of the Resource Access Management (RAM) user, and the required parameters. If the check fails, the corresponding error is returned. If the check passes, the <c>DryRunOperation</c> error code is returned.</para>
        /// <para><b>false</b> (default): sends a Normal request. If the check passes, a 2xx HTTP status code is returned and the routes are created.</para>
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
        /// <para>The region ID of the route table.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The list of route entry information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class CreateRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// <para>The description of the custom route entry. You can specify a maximum of 50 descriptions.</para>
            /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the custom route entry. Both IPv4 and IPv6 destination CIDR blocks are supported. You can specify a maximum of 50 destination CIDR blocks. The following requirements must be met:</para>
            /// <list type="bullet">
            /// <item><description><para>The destination CIDR block cannot point to or be contained by 100.64.0.0/10.  </para>
            /// </description></item>
            /// <item><description><para>The destination CIDR blocks of different route entries in the same route table must be unique.</para>
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
            /// <para>The version of the IP protocol. You can specify a maximum of 50 IP protocol versions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>4</b>: IPv4.</description></item>
            /// <item><description><b>6</b>: IPv6.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The name of the custom route entry to add. You can specify a maximum of 50 names.</para>
            /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the next hop instance for the custom route entry. You can specify a maximum of 50 instance IDs.</para>
            /// <remarks>
            /// <para>If NextHopType is set to ECR, you can call <a href="https://help.aliyun.com/document_detail/2712069.html">DescribeExpressConnectRouterAssociation</a> to obtain the AssociationId as the next hop ID.</para>
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
            /// <para>The type of the next hop for the custom route entry. You can specify a maximum of 50 next hop types. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><para><b>Instance</b> (default): ECS instance. Forwards traffic to an ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>HaVip</b>: high-availability virtual IP address.  </para>
            /// </description></item>
            /// <item><description><para><b>RouterInterface</b>: vRouter interface.</para>
            /// </description></item>
            /// <item><description><para><b>NetworkInterface</b>: elastic network interfaces (ENIs).</para>
            /// </description></item>
            /// <item><description><para><b>VpnGateway</b>: VPN gateway.</para>
            /// </description></item>
            /// <item><description><para><b>IPv6Gateway</b>: IPv6 gateway.</para>
            /// </description></item>
            /// <item><description><para><b>NatGateway</b>: NAT gateway.</para>
            /// </description></item>
            /// <item><description><para><b>Attachment</b>: transit router. Forwards traffic to a transit router.</para>
            /// </description></item>
            /// <item><description><para><b>VpcPeer</b>: VPC peering connection.</para>
            /// </description></item>
            /// <item><description><para><b>Ipv4Gateway</b>: IPv4 gateway.</para>
            /// </description></item>
            /// <item><description><para><b>GatewayEndpoint</b>: gateway endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>CenBasic</b>: CEN that does not support transit routers.</para>
            /// </description></item>
            /// <item><description><para><b>Ecr</b>: Express Connect Router (ECR).</para>
            /// </description></item>
            /// <item><description><para><b>GatewayLoadBalancerEndpoint</b>: Gateway Load Balancer endpoint (GWLBe).</para>
            /// </description></item>
            /// <item><description><para><b>RouteTargetGroup</b>: routing target group.</para>
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
            /// <para>The ID of the route table to which you want to add the custom route entry. You can specify a maximum of 50 route table IDs.</para>
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
