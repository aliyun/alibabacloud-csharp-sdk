// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page when entries are returned in pages. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first query or if no subsequent query is to be sent.</description></item>
        /// <item><description>If a subsequent query is to be sent, set the value to the <b>NextToken</b> value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fce19****</para>
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
        /// <para>The ID of the prefix list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-6ehtn5kqxgeyy08fi****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The filter conditions for route entry CIDR blocks.</para>
        /// </summary>
        [NameInMap("RouteFilter")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteEntriesRequestRouteFilter> RouteFilter { get; set; }
        public class ListTransitRouterRouteEntriesRequestRouteFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PrefixExactMatchCidrs</b>: exact match.</description></item>
            /// <item><description><b>LongestPrefixMatchCidrs</b>: longest prefix match. IP addresses and CIDR blocks are supported.</description></item>
            /// <item><description><b>SubnetOfMatchCidrs</b>: subnet match. Matches subnets of the specified CIDR block, including the specified CIDR block itself.</description></item>
            /// <item><description><b>SupernetOfMatchCidrs</b>: supernet match. Matches supernets of the specified CIDR block, including the specified CIDR block itself.</description></item>
            /// </list>
            /// <para>Multiple filter conditions have an <b>AND</b> relationship by default, which means that a route entry must meet all filter conditions to be considered a match. You cannot specify the same filter condition more than once.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrefixExactMatchCidrs</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The list of filter condition values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The destination CIDR block of the route entry (<b>This parameter will be deprecated. Use the RouteFilter parameter instead</b>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
        [Validation(Required=false)]
        [Obsolete]
        public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The IDs of the route entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rte-oklkgwmj97z6dn****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryIds { get; set; }

        /// <summary>
        /// <para>The names of the route entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryNames { get; set; }

        /// <summary>
        /// <para>The ID of the network instance connection associated with the next hop of the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-nls9fzkfat8934****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopId { get; set; }

        /// <summary>
        /// <para>The instance ID of the next hop of the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5ent6du8deaq5*****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceId { get; set; }

        /// <summary>
        /// <para>The type of the next hop instance of the route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC) instance.</description></item>
        /// <item><description><b>VBR</b>: Virtual Border Router (VBR) instance.</description></item>
        /// <item><description><b>TR</b>: transit router instance.</description></item>
        /// <item><description><b>VPN</b>: IPsec connection instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceType { get; set; }

        /// <summary>
        /// <para>The next hop type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BlackHole</b>: the route entry is a blackhole route.</description></item>
        /// <item><description><b>Attachment</b>: the next hop of the route entry is a network instance connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Attachment</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopType { get; set; }

        /// <summary>
        /// <para>The instance ID of the origin of the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5ent6du8deaq5*****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryOriginResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceId { get; set; }

        /// <summary>
        /// <para>The type of the origin instance of the route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC) instance.</description></item>
        /// <item><description><b>VBR</b>: Virtual Border Router (VBR) instance.</description></item>
        /// <item><description><b>TR</b>: transit router instance.</description></item>
        /// <item><description><b>VPN</b>: IPsec connection instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryOriginResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceType { get; set; }

        /// <summary>
        /// <para>The status of the route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: queries route entries in all states.</description></item>
        /// <item><description><b>Active (default)</b>: queries only route entries in the active state.</description></item>
        /// <item><description><b>Rejected</b>: queries only route entries that are rejected due to route conflicts.</description></item>
        /// <item><description><b>Prohibited</b>: queries only route entries that are prohibited because they match a routing policy.</description></item>
        /// <item><description><b>Standby</b>: queries only route entries that serve as standby routes.</description></item>
        /// <item><description><b>Candidate</b>: queries only route entries that serve as candidate routes.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, only route entries in the active state are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryStatus")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryStatus { get; set; }

        /// <summary>
        /// <para>The type of the route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Propagated</b>: generated by automatic learning on the current route table.</description></item>
        /// <item><description><b>Static</b>: generated by static configuration on the current route table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Propagated</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryType { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router route table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1dudbh2d5na6b50****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
