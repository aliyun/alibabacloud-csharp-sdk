// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyCenRouteMapRequest : TeaModel {
        /// <summary>
        /// <para>The match mode of the AS path list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Include</b>: fuzzy match. A match is successful if the AS path in the match condition overlaps with the AS path of the route to be matched. </para>
        /// </description></item>
        /// <item><description><para><b>Complete</b>: exact match. A match is successful only if the AS path in the match condition is the same as the AS path of the route to be matched.</para>
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
        /// <para>The instance ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jmc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the routing policy is applied.</para>
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
        /// <item><description><b>Include</b>: fuzzy match. A match is successful if the route prefix in the match condition contains the route prefix of the route to be matched.</description></item>
        /// </list>
        /// <para> For example, a policy that defines 10.10.0.0/16 can fuzzy match the route 10.10.1.0/24.</para>
        /// <list type="bullet">
        /// <item><description><b>Complete</b>: exact match. A match is successful only if the route prefix in the match condition is the same as the route prefix of the route to be matched.</description></item>
        /// </list>
        /// <para> For example, a policy that defines 10.10.0.0/16 can exact match only the route 10.10.0.0/16.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Include</para>
        /// </summary>
        [NameInMap("CidrMatchMode")]
        [Validation(Required=false)]
        public string CidrMatchMode { get; set; }

        /// <summary>
        /// <para>The match mode of the Community. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Include</b>: fuzzy match. A match is successful if the Community in the match condition overlaps with the Community of the route to be matched. </para>
        /// </description></item>
        /// <item><description><para><b>Complete</b>: exact match. A match is successful only if the Community in the match condition is the same as the Community of the route to be matched.</para>
        /// </description></item>
        /// <item><description><para><b>Contain</b>: contains match. A match is successful only if the Community of the route to be matched contains all the Communities specified in the match condition.</para>
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
        /// <para>The action to perform on the Community. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Additive</b>: adds the Community to the route.</para>
        /// </description></item>
        /// <item><description><para><b>Replace</b>: replaces the original Community of the route.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter specifies the action to perform on a route after the route matches the match conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Additive</para>
        /// </summary>
        [NameInMap("CommunityOperateMode")]
        [Validation(Required=false)]
        public string CommunityOperateMode { get; set; }

        /// <summary>
        /// <para>The description of the routing policy.</para>
        /// <para>The description can be empty or 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of destination instance types that the route must match. The following instance types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: VPC instance.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: VBR instance.</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: CCN instance.</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: IPsec connection.</para>
        /// <remarks>
        /// <para>If the IPsec connection or SSL server is bound to a VPN gateway instance and is connected to a transit router instance through the VPC associated with the VPN gateway instance, this parameter does not take effect. This parameter takes effect only when the IPsec connection is directly bound to a transit router instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>The destination instance type list takes effect only when the direction of the routing policy is Export from Regional Gateway and the destination instance types are instance types in the local region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DestinationChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> DestinationChildInstanceTypes { get; set; }

        /// <summary>
        /// <para>The prefix list that the route must match.</para>
        /// <para>IP address ranges in the prefix list are in CIDR format. A maximum of 64 IP address ranges can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlocks")]
        [Validation(Required=false)]
        public List<string> DestinationCidrBlocks { get; set; }

        /// <summary>
        /// <para>The list of destination instance IDs that the route must match. The following types of instance IDs are supported:</para>
        /// <list type="bullet">
        /// <item><description>Virtual Private Cloud (VPC) instance ID</description></item>
        /// <item><description>Virtual Border Router (VBR) instance ID</description></item>
        /// <item><description>Cloud Connect Network (CCN) instance ID</description></item>
        /// <item><description>Smart Access Gateway instance ID</description></item>
        /// <item><description>IPsec connection ID</description></item>
        /// </list>
        /// <para>A maximum of 64 instance IDs can be specified.</para>
        /// <remarks>
        /// <para>The destination instance ID list takes effect only when the direction of the routing policy is Export from Regional Gateway and the destination instance IDs are in the local region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-avcdsg34ds****</para>
        /// </summary>
        [NameInMap("DestinationInstanceIds")]
        [Validation(Required=false)]
        public List<string> DestinationInstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the reverse match mode for the destination instance ID list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): No. A match is successful if the destination instance ID of the route is in <b>DestinationInstanceIds.N</b>.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes. A match is successful if the destination instance ID of the route is not in <b>DestinationInstanceIds.N</b>.</para>
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
        /// <para>The list of destination region IDs that the route must match. A maximum of 64 region IDs can be specified.</para>
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public List<string> DestinationRegionIds { get; set; }

        /// <summary>
        /// <para>The list of destination route table IDs that the route must match. A maximum of 64 route table IDs can be specified.</para>
        /// <remarks>
        /// <para>The destination route table ID list takes effect only when the direction of the routing policy is Export from Regional Gateway and the destination route table IDs are route table IDs of network instances in the local region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-adfg53c322v****</para>
        /// </summary>
        [NameInMap("DestinationRouteTableIds")]
        [Validation(Required=false)]
        public List<string> DestinationRouteTableIds { get; set; }

        /// <summary>
        /// <para>The action to perform on a route that matches all the match conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Permit</b>: The route is permitted to pass.</para>
        /// </description></item>
        /// <item><description><para><b>Deny</b>: The route is denied from passing.</para>
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
        /// <para>The IP address type that the route must match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: matches only IPv4 routes.</description></item>
        /// <item><description><b>IPv6</b>: matches only IPv6 routes.</description></item>
        /// </list>
        /// <para>This parameter can be left empty, which indicates that all types of routes are matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("MatchAddressType")]
        [Validation(Required=false)]
        public string MatchAddressType { get; set; }

        /// <summary>
        /// <para>The AS path list that the route must match.</para>
        /// <remarks>
        /// <para>Only AS SEQUENCE is supported. AS SET, AS CONFED SEQUENCE, and AS CONFED SET are not supported. Specifically, only AS number lists are supported. Sets and sublists are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65501</para>
        /// </summary>
        [NameInMap("MatchAsns")]
        [Validation(Required=false)]
        public List<int?> MatchAsns { get; set; }

        /// <summary>
        /// <para>The Community set that the route must match.</para>
        /// <para>Each Community is in the n:m format, where the value ranges of n and m are <b>1</b> to <b>65535</b>. Communities must comply with RFC 1997. Large Communities (RFC 8092) are not supported.</para>
        /// <para>A maximum of 64 Communities can be specified.</para>
        /// <remarks>
        /// <para>Incorrect Community configurations may cause routes to fail to be advertised to on-premises data centers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65501:1</para>
        /// </summary>
        [NameInMap("MatchCommunitySet")]
        [Validation(Required=false)]
        public List<string> MatchCommunitySet { get; set; }

        /// <summary>
        /// <para>Policy priority of the next associated routing policy.</para>
        /// <list type="bullet">
        /// <item><description>You can set policy priority of the next associated routing policy only when <b>MapResult</b> is set to <b>Permit</b>. Only routes that are permitted to pass continue to match the next associated routing policy.</description></item>
        /// <item><description>The next associated routing policy must have the same region and direction as the current routing policy.</description></item>
        /// <item><description>Policy priority of the next associated routing policy must be lower than (a number greater than) policy priority of the current routing policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("NextPriority")]
        [Validation(Required=false)]
        public int? NextPriority { get; set; }

        /// <summary>
        /// <para>The Community set to be executed.</para>
        /// <para>Each Community is in the n:m format, where the value ranges of n and m are <b>1</b> to <b>65535</b>. Communities must comply with RFC 1997. Large Communities (RFC 8092) are not supported.</para>
        /// <para>A maximum of 32 Communities can be specified.</para>
        /// <remarks>
        /// <para>Incorrect Community configurations may cause routes to fail to be advertised to on-premises data centers.</para>
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
        /// <para>This parameter specifies the action to perform on a route after the route matches the match conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Preference")]
        [Validation(Required=false)]
        public int? Preference { get; set; }

        /// <summary>
        /// <para>The AS path that is prepended when the regional gateway receives or publishes route entries.</para>
        /// <para>The requirements for configuring the prepended AS path vary based on the direction of the routing policy:</para>
        /// <list type="bullet">
        /// <item><description><para>When configuring the prepended AS path for the Import to Regional Gateway direction, you must configure the source instance ID list and source region in the match conditions, and the source region must be the same as the region where the routing policy is applied.</para>
        /// </description></item>
        /// <item><description><para>When configuring the prepended AS path for the Export from Regional Gateway direction, you must configure the destination instance ID list in the match conditions.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter specifies the action to execute on a route after the route matches the match conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65501</para>
        /// </summary>
        [NameInMap("PrependAsPath")]
        [Validation(Required=false)]
        public List<long?> PrependAsPath { get; set; }

        /// <summary>
        /// <para>Policy priority of the routing policy. Valid values: <b>1</b> to <b>100</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>Policy priority of routing policies in the same region and with the same direction must be unique. When the system executes routing policies, it starts matching conditional statements from the routing policy with the smallest priority number. Specify policy priority based on the expected matching order.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>The ID of the routing policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cenrmap-abcdedfghij****</para>
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        /// <summary>
        /// <para>The list of routing types that the route must match. The following routing types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>System</b>: system routes that are automatically generated by the system.</para>
        /// </description></item>
        /// <item><description><para><b>Custom</b>: custom routes that are manually added by users.</para>
        /// </description></item>
        /// <item><description><para><b>BGP</b>: BGP routes that are propagated through the BGP routing protocol.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("RouteTypes")]
        [Validation(Required=false)]
        public List<string> RouteTypes { get; set; }

        /// <summary>
        /// <para>The list of source instance types that the route must match. The following instance types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: VPC instance.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: border router instance.</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: CCN instance.</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: VPN gateway instance or IPsec connection.</para>
        /// <list type="bullet">
        /// <item><description>If the IPsec connection or SSL server is attached to a VPN gateway instance, the VPC associated with the VPN gateway instance must be connected to a transit router instance, and the VPN gateway instance must run the BGP dynamic routing protocol for this parameter to take effect.</description></item>
        /// <item><description>If the IPsec connection is directly attached to a transit router instance, this parameter takes effect.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("SourceChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> SourceChildInstanceTypes { get; set; }

        /// <summary>
        /// <para>The list of source instance IDs that the route must match. The following types of instance IDs are supported:</para>
        /// <list type="bullet">
        /// <item><description>Virtual Private Cloud (VPC) instance ID</description></item>
        /// <item><description>Virtual Border Router (VBR) instance ID</description></item>
        /// <item><description>Cloud Connect Network (CCN) instance ID</description></item>
        /// <item><description>Smart Access Gateway instance ID</description></item>
        /// <item><description>IPsec connection ID</description></item>
        /// </list>
        /// <para>A maximum of 64 instance IDs can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-afsfdf5435vcvc****</para>
        /// </summary>
        [NameInMap("SourceInstanceIds")]
        [Validation(Required=false)]
        public List<string> SourceInstanceIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the reverse match mode for the source instance ID list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): No. A match is successful if the source instance ID of the route is in <b>SourceInstanceIds.N</b>.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes. A match is successful if the source instance ID of the route is not in <b>SourceInstanceIds.N</b>.</para>
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
        /// <para>The list of source region IDs that the route must match. A maximum of 64 region IDs can be specified.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegionIds")]
        [Validation(Required=false)]
        public List<string> SourceRegionIds { get; set; }

        /// <summary>
        /// <para>The list of source route table IDs that the route must match. A maximum of 64 route table IDs can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-acdbvtbr342cd****</para>
        /// </summary>
        [NameInMap("SourceRouteTableIds")]
        [Validation(Required=false)]
        public List<string> SourceRouteTableIds { get; set; }

    }

}
