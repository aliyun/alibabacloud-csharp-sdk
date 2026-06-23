// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteEntryListRequest : TeaModel {
        /// <summary>
        /// <para>The list of destination CIDR blocks of route entries.</para>
        /// </summary>
        [NameInMap("DestCidrBlockList")]
        [Validation(Required=false)]
        public List<string> DestCidrBlockList { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the route entry. Both IPv4 and IPv6 CIDR blocks are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.2.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The version of the IP protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ipv4</b>: IPv4 protocol.</para>
        /// </description></item>
        /// <item><description><para><b>ipv6</b>: IPv6 protocol.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page during a paged query. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// <para>The ID of the next hop instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp10zyaph5cc8b7c7****</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The type of the next hop. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b> (default): ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>HaVip</b>: high-availability virtual IP address (HAVIP).</para>
        /// </description></item>
        /// <item><description><para><b>VpnGateway</b>: VPN gateway.</para>
        /// </description></item>
        /// <item><description><para><b>NatGateway</b>: NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: secondary elastic network interface.</para>
        /// </description></item>
        /// <item><description><para><b>RouterInterface</b>: router interface.</para>
        /// </description></item>
        /// <item><description><para><b>IPv6Gateway</b>: IPv6 gateway.</para>
        /// </description></item>
        /// <item><description><para><b>Attachment</b>: transit router.</para>
        /// </description></item>
        /// <item><description><para><b>Ipv4Gateway</b>: IPv4 gateway.</para>
        /// </description></item>
        /// <item><description><para><b>GatewayEndpoint</b>: gateway endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>Ecr</b>: Express Connect Router.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        /// <summary>
        /// <para>Specifies whether a next query token (Token) exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first query or if no next query exists.</description></item>
        /// <item><description>If a next query exists, set the value to the NextToken value returned from the previous API call.</description></item>
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
        /// <para>The region ID of the route table to which the route entry belongs.</para>
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
        /// <para>The ID of the route entry to query.</para>
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
        /// <para>The type of the route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Custom</b>: custom route.</description></item>
        /// <item><description><b>System</b>: system route.</description></item>
        /// <item><description><b>BGP</b>: BGP route.</description></item>
        /// <item><description><b>CEN</b>: Cloud Enterprise Network (CEN) route.</description></item>
        /// <item><description><b>ECR</b>: Express Connect Router route.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("RouteEntryType")]
        [Validation(Required=false)]
        public string RouteEntryType { get; set; }

        /// <summary>
        /// <para>The ID of the route table to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1r9pvl4xen8s9ju****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>The type of route service. If this field is empty, it indicates that the route is not managed.</para>
        /// <para>Valid value: <b>TR</b>, which indicates that the managed type is transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TR</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
