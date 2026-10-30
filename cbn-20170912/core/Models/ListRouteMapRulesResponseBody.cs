// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListRouteMapRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is available.</description></item>
        /// <item><description>If <b>NextToken</b> has a return value, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF44D7B7-6248-5A60-8A4C-A92388605A57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of route map rules.</para>
        /// </summary>
        [NameInMap("RouteMapRules")]
        [Validation(Required=false)]
        public List<ListRouteMapRulesResponseBodyRouteMapRules> RouteMapRules { get; set; }
        public class ListRouteMapRulesResponseBodyRouteMapRules : TeaModel {
            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Matches production prefixes from on-prem and sets a higher local preference.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The match conditions of the route map rule. The system executes the actions defined in <b>SetActions</b> only when a route meets all the match conditions defined in this parameter.</para>
            /// </summary>
            [NameInMap("MatchConditions")]
            [Validation(Required=false)]
            public ListRouteMapRulesResponseBodyRouteMapRulesMatchConditions MatchConditions { get; set; }
            public class ListRouteMapRulesResponseBodyRouteMapRulesMatchConditions : TeaModel {
                /// <summary>
                /// <para>The route prefix list for fuzzy matching.</para>
                /// <para>A match succeeds if the route prefix in the match condition contains the route prefix of the matched route.</para>
                /// <para>For example, a policy defined with 10.0.0.0/8 can fuzzy match a route with 10.10.10.0/24.</para>
                /// <para>IP address ranges use the CIDR format. Both IPv4 and IPv6 are supported.</para>
                /// <para>This parameter and <b>AddressPrefixesMatch</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// </summary>
                [NameInMap("AddressPrefixesInclude")]
                [Validation(Required=false)]
                public List<string> AddressPrefixesInclude { get; set; }

                /// <summary>
                /// <para>The route prefix list for exact matching.</para>
                /// <para>A match succeeds only when the route prefix in the match condition is exactly the same as the route prefix of the matched route.</para>
                /// <para>For example, a policy defined with 10.0.0.0/8 can only exactly match a route with 10.0.0.0/8.</para>
                /// <para>IP address ranges use the CIDR format. Both IPv4 and IPv6 are supported.</para>
                /// <para>This parameter and <b>AddressPrefixesInclude</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// </summary>
                [NameInMap("AddressPrefixesMatch")]
                [Validation(Required=false)]
                public List<string> AddressPrefixesMatch { get; set; }

                /// <summary>
                /// <para>The list of AS paths for fuzzy matching.</para>
                /// <para>A match succeeds if the AS path in the match condition overlaps with the AS path of the matched route.</para>
                /// <para>This parameter and <b>AsPathsMatch</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <remarks>
                /// <para>Only AS SEQUENCE is supported. AS SET, AS CONFED SEQUENCE, and AS CONFED SET are not supported. This means only a list of AS numbers is supported, and sets and sub-lists are not supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AsPathsInclude")]
                [Validation(Required=false)]
                public List<long?> AsPathsInclude { get; set; }

                /// <summary>
                /// <para>The list of AS paths for exact matching.</para>
                /// <para>A match succeeds only when the AS path in the match condition is exactly the same as the AS path of the matched route.</para>
                /// <para>This parameter and <b>AsPathsInclude</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <remarks>
                /// <para>Only AS SEQUENCE is supported. AS SET, AS CONFED SEQUENCE, and AS CONFED SET are not supported. This means only a list of AS numbers is supported, and sets and sub-lists are not supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AsPathsMatch")]
                [Validation(Required=false)]
                public List<long?> AsPathsMatch { get; set; }

                /// <summary>
                /// <para>The community set for fuzzy matching.</para>
                /// <para>A match succeeds if the community in the match condition overlaps with the community of the matched route.</para>
                /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
                /// <para>This parameter and <b>CommunitySetMatch</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <remarks>
                /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CommunitySetInclude")]
                [Validation(Required=false)]
                public List<string> CommunitySetInclude { get; set; }

                /// <summary>
                /// <para>The community set for exact matching.</para>
                /// <para>A match succeeds only when the community in the match condition is exactly the same as the community of the matched route.</para>
                /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
                /// <para>This parameter and <b>CommunitySetInclude</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <remarks>
                /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CommunitySetMatch")]
                [Validation(Required=false)]
                public List<string> CommunitySetMatch { get; set; }

                /// <summary>
                /// <para>The list of destination instance IDs to match. The following instance types are supported:</para>
                /// <list type="bullet">
                /// <item><description>Virtual private cloud (VPC) instance IDs</description></item>
                /// <item><description>Virtual border router (VBR) instance IDs</description></item>
                /// </list>
                /// <remarks>
                /// <para>The list of destination instance IDs takes effect only when the direction of the route map is outbound.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DestinationInstanceIds")]
                [Validation(Required=false)]
                public List<string> DestinationInstanceIds { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the exclude matching mode for the list of destination instance IDs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b> (default): no. A match succeeds when the destination instance ID of the route is in <b>DestinationInstanceIds.N</b>.</description></item>
                /// <item><description><b>true</b>: yes. A match succeeds when the destination instance ID of the route is not in <b>DestinationInstanceIds.N</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DestinationInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? DestinationInstanceIdsReverseMatch { get; set; }

                /// <summary>
                /// <para>The list of destination instance types to match. The following instance types are supported:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: VPC instance.</description></item>
                /// <item><description><b>VBR</b>: VBR instance.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The list of destination instance types takes effect only when the direction of the route map is outbound.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DestinationInstanceTypes")]
                [Validation(Required=false)]
                public List<string> DestinationInstanceTypes { get; set; }

                /// <summary>
                /// <para>The list of destination region IDs to match.</para>
                /// </summary>
                [NameInMap("DestinationRegionIds")]
                [Validation(Required=false)]
                public List<string> DestinationRegionIds { get; set; }

                /// <summary>
                /// <para>The list of destination route table IDs to match.</para>
                /// <remarks>
                /// <para>The list of destination route table IDs takes effect only when the direction of the route map is outbound.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DestinationRouteTableIds")]
                [Validation(Required=false)]
                public List<string> DestinationRouteTableIds { get; set; }

                /// <summary>
                /// <para>The IP address type to match. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>IPv4</b>: matches only IPv4 routes.</description></item>
                /// <item><description><b>IPv6</b>: matches only IPv6 routes.</description></item>
                /// </list>
                /// <para>You can leave this parameter empty to match routes of all types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("MatchAddressType")]
                [Validation(Required=false)]
                public string MatchAddressType { get; set; }

                /// <summary>
                /// <para>The list of route types to match. The following route types are supported:</para>
                /// <list type="bullet">
                /// <item><description><b>System</b>: system route, which is automatically generated by the system.</description></item>
                /// <item><description><b>Custom</b>: custom route, which is manually added by a user.</description></item>
                /// <item><description><b>BGP</b>: BGP route, which is propagated through the BGP routable protocol.</description></item>
                /// </list>
                /// <para>You can specify multiple route types.</para>
                /// </summary>
                [NameInMap("RouteTypes")]
                [Validation(Required=false)]
                public List<string> RouteTypes { get; set; }

                /// <summary>
                /// <para>The list of source instance IDs to match. The following instance types are supported:</para>
                /// <list type="bullet">
                /// <item><description>Virtual private cloud (VPC) instance IDs</description></item>
                /// <item><description>Virtual border router (VBR) instance IDs</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SourceInstanceIds")]
                [Validation(Required=false)]
                public List<string> SourceInstanceIds { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the exclude matching mode for the list of source instance IDs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b> (default): no. A match succeeds when the source instance ID of the route is in <b>SourceInstanceIds.N</b>.</description></item>
                /// <item><description><b>true</b>: yes. A match succeeds when the source instance ID of the route is not in <b>SourceInstanceIds.N</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SourceInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? SourceInstanceIdsReverseMatch { get; set; }

                /// <summary>
                /// <para>The list of source instance types to match. The following instance types are supported:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: VPC instance.</description></item>
                /// <item><description><b>VBR</b>: VBR instance.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SourceInstanceTypes")]
                [Validation(Required=false)]
                public List<string> SourceInstanceTypes { get; set; }

                /// <summary>
                /// <para>The list of source region IDs to match.</para>
                /// </summary>
                [NameInMap("SourceRegionIds")]
                [Validation(Required=false)]
                public List<string> SourceRegionIds { get; set; }

                /// <summary>
                /// <para>The list of source route table IDs to match.</para>
                /// </summary>
                [NameInMap("SourceRouteTableIds")]
                [Validation(Required=false)]
                public List<string> SourceRouteTableIds { get; set; }

            }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Permit-Prod-Prefixes-Set-LP</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The priority of the rule. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the route map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-0a1b2c3d4e5f6a7b8</para>
            /// </summary>
            [NameInMap("RouteMapId")]
            [Validation(Required=false)]
            public string RouteMapId { get; set; }

            /// <summary>
            /// <para>The ID of the route map rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmr-3dm13f66wtctcnydup</para>
            /// </summary>
            [NameInMap("RouteMapRuleId")]
            [Validation(Required=false)]
            public string RouteMapRuleId { get; set; }

            /// <summary>
            /// <para>The actions to execute for the route map rule. After a route meets all the match conditions defined in <b>MatchConditions</b>, the system processes the route based on the actions defined in this parameter.</para>
            /// </summary>
            [NameInMap("SetActions")]
            [Validation(Required=false)]
            public ListRouteMapRulesResponseBodyRouteMapRulesSetActions SetActions { get; set; }
            public class ListRouteMapRulesResponseBodyRouteMapRulesSetActions : TeaModel {
                /// <summary>
                /// <para>The AS path to prepend when the regional gateway receives or advertises routes.</para>
                /// <para>This parameter and <b>AsPathReplace</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <para>This parameter specifies the action to execute after a route meets the match conditions.</para>
                /// </summary>
                [NameInMap("AsPathPrepend")]
                [Validation(Required=false)]
                public List<long?> AsPathPrepend { get; set; }

                /// <summary>
                /// <para>The AS path to replace when the regional gateway receives or advertises routes. The original AS path of the route is replaced with the list of AS numbers specified in this parameter.</para>
                /// <para>This parameter and <b>AsPathPrepend</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <para>This parameter specifies the action to execute after a route meets the match conditions.</para>
                /// </summary>
                [NameInMap("AsPathReplace")]
                [Validation(Required=false)]
                public List<long?> AsPathReplace { get; set; }

                /// <summary>
                /// <para>The community set to add to the route.</para>
                /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
                /// <para>This parameter and <b>CommunityReplace</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <para>This parameter specifies the action to execute after a route meets the match conditions.</para>
                /// <remarks>
                /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CommunityAdd")]
                [Validation(Required=false)]
                public List<string> CommunityAdd { get; set; }

                /// <summary>
                /// <para>The community set to replace the original community of the route.</para>
                /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
                /// <para>This parameter and <b>CommunityAdd</b> are mutually exclusive and cannot be specified at the same time.</para>
                /// <para>This parameter specifies the action to execute after a route meets the match conditions.</para>
                /// <remarks>
                /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CommunityReplace")]
                [Validation(Required=false)]
                public List<string> CommunityReplace { get; set; }

                /// <summary>
                /// <para>Policy priority of the associated next route map rule.</para>
                /// <list type="bullet">
                /// <item><description>You can set policy priority of the associated route map rule only when <b>RouteAction</b> is set to <b>Permit</b>. Only the permitted routes continue to match the associated next route map rule.</description></item>
                /// <item><description>Policy priority of the associated next route map rule must be lower than policy priority of the current route map rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NextPriority")]
                [Validation(Required=false)]
                public long? NextPriority { get; set; }

                /// <summary>
                /// <para>The policy action after all conditions are met. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Permit</b>: permits the matched routes.</description></item>
                /// <item><description><b>Deny</b>: denies the matched routes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Permit</para>
                /// </summary>
                [NameInMap("RouteAction")]
                [Validation(Required=false)]
                public string RouteAction { get; set; }

            }

            /// <summary>
            /// <para>The status of the route map rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The rule is being created.</description></item>
            /// <item><description><b>Updating</b>: The rule is being updated.</description></item>
            /// <item><description><b>Active</b>: The rule is available.</description></item>
            /// <item><description><b>Deleting</b>: The rule is being deleted.</description></item>
            /// <item><description><b>Deleted</b>: The rule is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
