// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without performing the operation. The system prechecks the required parameters, request syntax, and limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. After the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>The routes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<CreateRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class CreateRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// <para>The description of the custom route. You can specify at most 50 descriptions.</para>
            /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the custom route. IPv4 CIDR blocks, IPv6 CIDR blocks, and prefix lists are supported. You can enter up to 50 destination CIDR blocks. Make sure that the following requirements are met:</para>
            /// <list type="bullet">
            /// <item><description>The destination CIDR block cannot point to 100.64.0.0/10 or belong to 100.64.0.0/10.</description></item>
            /// <item><description>The destination CIDR block of each route in the route table is unique.</description></item>
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
            /// <para>The IP version. Valid values: You can specify at most 50 IP versions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>4</b>: IPv4</description></item>
            /// <item><description><b>6</b>: IPv6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The name of the custom route that you want to add. You can specify at most 50 names.</para>
            /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the next hop for the custom route. You can specify at most 50 instance IDs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6c2fp57q8rr4jlu****</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// <para>The type of next hop. You can specify at most 50 next hop types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Instance</b>: Elastic Compute Service (ECS) instance. This is the default value.</description></item>
            /// <item><description><b>HaVip</b>: high-availability virtual IP address (HaVip).</description></item>
            /// <item><description><b>RouterInterface</b>: router interface.</description></item>
            /// <item><description><b>NetworkInterface</b>: elastic network interface (ENI).</description></item>
            /// <item><description><b>VpnGateway</b>: VPN gateway.</description></item>
            /// <item><description><b>IPv6Gateway</b>: IPv6 gateway.</description></item>
            /// <item><description><b>NatGateway</b>: NAT gateway.</description></item>
            /// <item><description><b>Attachment</b>: transit router.</description></item>
            /// <item><description><b>VpcPeer</b>: VPC peering connection.</description></item>
            /// <item><description><b>Ipv4Gateway</b>: IPv4 gateway.</description></item>
            /// <item><description><b>GatewayEndpoint</b>: gateway endpoint.</description></item>
            /// <item><description><b>CenBasic</b>: CEN does not support transfer routers.</description></item>
            /// <item><description><b>Ecr</b>: Express Connect Router (ECR).</description></item>
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
            /// <para>The ID of the route table to which you want to add custom route s. You can specify at most 50 route table IDs.</para>
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
