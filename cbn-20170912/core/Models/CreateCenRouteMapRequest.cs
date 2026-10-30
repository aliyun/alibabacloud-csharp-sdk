// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenRouteMapRequest : TeaModel {
        /// <summary>
        /// <para>The match mode of the AS path list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Include</b>: fuzzy match. A route meets the match condition if the AS path in the match condition overlaps with the AS path of the route. </para>
        /// </description></item>
        /// <item><description><para><b>Complete</b>: exact match. A route meets the match condition only if the AS path in the match condition is exactly the same as the AS path of the route.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("AsPathMatchMode")]
        [Validation(Required=false)]
        public string AsPathMatchMode { get; set; }

        /// <summary>
        /// <para>The Cloud Enterprise Network (CEN) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jmc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the route map is applied.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CenRegionId")]
        [Validation(Required=false)]
        public string CenRegionId { get; set; }

        /// <summary>
        /// <para>The match mode of the prefix list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Include</b>: fuzzy match. A route meets the match condition if the route prefix in the match condition contains the prefix of the route.</description></item>
        /// </list>
        /// <para> For example, if the match condition is 10.10.0.0/16, a route with the prefix 10.10.1.0/24 meets the condition.</para>
        /// <list type="bullet">
        /// <item><description><b>Complete</b>: exact match. A route meets the match condition only if the route prefix in the match condition is exactly the same as the prefix of the route.</description></item>
        /// </list>
        /// <para> For example, if the match condition is 10.10.0.0/16, only a route with the prefix 10.10.0.0/16 meets the condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("CidrMatchMode")]
        [Validation(Required=false)]
        public string CidrMatchMode { get; set; }

        /// <summary>
        /// <para>The match mode of the community. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Include</b>: fuzzy match. A route meets the match condition if the community in the match condition overlaps with the community of the route. </para>
        /// </description></item>
        /// <item><description><para><b>Complete</b>: exact match. A route meets the match condition only if the community in the match condition is exactly the same as the community of the route.</para>
        /// </description></item>
        /// <item><description><para><b>Contain</b>: contain match. A route meets the match condition only if the community of the route contains all communities specified in the match condition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("CommunityMatchMode")]
        [Validation(Required=false)]
        public string CommunityMatchMode { get; set; }

        /// <summary>
        /// <para>The action mode of the community. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Additive</b>: adds a community to the route.</para>
        /// </description></item>
        /// <item><description><para><b>Replace</b>: replaces the existing community of the route.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter specifies the action to be performed after a route meets the match conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Additive</para>
        /// </summary>
        [NameInMap("CommunityOperateMode")]
        [Validation(Required=false)]
        public string CommunityOperateMode { get; set; }

        /// <summary>
        /// <para>The description of the route map. The description must be 1 to 256 characters in length, and cannot start with http:// or https://. The description can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of destination instance types to be matched. The following instance types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: VPC instance.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: VBR instance.</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: CCN instance.</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: IPsec connection.</para>
        /// <remarks>
        /// <para>If an IPsec connection or SSL server is associated with a VPN gateway instance and connected to a transit router instance through the VPC associated with the VPN gateway instance, this parameter does not take effect. This parameter takes effect only when an IPsec connection is directly associated with a transit router instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>You can enter multiple instance types.</para>
        /// <remarks>
        /// <para>The destination instance type list takes effect only when the application direction of the route map is set to RegionOut and the destination instance types are the types of instances in the local region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DestinationChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> DestinationChildInstanceTypes { get; set; }

        /// <summary>
        /// <para>The prefix list to be matched.</para>
        /// <para>The CIDR blocks in the prefix list must be in CIDR format. You can enter up to 64 CIDR blocks.</para>
        /// <para>Both IPv4 and IPv6 formats are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlocks")]
        [Validation(Required=false)]
        public List<string> DestinationCidrBlocks { get; set; }

        /// <summary>
        /// <para>The list of destination instance IDs to be matched. You can enter the IDs of the following types of instances:</para>
        /// <list type="bullet">
        /// <item><description>Virtual Private Cloud (VPC) instance IDs</description></item>
        /// <item><description>Virtual Border Router (VBR) instance IDs</description></item>
        /// <item><description>Cloud Connect Network (CCN) instance IDs</description></item>
        /// <item><description>Smart Access Gateway (SAG) instance IDs</description></item>
        /// <item><description>IPsec connection IDs</description></item>
        /// </list>
        /// <para>You can enter up to 64 instance IDs.</para>
        /// <remarks>
        /// <para>The destination instance ID list takes effect only when the application direction of the route map is set to RegionOut and the destination instance IDs are the IDs of instances in the local region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-afrfs434465fdf****</para>
        /// </summary>
        [NameInMap("DestinationInstanceIds")]
        [Validation(Required=false)]
        public List<string> DestinationInstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the exclude match mode for the destination instance ID list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): no. A route meets the match condition if the destination instance ID of the route is in <b>DestinationInstanceIds.N</b>.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: yes. A route meets the match condition if the destination instance ID of the route is not in <b>DestinationInstanceIds.N</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DestinationInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? DestinationInstanceIdsReverseMatch { get; set; }

        /// <summary>
        /// <para>The list of destination region IDs to be matched. You can enter up to 64 region IDs.</para>
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public List<string> DestinationRegionIds { get; set; }

        /// <summary>
        /// <para>The list of destination route table IDs to be matched. You can enter up to 64 route table IDs.</para>
        /// <remarks>
        /// <para>The destination route table ID list takes effect only when the application direction of the route map is set to RegionOut and the destination route table IDs are the IDs of route tables of network instances in the local region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-adefrgtr144vf****</para>
        /// </summary>
        [NameInMap("DestinationRouteTableIds")]
        [Validation(Required=false)]
        public List<string> DestinationRouteTableIds { get; set; }

        /// <summary>
        /// <para>The action to be performed when a route meets all match conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permit</b>: permits the matched route.</para>
        /// </description></item>
        /// <item><description><para><b>Deny</b>: denies the matched route.</para>
        /// </description></item>
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
        /// <para>The IP address type of the routes to be matched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: matches only IPv4 routes.</description></item>
        /// <item><description><b>IPv6</b>: matches only IPv6 routes.</description></item>
        /// </list>
        /// <para>If this parameter is left empty, all types of routes are matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("MatchAddressType")]
        [Validation(Required=false)]
        public string MatchAddressType { get; set; }

        /// <summary>
        /// <para>The AS path list to be matched.</para>
        /// <para>You can enter up to 64 AS numbers.</para>
        /// <remarks>
        /// <para>Only AS SEQUENCE is supported. AS SET, AS CONFED SEQUENCE, and AS CONFED SET are not supported. This means only AS number lists are supported, and sets and sub-lists are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65501</para>
        /// </summary>
        [NameInMap("MatchAsns")]
        [Validation(Required=false)]
        public List<long?> MatchAsns { get; set; }

        /// <summary>
        /// <para>The community set to be matched.</para>
        /// <para>Each community must be in the format of n:m, where n and m are integers from <b>1</b> to <b>65535</b>. Communities must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
        /// <para>You can enter up to 64 communities.</para>
        /// <remarks>
        /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65501:1</para>
        /// </summary>
        [NameInMap("MatchCommunitySet")]
        [Validation(Required=false)]
        public List<string> MatchCommunitySet { get; set; }

        /// <summary>
        /// <para>Policy priority of the next route map to be associated.</para>
        /// <list type="bullet">
        /// <item><description>You can set this parameter only when <b>MapResult</b> is set to <b>Permit</b>. Only permitted routes are matched against the next associated route map.</description></item>
        /// <item><description>The next route map to be associated must be applied to the same region and in the same direction as the current route map.</description></item>
        /// <item><description>Policy priority of the next route map to be associated must be lower than that of the current route map.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("NextPriority")]
        [Validation(Required=false)]
        public int? NextPriority { get; set; }

        /// <summary>
        /// <para>The community set to be operated.</para>
        /// <para>Each community must be in the format of n:m, where n and m are integers from <b>1</b> to <b>65535</b>. Communities must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
        /// <para>You can enter up to 32 communities.</para>
        /// <remarks>
        /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
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
        /// <para>The priority of the route to be modified.</para>
        /// <para>Valid values: <b>1</b> to <b>100</b>. The default priority of a route is <b>50</b>. A smaller value indicates a higher priority.</para>
        /// <para>This parameter specifies the action to be performed after a route meets the match conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Preference")]
        [Validation(Required=false)]
        public int? Preference { get; set; }

        /// <summary>
        /// <para>The AS path to be prepended when the regional gateway receives or performs publish route entry.</para>
        /// <para>The requirements for configuring the prepended AS path vary based on the application direction of the policy:</para>
        /// <list type="bullet">
        /// <item><description><para>If the application direction is RegionIn, you must configure the source instance ID list and source region in the match conditions, and the source region must be the same as the region where the policy is applied.</para>
        /// </description></item>
        /// <item><description><para>If the application direction is RegionOut, you must configure the destination instance ID list in the match conditions.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter specifies the action to be executed after routing meets the match conditions. You can enter up to 32 AS numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65501</para>
        /// </summary>
        [NameInMap("PrependAsPath")]
        [Validation(Required=false)]
        public List<long?> PrependAsPath { get; set; }

        /// <summary>
        /// <para>The policy priority of the route map. Valid values: <b>1</b> to <b>100</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>The policy priority of each route map applied to the same region in the same direction must be unique. When the policy is executed, the system matches routing against the conditional statements of the policy with the smallest priority value first. Therefore, specify the policy priority based on the expected match order.</para>
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
        /// <para>The list of route types to be matched. The following route types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>System</b>: system routing, which is automatically generated by the system.</para>
        /// </description></item>
        /// <item><description><para><b>Custom</b>: custom routing, which is manually added by a user.</para>
        /// </description></item>
        /// <item><description><para><b>BGP</b>: BGP routing, which is propagated through the BGP routable protocol.</para>
        /// </description></item>
        /// </list>
        /// <para>You can enter multiple route types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("RouteTypes")]
        [Validation(Required=false)]
        public List<string> RouteTypes { get; set; }

        /// <summary>
        /// <para>The list of source instance types to be matched. The following instance types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: VPC instance.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: border router instance.</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: CCN instance.</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: VPN gateway instance or IPsec connection.</para>
        /// <list type="bullet">
        /// <item><description>If an IPsec connection or SSL server is attached to a VPN gateway instance, the VPC associated with the VPN gateway instance must be connected to a forward router instance, and the VPN gateway instance must run the BGP dynamic routing routable protocol for this parameter to take effect.</description></item>
        /// <item><description>If an IPsec connection is directly attached to a forward router instance, this parameter takes effect.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>You can enter multiple instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("SourceChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> SourceChildInstanceTypes { get; set; }

        /// <summary>
        /// <para>The list of source instance IDs to be matched. You can enter the IDs of the following types of instances:</para>
        /// <list type="bullet">
        /// <item><description>Virtual Private Cloud (VPC) instance IDs</description></item>
        /// <item><description>Virtual Border Router (VBR) instance IDs</description></item>
        /// <item><description>Cloud Connect Network (CCN) instance IDs</description></item>
        /// <item><description>Smart Access Gateway (SAG) instance IDs</description></item>
        /// <item><description>IPsec connection IDs</description></item>
        /// </list>
        /// <para>You can enter up to 64 instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-adeg3544fdf34vf****</para>
        /// </summary>
        [NameInMap("SourceInstanceIds")]
        [Validation(Required=false)]
        public List<string> SourceInstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the exclude match mode for the source instance ID list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): no. A route meets the match condition if the source instance ID of the route is in <b>SourceInstanceIds.N</b>.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: yes. A route meets the match condition if the source instance ID of the route is not in <b>SourceInstanceIds.N</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? SourceInstanceIdsReverseMatch { get; set; }

        /// <summary>
        /// <para>The list of source region IDs to be matched. You can enter up to 64 region IDs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegionIds")]
        [Validation(Required=false)]
        public List<string> SourceRegionIds { get; set; }

        /// <summary>
        /// <para>The list of source route table IDs to be matched. You can enter up to 64 route table IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-adfr233vf34rvd4****</para>
        /// </summary>
        [NameInMap("SourceRouteTableIds")]
        [Validation(Required=false)]
        public List<string> SourceRouteTableIds { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the transit router.</para>
        /// <para>If you do not specify a route table ID, the route map is automatically associated with the default route table of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-gw8nx3515m1mbd1z1****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

        /// <summary>
        /// <para>The application direction of the route map. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RegionIn</b>: the direction in which routes are transmitted to the regional gateway of the CEN instance. For example, routes are advertised from a network instance in a region to the regional gateway in the same region, or routes are advertised from another region to the regional gateway.</para>
        /// </description></item>
        /// <item><description><para><b>RegionOut</b>: the direction in which routes are transmitted from the regional gateway of the CEN instance. For example, routes are advertised from the regional gateway to a network instance in the same region, or to a regional gateway in another region.</para>
        /// </description></item>
        /// </list>
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
