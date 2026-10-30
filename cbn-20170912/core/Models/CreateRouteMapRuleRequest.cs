// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateRouteMapRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the parameter value on your client. Make sure that the token is unique across different requests. The client token supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The detailed description of the rule. The description can be empty or 1 to 256 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Matches production prefixes from on-prem and sets a higher local preference.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Prechecks the request without creating the route map rule. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): Sends the request. After the request passes the precheck, the route map rule is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The match conditions of the route map rule. The system executes the actions defined in <b>SetActions</b> only when a route meets all the match conditions defined in this parameter.</para>
        /// </summary>
        [NameInMap("MatchConditions")]
        [Validation(Required=false)]
        public CreateRouteMapRuleRequestMatchConditions MatchConditions { get; set; }
        public class CreateRouteMapRuleRequestMatchConditions : TeaModel {
            /// <summary>
            /// <para>The route prefix list for fuzzy match. You can specify up to 64 IP address blocks.</para>
            /// <para>A match is successful if the route prefix in the match condition contains the route prefix of the matched route.</para>
            /// <para>For example, a policy defined with 10.0.0.0/8 can fuzzy match a route with 10.10.10.0/24.</para>
            /// <para>IP address blocks use the CIDR format and support IPv4 and IPv6.</para>
            /// <para>This parameter is mutually exclusive with <b>AddressPrefixesMatch</b>. You cannot specify both parameters at the same time.</para>
            /// </summary>
            [NameInMap("AddressPrefixesInclude")]
            [Validation(Required=false)]
            public List<string> AddressPrefixesInclude { get; set; }

            /// <summary>
            /// <para>The route prefix list for exact match. You can specify up to 64 IP address blocks.</para>
            /// <para>A match is successful only if the route prefix in the match condition is exactly the same as the route prefix of the matched route.</para>
            /// <para>For example, a policy defined with 10.0.0.0/8 can only exactly match a route with 10.0.0.0/8.</para>
            /// <para>IP address blocks use the CIDR format and support IPv4 and IPv6.</para>
            /// <para>This parameter is mutually exclusive with <b>AddressPrefixesInclude</b>. You cannot specify both parameters at the same time.</para>
            /// </summary>
            [NameInMap("AddressPrefixesMatch")]
            [Validation(Required=false)]
            public List<string> AddressPrefixesMatch { get; set; }

            /// <summary>
            /// <para>The list of AS paths for fuzzy match. You can specify up to 64 AS numbers.</para>
            /// <para>A match is successful if the AS path in the match condition overlaps with the AS path of the matched route.</para>
            /// <para>This parameter is mutually exclusive with <b>AsPathsMatch</b>. You cannot specify both parameters at the same time.</para>
            /// <remarks>
            /// <para>Only AS SEQUENCE is supported. AS SET, AS CONFED SEQUENCE, and AS CONFED SET are not supported. This means only a list of AS numbers is supported, and sets and sublists are not supported.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AsPathsInclude")]
            [Validation(Required=false)]
            public List<long?> AsPathsInclude { get; set; }

            /// <summary>
            /// <para>The list of AS paths for exact match. You can specify up to 64 AS numbers.</para>
            /// <para>A match is successful only if the AS path in the match condition is exactly the same as the AS path of the matched route.</para>
            /// <para>This parameter is mutually exclusive with <b>AsPathsInclude</b>. You cannot specify both parameters at the same time.</para>
            /// <remarks>
            /// <para>Only AS SEQUENCE is supported. AS SET, AS CONFED SEQUENCE, and AS CONFED SET are not supported. This means only a list of AS numbers is supported, and sets and sublists are not supported.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AsPathsMatch")]
            [Validation(Required=false)]
            public List<long?> AsPathsMatch { get; set; }

            /// <summary>
            /// <para>The community set for fuzzy match. You can specify up to 64 communities.</para>
            /// <para>A match is successful if the community in the match condition overlaps with the community of the matched route.</para>
            /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
            /// <para>This parameter is mutually exclusive with <b>CommunitySetMatch</b>. You cannot specify both parameters at the same time.</para>
            /// <remarks>
            /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CommunitySetInclude")]
            [Validation(Required=false)]
            public List<string> CommunitySetInclude { get; set; }

            /// <summary>
            /// <para>The community set for exact match. You can specify up to 64 communities.</para>
            /// <para>A match is successful only if the community in the match condition is exactly the same as the community of the matched route.</para>
            /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
            /// <para>This parameter is mutually exclusive with <b>CommunitySetInclude</b>. You cannot specify both parameters at the same time.</para>
            /// <remarks>
            /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CommunitySetMatch")]
            [Validation(Required=false)]
            public List<string> CommunitySetMatch { get; set; }

            /// <summary>
            /// <para>The list of destination instance IDs to match. You can specify the following types of instance IDs:</para>
            /// <list type="bullet">
            /// <item><description>Virtual Private Cloud (VPC) instance IDs</description></item>
            /// <item><description>Virtual Border Router (VBR) instance IDs</description></item>
            /// </list>
            /// <para>You can specify up to 64 instance IDs.</para>
            /// <remarks>
            /// <para>The list of destination instance IDs takes effect only when the direction of the route map is outbound.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DestinationInstanceIds")]
            [Validation(Required=false)]
            public List<string> DestinationInstanceIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the exclusion match mode for the list of destination instance IDs. Valid values:</para>
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
            /// <para>The list of destination instance types to match. The following instance types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>VPC</b>: VPC instance.</para>
            /// </description></item>
            /// <item><description><para><b>VBR</b>: VBR instance.</para>
            /// </description></item>
            /// </list>
            /// <para>You can specify multiple instance types.</para>
            /// <remarks>
            /// <para>The list of destination instance types takes effect only when the direction of the route map is outbound.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DestinationInstanceTypes")]
            [Validation(Required=false)]
            public List<string> DestinationInstanceTypes { get; set; }

            /// <summary>
            /// <para>The list of destination region IDs to match. You can specify up to 64 region IDs.</para>
            /// </summary>
            [NameInMap("DestinationRegionIds")]
            [Validation(Required=false)]
            public List<string> DestinationRegionIds { get; set; }

            /// <summary>
            /// <para>The list of destination route table IDs to match. You can specify up to 64 route table IDs.</para>
            /// <remarks>
            /// <para>The list of destination route table IDs takes effect only when the direction of the route map is outbound.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DestinationRouteTableIds")]
            [Validation(Required=false)]
            public List<string> DestinationRouteTableIds { get; set; }

            /// <summary>
            /// <para>The IP address type of the routes to match. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b>: Matches only IPv4 routes.</description></item>
            /// <item><description><b>IPv6</b>: Matches only IPv6 routes.</description></item>
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
            /// <item><description><para><b>System</b>: system route, which is automatically generated by the system.</para>
            /// </description></item>
            /// <item><description><para><b>Custom</b>: custom route, which is manually added by the user.</para>
            /// </description></item>
            /// <item><description><para><b>BGP</b>: BGP route, which is propagated through the BGP routable protocol.</para>
            /// </description></item>
            /// </list>
            /// <para>You can specify multiple route types.</para>
            /// </summary>
            [NameInMap("RouteTypes")]
            [Validation(Required=false)]
            public List<string> RouteTypes { get; set; }

            /// <summary>
            /// <para>The list of source instance IDs to match. You can specify the following types of instance IDs:</para>
            /// <list type="bullet">
            /// <item><description>Virtual Private Cloud (VPC) instance IDs</description></item>
            /// <item><description>Virtual Border Router (VBR) instance IDs</description></item>
            /// </list>
            /// <para>You can specify up to 64 instance IDs.</para>
            /// </summary>
            [NameInMap("SourceInstanceIds")]
            [Validation(Required=false)]
            public List<string> SourceInstanceIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the exclusion match mode for the list of source instance IDs. Valid values:</para>
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
            /// <para>The list of source instance types to match. The following instance types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>VPC</b>: VPC instance.</para>
            /// </description></item>
            /// <item><description><para><b>VBR</b>: VBR instance.</para>
            /// </description></item>
            /// </list>
            /// <para>You can specify multiple instance types.</para>
            /// </summary>
            [NameInMap("SourceInstanceTypes")]
            [Validation(Required=false)]
            public List<string> SourceInstanceTypes { get; set; }

            /// <summary>
            /// <para>The list of source region IDs to match. You can specify up to 64 region IDs.</para>
            /// </summary>
            [NameInMap("SourceRegionIds")]
            [Validation(Required=false)]
            public List<string> SourceRegionIds { get; set; }

            /// <summary>
            /// <para>The list of source route table IDs to match. You can specify up to 64 route table IDs.</para>
            /// </summary>
            [NameInMap("SourceRouteTableIds")]
            [Validation(Required=false)]
            public List<string> SourceRouteTableIds { get; set; }

        }

        /// <summary>
        /// <para>The name of the rule for easy identification. The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Permit-Prod-Prefixes-Set-LP</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority of the rule. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the route map.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-0a1b2c3d4e5f6a7b8</para>
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        /// <summary>
        /// <para>The actions to execute for the route map rule. After a route meets all the match conditions defined in <b>MatchConditions</b>, the system processes the route based on the actions defined in this parameter.</para>
        /// </summary>
        [NameInMap("SetActions")]
        [Validation(Required=false)]
        public CreateRouteMapRuleRequestSetActions SetActions { get; set; }
        public class CreateRouteMapRuleRequestSetActions : TeaModel {
            /// <summary>
            /// <para>The AS path to prepend when the regional gateway receives a route or executes a publish route entry. You can specify up to 64 AS numbers.</para>
            /// <para>This parameter is mutually exclusive with <b>AsPathReplace</b>. You cannot specify both parameters at the same time.</para>
            /// <para>This parameter specifies the action to execute after a route meets the match conditions.</para>
            /// </summary>
            [NameInMap("AsPathPrepend")]
            [Validation(Required=false)]
            public List<long?> AsPathPrepend { get; set; }

            /// <summary>
            /// <para>The AS path to replace when the regional gateway receives a route or executes a publish route entry. The original AS path of the route is replaced with the list of AS numbers specified in this parameter. You can specify up to 64 AS numbers.</para>
            /// <para>This parameter is mutually exclusive with <b>AsPathPrepend</b>. You cannot specify both parameters at the same time.</para>
            /// <para>This parameter specifies the action to execute after a route meets the match conditions.</para>
            /// </summary>
            [NameInMap("AsPathReplace")]
            [Validation(Required=false)]
            public List<long?> AsPathReplace { get; set; }

            /// <summary>
            /// <para>The community set to add to the route. You can specify up to 64 communities.</para>
            /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
            /// <para>This parameter is mutually exclusive with <b>CommunityReplace</b>. You cannot specify both parameters at the same time.</para>
            /// <para>This parameter specifies the action to execute after a route meets the match conditions.</para>
            /// <remarks>
            /// <para>Incorrect community configurations may prevent routes from being advertised to the on-premises data center.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CommunityAdd")]
            [Validation(Required=false)]
            public List<string> CommunityAdd { get; set; }

            /// <summary>
            /// <para>The community set to replace the original community of the route. You can specify up to 64 communities.</para>
            /// <para>Each community is in the format of n:m, where n and m range from <b>1</b> to <b>65535</b>. The community must comply with RFC 1997. Large communities (RFC 8092) are not supported.</para>
            /// <para>This parameter is mutually exclusive with <b>CommunityAdd</b>. You cannot specify both parameters at the same time.</para>
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
            /// <item><description>You can set policy priority of the associated route map rule only when <b>RouteAction</b> is set to <b>Permit</b>. Only the routes that are permitted continue to match the associated next route map rule.</description></item>
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
            /// <item><description><para><b>Permit</b>: Permits the matched routes.</para>
            /// </description></item>
            /// <item><description><para><b>Deny</b>: Denies the matched routes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Permit</para>
            /// </summary>
            [NameInMap("RouteAction")]
            [Validation(Required=false)]
            public string RouteAction { get; set; }

        }

    }

}
