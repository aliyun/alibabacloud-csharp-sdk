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
        /// <para>Generate a parameter value from your client. Make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
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
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the custom route entry. IPv4 CIDR blocks, IPv6 CIDR blocks, destination CIDR blocks of prefix lists, and instance IDs of prefix lists are supported. The following requirements must be met:</para>
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
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request format, and business restrictions. If the request fails the dry run, the corresponding error is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request, passes the dry run, and returns an HTTP 2xx status code. The route is directly created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the next hop instance of the custom route entry.</para>
        /// <remarks>
        /// <para>If you set NextHopType to ECR, you can call the <a href="https://help.aliyun.com/document_detail/2712069.html">DescribeExpressConnectRouterAssociation</a> operation to obtain the AssociationId as the next hop ID.
        /// -.</para>
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
            /// <para>The ID of the next hop instance of the ECMP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ri-2zeo3xzyf3cd8r4****</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The type of next hop of the ECMP route. Valid value: <b>RouterInterface</b> (router interface).</para>
            /// 
            /// <b>Example:</b>
            /// <para>RouterInterface</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// <para>The weight of the next hop of the ECMP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The type of next hop of the custom route entry. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b> (default): ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: high-availability virtual IP address.  </para>
        /// </description></item>
        /// <item><description><para><b>RouterInterface</b>: vRouter interface.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: network interface controller (NIC).</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The name of the custom route entry to add.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
