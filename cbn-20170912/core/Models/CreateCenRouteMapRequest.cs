// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenRouteMapRequest : TeaModel {
        /// <summary>
        /// <para>The match method that is used to match routes based on the AS path. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Include</b>: fuzzy match. A route is a match if the AS path of the route overlaps with the AS path in the match conditions.</description></item>
        /// <item><description><b>Complete</b>: exact match. A route is a match only if the AS path of the route matches the AS path in the match conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("AsPathMatchMode")]
        [Validation(Required=false)]
        public string AsPathMatchMode { get; set; }

        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jmc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the routing policy is applied.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CenRegionId")]
        [Validation(Required=false)]
        public string CenRegionId { get; set; }

        /// <summary>
        /// <para>The match method that is used to match routes against the prefix list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Include</b>: fuzzy match. A route is a match if the route prefix is included in the match conditions.</description></item>
        /// </list>
        /// <para>For example, if you set the match condition to 1.1.0.0/16 and fuzzy match is applied, the route whose prefix is 1.1.1.0/24 meets the match condition.</para>
        /// <list type="bullet">
        /// <item><description><b>Complete</b>: exact match. A route is a match only if the route prefix is the same as the prefix specified in the match condition.</description></item>
        /// </list>
        /// <para>For example, if you set the match condition to 1.1.0.0/16 and exact match is applied, only the route whose prefix is 1.1.0.0/16 meets the match condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("CidrMatchMode")]
        [Validation(Required=false)]
        public string CidrMatchMode { get; set; }

        /// <summary>
        /// <para>The match method that is used to match routes based on the community. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Include</b>: fuzzy match. A route is a match if the community of the route overlaps with the community in the match conditions.</description></item>
        /// <item><description><b>Complete</b>: exact match. A route is a match only if the community of the route matches the community in the match conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("CommunityMatchMode")]
        [Validation(Required=false)]
        public string CommunityMatchMode { get; set; }

        /// <summary>
        /// <para>The action to be performed on the community. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Additive</b>: adds the community to the route.</description></item>
        /// <item><description><b>Replace</b>: replaces the original community of the route.</description></item>
        /// </list>
        /// <para>This parameter specifies the action to be performed when a route meets the match condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Additive</para>
        /// </summary>
        [NameInMap("CommunityOperateMode")]
        [Validation(Required=false)]
        public string CommunityOperateMode { get; set; }

        /// <summary>
        /// <para>The description of the routing policy.</para>
        /// <para>This parameter is optional. If you enter a description, it must be 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The types of destination network instance to which the routes belong. The following types of network instances are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: VPC</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: VBR</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: CCN instance</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: IPsec connection</para>
        /// <remarks>
        /// <para>This parameter does not take effect if the IPsec-VPN connection or SSL client is associated with a transit router through a VPN gateway and a VPC. This parameter takes effect only if the IPsec connection is directly connected to the transit router.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>You can specify one or more network instance types.</para>
        /// <remarks>
        /// <para>The destination network instance types are valid only if the routing policy is applied to scenarios where routes are advertised from the gateway in the current region to network instances in the current region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DestinationChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> DestinationChildInstanceTypes { get; set; }

        /// <summary>
        /// <para>The prefix list against which routes are matched.</para>
        /// <para>You must specify the IP addresses in CIDR notation. You can enter at most 32 CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlocks")]
        [Validation(Required=false)]
        public List<string> DestinationCidrBlocks { get; set; }

        /// <summary>
        /// <para>The IDs of the destination network instances to which the routes belong. The following network instance types are supported:</para>
        /// <list type="bullet">
        /// <item><description>VPC</description></item>
        /// <item><description>VBR</description></item>
        /// <item><description>CCN instance</description></item>
        /// <item><description>SAG instance</description></item>
        /// <item><description>The ID of the IPsec-VPN connection.</description></item>
        /// </list>
        /// <para>You can enter at most 32 IDs.</para>
        /// <remarks>
        /// <para>The destination instance IDs take effect only when Direction is set to Export from Regional Gateway and the destination instances are deployed in the current region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-afrfs434465fdf****</para>
        /// </summary>
        [NameInMap("DestinationInstanceIds")]
        [Validation(Required=false)]
        public List<string> DestinationInstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude destination instance IDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): A route is a match if the destination instance ID is included in the list specified by <b>SourceInstanceIds.N</b>.</description></item>
        /// <item><description><b>true</b>: A route is a match if the destination network instance ID is not in the list specified by <b>SourceInstanceIds.N</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DestinationInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? DestinationInstanceIdsReverseMatch { get; set; }

        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public List<string> DestinationRegionIds { get; set; }

        /// <summary>
        /// <para>The IDs of the destination route tables to which routes are evaluated. You can enter at most 32 route table IDs.</para>
        /// <remarks>
        /// <para>The destination route table IDs take effect only when Direction is set to Export from Regional Gateway and the destination route tables belong to network instances deployed in the current region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-adefrgtr144vf****</para>
        /// </summary>
        [NameInMap("DestinationRouteTableIds")]
        [Validation(Required=false)]
        public List<string> DestinationRouteTableIds { get; set; }

        /// <summary>
        /// <para>The action to be performed on a route that meets all the match conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Permit</b>: the route is permitted.</description></item>
        /// <item><description><b>Deny</b>: the route is denied.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Permit</para>
        /// </summary>
        [NameInMap("MapResult")]
        [Validation(Required=false)]
        public string MapResult { get; set; }

        /// <summary>
        /// <para>The type of IP address in the match condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4 address</description></item>
        /// <item><description><b>IPv6</b>: IPv6 address</description></item>
        /// </list>
        /// <para>This parameter can be empty. If no value is specified, all types of IP address are a match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("MatchAddressType")]
        [Validation(Required=false)]
        public string MatchAddressType { get; set; }

        /// <summary>
        /// <para>The AS paths based on which routes are compared.</para>
        /// <para>You can specify at most 32 AS numbers.</para>
        /// <remarks>
        /// <para>Only the AS-SEQUENCE parameter is supported. The AS-SET, AS-CONFED-SEQUENCE, and AS-CONFED-SET parameters are not supported. In other words, only the AS number list is supported. Sets and sub-lists are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65501</para>
        /// </summary>
        [NameInMap("MatchAsns")]
        [Validation(Required=false)]
        public List<long?> MatchAsns { get; set; }

        /// <summary>
        /// <para>The community set based on which routes are compared.</para>
        /// <para>Specify the community in the format of n:m. Valid values of n and m: <b>1</b> to <b>65535</b>. Each community must comply with the RFC 1997 standard. The RFC 8092 standard that defines Border Gateway Protocol (BGP) large communities is not supported.</para>
        /// <para>You can specify at most 32 communities.</para>
        /// <remarks>
        /// <para>If the configurations of the communities are incorrect, routes may fail to be advertised to your data center.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65501:1</para>
        /// </summary>
        [NameInMap("MatchCommunitySet")]
        [Validation(Required=false)]
        public List<string> MatchCommunitySet { get; set; }

        /// <summary>
        /// <para>The priority of the routing policy that you want to associate with the current one.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when the <b>MapResult</b> parameter is set to <b>Permit</b>. This way, the permitted route is matched against the next routing policy.</description></item>
        /// <item><description>The region and direction of the routing policy to be associated must be the same as those of the current routing policy.</description></item>
        /// <item><description>The priority of the next routing policy must be lower than the priority of the current routing policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("NextPriority")]
        [Validation(Required=false)]
        public int? NextPriority { get; set; }

        /// <summary>
        /// <para>The community set on which actions are performed.</para>
        /// <para>Specify the community in the format of n:m. Valid values of n and m: <b>1</b> to <b>65535</b>. Each community must comply with RFC 1997. The RFC 8092 standard that defines BGP large communities is not supported.</para>
        /// <para>You can specify at most 32 communities.</para>
        /// <remarks>
        /// <para>If the configurations of the communities are incorrect, routes may fail to be advertised to your data center.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65501:1</para>
        /// </summary>
        [NameInMap("OperateCommunitySet")]
        [Validation(Required=false)]
        public List<string> OperateCommunitySet { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The new priority of the route.</para>
        /// <para>Valid values: <b>1</b> to <b>100</b>. The default priority is <b>50</b>. A smaller value indicates a higher priority.</para>
        /// <para>This parameter specifies the action to be performed when a route meets the match condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Preference")]
        [Validation(Required=false)]
        public int? Preference { get; set; }

        /// <summary>
        /// <para>The AS paths that are prepended by using an action statement when regional gateways receive or advertise routes.</para>
        /// <para>The AS paths vary based on the direction in which the routing policy is applied:</para>
        /// <list type="bullet">
        /// <item><description>If AS paths are prepended to a routing policy that is applied in the inbound direction, you must specify source network instance IDs and the source region in the match condition. In addition, the source region must be the same as the region where the routing policy is applied.</description></item>
        /// <item><description>If AS paths are prepended to a routing policy that is applied in the outbound direction, you must specify destination network instance IDs in the match condition.</description></item>
        /// </list>
        /// <para>This parameter specifies the action to be performed when a route meets the match condition. You can specify at most 32 AS numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65501</para>
        /// </summary>
        [NameInMap("PrependAsPath")]
        [Validation(Required=false)]
        public List<long?> PrependAsPath { get; set; }

        /// <summary>
        /// <para>The priority of the routing policy. Valid values: <b>1</b> to <b>100</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>You cannot specify the same priority for routing policies that apply in the same region and direction. The system matches routes against the match conditions of routing policies in descending order of priority. A smaller value indicates a higher priority. You must set the priorities to proper values.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of route to be compared. Valid values: The following route types are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>System</b>: system routes that are automatically generated by the system.</description></item>
        /// <item><description><b>Custom</b>: custom routes that are manually added.</description></item>
        /// <item><description><b>BGP</b>: routes that are advertised over BGP.</description></item>
        /// </list>
        /// <para>You can specify multiple route types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("RouteTypes")]
        [Validation(Required=false)]
        public List<string> RouteTypes { get; set; }

        /// <summary>
        /// <para>The types of source network instance to which the routes belong. The following types of network instances are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: VPC</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: VBR</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: CCN instance</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: VPN gateway or IPsec connection</para>
        /// <list type="bullet">
        /// <item><description>If the IPsec-VPN connection or SSL client is associated with a VPN gateway, the VPC associated with the VPN gateway must be connected to a transit router, and the VPN gateway must use BGP dynamic routing. Otherwise, this parameter cannot take effect.</description></item>
        /// <item><description>This parameter takes effect if the IPsec connection is directly connected to a transit router.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>You can specify one or more network instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("SourceChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> SourceChildInstanceTypes { get; set; }

        /// <summary>
        /// <para>The IDs of the source network instances to which the routes belong. The following network instance types are supported:</para>
        /// <list type="bullet">
        /// <item><description>Virtual private cloud (VPC)</description></item>
        /// <item><description>Virtual border router (VBR)</description></item>
        /// <item><description>Cloud Connect Network (CCN) instance</description></item>
        /// <item><description>Smart Access Gateway (SAG) instance</description></item>
        /// <item><description>The ID of the IPsec-VPN connection.</description></item>
        /// </list>
        /// <para>You can enter at most 32 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-adeg3544fdf34vf****</para>
        /// </summary>
        [NameInMap("SourceInstanceIds")]
        [Validation(Required=false)]
        public List<string> SourceInstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude source instance IDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): A route is a match if the source instance ID is included in the list specified by <b>SourceInstanceIds.N</b>.</description></item>
        /// <item><description><b>true</b>: A route is a match if the source network instance ID is not in the list specified by <b>SourceInstanceIds.N</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? SourceInstanceIdsReverseMatch { get; set; }

        /// <summary>
        /// <para>The IDs of the source regions from which routes are evaluated. You can enter at most 32 region IDs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegionIds")]
        [Validation(Required=false)]
        public List<string> SourceRegionIds { get; set; }

        /// <summary>
        /// <para>The IDs of the source route tables from which routes are evaluated. You can enter at most 32 route table IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-adfr233vf34rvd4****</para>
        /// </summary>
        [NameInMap("SourceRouteTableIds")]
        [Validation(Required=false)]
        public List<string> SourceRouteTableIds { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the transit router.</para>
        /// <para>If you do not specify a route table ID, the routing policy is automatically associated with the default route table of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-gw8nx3515m1mbd1z1****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

        /// <summary>
        /// <para>The direction in which the routing policy is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RegionIn</b>: Routes are advertised to the gateways in the regions that are connected by the CEN instance.</description></item>
        /// </list>
        /// <para>For example, routes are advertised from network instances deployed in the current region or other regions to the gateway deployed in the current region.</para>
        /// <list type="bullet">
        /// <item><description><b>RegionOut</b>: Routes are advertised from the gateways in the regions that are connected by the CEN instance.</description></item>
        /// </list>
        /// <para>For example, routes are advertised from the gateway deployed in the current region to network instances deployed in the same region, or to gateways deployed in other regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegionIn</para>
        /// </summary>
        [NameInMap("TransmitDirection")]
        [Validation(Required=false)]
        public string TransmitDirection { get; set; }

    }

}
