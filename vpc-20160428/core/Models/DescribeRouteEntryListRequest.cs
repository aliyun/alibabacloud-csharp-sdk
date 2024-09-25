// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteEntryListRequest : TeaModel {
        /// <summary>
        /// <para>The destination CIDR blocks of the routes.</para>
        /// </summary>
        [NameInMap("DestCidrBlockList")]
        [Validation(Required=false)]
        public List<string> DestCidrBlockList { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the route. IPv4 and IPv6 CIDR blocks are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.2.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b></description></item>
        /// <item><description><b>IPv6</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// <para>The ID of the next hop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp10zyaph5cc8b7c7****</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The next hop type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: an Elastic Compute Service (ECS) instance. This is the default value.</description></item>
        /// <item><description><b>HaVip</b>: a high-availability virtual IP address (HAVIP).</description></item>
        /// <item><description><b>VpnGateway</b>: a VPN gateway.</description></item>
        /// <item><description><b>NatGateway</b>: a NAT gateway.</description></item>
        /// <item><description><b>NetworkInterface</b>: a secondary elastic network interface (ENI).</description></item>
        /// <item><description><b>RouterInterface</b>: a router interface.</description></item>
        /// <item><description><b>IPv6Gateway</b>: an IPv6 gateway.</description></item>
        /// <item><description><b>Attachment</b>: a transit router.</description></item>
        /// <item><description><b>Ipv4Gateway</b>: an IPv4 gateway.</description></item>
        /// <item><description><b>GatewayEndpoint</b>: a gateway endpoint.</description></item>
        /// <item><description><b>CenBasic</b>: CEN does not support transit routers.</description></item>
        /// <item><description><b>Ecr</b>: Express Connect Router (ECR).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The ID of the route that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rte-bp1mnnr2al0naomnp****</para>
        /// </summary>
        [NameInMap("RouteEntryId")]
        [Validation(Required=false)]
        public string RouteEntryId { get; set; }

        /// <summary>
        /// <para>The name of the route entry.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// <para>The route type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Custom</b>: custom routes.</description></item>
        /// <item><description><b>System</b>: system routes.</description></item>
        /// <item><description><b>BGP</b>: BGP routes.</description></item>
        /// <item><description><b>CEN</b>: Cloud Enterprise Network (CEN) routes.</description></item>
        /// <item><description><b>ECR</b>: Express Connect Router (ECR) routes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("RouteEntryType")]
        [Validation(Required=false)]
        public string RouteEntryType { get; set; }

        /// <summary>
        /// <para>The ID of the route table that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1r9pvl4xen8s9ju****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>Specifies whether to host the route. If the parameter is empty, the route is not hosted.</para>
        /// <para>Set the value to <b>TR</b>, which specifies that the route is hosted by a transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TR</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
