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
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
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
        /// <para>The destination CIDR block of the custom route entry. IPv4 CIDR blocks, IPv6 CIDR blocks, destination CIDR blocks of prefix lists, and prefix list instance IDs are supported. The destination CIDR block must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The destination CIDR block cannot point to 100.64.0.0/10 or be contained by 100.64.0.0/10.  </para>
        /// </description></item>
        /// <item><description><para>Route entries in the same route table cannot have the same destination CIDR block.</para>
        /// </description></item>
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
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system prechecks the request without creating the route entry. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): The system sends a regular request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the next hop instance for the custom route entry.</para>
        /// <remarks>
        /// <h2>If you set NextHopType to ECR, you can call the <a href="https://help.aliyun.com/document_detail/2712069.html">DescribeExpressConnectRouterAssociation</a> operation to obtain the AssociationId as the next hop ID.</h2>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-j6c2fp57q8rr4jlu****</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The information about the next hops.</para>
        /// </summary>
        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<CreateRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class CreateRouteEntryRequestNextHopList : TeaModel {
            /// <summary>
            /// <para>The ID of the next hop instance for the ECMP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ri-2zeo3xzyf3cd8r4****</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The type of the next hop for the ECMP route. Valid value: <b>RouterInterface</b> (router interface).</para>
            /// 
            /// <b>Example:</b>
            /// <para>RouterInterface</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The route weight of the next hop for the ECMP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The type of the next hop for the custom route entry. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b> (default): an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: a high-availability virtual IP address.  </para>
        /// </description></item>
        /// <item><description><para><b>RouterInterface</b>: a vRouter interface.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: an elastic network interface (ENI).</para>
        /// </description></item>
        /// <item><description><para><b>VpnGateway</b>: a VPN gateway.</para>
        /// </description></item>
        /// <item><description><para><b>IPv6Gateway</b>: an IPv6 gateway.</para>
        /// </description></item>
        /// <item><description><para><b>NatGateway</b>: a NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>Attachment</b>: a transit router.</para>
        /// </description></item>
        /// <item><description><para><b>VpcPeer</b>: a VPC peering connection.</para>
        /// </description></item>
        /// <item><description><para><b>Ipv4Gateway</b>: an IPv4 gateway.</para>
        /// </description></item>
        /// <item><description><para><b>GatewayEndpoint</b>: a gateway endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>Ecr</b>: an Express Connect Router (ECR).</para>
        /// </description></item>
        /// <item><description><para><b>GatewayLoadBalancerEndpoint</b>: a Gateway Load Balancer endpoint (GWLBe).</para>
        /// </description></item>
        /// <item><description><para><b>RouteTargetGroup</b>: a route target group.</para>
        /// </description></item>
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
        /// <para>The name of the custom route entry to be added.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the route table to which you want to add the custom route entry.</para>
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
